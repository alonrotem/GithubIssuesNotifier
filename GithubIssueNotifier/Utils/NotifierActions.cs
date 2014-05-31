using GithubIssueNotifier.Dialogs;
using GithubIssueNotifier.Wrappers.Configuration;
using GithubIssueNotifier.Wrappers.Github;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GithubIssueNotifier.Utils
{
    static class NotifierActions
    {
        static NotifierActions()
        {
            NotifierActions.refreshWorker.DoWork += RefreshWorker_DoWork;
            NotifierActions.refreshWorker.RunWorkerCompleted += RefreshWorker_RunWorkerCompleted;
            NotifierActions.FirstScanPerformed = false;
            NotifierActions.nextScanTimer.Tick += nextScanTimer_Tick;
            NotifierActions.nextScanTimer.Enabled = false;
        }

        #region Refresh issues methods

        public static void RefreshIssuesData()
        {
            if (NotifierActions.IsRefreshing)
                return;

            NotifierActions.RepoIssues.Clear();
            NotifierActions.FirstScanPerformed = true;
            NotifierActions.IsRefreshing = true;
            NotifierActions.OnRefreshing();
            NotifierActions.lastScanTime = DateTime.Now;
            NotifierActions.nextScanTimer.Enabled = false;
            NotifierActions.refreshWorker.RunWorkerAsync();
        }

        private static void RefreshWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            NotifierActions.TotalRepositories = 0;
            NotifierActions.TotalIssues = 0;
            NotifierActions.TotalRepositoriesWithLateIssues = 0;

            DateTime scanTime = DateTime.Now;
            try
            {
                List<string> ignoredRepositories = ConfigWrapper.GetValues(Constants.ConfigKey_IgnoredRepositories);
                List<Repository> trackedRepositories = new List<Repository>();
                foreach (string organization in ConfigWrapper.GetValues(Constants.ConfigKey_TrackedOrganizations))
                {
                    foreach (Repository orgRepository in GitHubWrapper.GetRepositoriesForOrganization(organization))
                    {
                        if ((!string.IsNullOrWhiteSpace(orgRepository.Name)) &&
                            (!ignoredRepositories.Contains(string.Format("{0} / {1}", orgRepository.Owner.Login, orgRepository.Name))) &&
                            (!trackedRepositories.Contains(orgRepository)))
                        {
                            trackedRepositories.Add(orgRepository);
                        }
                    }
                }
                foreach (string additionalRepository in ConfigWrapper.GetValues(Constants.ConfigKey_TrackedRepositories))
                {
                    if ((!string.IsNullOrWhiteSpace(additionalRepository)) &&
                        (!ignoredRepositories.Contains(additionalRepository)) &&
                        (additionalRepository.Contains("/")))
                    {
                        string[] parts = additionalRepository.Split('/');
                        if (parts.Length > 1)
                        {
                            string repoowner = parts[0];
                            string reponame = parts[1];
                            if (trackedRepositories.FirstOrDefault(r => r.Name == reponame && r.Owner.Name == repoowner) == null)
                                trackedRepositories.Add(GitHubWrapper.GetRepository(repoowner, reponame));
                        }

                    }
                }
                foreach (Repository repo in trackedRepositories)
                {
                    if (repo == null)
                        continue;
                    RepositoryIssues issues = new RepositoryIssues()
                    {
                        Repo = repo,
                        OpenIssues = GitHubWrapper.GetIssues(repo),
                        IsLate = false
                    };
                    NotifierActions.TotalRepositories++;
                    NotifierActions.TotalIssues += issues.OpenIssues.Count;
                    if (ConfigWrapper.GetValue(Constants.ConfigKey_SLAEnabled).ToLower() == "true")
                    {
                        int slaInterval = 2;
                        string slaIntervalType = "days";
                        int hoursFactor = 24;
                        if (!int.TryParse(ConfigWrapper.GetValue(Constants.ConfigKey_SLAInterval), out slaInterval))
                        {
                            slaInterval = 2;
                        }
                        else
                        {
                            slaIntervalType = ConfigWrapper.GetValue(Constants.ConfigKey_SLAIntervalType);
                            if (string.IsNullOrWhiteSpace(slaIntervalType))
                            {
                                slaInterval = 2;
                                slaIntervalType = "days";
                            }
                            else
                            {
                                //counting days or hours?
                                hoursFactor = (slaIntervalType == "days") ? 24 : 1;
                            }
                        }
                        issues.TimeSinceEarliestOpenIssue = new TimeSpan(0);
                        bool lateIssuesInThisRepository = false;
                        foreach (Issue issue in issues.OpenIssues)
                        {
                            TimeSpan timeSinceThisIssue = (issue.UpdatedAt.HasValue) ? (scanTime - issue.UpdatedAt.Value) : (scanTime - issue.CreatedAt);
                            issues.IsLate = timeSinceThisIssue.TotalHours > (slaInterval * hoursFactor);
                            if ((issues.IsLate) && (!lateIssuesInThisRepository))
                            {
                                NotifierActions.TotalRepositoriesWithLateIssues++;
                                lateIssuesInThisRepository = true;
                            }
                            if (timeSinceThisIssue > issues.TimeSinceEarliestOpenIssue)
                            {
                                issues.TimeSinceEarliestOpenIssue = timeSinceThisIssue;
                            }
                        }
                    }
                    NotifierActions.RepoIssues.Add(issues);
                }
                NotifierActions.RepoIssues = NotifierActions.RepoIssues
                                                .OrderByDescending(i => i.IsLate)
                                                .ThenBy(i => i.OpenIssues.Count <= 0)
                                                .ThenBy(i => i.Repo.Name)
                                                .ToList();
            }
            catch (Exception x)
            {
                GitHubWrapper.ResetCredentials();
            }
        }

        private static void RefreshWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NotifierActions.IsRefreshing = false;
            NotifierActions.OnRefreshed();

            if ((NotifierActions.TotalRepositoriesWithLateIssues > 0) || (NotifierActions.TotalIssues > 0))
            {
                string configTotalRepos = ConfigWrapper.GetValue(Constants.ConfigKey_LastStatsTotalRepositories);
                string configTotalIssues = ConfigWrapper.GetValue(Constants.ConfigKey_LastStatsTotalIssues);
                string configTotalLate = ConfigWrapper.GetValue(Constants.ConfigKey_LastStatsTotalLateIssues);
                if ((configTotalRepos != NotifierActions.TotalRepositories.ToString()) ||
                    (configTotalIssues != NotifierActions.TotalIssues.ToString()) ||
                    (configTotalLate != NotifierActions.TotalRepositoriesWithLateIssues.ToString()))
                {
                    ConfigWrapper.SetValue(Constants.ConfigKey_LastStatsTotalRepositories, NotifierActions.TotalRepositories.ToString());
                    ConfigWrapper.SetValue(Constants.ConfigKey_LastStatsTotalIssues, NotifierActions.TotalIssues.ToString());
                    ConfigWrapper.SetValue(Constants.ConfigKey_LastStatsTotalLateIssues, NotifierActions.TotalIssues.ToString());
                    OnNewResults();
                }
            }

            NotifierActions.nextScanTimer.Interval = NotifierActions.GetNextInterval();
            if(NotifierActions.nextScanTimer.Interval > 0)
                NotifierActions.nextScanTimer.Enabled = true;
        }

        #endregion

        #region Other actions

        public static void OpenConfig(bool isWizard)
        {
            if (RepositoriesConfigDialog.CurrentActiveDialog != null)
            {
                RepositoriesConfigDialog.CurrentActiveDialog.Focus();
            }
            else
            {
                RepositoriesConfigDialog configDlg = new RepositoriesConfigDialog(isWizard);
                configDlg.ShowDialog();
            }
        }

        #endregion

        #region Scan timer

        static void nextScanTimer_Tick(object sender, EventArgs e)
        {
            RefreshIssuesData();
        }

        private static int GetNextInterval()
        {
            int intervalInt;
            int intervalFactor = 60;
            string intervalStr = ConfigWrapper.GetValue(Constants.ConfigKey_TrackingInterval, "30");
            if(!int.TryParse(intervalStr, out intervalInt))
                intervalInt = 30;
            string intervalType = ConfigWrapper.GetValue(Constants.ConfigKey_TrackingIntervalType, "minutes").ToLower().Trim();
            if (intervalType == "hours")
                intervalFactor = 60 * 60;
            return intervalInt * intervalFactor * 1000;
        }

        #endregion

        #region Public properties

        public static bool IsRefreshing
        {
            get;
            private set;
        }

        public static int TotalRepositories
        {
            get;
            private set;
        }

        public static int TotalIssues
        {
            get;
            private set;
        }

        public static int TotalRepositoriesWithLateIssues
        {
            get;
            private set;
        }

        public static string StatsStr
        {
            get 
            {
                return string.Format("{0} issue{1} found in {2} repositor{3}{4}.",
                    NotifierActions.TotalIssues,
                    (NotifierActions.TotalIssues == 1) ? "" : "s",
                    NotifierActions.RepoIssues.Count,
                    (NotifierActions.RepoIssues.Count == 1) ? "y" : "ies",
                    (NotifierActions.TotalRepositoriesWithLateIssues == 0) ? "" : " [" + NotifierActions.TotalRepositoriesWithLateIssues + " with late issues]");
            }
        }

        public static string LastRunStr
        {
            get 
            {
                if (NotifierActions.lastScanTime == DateTime.MinValue)
                    return "Not run yet";
                TimeSpan lastScanDff = DateTime.Now - NotifierActions.lastScanTime;
                if ((lastScanDff.Hours == 0) && (lastScanDff.Minutes == 0))
                    return "Just now";
                return string.Format("{0}{1}{2} ago",
                    ((lastScanDff.Hours == 0) ? "" : ((lastScanDff.Hours == 1) ? ("1 hour") : (lastScanDff.Hours.ToString() + " hours"))),
                    ((lastScanDff.Hours == 0)? "": " and "),
                    ((lastScanDff.Minutes == 1) ? ("1 minute") : (lastScanDff.Minutes.ToString() + " minutes")));
            }
        }

        #endregion

        #region Event handlers

        private static void OnRefreshing()
        {
            if (NotifierActions.Refreshing != null)
            {
                NotifierActions.Refreshing();
            }
        }
        private static void OnRefreshed()
        {
            if (NotifierActions.Refreshed != null)
            {
                NotifierActions.Refreshed();
            }
        }

        private static void OnNewResults()
        {
            if (NotifierActions.NewResults != null)
                NotifierActions.NewResults();
        }

        #endregion

        #region Helper inner class

        public class RepositoryIssues
        {
            public Repository Repo { get; set; }
            public List<Issue> OpenIssues { get; set; }
            public bool IsLate { get; set; }
            public TimeSpan TimeSinceEarliestOpenIssue { get; set; }
        }

        #endregion

        public static List<RepositoryIssues> RepoIssues = new List<RepositoryIssues>();
        private static readonly BackgroundWorker refreshWorker = new BackgroundWorker();
        public delegate void RefereshHandler();
        private static readonly Timer nextScanTimer = new Timer();
        public static event RefereshHandler Refreshing;
        public static event RefereshHandler Refreshed;
        public static event RefereshHandler NewResults;
        public static bool FirstScanPerformed = false;
        private static DateTime lastScanTime = DateTime.MinValue;
    }
}

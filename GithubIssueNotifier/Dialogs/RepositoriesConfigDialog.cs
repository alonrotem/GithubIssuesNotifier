using GithubIssueNotifier.Utils;
using GithubIssueNotifier.Wrappers.Configuration;
using GithubIssueNotifier.Wrappers.Github;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GithubIssueNotifier.Dialogs
{
    public partial class RepositoriesConfigDialog : Form
    {
        public RepositoriesConfigDialog(bool isWizardMode)
        {
            InitializeComponent();

            this.IsWizardMode = isWizardMode;

            this.Text = (this.IsWizardMode)? "Setup wizard" : "Options";
            this.btnSave.Visible = !this.IsWizardMode;
            this.btnCancel.Visible = !this.IsWizardMode;
            this.btnGotoNotificationSettings.Visible = !this.IsWizardMode;
            this.btnSaveCredentialsNoWizard.Visible = !this.IsWizardMode;
            this.btnWizardNext.Visible = this.IsWizardMode;
            this.btnWizardBack.Visible = false;
            this.tabTrackRepos.SelectedIndexChanged += tabTrackRepos_SelectedIndexChanged;
            this.btnWizardNext.Click += btnWizardNext_Click;
            this.btnWizardBack.Click += btnWizardBack_Click;
            this.btnSaveCredentialsNoWizard.Click += btnSaveCredentialsNoWizard_Click;
            this.FormClosed += RepositoriesConfigDialog_FormClosed;

            #region GitHub credentials

            this.txtUsername.Text = ConfigWrapper.GetValue(Constants.ConfigKey_GitHubUsername);
            this.txtPassword.Text = ConfigWrapper.GetValue(Constants.ConfigKey_GitHubPassword);
            this.txtUsername.GotFocus += txtUsername_GotFocus;
            this.txtPassword.GotFocus += txtPassword_GotFocus;

            #endregion

            #region Track / Untrack reposotiries

            this.txtNewOrganization.GotFocus += txtNewOrganization_GotFocus;
            this.txtNewRepository.GotFocus += txtNewRepository_GotFocus;
            this.btnAddOrganization.Click += btnAddOrganization_Click;
            this.btnRemoveOrganizations.Click += btnRemoveOrganizations_Click;
            this.btnAddRepository.Click += btnAddRepository_Click;
            this.btnRemoveRepositories.Click += btnRemoveRepositories_Click;
            this.btnAddIgnoredRepository.Click += btnAddIgnoredRepository_Click;
            this.btnRemoveIgnoredRepositories.Click += btnRemoveIgnoredRepositories_Click;
            this.lstReposToIgnore.DoubleClick += lstReposToIgnore_DoubleClick;
            this.lstIgnoredRepositories.DoubleClick += lstIgnoredRepositories_DoubleClick;
            this.organizationSynchWorker.DoWork += organizationSynchWorker_DoWork;
            this.organizationSynchWorker.RunWorkerCompleted += organizationSynchWorker_RunWorkerCompleted;

            this.lstTrackedOrganizations.Populate(ConfigWrapper.GetValues(Constants.ConfigKey_TrackedOrganizations), true);
            this.lstTrackedRepositories.Populate(ConfigWrapper.GetValues(Constants.ConfigKey_TrackedRepositories), true);
            this.lstIgnoredRepositories.Populate(ConfigWrapper.GetValues(Constants.ConfigKey_IgnoredRepositories), true);
            this.ReSyncOrganizationRepos();
            this.btnGotoNotificationSettings.Click += btnGotoNotificationSettings_Click;

            #endregion

            #region Notification Settings

            this.txtIntervalNum.Text = ConfigWrapper.GetValue(Constants.ConfigKey_TrackingInterval, "30");
            this.lstIntervalType.SelectedItem = ConfigWrapper.GetValue(Constants.ConfigKey_TrackingIntervalType, "minutes");
            this.txtIntervalNum.KeyPress += txtIntervalNum_KeyPress;

            this.chkSlaEnabled.Checked = ConfigWrapper.GetValue(Constants.ConfigKey_SLAEnabled, "true").ToLower() == "true";
            this.chkStartWithWindows.Checked = ConfigWrapper.GetValue(Constants.ConfigKey_StartWithWindows, "false").ToLower() == "true";
            this.chkShowBaloons.Checked = ConfigWrapper.GetValue(Constants.ConfigKey_ShowBaloons, "false").ToLower() == "true";
            this.txtSlaInterval.Text = ConfigWrapper.GetValue(Constants.ConfigKey_SLAInterval, "2");
            this.lstSlaIntervalType.SelectedItem = ConfigWrapper.GetValue(Constants.ConfigKey_SLAIntervalType, "days");
            this.txtSlaInterval.KeyPress += txtSlaInterval_KeyPress;
            
            #endregion

            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            RepositoriesConfigDialog.CurrentActiveDialog = this;
        }

        #region GitHub credentials

        private void txtUsername_GotFocus(object sender, EventArgs e)
        {
            if (this.IsWizardMode)
                this.AcceptButton = this.btnWizardNext;
            else
                this.AcceptButton = this.btnSaveCredentialsNoWizard;
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (this.IsWizardMode)
                this.AcceptButton = this.btnWizardNext;
            else
                this.AcceptButton = this.btnSaveCredentialsNoWizard;
        }

        private void btnWizardNext_Click(object sender, EventArgs e)
        {
            if (this.tabTrackRepos.SelectedTab == this.tabGitHubSettings)
            {
                this.SaveCredentialsToConfig();
                this.tabTrackRepos.SelectedTab = this.tabpageTrackRepositories;
            }
            else if (this.tabTrackRepos.SelectedTab == this.tabpageTrackRepositories)
            {
                this.tabTrackRepos.SelectedTab = this.tabPageNotificationSettings;
            }
        }

        private void SaveCredentialsToConfig()
        {
            ConfigWrapper.SetValue(Constants.ConfigKey_GitHubUsername, this.txtUsername.Text);
            ConfigWrapper.SetValue(Constants.ConfigKey_GitHubPassword, this.txtPassword.Text);
        }

        #endregion

        #region Track / Untrack reposotiries

        private void lstReposToIgnore_DoubleClick(object sender, EventArgs e)
        {
            this.lstReposToIgnore.MoveSelectedTo(this.lstIgnoredRepositories);
        }

        private void lstIgnoredRepositories_DoubleClick(object sender, EventArgs e)
        {
            this.lstIgnoredRepositories.MoveSelectedTo(this.lstReposToIgnore);
        }

        private void txtNewOrganization_GotFocus(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnAddOrganization;
        }

        private void txtNewRepository_GotFocus(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnAddRepository;
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            this.lstTrackedOrganizations.AddFromTextBox(this.txtNewOrganization);
            this.ReSyncOrganizationRepos();
        }

        private void btnRemoveOrganizations_Click(object sender, EventArgs e)
        {
            this.lstTrackedOrganizations.RemoveSelected();
        }
        
        private void btnAddRepository_Click(object sender, EventArgs e)
        {
            string repoName = string.Format("{0} / {1}", this.txtNewRepositoryOwner.Text, this.txtNewRepository.Text);
            this.repopulateIgnoredRepositories(new string[] { repoName });
            this.lstTrackedRepositories.Items.Add(repoName);
            this.txtNewRepositoryOwner.Text = "";
            this.txtNewRepository.Text = "";
            this.txtNewRepositoryOwner.Focus();
        }

        private void btnRemoveRepositories_Click(object sender, EventArgs e)
        {
            this.lstTrackedRepositories.RemoveSelected();
        }

        private void btnAddIgnoredRepository_Click(object sender, EventArgs e)
        {
            this.lstReposToIgnore.MoveSelectedTo(this.lstIgnoredRepositories);
        }

        private void btnRemoveIgnoredRepositories_Click(object sender, EventArgs e)
        {
            this.lstIgnoredRepositories.MoveSelectedTo(this.lstReposToIgnore);
        }

        private void repopulateIgnoredRepositories(string[] addedRepos)
        {
            foreach (string repo in addedRepos)
            {
                if ((!this.lstReposToIgnore.Items.Contains(repo)) && (!this.lstIgnoredRepositories.Items.Contains(repo)) && (!string.IsNullOrWhiteSpace(repo)))
                {
                    this.lstReposToIgnore.Items.Add(repo);
                }
            }
        }

        private void ReSyncOrganizationRepos()
        {
            this.organizationRepos.Clear();
            this.lstReposToIgnore.Items.Clear();
            this.lstReposToIgnore.Items.Add("~--- === * Re-Synching * === ---~");
            foreach (string org in this.lstTrackedOrganizations.Items)
            { 
                this.organizationRepos.Add(org, null);
            }
            this.SetUIState(false);
            this.organizationSynchWorker.RunWorkerAsync();
        }

        private void SetUIState(bool isEnabled)
        {
            this.lstReposToIgnore.Enabled = isEnabled;
            this.lstIgnoredRepositories.Enabled = isEnabled;
            this.btnAddIgnoredRepository.Enabled = isEnabled;
            this.btnAddOrganization.Enabled = isEnabled;
            this.btnAddRepository.Enabled = isEnabled;
            this.btnRemoveIgnoredRepositories.Enabled = isEnabled;
            this.btnRemoveOrganizations.Enabled = isEnabled;
            this.btnRemoveRepositories.Enabled = isEnabled;
        }

        private void organizationSynchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> keys = this.organizationRepos.Keys.ToList();
            foreach (string org in keys)
            {
                this.organizationRepos[org] = GitHubWrapper.GetRepositoriesForOrganization(org).Select(repo => repo.Name).ToList();
            }
        }

        private void organizationSynchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.SetUIState(true);
            this.lstReposToIgnore.Items.Clear();
            foreach (string org in this.organizationRepos.Keys)
            {
                if (this.organizationRepos[org] != null)
                {
                    foreach (string repo in this.organizationRepos[org])
                    {
                        string repoName = string.Format("{0} / {1}", org, repo);
                        if (!this.lstIgnoredRepositories.Items.Contains(repoName))
                            this.lstReposToIgnore.Items.Add(repoName);
                    }
                }
            }
            foreach (string repos in this.lstTrackedRepositories.GetItems())
            {
                if (!this.lstIgnoredRepositories.Items.Contains(repos))
                    this.lstReposToIgnore.Items.Add(repos);
            }
        }

        private void btnGotoNotificationSettings_Click(object sender, EventArgs e)
        {
            this.tabTrackRepos.SelectedTab = this.tabPageNotificationSettings;
        }

        Dictionary<string, List<string>> organizationRepos = new Dictionary<string, List<string>>();
        private BackgroundWorker organizationSynchWorker = new BackgroundWorker();

        #endregion

        #region Notification Settings

        private void txtSlaInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AllowOnlyDigits(sender, e);
        }

        private void txtIntervalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AllowOnlyDigits(sender, e);
        }

        #endregion

        #region Dialog behavior

        private void AllowOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveCredentialsToConfig();
            ConfigWrapper.SetValues(Constants.ConfigKey_TrackedOrganizations, this.lstTrackedOrganizations.GetItems());
            ConfigWrapper.SetValues(Constants.ConfigKey_TrackedRepositories, this.lstTrackedRepositories.GetItems());
            ConfigWrapper.SetValues(Constants.ConfigKey_IgnoredRepositories, this.lstIgnoredRepositories.GetItems());

            string intervalType = this.lstIntervalType.SelectedItem.ToString();
            string slaIntervalType = this.lstSlaIntervalType.SelectedItem.ToString();
            string interval = this.txtIntervalNum.Text;
            string slaInterval = this.txtSlaInterval.Text;
            int intervalInt = 0;
            int slaIntervalInt = 0;
            if ((string.IsNullOrWhiteSpace(interval)) || (!int.TryParse(interval, out intervalInt)) || (intervalInt <=0) || (intervalInt > 999))
            {
                interval = "30";
                intervalType = "minutes";
            }
            if ((string.IsNullOrWhiteSpace(slaInterval)) || (!int.TryParse(slaInterval, out slaIntervalInt)) || (slaIntervalInt <= 0) || (slaIntervalInt > 100))
            {
                slaInterval = "2";
                slaIntervalType = "days";
            }
            ConfigWrapper.SetValue(Constants.ConfigKey_TrackingInterval, interval);
            ConfigWrapper.SetValue(Constants.ConfigKey_TrackingIntervalType, intervalType);

            ConfigWrapper.SetValue(Constants.ConfigKey_SLAEnabled, this.chkSlaEnabled.Checked.ToString());
            ConfigWrapper.SetValue(Constants.ConfigKey_SLAInterval, slaInterval);
            ConfigWrapper.SetValue(Constants.ConfigKey_SLAIntervalType, slaIntervalType);
            ConfigWrapper.SetValue(Constants.ConfigKey_StartWithWindows, this.chkStartWithWindows.Checked.ToString());
            if (this.chkStartWithWindows.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue(Constants.ConfigKey_StartWithWindows_RegKey, Application.ExecutablePath);
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue(Constants.ConfigKey_StartWithWindows_RegKey, false);
            }
            ConfigWrapper.SetValue(Constants.ConfigKey_ShowBaloons, this.chkShowBaloons.Checked.ToString());
            GitHubWrapper.ResetCredentials();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void RepositoriesConfigDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.IsWizardMode)
            {
                NotifierActions.RefreshIssuesData();
            }
            RepositoriesConfigDialog.CurrentActiveDialog = null;
        }

        public bool IsWizardMode
        {
            get;
            private set;
        }

        private void btnSaveCredentialsNoWizard_Click(object sender, EventArgs e)
        {
            this.SaveCredentialsToConfig();
            this.tabTrackRepos.SelectedTab = this.tabpageTrackRepositories;
        }

        private void btnWizardBack_Click(object sender, EventArgs e)
        {
            if (this.tabTrackRepos.SelectedTab == this.tabpageTrackRepositories)
            {
                this.tabTrackRepos.SelectedTab = this.tabGitHubSettings;
            }
            else if (this.tabTrackRepos.SelectedTab == this.tabPageNotificationSettings)
            {
                this.tabTrackRepos.SelectedTab = this.tabpageTrackRepositories;
            }
        }

        private void tabTrackRepos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IsWizardMode)
            {
                this.btnWizardBack.Visible = !(this.tabTrackRepos.SelectedTab == this.tabGitHubSettings);
                if (this.tabTrackRepos.SelectedTab == this.tabPageNotificationSettings)
                {
                    this.btnWizardNext.Visible = false;
                    this.btnSave.Visible = true;
                    this.btnCancel.Visible = true;
                }
                else
                {
                    this.btnWizardNext.Visible = true;
                    this.btnSave.Visible = false;
                    this.btnCancel.Visible = false;
                    if (this.tabTrackRepos.SelectedTab == this.tabGitHubSettings)
                    {
                        this.btnWizardNext.Text = "Save credentials and go to select repositories >";
                    }
                    else if (this.tabTrackRepos.SelectedTab == this.tabpageTrackRepositories)
                    {
                        this.btnWizardNext.Text = "Go to set notification settings >";
                    }
                }
            }
        }

        public static RepositoriesConfigDialog CurrentActiveDialog = null;

        #endregion
    }
}

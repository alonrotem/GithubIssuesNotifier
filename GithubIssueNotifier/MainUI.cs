using GithubIssueNotifier.Dialogs;
using GithubIssueNotifier.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GithubIssueNotifier.Wrappers.Configuration;
using System.Diagnostics;
using Microsoft.Win32;

namespace GithubIssueNotifier
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            this.Hide();
            this.StartInTray();
            this.notifyIcon.Text = "GitHub Issues Notifier";
            this.notifyIcon.Click += notifyIcon_Click;
            this.openNotificaitionsWindowToolStripMenuItem.Click += openNotificaitionsWindowToolStripMenuItem_Click;
            this.refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            this.optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            this.exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            this.aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            this.forkOnGitHubToolStripMenuItem.Click += forkOnGitHubToolStripMenuItem_Click;
            NotifierActions.Refreshing += NotifierActions_Refreshing;
            NotifierActions.Refreshed += NotifierActions_Refreshed;
            NotifierActions.NewResults += NotifierActions_NewResults;
            NotifierActions.RefreshIssuesData();
            this.notifyIcon.MouseMove += notifyIcon_MouseMove;


            RegistryKey key = Registry.CurrentUser.OpenSubKey(Constants.ConfigKey_StartWithWindows_StartupRunPath, true);
            object regKey = key.GetValue(Constants.ConfigKey_StartWithWindows_RegKey);
            if ((regKey == null) || (regKey.Equals(Application.ExecutablePath)))
                ConfigWrapper.SetValue(Constants.ConfigKey_StartWithWindows, "true");

            ConfigWrapper.SetValue(Constants.ConfigKey_LastStatsTotalRepositories, "");
            ConfigWrapper.SetValue(Constants.ConfigKey_LastStatsTotalIssues, "");
            ConfigWrapper.SetValue(Constants.ConfigKey_LastStatsTotalLateIssues, "");

            bool configUnintialized = (((string.IsNullOrWhiteSpace(ConfigWrapper.GetValue(Constants.ConfigKey_GitHubUsername))) && (string.IsNullOrWhiteSpace(ConfigWrapper.GetValue(Constants.ConfigKey_GitHubPassword)))) ||
                ((string.IsNullOrWhiteSpace(ConfigWrapper.GetValue(Constants.ConfigKey_TrackedOrganizations))) && (string.IsNullOrWhiteSpace(ConfigWrapper.GetValue(Constants.ConfigKey_TrackedRepositories)))));
            if (configUnintialized)
                NotifierActions.OpenConfig(true);
        }

        #region Menu actions

        private void openNotificaitionsWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openNotificationsWindow();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifierActions.RefreshIssuesData();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifierActions.OpenConfig(true);
        }

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void forkOnGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.RepositoryURL);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.ShowDialog();
        }


        #endregion

        #region Notifier events

        private void NotifierActions_Refreshing()
        {
            this.isRefreshing = true;
            this.isRefreshed = false;
            this.notifyIcon.Text = "GitHub Issues Notifier\nScanning...";
            this.notifyIcon.OverlayText(Utilities.GetIcon(Constants.Icon_Tray_Normal), "***");
        }

        private void NotifierActions_Refreshed()
        {
            this.isRefreshing = false;
            this.isRefreshed = true;
            if(NotifierActions.TotalIssues > 0)
                this.notifyIcon.OverlayText(Utilities.GetIcon(Constants.Icon_Tray_Normal), NotifierActions.TotalIssues.ToString());
            else
                this.notifyIcon.Icon = Utilities.GetIcon(Constants.Icon_Tray_Normal);
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.isRefreshing)
                 this.notifyIcon.SetNotifyTextExtended("GitHub Issues Notifier\nScanning...");
            else if (this.isRefreshed)
                this.notifyIcon.SetNotifyTextExtended(string.Format("GitHub Issues Notifier\n{0}\nLast scan: {1}.", 
                    NotifierActions.StatsStr,
                    NotifierActions.LastRunStr));
        }

        private void NotifierActions_NewResults()
        {
            if (ConfigWrapper.GetValue(Constants.ConfigKey_ShowBaloons, "false").ToLower() == "true")
            {
                this.notifyIcon.BalloonTipTitle = "New GitHub Issues!";
                this.notifyIcon.BalloonTipText = NotifierActions.StatsStr;
                this.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                this.notifyIcon.ShowBalloonTip(3000);
            }
        }

        #endregion

        #region Form/icon interaction

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.openNotificationsWindow();
            }
        }

        private void openNotificationsWindow()
        {
            if (this.isActiveWindow)
            {
                this.notificationsWindow.BringToFront();
            }
            else
            {
                this.notificationsWindow = new NotificationsWindow() { StartPosition = FormStartPosition.Manual };
                this.notificationsWindow.Show();
                int x = Screen.PrimaryScreen.WorkingArea.Width - this.notificationsWindow.Width;
                int y = Screen.PrimaryScreen.WorkingArea.Height - this.notificationsWindow.Height;
                this.notificationsWindow.Bounds = new Rectangle(x, y, this.notificationsWindow.Width, this.notificationsWindow.Height);
                this.notificationsWindow.FormClosed += this.notificationsWindow_FormClosed;
                this.isActiveWindow = true;
            }
        }

        private void notificationsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.isActiveWindow = false;
        }

        private void StartInTray()
        { 
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.notifyIcon.Visible = true;
            this.notifyIcon.Icon = Utilities.GetIcon(Constants.Icon_Tray_Normal);
        }

        #endregion

        bool isRefreshing = false;
        bool isRefreshed = false;
        bool isActiveWindow = false;
        NotificationsWindow notificationsWindow = null;

    }
}

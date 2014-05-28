using GithubIssueNotifier.Dialogs;
using GithubIssueNotifier.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            this.refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            this.optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            this.exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            NotifierActions.Refreshing += NotifierActions_Refreshing;
            NotifierActions.Refreshed += NotifierActions_Refreshed;
            NotifierActions.RefreshIssuesData();
        }

        #region Menu actions

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

        #endregion

        #region Notifier events

        private void NotifierActions_Refreshing()
        {
            this.notifyIcon.Text = "GitHub Issues Notifier\nScanning...";
            //this.notifyIcon.OverlayText(Utilities.GetIcon(Constants.Icon_Tray_Normal), "***");
        }

        private void NotifierActions_Refreshed()
        {
            this.notifyIcon.SetNotifyTextExtended(
                string.Format("GitHub Issues Notifier\n{0} issues found in {1} repositories{2}.",
                    NotifierActions.TotalIssues, 
                    NotifierActions.TotalRepositories,
                    (NotifierActions.TotalLateIssues == 0) ? "" : " [" + NotifierActions.TotalLateIssues + " with late issues]"));
            this.notifyIcon.OverlayText(Utilities.GetIcon(Constants.Icon_Tray_Normal), NotifierActions.TotalIssues.ToString());
        }

        #endregion

        #region Form/icon interaction

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (this.isActiveWindow)
            {
                this.notificationsWindow.BringToFront();
            }
            else
            {
                if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
                {
                    //Point p = Control.MousePosition;

                    this.notificationsWindow = new NotificationsWindow() { StartPosition = FormStartPosition.Manual };
                    this.notificationsWindow.Show();
                    int x = Screen.PrimaryScreen.WorkingArea.Width - this.notificationsWindow.Width;
                    int y = Screen.PrimaryScreen.WorkingArea.Height - this.notificationsWindow.Height;
                    this.notificationsWindow.Bounds = new Rectangle(x, y, this.notificationsWindow.Width, this.notificationsWindow.Height);
                    this.notificationsWindow.FormClosed += this.notificationsWindow_FormClosed;
                    this.isActiveWindow = true;
                }
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

        bool isActiveWindow = false;
        NotificationsWindow notificationsWindow = null;

    }
}

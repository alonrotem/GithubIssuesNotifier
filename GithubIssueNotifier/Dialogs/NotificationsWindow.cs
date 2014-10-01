using GithubIssueNotifier.Utils;
using GithubIssueNotifier.Wrappers.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GithubIssueNotifier.Dialogs
{
    public partial class NotificationsWindow : Form
    {
        public NotificationsWindow()
        {
            InitializeComponent();
            this.LostFocus += NotificationsWindow_LostFocus;

            this.Icon = Utilities.GetIcon(Constants.Icon_Tray_Normal);
            this.repositoriesGrid.CellClick += repositoriesGrid_CellClick;
            this.picReload.Click += picReload_Click;
            this.picReload.Image = Utilities.GetImage(Constants.Img_Reload);
            this.loadingPic.Image = Utilities.GetImage(Constants.Img_Loading_Animation);
            this.picError.Image = Utilities.GetImage(Constants.Img_Info);
            this.lnkOpenConfig.Click += lnkOpenConfig_Click;
            this.loadingPanel.Visible = false;
            this.errorPanel.Visible = false;
            this.reloadTooltip.SetToolTip(this.picReload, "Click to reload");

            this.exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            this.refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            this.aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            this.readmeToolStripMenuItem.Click += readmeToolStripMenuItem_Click;
            this.forkOnGitHubToolStripMenuItem.Click += forkOnGitHubToolStripMenuItem_Click;
            this.Text = string.Format("GitHub Issues Notifier v{0}", Assembly.GetExecutingAssembly().GetName().Version);

            this.goToIssuesToolStripMenuItem.Image = Utilities.GetImage("GithubIssueNotifier.Images.MenuGoToIssues.png");
            this.goToIssuesToolStripMenuItem.Click += goToIssuesToolStripMenuItem_Click;
            this.goToToolStripMenuItem.Image = Utilities.GetImage("GithubIssueNotifier.Images.MenuGoToRepo.png");
            this.goToToolStripMenuItem.Click += goToToolStripMenuItem_Click;
            this.ignoreThisRepositoryToolStripMenuItem.Image = Utilities.GetImage("GithubIssueNotifier.Images.MenuIgnoreRepo.png");
            this.ignoreThisRepositoryToolStripMenuItem.Click += ignoreThisRepositoryToolStripMenuItem_Click;
            this.repositoriesGrid.CellMouseUp += repositoriesGrid_CellMouseUp;
            this.repositoriesGrid.ContextMenuStrip = this.contextMenuRepoActions;

            this.useAnimationsToolStripMenuItem.Checked = ConfigWrapper.GetValue(Constants.ConfigKey_UseAnimations) == "1";

            this.RestoreGridColumns();

            NotifierActions.Refreshing += NotifierActions_Refreshing;
            NotifierActions.Refreshed += NotifierActions_Refreshed;

            //when loading this window:
            //if the notifier is currently refreshing..
            if (NotifierActions.IsRefreshing)
                this.NotifierActions_Refreshing();
            else 
            {
                //if it's already refereshed...
                if (NotifierActions.FirstScanPerformed)
                    this.NotifierActions_Refreshed();
                else
                //if it hasn't been refreshed yet..
                    this.Refresh();
            }
        }


        #region Menu actions

        private void goToIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GoToRepository(currentContextMenuGridItem, true);
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GoToRepository(currentContextMenuGridItem, false);
        }


        private void ignoreThisRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int prevX = this.Left;
            int prevY = this.Top;
            if (MessageBox.Show(
                string.Format("Are you sure you want to add \"{0}\" to the ignore list?", NotifierActions.RepoIssues[currentContextMenuGridItem].Repo.Name),
                "Confirm Ignore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string repoName = string.Format("{0} / {1}", 
                    NotifierActions.RepoIssues[currentContextMenuGridItem].Repo.Owner.Login, 
                    NotifierActions.RepoIssues[currentContextMenuGridItem].Repo.Name);

                ConfigWrapper.AddValueToCollection(Constants.ConfigKey_IgnoredRepositories, repoName);
                ConfigWrapper.RemoveValueToCollection(Constants.ConfigKey_TrackedRepositories, repoName);

                this.repositoriesGrid.Rows.RemoveAt(currentContextMenuGridItem);
                NotifierActions.RepoIssues.RemoveAt(currentContextMenuGridItem);
            }
            //not sure why the window becomes hidden once a messagebox is shown, but this is a workaround.
            this.Left = prevX;
            this.Top = prevY;
            this.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifierActions.OpenConfig(false);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifierActions.RefreshIssuesData();
        }

        private void useAnimationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigWrapper.SetValue(Constants.ConfigKey_UseAnimations, (this.useAnimationsToolStripMenuItem.Checked) ? "1" : "0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.ShowDialog();
        }

        private void forkOnGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.RepositoryURL);
        }

        private void readmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.RepositoryReadmeURL);
        }

        #endregion

        #region UI interaction

        private void repositoriesGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.repositoriesGrid.ClearSelection();
            this.repositoriesGrid.Rows[e.RowIndex].Selected = true;
            this.currentContextMenuGridItem = e.RowIndex;
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            NotifierActions.RefreshIssuesData();
        }

        private void repositoriesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GoToRepository(e.RowIndex, true);
        }

        private void NotificationsWindow_LostFocus(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lnkOpenConfig_Click(object sender, EventArgs e)
        {
            NotifierActions.OpenConfig(true);
        }

        #endregion

        #region Private methods

        private void GoToRepository(int rowIndex, bool toIssuesPage)
        {
            string url = NotifierActions.RepoIssues[rowIndex].Repo.HtmlUrl;
            if (!string.IsNullOrWhiteSpace(url))
            {
                if(toIssuesPage)
                    url += (url.EndsWith("/") ? "" : "/") + "issues";
                Process.Start(url);
            }
        }

        #endregion

        #region UI extensions

        private void RestoreGridColumns()
        {
            if (this.repositoriesGrid.Columns.Count == 0)
            {
                this.repositoriesGrid.Columns.Add(new DataGridViewImageColumn()
                {
                    Name = "iconCol",
                    Width = 20,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Resizable = DataGridViewTriState.False,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Frozen = true,
                });

                this.repositoriesGrid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "repositoryCol",
                    Width = 300,
                    MinimumWidth = this.Width,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Resizable = DataGridViewTriState.False,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Frozen = true,
                });
            }
        }

        #endregion

        #region Refresh data

        private void NotifierActions_Refreshing()
        {
            if (ConfigWrapper.GetValue(Constants.ConfigKey_UseAnimations, "1") != "0")
            {
                //this.repositoriesGrid.Rows.Clear();
                this.loadingPanel.BringToFront();
                this.loadingPanel.Visible = true;
            }
            this.picReload.Image = Utilities.GetImage(Constants.Img_Reload_Inactive);
            this.picReload.Enabled = false;
            this.lblTotalIssues.Text = "Loading, please wait...";
        }

        private void NotifierActions_Refreshed()
        {
            this.repositoriesGrid.Rows.Clear();

            int totalIssueCounter = 0;
            int totalReposWithLateIssues = 0;
            if (NotifierActions.RepoIssues.Count > 0)
            {
                this.RestoreGridColumns();
                foreach (NotifierActions.RepositoryIssues repo in NotifierActions.RepoIssues)
                {
                    DataGridViewRow row = new DataGridViewRow() { MinimumHeight = 20, Resizable = DataGridViewTriState.False };
                    this.repositoriesGrid.Rows.Add(row);
                    int numOfOpenIssues = repo.OpenIssues.Count;
                    row = this.repositoriesGrid.Rows[this.repositoriesGrid.Rows.Count - 1];
                    string lateIssueDescription = "";
                    if (repo.IsLate)
                    {
                        row.Cells[0].Style = new DataGridViewCellStyle() { BackColor = Color.FromArgb(255, 255, 255, 192) };
                        row.Cells[1].Style = new DataGridViewCellStyle() { BackColor = Color.FromArgb(255, 255, 255, 192) };
                        lateIssueDescription = string.Format("{0}{1}{2}",
                            (((repo.TimeSinceEarliestOpenIssue.Days > 0) || (repo.TimeSinceEarliestOpenIssue.Hours > 0)) ? "Late: " : ""),
                            ((repo.TimeSinceEarliestOpenIssue.Days > 0) ? ((repo.TimeSinceEarliestOpenIssue.Days == 1) ? "1 day" : repo.TimeSinceEarliestOpenIssue.Days + " days") : ""),
                            ((repo.TimeSinceEarliestOpenIssue.Hours > 0) ? ((repo.TimeSinceEarliestOpenIssue.Hours == 1) ? ", 1 hour " : ", " + repo.TimeSinceEarliestOpenIssue.Hours + " hours") : ""));
                        totalReposWithLateIssues++;
                    }
                    row.Cells[0].Value = numOfOpenIssues == 0 ? imgRepoOK : imgRepoErr;
                    row.Cells[1].Value = string.Format("{0} / {1}{2}{3}",
                        repo.Repo.Owner.Login,
                        repo.Repo.Name,
                        ((numOfOpenIssues == 0) ? ("") : (" (" + numOfOpenIssues + ")")),
                        lateIssueDescription == "" ? "" : " [" + lateIssueDescription + "]");
                    row.Cells[1].ToolTipText = "Open " + repo.Repo.Name;
                    totalIssueCounter += numOfOpenIssues;
                }

                this.loadingPanel.Visible = false;
                this.errorPanel.Visible = false;
                this.errorPanel.SendToBack();
                this.loadingPanel.SendToBack();
                this.lblTotalIssues.Text = NotifierActions.StatsStr;
                this.repositoriesGrid.ClearSelection();
                this.repositoriesGrid.Visible = true;
            }
            else
            {
                this.repositoriesGrid.Visible = false;
                this.loadingPanel.Visible = false;
                this.loadingPanel.SendToBack();
                this.errorPanel.Visible = true;
                this.errorPanel.BringToFront();
                this.lblTotalIssues.Text = "No results.";
            }
            this.picReload.Image = Utilities.GetImage(Constants.Img_Reload);
            this.picReload.Enabled = true;
        }

        #endregion

        private Image imgRepoOK = Utilities.GetImage(Constants.Img_RepoOk);
        private Image imgRepoErr = Utilities.GetImage(Constants.Img_RepoErr);
        private int currentContextMenuGridItem = -1;
    }
}

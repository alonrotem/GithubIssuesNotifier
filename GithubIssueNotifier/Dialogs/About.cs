using GithubIssueNotifier.Utils;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GithubIssueNotifier.Dialogs
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            this.Text = this.Text = "About GitHub Issues Notifier";
            this.label1.Text = string.Format("GitHub Issues Notifierv{0}", Assembly.GetExecutingAssembly().GetName().Version);
            this.imgFSM.Image = Utilities.GetImage("GithubIssueNotifier.Images.FsmSmall.gif");
            this.btnOk.Click += btnOk_Click;
            this.lnkOctoKit.Click += lnkOctoKit_Click;
            this.lnkForkOnGithub.Click += lnkForkOnGithub_Click;
            this.tooltipFSM.SetToolTip(this.imgFSM, "Bless the Holy Flying Spaghetty Monster.\n - Ramen.");
            this.imgFSM.Click += imgFSM_Click;
        }

        private void imgFSM_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.venganza.org/");
        }

        private void lnkForkOnGithub_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.RepositoryURL);
        }

        private void lnkOctoKit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/octokit/octokit.net");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

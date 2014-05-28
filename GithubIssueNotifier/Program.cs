using System;
using System.Linq;
using System.Windows.Forms;

namespace GithubIssueNotifier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainUI ui = new MainUI();
            Application.Run();
        }
    }
}

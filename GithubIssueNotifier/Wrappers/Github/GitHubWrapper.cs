using GithubIssueNotifier.Utils;
using GithubIssueNotifier.Wrappers.Configuration;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubIssueNotifier.Wrappers.Github
{
    public static class GitHubWrapper
    {
        #region GitHub Credentials

        public static Credentials Credentials
        {
            get
            {
                if (GitHubWrapper.credentials == null)
                {
                    string githubUsername = GitHubWrapper.GetGitHubUserName();
                    string githubPassword = GitHubWrapper.GetGitHubPassword();
                    string githubToken = Environment.GetEnvironmentVariable(GitHubWrapper.TokenName);

                    GitHubWrapper.UserName = githubUsername;
                    if (githubToken != null)
                        GitHubWrapper.credentials = new Credentials(githubToken);


                    if (githubUsername != null && githubPassword != null)
                        GitHubWrapper.credentials = new Credentials(githubUsername, githubPassword);
                }
                return GitHubWrapper.credentials;
            }
        }

        public static void ResetCredentials()
        {
            GitHubWrapper.UserName = null;
            GitHubWrapper.credentials = null;
        }

        internal static string GetGitHubUserName()
        {
            return ConfigWrapper.GetValue(Constants.ConfigKey_GitHubUsername);
        }

        internal static string GetGitHubPassword()
        {
            return ConfigWrapper.GetValue(Constants.ConfigKey_GitHubPassword);
        }

        public static string UserName
        {
            get;
            private set;
        }


        #endregion

        #region Repository actions (GitHub)

        public static List<Octokit.Repository> GetRepositoriesForOrganization(string organizationName)
        {
            if(string.IsNullOrWhiteSpace(organizationName))
                return new List<Octokit.Repository>();
            Task<IReadOnlyList<Octokit.Repository>> repositories = GitHubWrapper.Client.Repository.GetAllForOrg(organizationName);
            try
            {
                repositories.Wait();
            }
            catch 
            {
                return new List<Octokit.Repository>();
            }
            if (repositories.Result != null)
            {
                return repositories.Result.ToList();
            }
            else
            {
                return new List<Octokit.Repository>();
            }
        }

        public static Repository GetRepository(string owner, string repoName)
        {
            Task<Repository> repo = GitHubWrapper.Client.Repository.Get(owner, repoName);
            try
            {
                repo.Wait();
            }
            catch
            {
                return null;
            }
            return repo.Result;
        }

        public static List<Issue> GetIssues(Octokit.Repository repo)
        {
            bool err = false;
            Task<IReadOnlyList<Octokit.Issue>> issues = GitHubWrapper.Client.Issue.GetForRepository(repo.Owner.Login, repo.Name);
            try
            {
                issues.Wait();
            }
            catch
            {
                err = true;
            }
            if ((!err) && (issues.Result != null))
            {
                return issues.Result.ToList();
            }
            return new List<Issue>();
        }

        private static GitHubClient Client
        {
            get
            {
                if (GitHubWrapper._client == null)
                {
                    GitHubWrapper._client = new GitHubClient(new ProductHeaderValue("GithubIssueNotifier"))
                    {
                        Credentials = GitHubWrapper.Credentials
                    };
                }
                return GitHubWrapper._client;
            }
        }
        private static GitHubClient _client;

        //public static void DeleteRepo(Octokit.Repository repository)
        //{
        //    GitHubWrapper.DeleteRepo(repository.Owner.Login, repository.Name);
        //}

        //public static void DeleteRepo(string owner, string name)
        //{
        //    GitHubClient api = new GitHubClient(new ProductHeaderValue("OctokitTests")) { Credentials = Credentials };
        //    try
        //    {
        //        api.Repository.Delete(owner, name).Wait(TimeSpan.FromSeconds(15));
        //    }
        //    catch
        //    {
        //    }
        //}
        #endregion

        #region Utility methods

        public static string GetNameWithTimestamp(string name)
        {
            return string.Format("{0}-{1}",
                name,
                DateTime.UtcNow.ToString("yyyyMMddhhmmssfff"));
        }

        #endregion

        #region Private parts

        private const string TokenName = "OCTOKIT_OAUTHTOKEN";
        private static Credentials credentials = null;

        #endregion
    }
}

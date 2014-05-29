using System;
using System.Linq;

namespace GithubIssueNotifier.Utils
{
    internal static class Constants
    {
        public const string Icon_Tray_Normal = @"GithubIssueNotifier.Images.IconTrayNormal.ico";
        public const string Img_RepoOk = @"GithubIssueNotifier.Images.Repository_OK_20x20.png";
        public const string Img_RepoErr = @"GithubIssueNotifier.Images.Repository_Error_20x20.png";
        public const string Img_Reload = @"GithubIssueNotifier.Images.Reload.png";
        public const string Img_Reload_Inactive = @"GithubIssueNotifier.Images.Reload_Inactive.png";
        public const string Img_Loading_Animation = @"GithubIssueNotifier.Images.Loading.GIF";
        public const string Img_Info = @"GithubIssueNotifier.Images.Info.png";

        public const string ConfigKey_GitHubUsername = @"GitHubUsername";
        public const string ConfigKey_GitHubPassword = @"GitHubPassword";
        public const string GitHubSitefinitySdkOrganizationName = @"Sitefinity-SDK";

        public const string ConfigKey_TrackedOrganizations = @"TrackedOrganizations";
        public const string ConfigKey_TrackedRepositories = @"TrackedRepositories";
        public const string ConfigKey_IgnoredRepositories = @"IgnoredRepositories";

        public const string ConfigKey_TrackingInterval = @"TrackingInterval";
        public const string ConfigKey_TrackingIntervalType = @"TrackingIntervalType";
        public const string ConfigKey_StartWithWindows = @"StartWithWindows";
        public const string ConfigKey_ShowBaloons = @"ShowBaloons";
        public const string ConfigKey_LastStatsTotalRepositories = @"LastStatsTotalRepositories";
        public const string ConfigKey_LastStatsTotalIssues = @"LastStatsTotalIssues";
        public const string ConfigKey_LastStatsTotalLateIssues = @"LastStatsTotalLateIssues";
        public const string ConfigKey_StartWithWindows_RegKey = @"GitHubIssuesNotifier";

        public const string ConfigKey_SLAEnabled = @"SLAEnabled";
        public const string ConfigKey_SLAInterval = @"SLAInterval";
        public const string ConfigKey_SLAIntervalType = @"SLAIntervalType";

        public const string RepositoryURL = @"https://github.com/alonrotem/GithubIssuesNotifier";
        public const string RepositoryReadmeURL = @"https://github.com/alonrotem/GithubIssuesNotifier#readme";
    }
}

#GitHub Issues Notifier
##Overview
GitHub Issues Notifier is a .NET Windows Forms application keeps track on GitHub open issues on selected repositories and reports in real time.
 It runs in the system's notification area (system tray), runs automatic scheduled scans for open issues in GitHub repositories and/or organizations and notifies the user with new findings.   
 GitHub Issues Notifier is using [OctoKit.NET](https://github.com/octokit/octokit.net) in order to integrate with GitHub's API.

![About GitHub Issues Notifier](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/AboutDialog.png)
##Getting the Solution and Building it
GitHub Issue Notifier's solution references [OctoKit.NET](https://github.com/octokit/octokit.net)'s [Nuget package](http://www.nuget.org/packages/Octokit/). Once the solution is built, OctoKit's package is automatically retrieved and restored as a reference to the Windows Forms project.
##Initial Configuration
When opened for the first time, the setup wizard, which contains 3 tabs will open.

 On the first tab, **GitHub Settings**, fill in your GitHub credentials in the respectivce *Username* and *Password* fields and click **Save credentials and go to select repositories >** to continue.   
![Setup wizard > GitHub Settings](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Settings_GithubSettings.png)
 
On the second tab, **Track / Untrack Repositories**, 3 areas can be configured: 

 - Tracked organizations   
To add GitHub organizations to track and be notified about open issues, fill in the organization's name and click the green **Add >** button.  
All the repositories of the organization are now being tracked for open issues. You can omit specific repositories from the scan by adding them to the ignored repositories list (see below).    
To remove organizations from the tracked organization list, select them and and click the red **< Remove** button. 

 - Tracked individual repositories    
To add a single repository to track and be notified about open issues, fill in the repository's owner name and the repository's name in the *Owner* and *Repository* textboxes respectively and click the green **Add >** button.  
The repository is also added to the ignored repositories list, so you can omit it from future scans (see below).    
To remove a repositories from the tracked repositories list, select them and and click the red **< Remove** button. 

 - Ignored repositories    
Once organizations and individual repositories are added, all their relevant repositories are added to the list of repositories in the **Ignored repositories** section.  
To ignore specific repositories from the scan, select them on the left list and click the green **Add >** button. The ignored repositories are moved to the right list box.   
To remove a repositories from the ignored repositories list, select them and and click the red **< Remove** button. 

Once you're done choosing repositories and organizations to track, click **Go to set notification settings >** to continue.

![Setup wizard > Untrack Repositories](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Settings_Track_Untrack.png)

On the third tab, **Notification settings**, you can configure the settings for automatic scans and notifications for scan results.

  - On **Tracking interval** Set the interval in which repositories will be automatically scanned for new issues. Enter the number of hours or minutes and select *hours* or *minutes* in the drop-down box.

  - Check the **Start GitHub Issues Notifier with Windows** in order to automatically start GitHub Issues Notifier with Windows.

  - Check the **Show Baloon notifications when new results are received** in order to show baloon-notifications from the notification area (system tray) at the end of scans.

 - If you keep a specific SLA for answering issues, check the **Highlight issues, if not answerd within:** checkbox, enter the number of hours or days and select *hours* or *days* in the drop-down box. This will highlight repositories which have open issues which have not been answered for a longer period than specified.
  
![Setup wizard > Notification settings](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Settings_Nofitications.png)

Once you are done, click **Save** to save all your settings and close the dialog.
##Working with GitHub Issues Notifier
###System tray notifications
Once your settings are saved and GitHub Issues Notifier is active, an icon will appear in your system's notification area (system tray) with a tooltip indicating its current status.   
![Scanning...](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Scanning.png)

If baloon notifications are active, when scanning is complete with new results, a notification baloon will appear.
![Baloon notifications](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Baloon.png)

The notification icon will now also show the total number of open issues
![Open issues count](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Results.png)

Right-click the notification icon to open a menu of immediate actions.
![Menu](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Menu.png)

Left-click  the notification icon to open the notifications window
###The notifications window
The notifications window lists all the tracked repositories marking the ones with open issues and highlighting the ones which contain late issues according to the SLA set in the options.   
![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_Results.png)

While scanning, an animation is displayed in the notifications window.
![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_Scanning.png)

If the scan ends with no results at all (no repositories and no issues) which can indicate, for example, a network problem or a GitHub credentials issue, an error message is displayed.   
![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_NoResults.png)

In order to refresh the repositories on demand at any time, there are 2 options:

 - In the notificaitons window's menu, under **Tools** click **Refresh now**.   
 ![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_Menu.png)

 - Click the *Refresh* button at the bottom of the notifications window.   
 ![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_RefreshButton.png)

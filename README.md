#GitHub Issues Notifier
##Overview
GitHub Issues Notifier is a .NET Windows Forms application, which helps to keep track on GitHub open issues of selected repositories.  
It runs automatic scheduled scans for open issues in GitHub repositories and/or organizations and notifies the user with new findings in real time from the system's notification area (system tray).    

GitHub Issues Notifier uses [OctoKit.NET](https://github.com/octokit/octokit.net) open library to integrate with GitHub's API.

**More info on a post in [my blog, AlonInTheWorld.com](http://www.alonintheworld.com/2014/06/project-keeping-track-of-your-github.html).**   

![About GitHub Issues Notifier](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/AboutDialog.png).

##Getting the Solution and Building it
GitHub Issue Notifier's solution references [OctoKit.NET](https://github.com/octokit/octokit.net)'s [Nuget package](http://www.nuget.org/packages/Octokit/). Once the solution is built, OctoKit's package is automatically retrieved and restored as a reference.
##Initial Configuration
When opened for the first time, the setup wizard opens and presents 3 tabs for settings.

 On the first tab, **GitHub Settings**, fill in your GitHub credentials in the respectivce *Username* and *Password* fields and click **Save credentials and go to select repositories >** to continue.   
![Setup wizard > GitHub Settings](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Settings_GithubSettings.png)
 
On the second tab, **Track / Untrack Repositories**, 3 areas can be configured: 

 - Tracked organizations   
To add GitHub organizations to track and be notified about open issues in them, fill in an organization's name and click the green **Add >** button.  
All the repositories of the organization are now being tracked for open issues. You can omit specific repositories from the scan by adding them to the ignored repositories list (see below).    
To remove organizations from the tracked organization list, select them and and click the red **< Remove** button. 

 - Tracked individual repositories    
To add a single repository to track and be notified about open issues in it, fill in the repository's owner name and the repository's name in the *Owner* and *Repository* textboxes respectively and click the green **Add >** button.  
The repository is also added to the ignorable repositories list below, so you can omit it from future scans (see below).    
To remove repositories from the tracked repositories list, select them and and click the red **< Remove** button. 

 - Ignored repositories    
Once organizations and individual repositories are added to be tracked, all their individual repositories are added to the list of the **Ignored repositories** section.  
To ignore specific repositories from the scan, select them on the left list and click the green **Add >** button. The ignored repositories will move to the right list box.   
To remove a repositories from the ignored repositories list, select them and and click the red **< Remove** button. 

Once you're done choosing repositories and organizations to track, click **Go to set notification settings >** to continue.

![Setup wizard > Untrack Repositories](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Settings_Track_Untrack.png)

On the third tab, **Notification settings**, you can configure the settings for automatic scans and notifications for scan results.

  - On **Tracking interval** Set the interval in which repositories will be automatically scanned for new issues. Enter the number of hours or minutes and select *hours* or *minutes* in the drop-down box.

  - Check the **Start GitHub Issues Notifier with Windows** in order to automatically start GitHub Issues Notifier when Windows starts.

  - Check the **Show Baloon notifications when new results are received** in order to show baloon-notifications from the notification area (system tray) at the end of scans.

  - If you keep a specific SLA for responding to issues, check the **Highlight issues, if not answerd within:** checkbox, enter the number of hours or days and select *hours* or *days* in the drop-down box. Repositories which have open issues which have not been responded to within a longer period than specified will be highlighted as late.
  
![Setup wizard > Notification settings](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Settings_Nofitications.png)

Once you are done, click **Save** to save all your settings and close the settings dialog.
##Working with GitHub Issues Notifier
###System tray notifications
Once your settings are saved and GitHub Issues Notifier is active, an icon will appear in your system's notification area (system tray) with a tooltip indicating its current status.   
![Scanning...](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Scanning.png)   
![Tooltip with results](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_TooltipFull.png)

If baloon notifications are active, when scanning is complete with new results, a notification baloon will appear.
![Baloon notifications](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Baloon.png)

The notification icon will now also show the total number of open issues detected in the last scan.
![Open issues count](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Results.png)

Right-click the notification icon to open a menu of immediate actions.
![Menu](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Menu.png)

Left-click  the notification icon to open the notifications window.
###The notifications window
The notifications window lists all the tracked repositories marking the ones with open issues and highlighting the ones which contain late issues according to the SLA set in the options.   
![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_Results.png)

While scanning, an animation is displayed in the notifications window.
![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_Scanning.png)

If the scan ends with no results at all (no repositories and no issues are returned) which may indicate a network problem or a GitHub credentials issue, an error message is displayed.   
![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_NoResults.png)

In order to refresh the repositories on demand at any time, there are 3 options:

 - In the notificaitons window's menu, under **Tools** click **Refresh now**.   
 ![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_Menu.png)

 - Click the *Refresh* button at the bottom of the notifications window.   
 ![](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/NotifierWin_RefreshButton.png)

 - Right-click the notification icon and click the Refresh option in the menu.
![Menu](https://raw.githubusercontent.com/alonrotem/GithubIssuesNotifier/master/Screenshots/Systray_Menu.png)

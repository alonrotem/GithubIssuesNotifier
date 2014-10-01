namespace GithubIssueNotifier.Dialogs
{
    partial class RepositoriesConfigDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabTrackRepos = new System.Windows.Forms.TabControl();
            this.tabGitHubSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaveCredentialsNoWizard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabpageTrackRepositories = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpIncludeOrganizations = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveOrganizations = new System.Windows.Forms.Button();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrackOrganizations = new System.Windows.Forms.Label();
            this.txtNewOrganization = new System.Windows.Forms.TextBox();
            this.lstTrackedOrganizations = new System.Windows.Forms.ListBox();
            this.grpIncludedRepositories = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewRepositoryOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveRepositories = new System.Windows.Forms.Button();
            this.btnAddRepository = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewRepository = new System.Windows.Forms.TextBox();
            this.lstTrackedRepositories = new System.Windows.Forms.ListBox();
            this.grpIgnoredRepositories = new System.Windows.Forms.GroupBox();
            this.lstReposToIgnore = new System.Windows.Forms.ListBox();
            this.btnRemoveIgnoredRepositories = new System.Windows.Forms.Button();
            this.btnAddIgnoredRepository = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstIgnoredRepositories = new System.Windows.Forms.ListBox();
            this.btnGotoNotificationSettings = new System.Windows.Forms.Button();
            this.tabPageNotificationSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstSlaIntervalType = new System.Windows.Forms.ComboBox();
            this.txtSlaInterval = new System.Windows.Forms.TextBox();
            this.chkSlaEnabled = new System.Windows.Forms.CheckBox();
            this.grpGitHubRefresh = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstIntervalType = new System.Windows.Forms.ComboBox();
            this.txtIntervalNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.chkShowBalloons = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWizardNext = new System.Windows.Forms.Button();
            this.btnWizardBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabTrackRepos.SuspendLayout();
            this.tabGitHubSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabpageTrackRepositories.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpIncludeOrganizations.SuspendLayout();
            this.grpIncludedRepositories.SuspendLayout();
            this.grpIgnoredRepositories.SuspendLayout();
            this.tabPageNotificationSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpGitHubRefresh.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabTrackRepos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.0622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.937799F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabTrackRepos
            // 
            this.tabTrackRepos.Controls.Add(this.tabGitHubSettings);
            this.tabTrackRepos.Controls.Add(this.tabpageTrackRepositories);
            this.tabTrackRepos.Controls.Add(this.tabPageNotificationSettings);
            this.tabTrackRepos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTrackRepos.Location = new System.Drawing.Point(3, 3);
            this.tabTrackRepos.Name = "tabTrackRepos";
            this.tabTrackRepos.SelectedIndex = 0;
            this.tabTrackRepos.Size = new System.Drawing.Size(631, 545);
            this.tabTrackRepos.TabIndex = 1;
            // 
            // tabGitHubSettings
            // 
            this.tabGitHubSettings.Controls.Add(this.tableLayoutPanel3);
            this.tabGitHubSettings.Controls.Add(this.label6);
            this.tabGitHubSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGitHubSettings.Name = "tabGitHubSettings";
            this.tabGitHubSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabGitHubSettings.Size = new System.Drawing.Size(623, 519);
            this.tabGitHubSettings.TabIndex = 1;
            this.tabGitHubSettings.Text = "GitHub Settings";
            this.tabGitHubSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveCredentialsNoWizard, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(425, 135);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(215, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(215, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnSaveCredentialsNoWizard
            // 
            this.btnSaveCredentialsNoWizard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveCredentialsNoWizard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.SetColumnSpan(this.btnSaveCredentialsNoWizard, 2);
            this.btnSaveCredentialsNoWizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCredentialsNoWizard.Location = new System.Drawing.Point(154, 100);
            this.btnSaveCredentialsNoWizard.Name = "btnSaveCredentialsNoWizard";
            this.btnSaveCredentialsNoWizard.Size = new System.Drawing.Size(268, 23);
            this.btnSaveCredentialsNoWizard.TabIndex = 6;
            this.btnSaveCredentialsNoWizard.Text = "Save credentials and go to select repositories >";
            this.btnSaveCredentialsNoWizard.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter your GitHub credentials:";
            // 
            // tabpageTrackRepositories
            // 
            this.tabpageTrackRepositories.Controls.Add(this.tableLayoutPanel2);
            this.tabpageTrackRepositories.Location = new System.Drawing.Point(4, 22);
            this.tabpageTrackRepositories.Name = "tabpageTrackRepositories";
            this.tabpageTrackRepositories.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageTrackRepositories.Size = new System.Drawing.Size(623, 519);
            this.tabpageTrackRepositories.TabIndex = 0;
            this.tabpageTrackRepositories.Text = "Track / Untrack Repositories";
            this.tabpageTrackRepositories.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grpIncludeOrganizations, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpIncludedRepositories, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpIgnoredRepositories, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnGotoNotificationSettings, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 513);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grpIncludeOrganizations
            // 
            this.grpIncludeOrganizations.Controls.Add(this.label2);
            this.grpIncludeOrganizations.Controls.Add(this.btnRemoveOrganizations);
            this.grpIncludeOrganizations.Controls.Add(this.btnAddOrganization);
            this.grpIncludeOrganizations.Controls.Add(this.label1);
            this.grpIncludeOrganizations.Controls.Add(this.lblTrackOrganizations);
            this.grpIncludeOrganizations.Controls.Add(this.txtNewOrganization);
            this.grpIncludeOrganizations.Controls.Add(this.lstTrackedOrganizations);
            this.grpIncludeOrganizations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIncludeOrganizations.Location = new System.Drawing.Point(3, 3);
            this.grpIncludeOrganizations.Name = "grpIncludeOrganizations";
            this.grpIncludeOrganizations.Size = new System.Drawing.Size(611, 150);
            this.grpIncludeOrganizations.TabIndex = 0;
            this.grpIncludeOrganizations.TabStop = false;
            this.grpIncludeOrganizations.Text = "Tracked organizations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click Remove to remove selected organizations.";
            // 
            // btnRemoveOrganizations
            // 
            this.btnRemoveOrganizations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveOrganizations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrganizations.Location = new System.Drawing.Point(278, 117);
            this.btnRemoveOrganizations.Name = "btnRemoveOrganizations";
            this.btnRemoveOrganizations.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOrganizations.TabIndex = 5;
            this.btnRemoveOrganizations.Text = "< Remove";
            this.btnRemoveOrganizations.UseVisualStyleBackColor = false;
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrganization.Location = new System.Drawing.Point(278, 69);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrganization.TabIndex = 4;
            this.btnAddOrganization.Text = "Add >";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(357, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "These organizations are tracked:";
            // 
            // lblTrackOrganizations
            // 
            this.lblTrackOrganizations.AutoSize = true;
            this.lblTrackOrganizations.Location = new System.Drawing.Point(6, 39);
            this.lblTrackOrganizations.Name = "lblTrackOrganizations";
            this.lblTrackOrganizations.Size = new System.Drawing.Size(246, 26);
            this.lblTrackOrganizations.TabIndex = 2;
            this.lblTrackOrganizations.Text = "All repositories in the organization will be tracked,\r\nexcept the ones which are " +
    "explicitly ignored below.";
            // 
            // txtNewOrganization
            // 
            this.txtNewOrganization.Location = new System.Drawing.Point(6, 72);
            this.txtNewOrganization.Name = "txtNewOrganization";
            this.txtNewOrganization.Size = new System.Drawing.Size(262, 20);
            this.txtNewOrganization.TabIndex = 1;
            // 
            // lstTrackedOrganizations
            // 
            this.lstTrackedOrganizations.FormattingEnabled = true;
            this.lstTrackedOrganizations.Location = new System.Drawing.Point(358, 32);
            this.lstTrackedOrganizations.Name = "lstTrackedOrganizations";
            this.lstTrackedOrganizations.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTrackedOrganizations.Size = new System.Drawing.Size(234, 108);
            this.lstTrackedOrganizations.Sorted = true;
            this.lstTrackedOrganizations.TabIndex = 0;
            // 
            // grpIncludedRepositories
            // 
            this.grpIncludedRepositories.Controls.Add(this.label12);
            this.grpIncludedRepositories.Controls.Add(this.label11);
            this.grpIncludedRepositories.Controls.Add(this.txtNewRepositoryOwner);
            this.grpIncludedRepositories.Controls.Add(this.label3);
            this.grpIncludedRepositories.Controls.Add(this.btnRemoveRepositories);
            this.grpIncludedRepositories.Controls.Add(this.btnAddRepository);
            this.grpIncludedRepositories.Controls.Add(this.label4);
            this.grpIncludedRepositories.Controls.Add(this.label5);
            this.grpIncludedRepositories.Controls.Add(this.txtNewRepository);
            this.grpIncludedRepositories.Controls.Add(this.lstTrackedRepositories);
            this.grpIncludedRepositories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIncludedRepositories.Location = new System.Drawing.Point(3, 159);
            this.grpIncludedRepositories.Name = "grpIncludedRepositories";
            this.grpIncludedRepositories.Size = new System.Drawing.Size(611, 150);
            this.grpIncludedRepositories.TabIndex = 1;
            this.grpIncludedRepositories.TabStop = false;
            this.grpIncludedRepositories.Text = "Tracked individual repositories";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Owner:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Repository:";
            // 
            // txtNewRepositoryOwner
            // 
            this.txtNewRepositoryOwner.Location = new System.Drawing.Point(72, 64);
            this.txtNewRepositoryOwner.Name = "txtNewRepositoryOwner";
            this.txtNewRepositoryOwner.Size = new System.Drawing.Size(196, 20);
            this.txtNewRepositoryOwner.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Click Remove to remove selected repositories.";
            // 
            // btnRemoveRepositories
            // 
            this.btnRemoveRepositories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveRepositories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRepositories.Location = new System.Drawing.Point(278, 115);
            this.btnRemoveRepositories.Name = "btnRemoveRepositories";
            this.btnRemoveRepositories.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRepositories.TabIndex = 12;
            this.btnRemoveRepositories.Text = "< Remove";
            this.btnRemoveRepositories.UseVisualStyleBackColor = false;
            // 
            // btnAddRepository
            // 
            this.btnAddRepository.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddRepository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRepository.Location = new System.Drawing.Point(278, 69);
            this.btnAddRepository.Name = "btnAddRepository";
            this.btnAddRepository.Size = new System.Drawing.Size(75, 23);
            this.btnAddRepository.TabIndex = 11;
            this.btnAddRepository.Text = "Add >";
            this.btnAddRepository.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(357, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "These GitHub repositories are tracked:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add here an indivisual repository to be tracked.\r\n";
            // 
            // txtNewRepository
            // 
            this.txtNewRepository.Location = new System.Drawing.Point(72, 89);
            this.txtNewRepository.Name = "txtNewRepository";
            this.txtNewRepository.Size = new System.Drawing.Size(196, 20);
            this.txtNewRepository.TabIndex = 8;
            // 
            // lstTrackedRepositories
            // 
            this.lstTrackedRepositories.FormattingEnabled = true;
            this.lstTrackedRepositories.Location = new System.Drawing.Point(358, 30);
            this.lstTrackedRepositories.Name = "lstTrackedRepositories";
            this.lstTrackedRepositories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTrackedRepositories.Size = new System.Drawing.Size(234, 108);
            this.lstTrackedRepositories.Sorted = true;
            this.lstTrackedRepositories.TabIndex = 7;
            // 
            // grpIgnoredRepositories
            // 
            this.grpIgnoredRepositories.Controls.Add(this.lstReposToIgnore);
            this.grpIgnoredRepositories.Controls.Add(this.btnRemoveIgnoredRepositories);
            this.grpIgnoredRepositories.Controls.Add(this.btnAddIgnoredRepository);
            this.grpIgnoredRepositories.Controls.Add(this.label7);
            this.grpIgnoredRepositories.Controls.Add(this.lstIgnoredRepositories);
            this.grpIgnoredRepositories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIgnoredRepositories.Location = new System.Drawing.Point(3, 315);
            this.grpIgnoredRepositories.Name = "grpIgnoredRepositories";
            this.grpIgnoredRepositories.Size = new System.Drawing.Size(611, 155);
            this.grpIgnoredRepositories.TabIndex = 2;
            this.grpIgnoredRepositories.TabStop = false;
            this.grpIgnoredRepositories.Text = "Ignored repositories";
            // 
            // lstReposToIgnore
            // 
            this.lstReposToIgnore.FormattingEnabled = true;
            this.lstReposToIgnore.Location = new System.Drawing.Point(15, 33);
            this.lstReposToIgnore.Name = "lstReposToIgnore";
            this.lstReposToIgnore.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstReposToIgnore.Size = new System.Drawing.Size(253, 108);
            this.lstReposToIgnore.Sorted = true;
            this.lstReposToIgnore.TabIndex = 20;
            // 
            // btnRemoveIgnoredRepositories
            // 
            this.btnRemoveIgnoredRepositories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveIgnoredRepositories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveIgnoredRepositories.Location = new System.Drawing.Point(278, 118);
            this.btnRemoveIgnoredRepositories.Name = "btnRemoveIgnoredRepositories";
            this.btnRemoveIgnoredRepositories.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveIgnoredRepositories.TabIndex = 19;
            this.btnRemoveIgnoredRepositories.Text = "< Remove";
            this.btnRemoveIgnoredRepositories.UseVisualStyleBackColor = false;
            // 
            // btnAddIgnoredRepository
            // 
            this.btnAddIgnoredRepository.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddIgnoredRepository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIgnoredRepository.Location = new System.Drawing.Point(278, 70);
            this.btnAddIgnoredRepository.Name = "btnAddIgnoredRepository";
            this.btnAddIgnoredRepository.Size = new System.Drawing.Size(75, 23);
            this.btnAddIgnoredRepository.TabIndex = 18;
            this.btnAddIgnoredRepository.Text = "Add >";
            this.btnAddIgnoredRepository.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(360, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "These repositories are ignored:";
            // 
            // lstIgnoredRepositories
            // 
            this.lstIgnoredRepositories.FormattingEnabled = true;
            this.lstIgnoredRepositories.Location = new System.Drawing.Point(363, 33);
            this.lstIgnoredRepositories.Name = "lstIgnoredRepositories";
            this.lstIgnoredRepositories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstIgnoredRepositories.Size = new System.Drawing.Size(234, 108);
            this.lstIgnoredRepositories.Sorted = true;
            this.lstIgnoredRepositories.TabIndex = 14;
            // 
            // btnGotoNotificationSettings
            // 
            this.btnGotoNotificationSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGotoNotificationSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGotoNotificationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGotoNotificationSettings.Location = new System.Drawing.Point(404, 481);
            this.btnGotoNotificationSettings.Name = "btnGotoNotificationSettings";
            this.btnGotoNotificationSettings.Size = new System.Drawing.Size(210, 23);
            this.btnGotoNotificationSettings.TabIndex = 3;
            this.btnGotoNotificationSettings.Text = "Go to set notification settings >";
            this.btnGotoNotificationSettings.UseVisualStyleBackColor = false;
            // 
            // tabPageNotificationSettings
            // 
            this.tabPageNotificationSettings.Controls.Add(this.groupBox1);
            this.tabPageNotificationSettings.Controls.Add(this.grpGitHubRefresh);
            this.tabPageNotificationSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotificationSettings.Name = "tabPageNotificationSettings";
            this.tabPageNotificationSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotificationSettings.Size = new System.Drawing.Size(623, 519);
            this.tabPageNotificationSettings.TabIndex = 2;
            this.tabPageNotificationSettings.Text = "Notification settings";
            this.tabPageNotificationSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issues SLA";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.chkSlaEnabled, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(611, 41);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstSlaIntervalType);
            this.panel3.Controls.Add(this.txtSlaInterval);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(305, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 41);
            this.panel3.TabIndex = 0;
            // 
            // lstSlaIntervalType
            // 
            this.lstSlaIntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSlaIntervalType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lstSlaIntervalType.FormattingEnabled = true;
            this.lstSlaIntervalType.Items.AddRange(new object[] {
            "hours",
            "days"});
            this.lstSlaIntervalType.Location = new System.Drawing.Point(111, 10);
            this.lstSlaIntervalType.Name = "lstSlaIntervalType";
            this.lstSlaIntervalType.Size = new System.Drawing.Size(121, 21);
            this.lstSlaIntervalType.TabIndex = 1;
            // 
            // txtSlaInterval
            // 
            this.txtSlaInterval.Location = new System.Drawing.Point(5, 11);
            this.txtSlaInterval.Name = "txtSlaInterval";
            this.txtSlaInterval.Size = new System.Drawing.Size(100, 20);
            this.txtSlaInterval.TabIndex = 0;
            // 
            // chkSlaEnabled
            // 
            this.chkSlaEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSlaEnabled.AutoSize = true;
            this.chkSlaEnabled.Location = new System.Drawing.Point(3, 12);
            this.chkSlaEnabled.Name = "chkSlaEnabled";
            this.chkSlaEnabled.Size = new System.Drawing.Size(213, 17);
            this.chkSlaEnabled.TabIndex = 1;
            this.chkSlaEnabled.Text = "Highlight issues, if  not answered within:";
            this.chkSlaEnabled.UseVisualStyleBackColor = true;
            // 
            // grpGitHubRefresh
            // 
            this.grpGitHubRefresh.Controls.Add(this.tableLayoutPanel4);
            this.grpGitHubRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGitHubRefresh.Location = new System.Drawing.Point(3, 3);
            this.grpGitHubRefresh.Name = "grpGitHubRefresh";
            this.grpGitHubRefresh.Size = new System.Drawing.Size(617, 138);
            this.grpGitHubRefresh.TabIndex = 0;
            this.grpGitHubRefresh.TabStop = false;
            this.grpGitHubRefresh.Text = "GitHub Refresh";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chkStartWithWindows, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.chkShowBalloons, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(611, 119);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstIntervalType);
            this.panel2.Controls.Add(this.txtIntervalNum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(305, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 38);
            this.panel2.TabIndex = 0;
            // 
            // lstIntervalType
            // 
            this.lstIntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstIntervalType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lstIntervalType.FormattingEnabled = true;
            this.lstIntervalType.Items.AddRange(new object[] {
            "minutes",
            "hours"});
            this.lstIntervalType.Location = new System.Drawing.Point(111, 10);
            this.lstIntervalType.Name = "lstIntervalType";
            this.lstIntervalType.Size = new System.Drawing.Size(121, 21);
            this.lstIntervalType.TabIndex = 1;
            // 
            // txtIntervalNum
            // 
            this.txtIntervalNum.Location = new System.Drawing.Point(5, 11);
            this.txtIntervalNum.Name = "txtIntervalNum";
            this.txtIntervalNum.Size = new System.Drawing.Size(100, 20);
            this.txtIntervalNum.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tracking interval (Default=30 minutes):";
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkStartWithWindows.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.chkStartWithWindows, 2);
            this.chkStartWithWindows.Location = new System.Drawing.Point(3, 48);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(222, 17);
            this.chkStartWithWindows.TabIndex = 2;
            this.chkStartWithWindows.Text = "Start GitHub Issues Notifier with Windows";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // chkShowBalloons
            // 
            this.chkShowBalloons.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkShowBalloons.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.chkShowBalloons, 2);
            this.chkShowBalloons.Location = new System.Drawing.Point(3, 89);
            this.chkShowBalloons.Name = "chkShowBalloons";
            this.chkShowBalloons.Size = new System.Drawing.Size(297, 17);
            this.chkShowBalloons.TabIndex = 3;
            this.chkShowBalloons.Text = "Show Balloon notifications when new results are received";
            this.chkShowBalloons.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWizardNext);
            this.panel1.Controls.Add(this.btnWizardBack);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnWizardNext
            // 
            this.btnWizardNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWizardNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWizardNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWizardNext.Location = new System.Drawing.Point(201, 6);
            this.btnWizardNext.Name = "btnWizardNext";
            this.btnWizardNext.Size = new System.Drawing.Size(268, 23);
            this.btnWizardNext.TabIndex = 5;
            this.btnWizardNext.Text = "Save credentials and go to select repositories >";
            this.btnWizardNext.UseVisualStyleBackColor = false;
            // 
            // btnWizardBack
            // 
            this.btnWizardBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWizardBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWizardBack.Location = new System.Drawing.Point(104, 6);
            this.btnWizardBack.Name = "btnWizardBack";
            this.btnWizardBack.Size = new System.Drawing.Size(55, 23);
            this.btnWizardBack.TabIndex = 6;
            this.btnWizardBack.Text = "<";
            this.btnWizardBack.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(344, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(189, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // RepositoriesConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepositoriesConfigDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabTrackRepos.ResumeLayout(false);
            this.tabGitHubSettings.ResumeLayout(false);
            this.tabGitHubSettings.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabpageTrackRepositories.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpIncludeOrganizations.ResumeLayout(false);
            this.grpIncludeOrganizations.PerformLayout();
            this.grpIncludedRepositories.ResumeLayout(false);
            this.grpIncludedRepositories.PerformLayout();
            this.grpIgnoredRepositories.ResumeLayout(false);
            this.grpIgnoredRepositories.PerformLayout();
            this.tabPageNotificationSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpGitHubRefresh.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabTrackRepos;
        private System.Windows.Forms.TabPage tabpageTrackRepositories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpIncludeOrganizations;
        private System.Windows.Forms.GroupBox grpIncludedRepositories;
        private System.Windows.Forms.GroupBox grpIgnoredRepositories;
        private System.Windows.Forms.TabPage tabGitHubSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveOrganizations;
        private System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrackOrganizations;
        private System.Windows.Forms.TextBox txtNewOrganization;
        private System.Windows.Forms.ListBox lstTrackedOrganizations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveRepositories;
        private System.Windows.Forms.Button btnAddRepository;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewRepository;
        private System.Windows.Forms.ListBox lstTrackedRepositories;
        private System.Windows.Forms.Button btnRemoveIgnoredRepositories;
        private System.Windows.Forms.Button btnAddIgnoredRepository;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstIgnoredRepositories;
        private System.Windows.Forms.ListBox lstReposToIgnore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageNotificationSettings;
        private System.Windows.Forms.GroupBox grpGitHubRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox lstIntervalType;
        private System.Windows.Forms.TextBox txtIntervalNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox lstSlaIntervalType;
        private System.Windows.Forms.TextBox txtSlaInterval;
        private System.Windows.Forms.CheckBox chkSlaEnabled;
        private System.Windows.Forms.Button btnGotoNotificationSettings;
        private System.Windows.Forms.Button btnWizardNext;
        private System.Windows.Forms.Button btnSaveCredentialsNoWizard;
        private System.Windows.Forms.Button btnWizardBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNewRepositoryOwner;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.CheckBox chkShowBalloons;
    }
}
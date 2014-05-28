using System.Windows.Forms;
namespace GithubIssueNotifier.Dialogs
{
    partial class NotificationsWindow
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
            this.components = new System.ComponentModel.Container();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.repositoriesGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlImmediateActions = new System.Windows.Forms.Panel();
            this.lblTotalIssues = new System.Windows.Forms.Label();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingPic = new System.Windows.Forms.PictureBox();
            this.reloadTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoriesGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlImmediateActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // il
            // 
            this.il.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il.ImageSize = new System.Drawing.Size(16, 16);
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.loadingPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 380);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.repositoriesGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlImmediateActions, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.849582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.15042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 380);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // repositoriesGrid
            // 
            this.repositoriesGrid.AllowUserToAddRows = false;
            this.repositoriesGrid.AllowUserToDeleteRows = false;
            this.repositoriesGrid.AllowUserToResizeColumns = false;
            this.repositoriesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.repositoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.repositoriesGrid.ColumnHeadersVisible = false;
            this.repositoriesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repositoriesGrid.Location = new System.Drawing.Point(3, 24);
            this.repositoriesGrid.Name = "repositoriesGrid";
            this.repositoriesGrid.RowHeadersVisible = false;
            this.repositoriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.repositoriesGrid.Size = new System.Drawing.Size(375, 332);
            this.repositoriesGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 21);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 17);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 17);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "abougToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // pnlImmediateActions
            // 
            this.pnlImmediateActions.Controls.Add(this.lblTotalIssues);
            this.pnlImmediateActions.Controls.Add(this.picReload);
            this.pnlImmediateActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImmediateActions.Location = new System.Drawing.Point(0, 359);
            this.pnlImmediateActions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImmediateActions.Name = "pnlImmediateActions";
            this.pnlImmediateActions.Size = new System.Drawing.Size(381, 21);
            this.pnlImmediateActions.TabIndex = 2;
            // 
            // lblTotalIssues
            // 
            this.lblTotalIssues.AutoSize = true;
            this.lblTotalIssues.Location = new System.Drawing.Point(24, 2);
            this.lblTotalIssues.Name = "lblTotalIssues";
            this.lblTotalIssues.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.lblTotalIssues.Size = new System.Drawing.Size(57, 15);
            this.lblTotalIssues.TabIndex = 1;
            this.lblTotalIssues.Text = "Loading...";
            // 
            // picReload
            // 
            this.picReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReload.Location = new System.Drawing.Point(5, 2);
            this.picReload.Margin = new System.Windows.Forms.Padding(0);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(16, 16);
            this.picReload.TabIndex = 0;
            this.picReload.TabStop = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.White;
            this.loadingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadingPanel.Controls.Add(this.label1);
            this.loadingPanel.Controls.Add(this.loadingPic);
            this.loadingPanel.Location = new System.Drawing.Point(2, 24);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(381, 332);
            this.loadingPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(120, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reloading repositories...";
            // 
            // loadingPic
            // 
            this.loadingPic.Location = new System.Drawing.Point(128, 74);
            this.loadingPic.Margin = new System.Windows.Forms.Padding(0);
            this.loadingPic.Name = "loadingPic";
            this.loadingPic.Size = new System.Drawing.Size(128, 128);
            this.loadingPic.TabIndex = 0;
            this.loadingPic.TabStop = false;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 17);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // NotificationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 380);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotificationsWindow";
            this.Text = "GitHub Issues Notifications";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoriesGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlImmediateActions.ResumeLayout(false);
            this.pnlImmediateActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList il;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView repositoriesGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Panel loadingPanel;
        private PictureBox loadingPic;
        private Label label1;
        private Panel pnlImmediateActions;
        private PictureBox picReload;
        private ToolTip reloadTooltip;
        private Label lblTotalIssues;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}
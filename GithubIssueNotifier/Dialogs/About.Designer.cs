namespace GithubIssueNotifier.Dialogs
{
    partial class AboutDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.imgFSM = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkForkOnGithub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkOctoKit = new System.Windows.Forms.LinkLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.tooltipFSM = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgFSM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "lblVersion";
            // 
            // imgFSM
            // 
            this.imgFSM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFSM.Location = new System.Drawing.Point(253, 67);
            this.imgFSM.Name = "imgFSM";
            this.imgFSM.Size = new System.Drawing.Size(37, 31);
            this.imgFSM.TabIndex = 1;
            this.imgFSM.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alon Rotem, 05/2014";
            // 
            // lnkForkOnGithub
            // 
            this.lnkForkOnGithub.AutoSize = true;
            this.lnkForkOnGithub.Location = new System.Drawing.Point(12, 116);
            this.lnkForkOnGithub.Name = "lnkForkOnGithub";
            this.lnkForkOnGithub.Size = new System.Drawing.Size(187, 13);
            this.lnkForkOnGithub.TabIndex = 3;
            this.lnkForkOnGithub.TabStop = true;
            this.lnkForkOnGithub.Text = "Fork GitHub Issues Notifier on GitHub!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "GitHub integration using";
            // 
            // lnkOctoKit
            // 
            this.lnkOctoKit.AutoSize = true;
            this.lnkOctoKit.BackColor = System.Drawing.Color.Transparent;
            this.lnkOctoKit.Location = new System.Drawing.Point(129, 85);
            this.lnkOctoKit.Name = "lnkOctoKit";
            this.lnkOctoKit.Size = new System.Drawing.Size(67, 13);
            this.lnkOctoKit.TabIndex = 5;
            this.lnkOctoKit.TabStop = true;
            this.lnkOctoKit.Text = "OctoKit.NET";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(12, 147);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(312, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OKAY ALREADY!";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 185);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lnkOctoKit);
            this.Controls.Add(this.lnkForkOnGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgFSM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.imgFSM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgFSM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkForkOnGithub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkOctoKit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ToolTip tooltipFSM;
    }
}
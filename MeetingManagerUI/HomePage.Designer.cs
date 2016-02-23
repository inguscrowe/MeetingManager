namespace MeetingManagerUI
{
    partial class HomePage
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
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.LastLoginLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congregationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentScheduleGridView = new System.Windows.Forms.DataGridView();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExportLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.BeginningLabel = new System.Windows.Forms.Label();
            this.EndingLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameLabel.Location = new System.Drawing.Point(818, 46);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(119, 20);
            this.MemberNameLabel.TabIndex = 0;
            this.MemberNameLabel.Text = "MemberName";
            // 
            // LastLoginLabel
            // 
            this.LastLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastLoginLabel.AutoSize = true;
            this.LastLoginLabel.Location = new System.Drawing.Point(819, 75);
            this.LastLoginLabel.Name = "LastLoginLabel";
            this.LastLoginLabel.Size = new System.Drawing.Size(53, 13);
            this.LastLoginLabel.TabIndex = 1;
            this.LastLoginLabel.Text = "LastLogin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.assignmentsToolStripMenuItem,
            this.schedulesToolStripMenuItem,
            this.congregationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMembersToolStripMenuItem});
            this.membersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // editMembersToolStripMenuItem
            // 
            this.editMembersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editMembersToolStripMenuItem.Name = "editMembersToolStripMenuItem";
            this.editMembersToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.editMembersToolStripMenuItem.Text = "Edit Members";
            this.editMembersToolStripMenuItem.Click += new System.EventHandler(this.editMembersToolStripMenuItem_Click);
            // 
            // assignmentsToolStripMenuItem
            // 
            this.assignmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignmentsProfileToolStripMenuItem});
            this.assignmentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            this.assignmentsToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.assignmentsToolStripMenuItem.Text = "Assignments";
            // 
            // assignmentsProfileToolStripMenuItem
            // 
            this.assignmentsProfileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.assignmentsProfileToolStripMenuItem.Name = "assignmentsProfileToolStripMenuItem";
            this.assignmentsProfileToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.assignmentsProfileToolStripMenuItem.Text = "Assignments Profile";
            this.assignmentsProfileToolStripMenuItem.Click += new System.EventHandler(this.assignmentsProfileToolStripMenuItem_Click);
            // 
            // schedulesToolStripMenuItem
            // 
            this.schedulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScheduleToolStripMenuItem,
            this.removeScheduleToolStripMenuItem});
            this.schedulesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.schedulesToolStripMenuItem.Name = "schedulesToolStripMenuItem";
            this.schedulesToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.schedulesToolStripMenuItem.Text = "Schedules";
            // 
            // newScheduleToolStripMenuItem
            // 
            this.newScheduleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.newScheduleToolStripMenuItem.Name = "newScheduleToolStripMenuItem";
            this.newScheduleToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.newScheduleToolStripMenuItem.Text = "New Schedule";
            this.newScheduleToolStripMenuItem.Click += new System.EventHandler(this.newScheduleToolStripMenuItem_Click);
            // 
            // removeScheduleToolStripMenuItem
            // 
            this.removeScheduleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.removeScheduleToolStripMenuItem.Name = "removeScheduleToolStripMenuItem";
            this.removeScheduleToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.removeScheduleToolStripMenuItem.Text = "Existing Schedules";
            this.removeScheduleToolStripMenuItem.Click += new System.EventHandler(this.removeScheduleToolStripMenuItem_Click);
            // 
            // congregationToolStripMenuItem
            // 
            this.congregationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.congregationToolStripMenuItem.Name = "congregationToolStripMenuItem";
            this.congregationToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.congregationToolStripMenuItem.Text = "Congregation";
            // 
            // CurrentScheduleGridView
            // 
            this.CurrentScheduleGridView.AllowUserToAddRows = false;
            this.CurrentScheduleGridView.AllowUserToDeleteRows = false;
            this.CurrentScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentScheduleGridView.Location = new System.Drawing.Point(91, 75);
            this.CurrentScheduleGridView.Name = "CurrentScheduleGridView";
            this.CurrentScheduleGridView.Size = new System.Drawing.Size(722, 318);
            this.CurrentScheduleGridView.TabIndex = 3;
            this.CurrentScheduleGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentScheduleGridView_DoubleClick);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(297, 46);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 6;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(524, 46);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(52, 13);
            this.EndDateLabel.TabIndex = 7;
            this.EndDateLabel.Text = "End Date";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(91, 413);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 8;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // BeginningLabel
            // 
            this.BeginningLabel.AutoSize = true;
            this.BeginningLabel.Location = new System.Drawing.Point(234, 46);
            this.BeginningLabel.Name = "BeginningLabel";
            this.BeginningLabel.Size = new System.Drawing.Size(57, 13);
            this.BeginningLabel.TabIndex = 9;
            this.BeginningLabel.Text = "Beginning:";
            // 
            // EndingLabel
            // 
            this.EndingLabel.AutoSize = true;
            this.EndingLabel.Location = new System.Drawing.Point(475, 46);
            this.EndingLabel.Name = "EndingLabel";
            this.EndingLabel.Size = new System.Drawing.Size(43, 13);
            this.EndingLabel.TabIndex = 10;
            this.EndingLabel.Text = "Ending:";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 501);
            this.Controls.Add(this.EndingLabel);
            this.Controls.Add(this.BeginningLabel);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.CurrentScheduleGridView);
            this.Controls.Add(this.LastLoginLabel);
            this.Controls.Add(this.MemberNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentScheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label LastLoginLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congregationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentsProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newScheduleToolStripMenuItem;
        public System.Windows.Forms.DataGridView CurrentScheduleGridView;
        private System.Windows.Forms.ToolStripMenuItem removeScheduleToolStripMenuItem;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.FolderBrowserDialog ExportLocation;
        public System.Windows.Forms.Label StartDateLabel;
        public System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label BeginningLabel;
        private System.Windows.Forms.Label EndingLabel;
    }
}
namespace MeetingManagerUI
{
    partial class EditMembersForm
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
            this.AddMember = new System.Windows.Forms.Button();
            this.MemberAssignmentsButton = new System.Windows.Forms.Button();
            this.CurrentMembersGridBox = new System.Windows.Forms.DataGridView();
            this.MemberAssignmentsGridBox = new System.Windows.Forms.DataGridView();
            this.AssignementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchedulePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAssigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPerMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatesAvailableGridBox = new System.Windows.Forms.DataGridView();
            this.UnavilableDateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateAvailableDatesButton = new System.Windows.Forms.Button();
            this.SelectedMemberLabel = new System.Windows.Forms.Label();
            this.PublicMeetingAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.WeekdayMeetingAvailableCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentMembersGridBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberAssignmentsGridBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesAvailableGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(50, 274);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(174, 25);
            this.AddMember.TabIndex = 0;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMembers_Click);
            // 
            // MemberAssignmentsButton
            // 
            this.MemberAssignmentsButton.Location = new System.Drawing.Point(338, 274);
            this.MemberAssignmentsButton.Name = "MemberAssignmentsButton";
            this.MemberAssignmentsButton.Size = new System.Drawing.Size(178, 38);
            this.MemberAssignmentsButton.TabIndex = 1;
            this.MemberAssignmentsButton.Text = "Update Assignments";
            this.MemberAssignmentsButton.UseVisualStyleBackColor = true;
            this.MemberAssignmentsButton.Click += new System.EventHandler(this.MemberAssignmentsButton_Click);
            // 
            // CurrentMembersGridBox
            // 
            this.CurrentMembersGridBox.AllowUserToAddRows = false;
            this.CurrentMembersGridBox.AllowUserToDeleteRows = false;
            this.CurrentMembersGridBox.AllowUserToResizeRows = false;
            this.CurrentMembersGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentMembersGridBox.ColumnHeadersVisible = false;
            this.CurrentMembersGridBox.Location = new System.Drawing.Point(50, 31);
            this.CurrentMembersGridBox.Name = "CurrentMembersGridBox";
            this.CurrentMembersGridBox.ReadOnly = true;
            this.CurrentMembersGridBox.RowHeadersVisible = false;
            this.CurrentMembersGridBox.Size = new System.Drawing.Size(174, 237);
            this.CurrentMembersGridBox.TabIndex = 2;
            this.CurrentMembersGridBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentMembersGridBox_CellContentClick);
            this.CurrentMembersGridBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentMembersGridBox_CellDoubleClick);
            // 
            // MemberAssignmentsGridBox
            // 
            this.MemberAssignmentsGridBox.AllowUserToAddRows = false;
            this.MemberAssignmentsGridBox.AllowUserToDeleteRows = false;
            this.MemberAssignmentsGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberAssignmentsGridBox.ColumnHeadersVisible = false;
            this.MemberAssignmentsGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignementId,
            this.SchedulePosition,
            this.IsAssigned,
            this.Assignment,
            this.Description,
            this.AmountPerMeeting});
            this.MemberAssignmentsGridBox.Location = new System.Drawing.Point(338, 31);
            this.MemberAssignmentsGridBox.Name = "MemberAssignmentsGridBox";
            this.MemberAssignmentsGridBox.RowHeadersVisible = false;
            this.MemberAssignmentsGridBox.Size = new System.Drawing.Size(178, 237);
            this.MemberAssignmentsGridBox.TabIndex = 3;
            // 
            // AssignementId
            // 
            this.AssignementId.HeaderText = "AssignmentId";
            this.AssignementId.Name = "AssignementId";
            this.AssignementId.Visible = false;
            // 
            // SchedulePosition
            // 
            this.SchedulePosition.HeaderText = "Schedule Position";
            this.SchedulePosition.Name = "SchedulePosition";
            this.SchedulePosition.Visible = false;
            // 
            // IsAssigned
            // 
            this.IsAssigned.HeaderText = "IsAssignment";
            this.IsAssigned.Name = "IsAssigned";
            this.IsAssigned.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAssigned.Width = 50;
            // 
            // Assignment
            // 
            this.Assignment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Assignment.HeaderText = "Assignement";
            this.Assignment.Name = "Assignment";
            this.Assignment.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = false;
            // 
            // AmountPerMeeting
            // 
            this.AmountPerMeeting.HeaderText = "MeetingAmount";
            this.AmountPerMeeting.Name = "AmountPerMeeting";
            this.AmountPerMeeting.Visible = false;
            // 
            // DatesAvailableGridBox
            // 
            this.DatesAvailableGridBox.AllowUserToAddRows = false;
            this.DatesAvailableGridBox.AllowUserToDeleteRows = false;
            this.DatesAvailableGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatesAvailableGridBox.ColumnHeadersVisible = false;
            this.DatesAvailableGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnavilableDateId,
            this.IsAvailable,
            this.Date});
            this.DatesAvailableGridBox.Location = new System.Drawing.Point(612, 31);
            this.DatesAvailableGridBox.Name = "DatesAvailableGridBox";
            this.DatesAvailableGridBox.RowHeadersVisible = false;
            this.DatesAvailableGridBox.Size = new System.Drawing.Size(209, 237);
            this.DatesAvailableGridBox.TabIndex = 4;
            // 
            // UnavilableDateId
            // 
            this.UnavilableDateId.HeaderText = "UnavailableDateId";
            this.UnavilableDateId.Name = "UnavilableDateId";
            this.UnavilableDateId.Visible = false;
            // 
            // IsAvailable
            // 
            this.IsAvailable.HeaderText = "IsAvailable";
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAvailable.Width = 50;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // UpdateAvailableDatesButton
            // 
            this.UpdateAvailableDatesButton.Location = new System.Drawing.Point(612, 274);
            this.UpdateAvailableDatesButton.Name = "UpdateAvailableDatesButton";
            this.UpdateAvailableDatesButton.Size = new System.Drawing.Size(209, 38);
            this.UpdateAvailableDatesButton.TabIndex = 5;
            this.UpdateAvailableDatesButton.Text = "Update Availability";
            this.UpdateAvailableDatesButton.UseVisualStyleBackColor = true;
            this.UpdateAvailableDatesButton.Click += new System.EventHandler(this.UpdateAvailableDatesButton_Click);
            // 
            // SelectedMemberLabel
            // 
            this.SelectedMemberLabel.AutoSize = true;
            this.SelectedMemberLabel.Location = new System.Drawing.Point(335, 12);
            this.SelectedMemberLabel.Name = "SelectedMemberLabel";
            this.SelectedMemberLabel.Size = new System.Drawing.Size(35, 13);
            this.SelectedMemberLabel.TabIndex = 6;
            this.SelectedMemberLabel.Text = "label1";
            // 
            // PublicMeetingAvailableCheckBox
            // 
            this.PublicMeetingAvailableCheckBox.AutoSize = true;
            this.PublicMeetingAvailableCheckBox.Location = new System.Drawing.Point(838, 31);
            this.PublicMeetingAvailableCheckBox.Name = "PublicMeetingAvailableCheckBox";
            this.PublicMeetingAvailableCheckBox.Size = new System.Drawing.Size(96, 17);
            this.PublicMeetingAvailableCheckBox.TabIndex = 7;
            this.PublicMeetingAvailableCheckBox.Text = "Public Meeting";
            this.PublicMeetingAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // WeekdayMeetingAvailableCheckBox
            // 
            this.WeekdayMeetingAvailableCheckBox.AutoSize = true;
            this.WeekdayMeetingAvailableCheckBox.Location = new System.Drawing.Point(838, 67);
            this.WeekdayMeetingAvailableCheckBox.Name = "WeekdayMeetingAvailableCheckBox";
            this.WeekdayMeetingAvailableCheckBox.Size = new System.Drawing.Size(113, 17);
            this.WeekdayMeetingAvailableCheckBox.TabIndex = 8;
            this.WeekdayMeetingAvailableCheckBox.Text = "Weekday Meeting";
            this.WeekdayMeetingAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 404);
            this.Controls.Add(this.WeekdayMeetingAvailableCheckBox);
            this.Controls.Add(this.PublicMeetingAvailableCheckBox);
            this.Controls.Add(this.SelectedMemberLabel);
            this.Controls.Add(this.UpdateAvailableDatesButton);
            this.Controls.Add(this.DatesAvailableGridBox);
            this.Controls.Add(this.MemberAssignmentsGridBox);
            this.Controls.Add(this.CurrentMembersGridBox);
            this.Controls.Add(this.MemberAssignmentsButton);
            this.Controls.Add(this.AddMember);
            this.Name = "EditMembersForm";
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentMembersGridBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberAssignmentsGridBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesAvailableGridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.Button MemberAssignmentsButton;
        public System.Windows.Forms.DataGridView CurrentMembersGridBox;
        public System.Windows.Forms.DataGridView MemberAssignmentsGridBox;
        public System.Windows.Forms.DataGridView DatesAvailableGridBox;
        private System.Windows.Forms.Button UpdateAvailableDatesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnavilableDateId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label SelectedMemberLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedulePosition;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPerMeeting;
        private System.Windows.Forms.CheckBox PublicMeetingAvailableCheckBox;
        private System.Windows.Forms.CheckBox WeekdayMeetingAvailableCheckBox;
        
    }
}
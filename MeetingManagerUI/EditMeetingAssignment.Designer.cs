namespace MeetingManagerUI
{
    partial class EditMeetingAssignment
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
            this.MeetingAssignmentsGridBox = new System.Windows.Forms.DataGridView();
            this.MeetingAssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseMemberBox = new System.Windows.Forms.ComboBox();
            this.UpdateMemberAssignment = new System.Windows.Forms.Button();
            this.AssignmentLabel = new System.Windows.Forms.Label();
            this.MeetingDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MeetingAssignmentsGridBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberAssignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MeetingAssignmentsGridBox
            // 
            this.MeetingAssignmentsGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeetingAssignmentsGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeetingAssignmentId,
            this.Assignment,
            this.Member});
            this.MeetingAssignmentsGridBox.Location = new System.Drawing.Point(116, 37);
            this.MeetingAssignmentsGridBox.Name = "MeetingAssignmentsGridBox";
            this.MeetingAssignmentsGridBox.RowHeadersVisible = false;
            this.MeetingAssignmentsGridBox.Size = new System.Drawing.Size(303, 159);
            this.MeetingAssignmentsGridBox.TabIndex = 0;
            this.MeetingAssignmentsGridBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MeetingAssignmentsGridBox_CellContentClick);
            // 
            // MeetingAssignmentId
            // 
            this.MeetingAssignmentId.HeaderText = "MeetingAssignmentId";
            this.MeetingAssignmentId.Name = "MeetingAssignmentId";
            this.MeetingAssignmentId.Visible = false;
            // 
            // Assignment
            // 
            this.Assignment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Assignment.HeaderText = "Assignment";
            this.Assignment.Name = "Assignment";
            this.Assignment.ReadOnly = true;
            this.Assignment.Width = 86;
            // 
            // Member
            // 
            this.Member.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Member.DataPropertyName = "am";
            this.Member.HeaderText = "Member Assigned";
            this.Member.Name = "Member";
            this.Member.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // memberAssignmentBindingSource
            // 
            this.memberAssignmentBindingSource.DataSource = typeof(MeetingManager.MemberAssignment);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(MeetingManager.Member);
            // 
            // chooseMemberBox
            // 
            this.chooseMemberBox.FormattingEnabled = true;
            this.chooseMemberBox.Location = new System.Drawing.Point(116, 245);
            this.chooseMemberBox.Name = "chooseMemberBox";
            this.chooseMemberBox.Size = new System.Drawing.Size(171, 21);
            this.chooseMemberBox.TabIndex = 1;
            this.chooseMemberBox.Visible = false;
            // 
            // UpdateMemberAssignment
            // 
            this.UpdateMemberAssignment.Location = new System.Drawing.Point(322, 245);
            this.UpdateMemberAssignment.Name = "UpdateMemberAssignment";
            this.UpdateMemberAssignment.Size = new System.Drawing.Size(81, 23);
            this.UpdateMemberAssignment.TabIndex = 3;
            this.UpdateMemberAssignment.Text = "Update Assignment";
            this.UpdateMemberAssignment.UseVisualStyleBackColor = true;
            this.UpdateMemberAssignment.Visible = false;
            this.UpdateMemberAssignment.Click += new System.EventHandler(this.UpdateMemberAssignment_Click);
            // 
            // AssignmentLabel
            // 
            this.AssignmentLabel.AutoSize = true;
            this.AssignmentLabel.Location = new System.Drawing.Point(116, 213);
            this.AssignmentLabel.Name = "AssignmentLabel";
            this.AssignmentLabel.Size = new System.Drawing.Size(35, 13);
            this.AssignmentLabel.TabIndex = 4;
            this.AssignmentLabel.Text = "label1";
            this.AssignmentLabel.Visible = false;
            // 
            // MeetingDateLabel
            // 
            this.MeetingDateLabel.AutoSize = true;
            this.MeetingDateLabel.Location = new System.Drawing.Point(238, 13);
            this.MeetingDateLabel.Name = "MeetingDateLabel";
            this.MeetingDateLabel.Size = new System.Drawing.Size(30, 13);
            this.MeetingDateLabel.TabIndex = 5;
            this.MeetingDateLabel.Text = "Date";
            // 
            // EditMeetingAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 337);
            this.Controls.Add(this.MeetingDateLabel);
            this.Controls.Add(this.AssignmentLabel);
            this.Controls.Add(this.UpdateMemberAssignment);
            this.Controls.Add(this.chooseMemberBox);
            this.Controls.Add(this.MeetingAssignmentsGridBox);
            this.Name = "EditMeetingAssignment";
            this.Text = "EditMeetingAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.MeetingAssignmentsGridBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberAssignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MeetingAssignmentsGridBox;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource memberAssignmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetingAssignmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.ComboBox chooseMemberBox;
        private System.Windows.Forms.Button UpdateMemberAssignment;
        private System.Windows.Forms.Label AssignmentLabel;
        private System.Windows.Forms.Label MeetingDateLabel;
    }
}
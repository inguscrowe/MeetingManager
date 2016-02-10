namespace MeetingManagerUI
{
    partial class AssignmentsProfileForm
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
            this.AssignmentsGridBox = new System.Windows.Forms.DataGridView();
            this.AddAssignmentButton = new System.Windows.Forms.Button();
            this.AssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchedulePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAssignment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPerMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentsGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignmentsGridBox
            // 
            this.AssignmentsGridBox.AllowUserToAddRows = false;
            this.AssignmentsGridBox.AllowUserToDeleteRows = false;
            this.AssignmentsGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentsGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentId,
            this.SchedulePosition,
            this.IsAssignment,
            this.Assignment,
            this.Description,
            this.AmountPerMeeting});
            this.AssignmentsGridBox.Location = new System.Drawing.Point(12, 25);
            this.AssignmentsGridBox.Name = "AssignmentsGridBox";
            this.AssignmentsGridBox.ReadOnly = true;
            this.AssignmentsGridBox.RowHeadersVisible = false;
            this.AssignmentsGridBox.Size = new System.Drawing.Size(586, 185);
            this.AssignmentsGridBox.TabIndex = 0;
            this.AssignmentsGridBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssignmentsGridBox_CellDoubleClick);
            // 
            // AddAssignmentButton
            // 
            this.AddAssignmentButton.Location = new System.Drawing.Point(13, 217);
            this.AddAssignmentButton.Name = "AddAssignmentButton";
            this.AddAssignmentButton.Size = new System.Drawing.Size(131, 31);
            this.AddAssignmentButton.TabIndex = 1;
            this.AddAssignmentButton.Text = "Add Assignment";
            this.AddAssignmentButton.UseVisualStyleBackColor = true;
            this.AddAssignmentButton.Click += new System.EventHandler(this.AddAssignmentButton_Click);
            // 
            // AssignmentId
            // 
            this.AssignmentId.HeaderText = "AssignmentId";
            this.AssignmentId.Name = "AssignmentId";
            this.AssignmentId.ReadOnly = true;
            this.AssignmentId.Visible = false;
            // 
            // SchedulePosition
            // 
            this.SchedulePosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SchedulePosition.HeaderText = "Schedule Position";
            this.SchedulePosition.Name = "SchedulePosition";
            this.SchedulePosition.ReadOnly = true;
            this.SchedulePosition.Width = 107;
            // 
            // IsAssignment
            // 
            this.IsAssignment.HeaderText = "IsAssignment";
            this.IsAssignment.Name = "IsAssignment";
            this.IsAssignment.ReadOnly = true;
            this.IsAssignment.Visible = false;
            // 
            // Assignment
            // 
            this.Assignment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Assignment.HeaderText = "Assignment";
            this.Assignment.Name = "Assignment";
            this.Assignment.ReadOnly = true;
            this.Assignment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Assignment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Assignment.Width = 67;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // AmountPerMeeting
            // 
            this.AmountPerMeeting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountPerMeeting.HeaderText = "Meeting Amount";
            this.AmountPerMeeting.Name = "AmountPerMeeting";
            this.AmountPerMeeting.ReadOnly = true;
            // 
            // AssignmentsProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 316);
            this.Controls.Add(this.AddAssignmentButton);
            this.Controls.Add(this.AssignmentsGridBox);
            this.Name = "AssignmentsProfileForm";
            this.Text = "Assignment Profile";
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentsGridBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAssignmentButton;
        public System.Windows.Forms.DataGridView AssignmentsGridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedulePosition;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPerMeeting;
    }
}
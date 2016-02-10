namespace MeetingManagerUI
{
    partial class AssignmentForm
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
            this.AssignmentNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AmountPerMeetingLabel = new System.Windows.Forms.Label();
            this.AssignmentNameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AmountPerMeetingPicker = new System.Windows.Forms.NumericUpDown();
            this.CreateUpdateAssignmentButton = new System.Windows.Forms.Button();
            this.schedulePositionPicker = new System.Windows.Forms.NumericUpDown();
            this.SchedulePositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AmountPerMeetingPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePositionPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignmentNameLabel
            // 
            this.AssignmentNameLabel.AutoSize = true;
            this.AssignmentNameLabel.Location = new System.Drawing.Point(30, 35);
            this.AssignmentNameLabel.Name = "AssignmentNameLabel";
            this.AssignmentNameLabel.Size = new System.Drawing.Size(92, 13);
            this.AssignmentNameLabel.TabIndex = 0;
            this.AssignmentNameLabel.Text = "Assignment Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(30, 74);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            // 
            // AmountPerMeetingLabel
            // 
            this.AmountPerMeetingLabel.AutoSize = true;
            this.AmountPerMeetingLabel.Location = new System.Drawing.Point(30, 119);
            this.AmountPerMeetingLabel.Name = "AmountPerMeetingLabel";
            this.AmountPerMeetingLabel.Size = new System.Drawing.Size(103, 13);
            this.AmountPerMeetingLabel.TabIndex = 2;
            this.AmountPerMeetingLabel.Text = "Amount Per Meeting";
            // 
            // AssignmentNameTextBox
            // 
            this.AssignmentNameTextBox.Location = new System.Drawing.Point(139, 28);
            this.AssignmentNameTextBox.Name = "AssignmentNameTextBox";
            this.AssignmentNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.AssignmentNameTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(139, 67);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(301, 20);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // AmountPerMeetingPicker
            // 
            this.AmountPerMeetingPicker.Location = new System.Drawing.Point(158, 112);
            this.AmountPerMeetingPicker.Name = "AmountPerMeetingPicker";
            this.AmountPerMeetingPicker.Size = new System.Drawing.Size(45, 20);
            this.AmountPerMeetingPicker.TabIndex = 5;
            // 
            // CreateUpdateAssignmentButton
            // 
            this.CreateUpdateAssignmentButton.Location = new System.Drawing.Point(139, 230);
            this.CreateUpdateAssignmentButton.Name = "CreateUpdateAssignmentButton";
            this.CreateUpdateAssignmentButton.Size = new System.Drawing.Size(164, 23);
            this.CreateUpdateAssignmentButton.TabIndex = 6;
            this.CreateUpdateAssignmentButton.Text = "Create Assignment";
            this.CreateUpdateAssignmentButton.UseVisualStyleBackColor = true;
            this.CreateUpdateAssignmentButton.Click += new System.EventHandler(this.CreateUpdateAssignmentButton_Click);
            // 
            // schedulePositionPicker
            // 
            this.schedulePositionPicker.Location = new System.Drawing.Point(158, 156);
            this.schedulePositionPicker.Name = "schedulePositionPicker";
            this.schedulePositionPicker.Size = new System.Drawing.Size(45, 20);
            this.schedulePositionPicker.TabIndex = 8;
            // 
            // SchedulePositionLabel
            // 
            this.SchedulePositionLabel.AutoSize = true;
            this.SchedulePositionLabel.Location = new System.Drawing.Point(30, 163);
            this.SchedulePositionLabel.Name = "SchedulePositionLabel";
            this.SchedulePositionLabel.Size = new System.Drawing.Size(92, 13);
            this.SchedulePositionLabel.TabIndex = 7;
            this.SchedulePositionLabel.Text = "Schedule Position";
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 281);
            this.Controls.Add(this.schedulePositionPicker);
            this.Controls.Add(this.SchedulePositionLabel);
            this.Controls.Add(this.CreateUpdateAssignmentButton);
            this.Controls.Add(this.AmountPerMeetingPicker);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.AssignmentNameTextBox);
            this.Controls.Add(this.AmountPerMeetingLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AssignmentNameLabel);
            this.Name = "AssignmentForm";
            this.Text = "Assignment Form";
            ((System.ComponentModel.ISupportInitialize)(this.AmountPerMeetingPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePositionPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssignmentNameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label AmountPerMeetingLabel;
        private System.Windows.Forms.TextBox AssignmentNameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.NumericUpDown AmountPerMeetingPicker;
        private System.Windows.Forms.Button CreateUpdateAssignmentButton;
        private System.Windows.Forms.NumericUpDown schedulePositionPicker;
        private System.Windows.Forms.Label SchedulePositionLabel;

    }
}
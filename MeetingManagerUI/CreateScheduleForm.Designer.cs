namespace MeetingManagerUI
{
    partial class CreateScheduleForm
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
            this.StartDateCalenedar = new System.Windows.Forms.MonthCalendar();
            this.EndDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.CreateScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDateCalenedar
            // 
            this.StartDateCalenedar.Location = new System.Drawing.Point(18, 18);
            this.StartDateCalenedar.Name = "StartDateCalenedar";
            this.StartDateCalenedar.TabIndex = 0;
            // 
            // EndDateCalendar
            // 
            this.EndDateCalendar.Location = new System.Drawing.Point(350, 18);
            this.EndDateCalendar.Name = "EndDateCalendar";
            this.EndDateCalendar.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(99, 189);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 2;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(444, 189);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(52, 13);
            this.EndDateLabel.TabIndex = 3;
            this.EndDateLabel.Text = "End Date";
            // 
            // CreateScheduleButton
            // 
            this.CreateScheduleButton.Location = new System.Drawing.Point(250, 219);
            this.CreateScheduleButton.Name = "CreateScheduleButton";
            this.CreateScheduleButton.Size = new System.Drawing.Size(109, 23);
            this.CreateScheduleButton.TabIndex = 4;
            this.CreateScheduleButton.Text = "Create Schedule";
            this.CreateScheduleButton.UseVisualStyleBackColor = true;
            this.CreateScheduleButton.Click += new System.EventHandler(this.CreateScheduleButton_Click);
            // 
            // CreateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 295);
            this.Controls.Add(this.CreateScheduleButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDateCalendar);
            this.Controls.Add(this.StartDateCalenedar);
            this.Name = "CreateScheduleForm";
            this.Text = "Create Schedule Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar StartDateCalenedar;
        private System.Windows.Forms.MonthCalendar EndDateCalendar;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button CreateScheduleButton;
    }
}
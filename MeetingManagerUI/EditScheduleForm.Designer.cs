namespace MeetingManagerUI
{
    partial class EditScheduleForm
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
            this.ScheduleGridBox = new System.Windows.Forms.DataGridView();
            this.ScheduleDateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddCancelMeetingButton = new System.Windows.Forms.Button();
            this.SelectedScheduleLabel = new System.Windows.Forms.Label();
            this.AddCancelMeetingPicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.SpecialMeetingEventsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleGridBox
            // 
            this.ScheduleGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleDateId,
            this.DateStart,
            this.DateEnd});
            this.ScheduleGridBox.Location = new System.Drawing.Point(411, 24);
            this.ScheduleGridBox.Name = "ScheduleGridBox";
            this.ScheduleGridBox.RowHeadersVisible = false;
            this.ScheduleGridBox.Size = new System.Drawing.Size(240, 150);
            this.ScheduleGridBox.TabIndex = 0;
            this.ScheduleGridBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleGridBox_CellContentClick);
            // 
            // ScheduleDateId
            // 
            this.ScheduleDateId.HeaderText = "ScheduleId";
            this.ScheduleDateId.Name = "ScheduleDateId";
            this.ScheduleDateId.Visible = false;
            // 
            // DateStart
            // 
            this.DateStart.HeaderText = "Date Start";
            this.DateStart.Name = "DateStart";
            // 
            // DateEnd
            // 
            this.DateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateEnd.HeaderText = "Date End";
            this.DateEnd.Name = "DateEnd";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(411, 180);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(576, 180);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddCancelMeetingButton
            // 
            this.AddCancelMeetingButton.Location = new System.Drawing.Point(72, 24);
            this.AddCancelMeetingButton.Name = "AddCancelMeetingButton";
            this.AddCancelMeetingButton.Size = new System.Drawing.Size(148, 23);
            this.AddCancelMeetingButton.TabIndex = 3;
            this.AddCancelMeetingButton.Text = "Add/Cancel Meeting";
            this.AddCancelMeetingButton.UseVisualStyleBackColor = true;
            this.AddCancelMeetingButton.Click += new System.EventHandler(this.AddCancelMeetingButton_Click);
            // 
            // SelectedScheduleLabel
            // 
            this.SelectedScheduleLabel.AutoSize = true;
            this.SelectedScheduleLabel.Location = new System.Drawing.Point(448, 223);
            this.SelectedScheduleLabel.Name = "SelectedScheduleLabel";
            this.SelectedScheduleLabel.Size = new System.Drawing.Size(114, 13);
            this.SelectedScheduleLabel.TabIndex = 5;
            this.SelectedScheduleLabel.Text = "No Schedule Selected";
            // 
            // AddCancelMeetingPicker
            // 
            this.AddCancelMeetingPicker.Location = new System.Drawing.Point(53, 170);
            this.AddCancelMeetingPicker.Name = "AddCancelMeetingPicker";
            this.AddCancelMeetingPicker.Size = new System.Drawing.Size(200, 20);
            this.AddCancelMeetingPicker.TabIndex = 6;
            this.AddCancelMeetingPicker.Visible = false;
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.Location = new System.Drawing.Point(53, 205);
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.Size = new System.Drawing.Size(200, 20);
            this.ReasonTextBox.TabIndex = 7;
            this.ReasonTextBox.Text = "**ENTER NOTE**";
            this.ReasonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReasonTextBox.Visible = false;
            // 
            // SpecialMeetingEventsListBox
            // 
            this.SpecialMeetingEventsListBox.FormattingEnabled = true;
            this.SpecialMeetingEventsListBox.Location = new System.Drawing.Point(53, 69);
            this.SpecialMeetingEventsListBox.Name = "SpecialMeetingEventsListBox";
            this.SpecialMeetingEventsListBox.Size = new System.Drawing.Size(200, 95);
            this.SpecialMeetingEventsListBox.TabIndex = 8;
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.SpecialMeetingEventsListBox);
            this.Controls.Add(this.ReasonTextBox);
            this.Controls.Add(this.AddCancelMeetingPicker);
            this.Controls.Add(this.SelectedScheduleLabel);
            this.Controls.Add(this.AddCancelMeetingButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ScheduleGridBox);
            this.Name = "EditScheduleForm";
            this.Text = "EditScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleGridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddCancelMeetingButton;
        private System.Windows.Forms.Label SelectedScheduleLabel;
        private System.Windows.Forms.DateTimePicker AddCancelMeetingPicker;
        private System.Windows.Forms.TextBox ReasonTextBox;
        private System.Windows.Forms.ListBox SpecialMeetingEventsListBox;
    }
}
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
            this.ScheduleGridBox.Location = new System.Drawing.Point(129, 12);
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
            this.ViewButton.Location = new System.Drawing.Point(129, 195);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(293, 194);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ScheduleGridBox);
            this.Name = "EditScheduleForm";
            this.Text = "EditScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleGridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
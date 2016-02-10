namespace MeetingManagerUI
{
    partial class MemberAssignmentForm
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
            this.ExistingMembersList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentMemberAssignments = new System.Windows.Forms.DataGridView();
            this.AddMemberAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExistingMembersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentMemberAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // ExistingMembersList
            // 
            this.ExistingMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExistingMembersList.ColumnHeadersVisible = false;
            this.ExistingMembersList.Location = new System.Drawing.Point(12, 46);
            this.ExistingMembersList.Name = "ExistingMembersList";
            this.ExistingMembersList.RowHeadersVisible = false;
            this.ExistingMembersList.Size = new System.Drawing.Size(175, 205);
            this.ExistingMembersList.TabIndex = 34;
            this.ExistingMembersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExistingMembersList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Choose Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Current Assigments";
            // 
            // CurrentMemberAssignments
            // 
            this.CurrentMemberAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentMemberAssignments.Location = new System.Drawing.Point(298, 46);
            this.CurrentMemberAssignments.Name = "CurrentMemberAssignments";
            this.CurrentMemberAssignments.Size = new System.Drawing.Size(154, 205);
            this.CurrentMemberAssignments.TabIndex = 38;
            // 
            // AddMemberAssignment
            // 
            this.AddMemberAssignment.Location = new System.Drawing.Point(298, 274);
            this.AddMemberAssignment.Name = "AddMemberAssignment";
            this.AddMemberAssignment.Size = new System.Drawing.Size(94, 23);
            this.AddMemberAssignment.TabIndex = 39;
            this.AddMemberAssignment.Text = "Add Assignment";
            this.AddMemberAssignment.UseVisualStyleBackColor = true;
            this.AddMemberAssignment.Click += new System.EventHandler(this.AddMemberAssignment_Click);
            // 
            // MemberAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 328);
            this.Controls.Add(this.AddMemberAssignment);
            this.Controls.Add(this.CurrentMemberAssignments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExistingMembersList);
            this.Name = "MemberAssignmentForm";
            this.Text = "MemberAssignments";
            ((System.ComponentModel.ISupportInitialize)(this.ExistingMembersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentMemberAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ExistingMembersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CurrentMemberAssignments;
        private System.Windows.Forms.Button AddMemberAssignment;

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingManager;


namespace MeetingManagerUI
{
    public partial class EditMemberForm : Form
    {
        ClassManager cmanager = new ClassManager();
        public EditMemberForm()
        {
            InitializeComponent();

            RefreshMembersListBox();
           
        }

        public void RefreshMembersListBox()
        {
            List<Member> mem = cmanager.MembersByCongregationId(1);
            ExistingMembersList.AutoGenerateColumns = false;
            ExistingMembersList.ColumnCount = 2;
            ExistingMembersList.Columns[0].Name = "Id";
            ExistingMembersList.Columns[0].Visible = false;
            ExistingMembersList.Columns[1].Name = "Member";
            ExistingMembersList.Columns[1].Visible = true;
            ExistingMembersList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (Member m in mem)
            {
                string[] row = new string[2];
                if (m.PreferredName == null)
                {
                    row = new string[2] { m.Id.ToString(), m.FirstName + " " + m.LastName };
                }
                else
                {
                    row = new string[2] { m.Id.ToString(), m.PreferredName };
                }

                ExistingMembersList.Rows.Add(row);
            }
            
        }

        private void UpdateMember_Click(object sender, EventArgs e)
        {
            //Member selectedMember = cmanager.UpdateMember(Convert.ToInt32(this.MemberId.Text), this.FirstName.Text, this.MiddleName.Text, this.LastName.Text, this.PreferredName.Text, 
            //    this.DateOfBirthPicker.Value, this.BaptismDatePicker.Value, this.Email.Text, this.ContactNumber.Text);
            //MessageBox.Show((selectedMember.PreferredName ?? selectedMember.FirstName + " " + selectedMember.LastName) + " information has been updated.");
            this.MemberId.Text = "";
            this.FirstName.Text = "";
            this.MiddleName.Text = "";
            this.LastName.Text = "";
            this.PreferredName.Text = "";
            this.Email.Text = "";
            this.ContactNumber.Text = "";
            this.DateOfBirthPicker.Value = DateTime.Now;
            this.BaptismDatePicker.Value = DateTime.Now;

        }

        private void existingMembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = ExistingMembersList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            int id = Convert.ToInt32(i);
            Member selectedMember = cmanager.MemberByMemberId(id);
            this.MemberId.Text = selectedMember.Id.ToString();
            this.FirstName.Text = selectedMember.FirstName;
            this.MiddleName.Text = selectedMember.MiddleName;
            this.LastName.Text = selectedMember.LastName;
            this.PreferredName.Text = selectedMember.PreferredName;
            this.Email.Text = selectedMember.Email;
            this.ContactNumber.Text = selectedMember.ContactNumber;
            this.DateOfBirthPicker.Value = selectedMember.DateOfBirth??DateTime.Now;
            this.BaptismDatePicker.Value = selectedMember.BaptismDate ?? DateTime.Now;


        }

        


    }
}

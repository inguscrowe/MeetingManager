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
    public partial class MemberAssignmentForm : Form
    {
        ClassManager cmanager = new ClassManager();
        public MemberAssignmentForm()
        {
            InitializeComponent();
            RefreshMembersListBox();

        }

        private void ExistingMembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = ExistingMembersList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            int id = Convert.ToInt32(i);
            List<MemberAssignment> me = cmanager.MemberAssignmentsByMemberId(id);
            CurrentMemberAssignments.AutoGenerateColumns = false;
            CurrentMemberAssignments.ColumnCount = 3;
            CurrentMemberAssignments.Columns[0].Name = "MemberId";
            CurrentMemberAssignments.Columns[0].Visible = false;
            CurrentMemberAssignments.Columns[1].Name = "AssignmentId";
            CurrentMemberAssignments.Columns[1].Visible = false;
            CurrentMemberAssignments.Columns[2].Name = "Assignment";
            CurrentMemberAssignments.Columns[2].Visible = true;
            CurrentMemberAssignments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (MemberAssignment ma in me)
            {
                string[] row = new string[3]{ma.MemberId.ToString(),ma.AssignmentId.ToString(),ma.Assignment.Label};
                CurrentMemberAssignments.Rows.Add(row);
            }
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

        private void AddMemberAssignment_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(CurrentMemberAssignments.Rows[0].Cells[0].Value);
            //AddMemberAssignmentForm addma = new AddMemberAssignmentForm(memberId);
            

        } 
    }
}

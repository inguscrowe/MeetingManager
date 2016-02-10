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
    public partial class AssignmentsProfileForm : Form
    {
        CommonControls cc = new CommonControls();
        ClassManager manager = new ClassManager();
        public AssignmentsProfileForm(Member member)
        {
            InitializeComponent();
            AssignmentsGridBox = cc.MemberAssignmentBox(AssignmentsGridBox, member);
            Scheduler = member;
        }

        public Member Scheduler { get; set; }

        private void AddAssignmentButton_Click(object sender, EventArgs e)
        {
            AssignmentForm af = new AssignmentForm(Scheduler,this,null);
            af.WindowState = FormWindowState.Normal;
            af.Show();
        }

        private void AssignmentsGridBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             AssignmentForm af = new AssignmentForm(Scheduler,this,Convert.ToInt32(AssignmentsGridBox.Rows[e.RowIndex].Cells["AssignmentId"].Value));
             af.WindowState = FormWindowState.Normal;
             af.Show();
        }
    }
}

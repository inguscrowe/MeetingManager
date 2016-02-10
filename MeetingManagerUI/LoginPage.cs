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
    public partial class LoginPage : Form
    {
        ClassManager manager = new ClassManager();
        Form parent = new Form();
        public LoginPage(Form mdiParent)
        {
            InitializeComponent();
            parent = mdiParent;
        }

        private void NewCongregationButton_Click(object sender, EventArgs e)
        {
            CongregationForm congoForm = new CongregationForm(true);
            congoForm.WindowState = FormWindowState.Normal;
            congoForm.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int count = manager.MemberByUsername(UserNameTextBox.Text);
            List<Member> members = manager.MemberByUsernamePassword(UserNameTextBox.Text, PasswordTextBox.Text);
            if (count == 0)
            {
                MessageBox.Show("Username not valid.");
                return;
            }

            if (members.Count == 0)
            {
                MessageBox.Show("Username & Password not Valid.");
                return;
            }
            List<MemberAssignment> ma = manager.MemberAssignmentsByMemberId(members[0].Id);
            if (ma.Any(z => z.Assignment.Label == "Assignment Scheduler"))
            {
                HomePage home = new HomePage(members[0], true);
                home.WindowState = FormWindowState.Maximized;
                home.MdiParent = parent;
                home.Show();
                this.Close();
            }
            else
            {
                HomePage home2 = new HomePage(members[0], false);
            }
        }
    }
}

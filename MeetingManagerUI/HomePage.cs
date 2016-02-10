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
    public partial class HomePage : Form
    {
        ClassManager manager = new ClassManager();
        CommonControls cc = new CommonControls();
        public HomePage(Member member, bool isScheduler)
        {
            InitializeComponent();
            ThisMember = member;
            MemberNameLabel.Text = ThisMember.PreferredName ?? ThisMember.FirstName + " " + ThisMember.LastName;
            if(member.LastLoginTime==null)
            {
                LastLoginLabel.Text = "Last Login: First Login TODAY!";
                ThisMember.LastLoginTime = DateTime.Now;
                manager.UpdateMember(ThisMember, false);
            }
            else
            {
                LastLoginLabel.Text = "Last Login: " + ThisMember.LastLoginTime.ToString();
                ThisMember.LastLoginTime = DateTime.Now;
                manager.UpdateMember(ThisMember, false);
            }

            ScheduleDate currentSchedule = manager.CurrentScheduleDate();
            if(currentSchedule!=null)
            {
                CurrentScheduleGridView = cc.Schedule(CurrentScheduleGridView, currentSchedule);
            }
            

            
        }

        public Member ThisMember { get; set; }
        private void editMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMembersForm em = new EditMembersForm(ThisMember.CongregationId);
            em.WindowState = FormWindowState.Normal;
            em.Show();
        }

        private void assignmentsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignmentsProfileForm ap = new AssignmentsProfileForm(ThisMember);
            ap.WindowState = FormWindowState.Normal;
            ap.Show();
        }

        private void newScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForm sf = new ScheduleForm(ThisMember, this);
            sf.WindowState = FormWindowState.Normal;
            sf.Show();
        }


        private void CurrentScheduleGridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditMeetingAssignment ema = new EditMeetingAssignment((Convert.ToInt32(CurrentScheduleGridView.Rows[e.RowIndex].Cells[0].Value)));
            ema.WindowState = FormWindowState.Normal;
            ema.Show();
        }

        
    }
}

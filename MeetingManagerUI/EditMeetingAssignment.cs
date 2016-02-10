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
    public partial class EditMeetingAssignment : Form
    {
        ClassManager manager = new ClassManager();
        CommonControls cc = new CommonControls();

        public EditMeetingAssignment(int meetingId)
        {
            InitializeComponent();

            UpdateMemberAssignmentBox(meetingId);
            Meeting meet = manager.MeetingByMeetingId(meetingId);
            MeetingDateLabel.Text = "Meeting Assignments for " + meet.MeetingDate.DayOfWeek + ", " + meet.MeetingDate.Month.ToString("MMM") + " " + meet.MeetingDate.Day;
            
        }

        public MeetingAssignment SelectedMeetingAssignment { get; set; }

        private void MeetingAssignmentsGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MeetingAssignment meetassign = manager.MeetingAssignmentByMeetingAssignmentId(Convert.ToInt32(MeetingAssignmentsGridBox.Rows[e.RowIndex].Cells[0].Value));
            SelectedMeetingAssignment = meetassign;
           List<Member> mavailabe = manager.MembersAvailable(meetassign.AssignmentId,meetassign.Meeting.MeetingDate);
            chooseMemberBox.Visible = true;
            AssignmentLabel.Visible = true;
            UpdateMemberAssignment.Visible = true;
            AssignmentLabel.Text = "Choose member for " + meetassign.Assignment.Label;
            chooseMemberBox.DataSource = mavailabe;
            chooseMemberBox.ValueMember = "Id";
            chooseMemberBox.DisplayMember = "LastName";
        }

        private void UpdateMemberAssignment_Click(object sender, EventArgs e)
        {
            List<MeetingAssignment> oldMeetingAssignment = SelectedMeetingAssignment.Member.MeetingAssignments.ToList();
            oldMeetingAssignment = oldMeetingAssignment.Where(z => z.ReferanceMark == true).ToList();
            if(oldMeetingAssignment.Count!=0)
            {
                oldMeetingAssignment.OrderBy(o => o.Meeting.MeetingDate).ToList();
                oldMeetingAssignment.Last().ReferanceMark = false;
                manager.UpdateMeetingAssignment(oldMeetingAssignment.Last());
            }
            

            SelectedMeetingAssignment.MemberId = Convert.ToInt32(chooseMemberBox.SelectedValue);
            SelectedMeetingAssignment.ReferanceMark = false;
            SelectedMeetingAssignment = manager.UpdateMeetingAssignment(SelectedMeetingAssignment);
            UpdateMemberAssignmentBox(SelectedMeetingAssignment.MeetingId);
        }

        public void UpdateMemberAssignmentBox(int meetingId)
        {
            MeetingAssignmentsGridBox.Rows.Clear();
            MeetingAssignmentsGridBox.Refresh();
            List<MeetingAssignment> maList = manager.MeetingAssignmentsByMeetingId(meetingId);
            foreach (MeetingAssignment m in maList)
            {
                MeetingAssignmentsGridBox.Rows.Add(m.Id, m.Assignment.Label, m.Member.PreferredName ?? m.Member.FirstName + " " + m.Member.LastName);
            }
        }
    }
}

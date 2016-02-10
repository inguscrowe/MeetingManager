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
    public partial class EditMembersForm : Form
    {
        ClassManager manager = new ClassManager();
        CommonControls cc = new CommonControls();
        Congregation congo = new Congregation();
        
        public EditMembersForm(int congregationId)
        {
            InitializeComponent();
            congo=manager.CongregationByCongregationId(congregationId);
            CurrentMembersGridBox = cc.CurrentMembersBox(CurrentMembersGridBox,congo.Id);
            
        }

        public Member SelectedMember { get; set; }

        private void AddMembers_Click(object sender, EventArgs e)
        {
            MemberForm mf = new MemberForm(congo.Id, false, true,false,this);
            mf.WindowState = FormWindowState.Normal;
            mf.Show();
            
        }

        
        private void CurrentMembersGridBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberForm mf = new MemberForm(congo.Id,false,true,true,this);
            mf.WindowState = FormWindowState.Normal;
            mf.Show();

        }

        private void CurrentMembersGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowsindex = e.RowIndex;
            SelectedMember = manager.MemberByMemberId(Convert.ToInt32(CurrentMembersGridBox.Rows[rowsindex].Cells["Id"].Value));
            SelectedMemberLabel.Text = "Member currently selected: "+(SelectedMember.PreferredName??SelectedMember.FirstName + " " + SelectedMember.LastName);
            MemberAssignmentsGridBox = cc.MemberAssignmentBox(MemberAssignmentsGridBox, SelectedMember);
            DatesAvailableGridBox = cc.DatesAvailableBox(DatesAvailableGridBox, SelectedMember);
            PublicMeetingAvailableCheckBox.Checked = Convert.ToBoolean(SelectedMember.IsAvailablePublicMeeting);
            WeekdayMeetingAvailableCheckBox.Checked = Convert.ToBoolean(SelectedMember.IsAvailableWeekMeeting);
        }

        private void MemberAssignmentsButton_Click(object sender, EventArgs e)
        {
            List<MemberAssignment> ma = manager.MemberAssignmentsByMemberId(SelectedMember.Id);

            foreach(DataGridViewRow r in MemberAssignmentsGridBox.Rows)
            {
                if (Convert.ToBoolean(r.Cells["IsAssigned"].Value) == true)
                {
                    if (ma.All(z => z.AssignmentId != Convert.ToInt32(r.Cells["AssignementId"].Value)))
                    {
                        MemberAssignment newMa = manager.CreateMemberAssignment(SelectedMember.Id, Convert.ToInt32(r.Cells["AssignementId"].Value), SelectedMember.CongregationId);
                    }
                }
                if (Convert.ToBoolean(r.Cells["IsAssigned"].Value) == false)
                {
                    List<MemberAssignment> toBeRemoved = (from remove in ma
                                                          where remove.AssignmentId == Convert.ToInt32(r.Cells["AssignementId"].Value)
                                                          select remove).ToList();
                    if(toBeRemoved.Count!=0)
                    {
                        manager.DeleteMemberAssignement(toBeRemoved[0].Id);
                    }
                    
                }
            }
            MemberAssignmentsGridBox = cc.MemberAssignmentBox(MemberAssignmentsGridBox, SelectedMember);
            MessageBox.Show("Member Assignments Updated.");
        }

        private void UpdateAvailableDatesButton_Click(object sender, EventArgs e)
        {
            List<UnavailableDate> udates1= manager.UnavailableDateByMemberId(SelectedMember.Id);
            Member currentMembter = manager.MemberByMemberId(SelectedMember.Id);
            if(currentMembter.IsAvailableWeekMeeting!=WeekdayMeetingAvailableCheckBox.Checked||currentMembter.IsAvailablePublicMeeting!=PublicMeetingAvailableCheckBox.Checked)
            {
                SelectedMember.IsAvailablePublicMeeting = PublicMeetingAvailableCheckBox.Checked;
                SelectedMember.IsAvailableWeekMeeting = WeekdayMeetingAvailableCheckBox.Checked;
                manager.UpdateMember(SelectedMember, true);
            }
            foreach(DataGridViewRow r in DatesAvailableGridBox.Rows)
            {
                if(Convert.ToBoolean(r.Cells["IsAvailable"].Value)==false)
                {
                    if(udates1.Any(u=>u.DateUnavailable==Convert.ToDateTime(r.Cells["Date"].Value)))
                    {
                        continue;
                    }
                    else
                    {
                        manager.CreateUnavailableDate(SelectedMember.Id, Convert.ToDateTime(r.Cells["Date"].Value), null);
                        continue;
                    }
                }
                else
                {
                    if (udates1.Any(u => u.DateUnavailable == Convert.ToDateTime(r.Cells["Date"].Value)))
                    {
                        manager.DeleteUnavailableDate(Convert.ToDateTime(r.Cells["Date"].Value), SelectedMember.Id);
                        continue;
                    }
                    
                }
            }
            MessageBox.Show((SelectedMember.PreferredName ?? SelectedMember.FirstName + " " + SelectedMember.LastName) + " availability has been updated.");
        }

        
    }
}

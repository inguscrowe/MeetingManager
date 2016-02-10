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
    public partial class AssignmentForm : Form
    {
        ClassManager manager = new ClassManager();
        CommonControls cc = new CommonControls();
        AssignmentsProfileForm assignmentProfileForm;
        public AssignmentForm(Member scheduler,AssignmentsProfileForm apf,int? assignmentId)
        {
            InitializeComponent();
            Scheduler = scheduler;
            assignmentProfileForm = apf;
            if(assignmentId!=null)
            {
                int ai=Convert.ToInt32(assignmentId);
                AssignmentUpdate = manager.AssignmentByAssignmentId(ai);
                this.AssignmentNameTextBox.Text = AssignmentUpdate.Label;
                this.DescriptionTextBox.Text = AssignmentUpdate.Description;
                this.AmountPerMeetingPicker.Value = Convert.ToDecimal(AssignmentUpdate.AmountPerMeeting);
                this.schedulePositionPicker.Value = Convert.ToDecimal(AssignmentUpdate.PositionOnSchedule);
                this.CreateUpdateAssignmentButton.Text = "Update Assignment";
            }
        }

        public Member Scheduler { get; set; }

        public Assignment AssignmentUpdate { get; set; }

        private void CreateUpdateAssignmentButton_Click(object sender, EventArgs e)
        {
            if(this.CreateUpdateAssignmentButton.Text!="Update Assignment")
            {
                Assignment a = manager.CreateAssignment(AssignmentNameTextBox.Text, DescriptionTextBox.Text, Scheduler.CongregationId, Convert.ToInt32(AmountPerMeetingPicker.Value),Convert.ToInt32(schedulePositionPicker.Value), Scheduler.Id);
                assignmentProfileForm.AssignmentsGridBox = cc.MemberAssignmentBox(assignmentProfileForm.AssignmentsGridBox, Scheduler);
                MessageBox.Show("Assignment " + a.Label + " created.");
                this.Close();
            }
            else
            {
                AssignmentUpdate.Label = this.AssignmentNameTextBox.Text;
                AssignmentUpdate.Description = this.DescriptionTextBox.Text;
                AssignmentUpdate.AmountPerMeeting = Convert.ToInt32(this.AmountPerMeetingPicker.Value);
                AssignmentUpdate.PositionOnSchedule = Convert.ToInt32(this.schedulePositionPicker.Value);
                Assignment ua = manager.UpdateAssignment(AssignmentUpdate);
                MessageBox.Show(ua.Label + " assignment updated.");
                assignmentProfileForm.AssignmentsGridBox = cc.MemberAssignmentBox(assignmentProfileForm.AssignmentsGridBox, Scheduler);
                this.Close();
            }
            

        }

        

        
    }
}

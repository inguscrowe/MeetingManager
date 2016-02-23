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
    public partial class EditScheduleForm : Form
    {
        ClassManager manager = new ClassManager();
        CommonControls cc = new CommonControls();
        ScheduleDate selected = new ScheduleDate();
        Member scheduler = new Member();
        HomePage hopa;
        public EditScheduleForm(Member thismember, HomePage hp)
        {
            InitializeComponent();
            RefreshScheduleBox();
            hopa = hp;
            scheduler = thismember;
            RefreshEventsBox();
        }

        public void RefreshEventsBox()
        {
            SpecialMeetingEventsListBox.Items.Clear();
            SpecialMeetingEventsListBox.Refresh();
            List<UnavailableDate> ud = manager.UnavailableDateByCongregationId(scheduler.CongregationId);
            foreach (UnavailableDate u in ud)
            {
                SpecialMeetingEventsListBox.Items.Add(u.DateUnavailable.ToShortDateString() + " - " + u.Reason.ToString());
            }
        }

        public void RefreshScheduleBox()
        {
            ScheduleGridBox.Rows.Clear();
            ScheduleGridBox.Refresh();
            List<ScheduleDate> sd = manager.ScheduleDates();

            foreach (ScheduleDate s in sd)
            {
                ScheduleGridBox.Rows.Add(s.Id, s.StartDate.ToShortDateString(), s.EndDate.ToShortDateString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            manager.DeleteScheduleMeetingAssignments(selected);
            RefreshScheduleBox();
            MessageBox.Show("Schedule and Assignments deleted.");
        }

        private void ScheduleGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = manager.ScheduleDatesByScheduleDateId(Convert.ToInt32(ScheduleGridBox.Rows[e.RowIndex].Cells[0].Value));
            SelectedScheduleLabel.Text = "Schedule selected: " + selected.StartDate.ToShortDateString() + "-" + selected.EndDate.ToShortDateString();
        }

        private void AddCancelMeetingButton_Click(object sender, EventArgs e)
        {
            if (AddCancelMeetingButton.Text == "Add/Cancel Meeting")
            {
                AddCancelMeetingPicker.Visible = true;
                ReasonTextBox.Visible = true;
                AddCancelMeetingButton.Text = "Create/Remove Meeting";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you cancelling a meeting", "Meeting Canceled?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    manager.CreateUnavailableDate(scheduler.Id, AddCancelMeetingPicker.Value, true, ReasonTextBox.Text,scheduler.CongregationId);
                }
                RefreshEventsBox();
                AddCancelMeetingPicker.Visible = false;
                ReasonTextBox.Visible = false;
                AddCancelMeetingButton.Text = "Add/Cancel Meeting";

            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            hopa.CurrentScheduleGridView = cc.Schedule(hopa.CurrentScheduleGridView, selected);
            hopa.CurrentSelectedSchedule = selected;
            hopa.StartDateLabel.Text = selected.StartDate.ToShortDateString();
            hopa.EndDateLabel.Text = selected.EndDate.ToShortDateString();
        }
    }
}

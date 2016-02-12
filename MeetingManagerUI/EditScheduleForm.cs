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
        ScheduleDate selected = new ScheduleDate();
        public EditScheduleForm()
        {
            InitializeComponent();
            RefreshScheduleBox();
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
            MessageBox.Show("Schedule and Assignmetns deleted.");
        }

        private void ScheduleGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = manager.ScheduleDatesByScheduleDateId(Convert.ToInt32(ScheduleGridBox.Rows[e.RowIndex].Cells[0].Value));
        }
    }
}

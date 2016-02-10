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
   
    public partial class ScheduleForm : Form
    {
        ClassManager manager = new ClassManager();
        CommonControls cc = new CommonControls();
        HomePage currentHp;
        public ScheduleForm(Member scheduler,HomePage hp)
        {
            InitializeComponent();
            Scheduler = scheduler;
            currentHp = hp;
        }


        public Member Scheduler { get; set; }
        private void CreateScheduleButton_Click(object sender, EventArgs e)
        {
            DateTime sd = StartDateCalenedar.SelectionStart;
            DateTime se = EndDateCalendar.SelectionStart;
            ScheduleDate shedate= manager.CreateScheduleDates(sd, se, Scheduler.CongregationId, Scheduler.Id);
            currentHp.CurrentScheduleGridView = cc.Schedule(currentHp.CurrentScheduleGridView, shedate);
            this.Close();

        }
    }
}

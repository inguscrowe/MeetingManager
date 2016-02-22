using System;
using System.IO;
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
            if (member.LastLoginTime == null)
            {
                LastLoginLabel.Text = "Last Login: First Login TODAY!";
                ThisMember.LastLoginTime = DateTime.Now;
                manager.UpdateMember(ThisMember, false);
            }
            else
            {

                LastLoginLabel.Text = "Last Login: " + Convert.ToDateTime(ThisMember.LastLoginTime).ToString("g");
                ThisMember.LastLoginTime = DateTime.Now;
                manager.UpdateMember(ThisMember, false);
            }

            CurrentSelectedSchedule = manager.CurrentScheduleDate();
            if (CurrentSelectedSchedule != null)
            {
                CurrentScheduleGridView = cc.Schedule(CurrentScheduleGridView, CurrentSelectedSchedule);
            }



        }

        public Member ThisMember { get; set; }

        public ScheduleDate CurrentSelectedSchedule { get; set; }
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
            CreateScheduleForm sf = new CreateScheduleForm(ThisMember, this);
            sf.WindowState = FormWindowState.Normal;
            sf.Show();
        }


        private void CurrentScheduleGridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditMeetingAssignment ema = new EditMeetingAssignment((Convert.ToInt32(CurrentScheduleGridView.Rows[e.RowIndex].Cells[0].Value)));
            ema.WindowState = FormWindowState.Normal;
            ema.Show();
        }

        private void removeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditScheduleForm esf = new EditScheduleForm(ThisMember,this);
            esf.WindowState = FormWindowState.Normal;
            esf.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportLocation.ShowDialog();
            using (StreamWriter sw = new StreamWriter(ExportLocation.SelectedPath + "\\" + CurrentSelectedSchedule.StartDate.ToString("MMdd") + "_" + CurrentSelectedSchedule.EndDate.ToString("MMdd") + ".csv"))
            {
                foreach (DataGridViewColumn c in CurrentScheduleGridView.Columns)
                {
                    if (c.Index == 0)
                    {
                        continue;
                    }
                    sw.Write(c.Name.ToString() + ",");
                }
                sw.WriteLine();

                foreach (DataGridViewRow r in CurrentScheduleGridView.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.ColumnIndex == 0||c.Value==null)
                        {
                            continue;
                        }
                        sw.Write(c.Value.ToString() + ",");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            MessageBox.Show("File Created");
        }


    }
}

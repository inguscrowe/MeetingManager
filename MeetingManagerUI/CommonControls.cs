using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingManager;
using System.Windows.Forms;

namespace MeetingManagerUI
{
    class CommonControls
    {
        ClassManager manager = new ClassManager();
        public CommonControls()
        {
            manager = new ClassManager();
        }
        public DataGridView CurrentMembersBox(DataGridView data, int congregationId)
        {

            List<Member> mem = manager.MembersByCongregationId(congregationId);
            data.Rows.Clear();
            data.Refresh();
            data.AutoGenerateColumns = false;
            data.ColumnCount = 2;
            data.Columns[0].Name = "Id";
            data.Columns[0].Visible = false;
            data.Columns[1].Name = "Member";
            data.Columns[1].Visible = true;
            data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (Member m in mem)
            {
                string[] row = new string[2];
                if (m.PreferredName == null || m.PreferredName == "")
                {
                    row = new string[2] { m.Id.ToString(), m.FirstName + " " + m.LastName };
                }
                else
                {
                    row = new string[2] { m.Id.ToString(), Convert.ToString(m.PreferredName) };
                }

                data.Rows.Add(row);
            }

            return data;
        }

        public DataGridView MemberAssignmentBox(DataGridView data, Member selectedMember)
        {
            List<Assignment> assignments = manager.AssignmentsByCongregationId(selectedMember.CongregationId);
            List<MemberAssignment> ma = manager.MemberAssignmentsByMemberId(selectedMember.Id);
            data.Rows.Clear();
            data.Refresh();

            foreach (Assignment a in assignments)
            {
                bool isAssigned;
                if (ma.Any(z => z.AssignmentId == a.Id))
                {
                    isAssigned = true;
                }
                else
                {
                    isAssigned = false;
                }
                data.Rows.Add(a.Id.ToString(), a.PositionOnSchedule, isAssigned, a.Label, a.Description, a.AmountPerMeeting);
            }
            data.Sort(data.Columns["SchedulePosition"], System.ComponentModel.ListSortDirection.Ascending);
            return data;
        }

        public DataGridView DatesAvailableBox(DataGridView data, Member selectedMember)
        {
            data.Rows.Clear();
            data.Refresh();
            data.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            List<UnavailableDate> udates = manager.UnavailableDateByMemberId(selectedMember.Id);
            TimeSpan startSpan = new TimeSpan(21, 0, 0, 0);
            TimeSpan endSpan = new TimeSpan(120, 0, 0, 0);
            DateTime start = DateTime.Now - startSpan;
            DateTime end = DateTime.Now + endSpan;
            string dayOfWeekMeeting = selectedMember.Congregation.WeekMeetingDay;
            string dayOfPublicMeeting = selectedMember.Congregation.PublicMeetingDay;
            bool available = true;
            foreach (DateTime day in manager.EachDayLoop(start, end))
            {
                available = true;
                if (udates.Any(z => z.DateUnavailable == day) ||
                    (selectedMember.IsAvailablePublicMeeting == false && day.DayOfWeek.ToString() == dayOfPublicMeeting) ||
                    (selectedMember.IsAvailableWeekMeeting == false && day.DayOfWeek.ToString() == dayOfWeekMeeting))
                {
                    available = false;
                }
                if (Convert.ToString(day.DayOfWeek) == dayOfWeekMeeting || Convert.ToString(day.DayOfWeek) == dayOfPublicMeeting)
                {
                    string dd = day.DayOfWeek + ", " + day.ToShortDateString();
                    data.Rows.Add(null, available, dd);
                }

            }

            return data;
        }

        public DataGridView Schedule(DataGridView data, ScheduleDate sd)
        {
            data.Rows.Clear();
            data.Refresh();

            List<MeetingAssignment> ma = new List<MeetingAssignment>();
            if (sd == null)
            {
                return null;
            }
            else if(manager.MeetingAssignmentsForExistingSchedule(sd.Id).Count!=0)
            {
                ma = manager.MeetingAssignmentsForExistingSchedule(sd.Id);
            }
            else
            {
                ma = manager.MeetingAssignmentsForSchedule(sd, sd.CongregationId);
            }

            ma = ma.OrderBy(o => o.Meeting.MeetingDate).ThenBy(y => y.Assignment.PositionOnSchedule).ToList();

            data.ColumnCount = ma[0].Meeting.MeetingAssignments.Count + 2;
            data.RowHeadersVisible = false;
            data.Columns[0].Name = "MeetingId";
            data.Columns[0].Visible = false;
            data.Columns[1].Name = "MeetingDate";
            data.Columns[1].HeaderText = "Meeting Date";
            

            List<MeetingAssignment> test = ma[0].Meeting.MeetingAssignments.ToList();
            test = test.OrderBy(o => o.Assignment.PositionOnSchedule).ToList();
            int columnCounter = test.Count + 1;
            int assignmentcounter = test.Count - 1;
            while (assignmentcounter >= 0)
            {
                data.Columns[columnCounter].Name = test[assignmentcounter].Assignment.Label;
                data.Columns[columnCounter].HeaderText = data.Columns[columnCounter].Name;
                columnCounter--;
                assignmentcounter--;
            }

            List<Meeting> meetings = (from meet in ma
                                      select meet.Meeting).ToList();

            meetings = meetings.Select(z => z).Distinct().ToList();
            int rowCounter = 0;
            foreach (Meeting meet in meetings)
            {
                data.Rows.Add();
                data.Rows[rowCounter].Cells[0].Value = meet.Id;
                data.Rows[rowCounter].Cells[1].Value = meet.MeetingDate.DayOfWeek + ", " + meet.MeetingDate.ToString("MMM") + " " + meet.MeetingDate.Day;

                List<MeetingAssignment> cahi = manager.MeetingAssignmentsByMeetingId(meet.Id);

                cahi.OrderBy(o => o.Assignment.PositionOnSchedule).ToList();

                int CellCounter = 2;
                foreach (MeetingAssignment am in cahi)
                {
                    data.Rows[rowCounter].Cells[CellCounter].Value = ((am.Member.PreferredName) ?? am.Member.FirstName + " " + am.Member.LastName);
                    CellCounter++;
                }
                rowCounter++;
            }

            return data;
        }


    }
}

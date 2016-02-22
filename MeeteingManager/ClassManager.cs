using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MeetingManager
{
    public class ClassManager
    {
        MeetingManagerEntities repository = new MeetingManagerEntities();

        public ClassManager()
        {
            repository = new MeetingManagerEntities();
        }

        #region CREATE

        public Congregation CreateCongregation(string congregationName, string address, string city, string state, string zipcode, string weekMeetingDay, string weekMeetingTime, string publicMeetingDay, string publicMeetingTime)
        {
            Congregation congregation = new Congregation();
            congregation.CongregationName = congregationName;
            congregation.Address = address;
            congregation.City = city;
            congregation.State = state;
            congregation.Zipcode = zipcode;
            congregation.WeekMeetingDay = weekMeetingDay;
            congregation.WeekMeetingTime = weekMeetingTime;
            congregation.PublicMeetingDay = publicMeetingDay;
            congregation.PublicMeetingTime = publicMeetingTime;
            congregation.CreateDate = DateTime.Now;

            repository.Congregations.Add(congregation);
            repository.SaveChanges();
            return congregation;
        }

        public Member CreateMember(string firstName, string preferredName, string lastName, string email, string contactNumber, int congregationId)
        {
            Member member = new Member();
            member.FirstName = firstName;
            if (preferredName != "")
            {
                member.PreferredName = preferredName;
            }
            if (email != "")
            {
                member.Email = email;
            }
            if (contactNumber != "")
            {
                member.ContactNumber = contactNumber;
            }
            member.LastName = lastName;
            member.CongregationId = congregationId;


            repository.Members.Add(member);
            repository.SaveChanges();
            return member;

        }

        public Member CreateMember(string firstName, string middleName, string lastName, string preferredName, DateTime? dateOfBirth, DateTime? baptismDate, string email, string contactNumber, string userName, string password, int congregationId)
        {

            Member member = new Member();
            member.FirstName = firstName;
            member.MiddleName = middleName;
            member.LastName = lastName;
            if (preferredName != "")
            {
                member.PreferredName = preferredName;
            }
            if (email != "")
            {
                member.Email = email;
            }
            if (contactNumber != "")
            {
                member.ContactNumber = contactNumber;
            }
            member.DateOfBirth = dateOfBirth;
            member.BaptismDate = baptismDate;
            member.UserName = userName;
            member.Password = password;
            member.CongregationId = congregationId;
            member.IsAvailablePublicMeeting = true;
            member.IsAvailableWeekMeeting = true;
            member.CreateDate = DateTime.Now;

            repository.Members.Add(member);
            repository.SaveChanges();

            return member;
        }

        public Assignment CreateAssignment(string label, string description, int congregationId, int? amountPerMeeting, int? schedulePosition, int creatorId)
        {
            Assignment assignment = new Assignment();
            assignment.Label = label;
            assignment.Description = description;
            assignment.CongregationId = congregationId;
            assignment.AmountPerMeeting = amountPerMeeting;
            assignment.PositionOnSchedule = schedulePosition;
            assignment.CreatorId = creatorId;
            assignment.CreateDate = DateTime.Now;

            repository.Assignments.Add(assignment);
            repository.SaveChanges();

            return assignment;
        }

        public Meeting CreateMeeting(int meetingDescriptionId, DateTime meetingDate, int congregationId)
        {
            Meeting meeting = new Meeting();
            meeting.MeetingDate = meetingDate;
            meeting.MeetingDescriptionId = meetingDescriptionId;
            meeting.CongregationId = congregationId;
            meeting.CreateDate = DateTime.Now;

            repository.Meetings.Add(meeting);
            repository.SaveChanges();
            return meeting;
        }

        public MeetingAssignment CreateMeetingAssignment(int meetingId, int memberId, int assignmentId, int congregationId, int scheduleDateId)
        {
            MeetingAssignment meetingassignment = new MeetingAssignment();
            meetingassignment.MeetingId = meetingId;
            meetingassignment.MemberId = memberId;
            meetingassignment.AssignmentId = assignmentId;
            meetingassignment.CongregationId = congregationId;
            meetingassignment.ReferanceMark = false;
            meetingassignment.ScheduleDateId = scheduleDateId;
            meetingassignment.CreateDate = DateTime.Now;

            repository.MeetingAssignments.Add(meetingassignment);
            repository.SaveChanges();
            return meetingassignment;
        }

        public MemberAssignment CreateMemberAssignment(int memberId, int assignmentId, int congregationId)
        {
            MemberAssignment memberAssignment = new MemberAssignment();
            memberAssignment.AssignmentId = assignmentId;
            memberAssignment.MemberId = memberId;
            memberAssignment.CongregationId = congregationId;
            memberAssignment.CreateDate = DateTime.Now;

            repository.MemberAssignments.Add(memberAssignment);
            repository.SaveChanges();

            return memberAssignment;
        }

        public UnavailableDate CreateUnavailableDate(int memberId, DateTime dateUnavailable, string reason)
        {
            UnavailableDate ud = new UnavailableDate();
            ud.MemberId = memberId;
            ud.DateUnavailable = dateUnavailable;
            ud.Reason = reason;
            ud.CreateDate = DateTime.Now;

            repository.UnavailableDates.Add(ud);
            repository.SaveChanges();
            return ud;
        }

        public UnavailableDate CreateUnavailableDate(int memberId, DateTime dateUnavailable, bool meetingCancelled, string reason)
        {
            UnavailableDate ud = new UnavailableDate();
            ud.MemberId = memberId;
            ud.DateUnavailable = dateUnavailable;
            ud.MeetingCancelled = meetingCancelled;
            ud.Reason = reason;
            ud.CreateDate = DateTime.Now;

            repository.UnavailableDates.Add(ud);
            repository.SaveChanges();
            return ud;
        }

        public ScheduleDate CreateScheduleDates(DateTime startDate, DateTime endDate, int congregationId, int creatorId)
        {
            ScheduleDate sd = new ScheduleDate();
            sd.StartDate = startDate;
            sd.EndDate = endDate;
            sd.CongregationId = congregationId;
            sd.CreatorId = creatorId;
            sd.CreateDate = DateTime.Now;

            repository.ScheduleDates.Add(sd);
            repository.SaveChanges();
            return sd;
        }

        public ServiceGroup CreateServiceGroup(int overseerId, int assistantId, string meetingLocation, string serviceMeetingTime)
        {
            ServiceGroup serviceGroup = new ServiceGroup();
            serviceGroup.OverseerId = overseerId;
            serviceGroup.AssistantId = assistantId;
            serviceGroup.ServiceMeetingLocation = meetingLocation;
            serviceGroup.ServiceMeetingTime = serviceMeetingTime;
            serviceGroup.CreateDate = DateTime.Now;

            repository.ServiceGroups.Add(serviceGroup);
            repository.SaveChanges();
            return serviceGroup;

        }


        #endregion

        #region READ

        public Member MemberByMemberId(int memberId)
        {
            Member member = (from m in repository.Members

                             where m.Id == memberId

                             select m).Single();

            return member;

        }

        /// <summary>
        /// Login from the home screen. Use list to make sure there is a count for those mathcing username and password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public List<Member> MemberByUsernamePassword(string userName, string password)
        {
            List<Member> member = (from m in repository.Members
                                   where m.UserName == userName && m.Password == password
                                   select m).ToList();



            return member;

        }

        /// <summary>
        /// Make sure username is unique.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public int MemberByUsername(string userName)
        {
            List<Member> memberCount = (from m in repository.Members
                                        where m.UserName == userName
                                        select m).ToList();

            return memberCount.Count;
        }

        /// <summary>

        /// Gets all members in congregation

        /// </summary>

        /// <param name="congregationId"></param>

        /// <returns></returns>

        public List<Member> MembersByCongregationId(int congregationId)
        {

            List<Member> congregationMembers = (from m in repository.Members

                                                where m.CongregationId == congregationId && (m.IsDeleted == false || m.IsDeleted == null)

                                                select m).ToList();

            return congregationMembers;

        }

        public List<Member> MembersAvailable(int assignmentId, DateTime meetingDate)
        {

            List<Member> all = (from v in repository.MemberAssignments
                                where v.AssignmentId == assignmentId
                                select v.Member).ToList();

            List<Member> notAvailable = (from m in repository.MemberAssignments
                                         where m.AssignmentId == assignmentId
                                         from a in repository.UnavailableDates
                                         where a.DateUnavailable == meetingDate && m.MemberId == a.MemberId
                                         select m.Member).ToList();
            if (notAvailable.Count == 0)
            {
                return all;
            }

            List<Member> available = (from p in all
                                      from x in notAvailable
                                      where p.Id != x.Id
                                      select p).ToList();

            return available;
        }

        public Member NextMemberToAssign(List<Member> membersAvailable, Meeting currentMeeting, Assignment currentAssignment)
        {
            List<Member> newMembers = (from mem in membersAvailable
                                       where mem.MeetingAssignments.Count == 0
                                       select mem).ToList();

            if (newMembers.Count != 0)
            {
                newMembers = newMembers.OrderBy(z => z.FirstName).ToList();
                return newMembers[0];
            }

            int meetingCountToBeat = new int();
            int meetingCounter = 0;
            Member currentlySelected = new Member();
            MeetingAssignment mLastMeetingAssignment = new MeetingAssignment();
            List<Member> alreadyAssigned = (from l in currentMeeting.MeetingAssignments
                                            select l.Member).ToList();
            List<Meeting> allMeeting = (from v in repository.Meetings
                                        where v.CongregationId == currentMeeting.CongregationId
                                        select v).ToList();
            allMeeting = allMeeting.OrderByDescending(o => o.MeetingDate).ToList();
            int index = allMeeting.IndexOf(currentMeeting);
            List<Member> go = (from goat in allMeeting[index + 1].MeetingAssignments
                               select goat.Member).ToList();

            foreach (Member m in membersAvailable)
            {
                List<MeetingAssignment> selectedMAssignments = (from d in repository.MeetingAssignments
                                                                where d.MemberId == m.Id
                                                                select d).ToList();
                selectedMAssignments = selectedMAssignments.OrderByDescending(o => o.Meeting.MeetingDate).ToList();
                if (alreadyAssigned.Any(p => p.Id == m.Id))//skips if they are already assigned or previous assignment was same assignment.
                {
                    continue;
                }
                if (selectedMAssignments[0].AssignmentId == currentAssignment.Id && m.MemberAssignments.Count > 2)
                {
                    continue;
                }

                foreach (DateTime d in EachDayLoop(selectedMAssignments[0].Meeting.MeetingDate.AddDays(1), currentMeeting.MeetingDate.AddDays(-1)))
                {
                    if (Convert.ToString(d.DayOfWeek) == m.Congregation.PublicMeetingDay || Convert.ToString(d.DayOfWeek) == m.Congregation.WeekMeetingDay)
                    {
                        meetingCounter++;
                    }
                }
                if (currentlySelected.Id == 0)
                {
                    meetingCountToBeat = meetingCounter;
                    currentlySelected = m;
                    mLastMeetingAssignment = selectedMAssignments[0];
                    meetingCounter = 0;
                    continue;
                }
                if (meetingCounter > meetingCountToBeat)
                {
                    meetingCountToBeat = meetingCounter;
                    currentlySelected = m;
                    mLastMeetingAssignment = selectedMAssignments[0];
                    meetingCounter = 0;
                }

                if (meetingCounter == meetingCountToBeat)
                {
                    if (selectedMAssignments[0].Assignment.Label != currentAssignment.Label && mLastMeetingAssignment.Assignment.Label == currentAssignment.Label)
                    {
                        currentlySelected = m;
                        mLastMeetingAssignment = selectedMAssignments[0];
                    }

                }
                meetingCounter = 0;
                continue;

            }
            return currentlySelected;

        }


        public Assignment AssignmentByAssignmentId(int assignmentId)
        {

            Assignment assignment = (from a in repository.Assignments

                                     where a.Id == assignmentId

                                     select a).Single();

            return assignment;

        }

        public List<Assignment> AssignmentsByCongregationId(int congregationId)
        {
            List<Assignment> allAssignments = (from a in repository.Assignments
                                               where a.CongregationId == congregationId
                                               select a).ToList();
            return allAssignments;
        }


        public MemberAssignment MemberAssignmentByMemberAssignmentId(int memberAssignmentId)
        {
            MemberAssignment ma = (from a in repository.MemberAssignments
                                   where a.Id == memberAssignmentId
                                   select a).Single();
            return ma;
        }

        public List<MemberAssignment> MemberAssignmentsByMemberId(int memberId)
        {
            List<MemberAssignment> ma = (from m in repository.MemberAssignments
                                         where m.MemberId == memberId
                                         select m).ToList();
            return ma;

        }

        public Congregation CongregationByCongregationId(int congregationId)
        {

            Congregation congregation = (from c in repository.Congregations

                                         where c.Id == congregationId

                                         select c).Single();

            return congregation;

        }

        public Meeting MeetingByMeetingId(int meetingId)
        {

            Meeting meeting = (from m in repository.Meetings

                               where m.Id == meetingId

                               select m).Single();

            return meeting;

        }

        public List<Meeting> MeetingsByCongregationId(int congregationId)
        {
            List<Meeting> meeting = (from m in repository.Meetings
                                     where m.CongregationId == congregationId
                                     select m).ToList();

            return meeting;
        }

        public MeetingAssignment MeetingAssignmentByMeetingAssignmentId(int meetingAssignmentId)
        {

            MeetingAssignment meetingAssignment = (from ms in repository.MeetingAssignments

                                                   where ms.Id == meetingAssignmentId

                                                   select ms).Single();

            return meetingAssignment;

        }

        public List<MeetingAssignment> MeetingAssignmentsByMeetingId(int meetingId)
        {
            List<MeetingAssignment> meetingAssignments = (from ma in repository.MeetingAssignments
                                                          where ma.MeetingId == meetingId
                                                          select ma).ToList();
            return meetingAssignments;
        }

        public List<MeetingAssignment> MeetingAssignmentsByCongregationId(int congregationId)
        {
            List<MeetingAssignment> meeta = (from ma in repository.MeetingAssignments
                                             where ma.CongregationId == congregationId
                                             select ma).ToList();
            return meeta;
        }

        public List<MeetingAssignment> MeetingAssignmentsByMemberId(int memberId)
        {

            List<MeetingAssignment> memberMeetingAssignments = (from ma in repository.MeetingAssignments

                                                                where ma.MemberId == memberId

                                                                select ma).ToList();

            return memberMeetingAssignments;

        }

        public List<MeetingAssignment> MeetingAssignmentsForSchedule(ScheduleDate scheduleDates, int congregationId)
        {
            Congregation congo = CongregationByCongregationId(congregationId);
            List<Assignment> congoAssignments = AssignmentsByCongregationId(congo.Id);
            List<Meeting> meetings = new List<Meeting>();
            List<MeetingAssignment> meetingAssignments = new List<MeetingAssignment>();
            Meeting meeting;
            string dayOfWeekMeeting = congo.WeekMeetingDay;
            string publicMeeting = congo.PublicMeetingDay;
            foreach (DateTime day in EachDayLoop(scheduleDates.StartDate, scheduleDates.EndDate))
            {
                if (Convert.ToString(day.DayOfWeek) == dayOfWeekMeeting || Convert.ToString(day.DayOfWeek) == publicMeeting)
                {
                    if (Convert.ToString(day.DayOfWeek) == publicMeeting)
                    {
                        meeting = CreateMeeting(2, day.Date, congo.Id);
                    }
                    else
                    {
                        meeting = CreateMeeting(1, day.Date, congo.Id);
                    }
                    meetings.Add(meeting);

                }
            }

            List<UnavailableDate> cancelled = UnavailableDateByCongregationId(congregationId);

            foreach (Meeting m in meetings)
            {
                if (cancelled.Any(p => p.DateUnavailable == m.MeetingDate))
                {
                    continue;
                }
                congoAssignments = congoAssignments.OrderBy(o => o.PositionOnSchedule).ToList();
                foreach (Assignment a in congoAssignments)
                {
                    if (a.AmountPerMeeting == 0)
                    {
                        continue;
                    }
                    List<Member> membersAvailable = MembersAvailable(a.Id, m.MeetingDate);
                    int counter = 1;
                    while (counter <= a.AmountPerMeeting)
                    {
                        Member nextMember = NextMemberToAssign(membersAvailable, m, a);
                        MeetingAssignment ma = CreateMeetingAssignment(m.Id, nextMember.Id, a.Id, nextMember.CongregationId, scheduleDates.Id);
                        meetingAssignments.Add(ma);
                        counter++;
                    }

                }


            }
            return meetingAssignments;
        }

        public List<MeetingAssignment> MeetingAssignmentsForExistingSchedule(int scheduleDateId)
        {
            List<MeetingAssignment> ma = (from d in repository.MeetingAssignments
                                          where d.ScheduleDateId == scheduleDateId
                                          select d).ToList();

            return ma;
        }

        public MeetingDescription MeetingDescriptionByMeetingDescriptionId(int meetingDescriptionId)
        {

            MeetingDescription meetingDescription = (from md in repository.MeetingDescriptions

                                                     where md.Id == meetingDescriptionId

                                                     select md).Single();

            return meetingDescription;


        }

        public UnavailableDate UnavailableDateByUnavailableDateId(int unavailableDateId)
        {
            UnavailableDate ud = (from u in repository.UnavailableDates
                                  where u.Id == unavailableDateId
                                  select u).Single();
            return ud;
        }

        public List<UnavailableDate> UnavailableDateByMemberId(int memberId)
        {
            List<UnavailableDate> udates = (from u in repository.UnavailableDates
                                            where u.MemberId == memberId
                                            select u).ToList();
            return udates;
        }

        public List<UnavailableDate> UnavailableDateByCongregationId(int congoId)
        {
            List<UnavailableDate> cancelled = (from c in repository.UnavailableDates
                                               where c.MeetingCancelled == true && congoId == c.CongregationId
                                               select c).ToList();

            return cancelled;
        }

        public ScheduleDate ScheduleDatesByScheduleDateId(int scheduleDateId)
        {
            ScheduleDate sd = (from s in repository.ScheduleDates
                               where s.Id == scheduleDateId
                               select s).Single();
            return sd;
        }

        public List<ScheduleDate> ScheduleDates()
        {
            List<ScheduleDate> allSd = (from s in repository.ScheduleDates
                                        select s).ToList();
            return allSd;
        }


        public ScheduleDate CurrentScheduleDate()
        {
            ScheduleDate sd = (from s in repository.ScheduleDates
                               where s.StartDate < DateTime.Now && s.EndDate > DateTime.Now
                               select s).SingleOrDefault();
            return sd;

        }

        public ServiceGroup ServiceGroupByServiceGroupId(int serviceGroupId)
        {

            ServiceGroup serviceGroup = (from s in repository.ServiceGroups

                                         where s.Id == serviceGroupId

                                         select s).Single();

            return serviceGroup;

        }


        #endregion

        #region UPDATE

        public Congregation UpdateCongregation(int congregationId, string congregationName, string address, string city, string state, string zipcode, string weekMeetingDay, string weekMeetingTime, string publicMeetingDay, string publicMeetingTime)
        {
            Congregation congregation = CongregationByCongregationId(congregationId);
            congregation.CongregationName = congregationName;
            congregation.Address = address;
            congregation.City = city;
            congregation.State = state;
            congregation.Zipcode = zipcode;
            congregation.WeekMeetingDay = weekMeetingDay;
            congregation.WeekMeetingTime = weekMeetingTime;
            congregation.PublicMeetingDay = publicMeetingDay;
            congregation.PublicMeetingTime = publicMeetingTime;
            congregation.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return congregation;
        }

        //public Member UpdateMember(int memberId, string firstName, string middleName, string lastName, string preferredName, DateTime dateOfBirth, DateTime baptismDate, string email, string contactNumber,string username,string password)
        //{
        //    Member member = MemberByMemberId(memberId);
        //    member.FirstName = firstName;
        //    member.MiddleName = middleName;
        //    member.LastName = lastName;
        //    member.PreferredName = preferredName;
        //    member.DateOfBirth = dateOfBirth;
        //    member.BaptismDate = baptismDate;
        //    member.Email = email;
        //    member.ContactNumber = contactNumber;
        //    member.UserName = username;
        //    member.Password = password;
        //    member.UpdateDate = DateTime.Now;
        //    member.CongregationId = member.CongregationId;

        //    repository.SaveChanges();
        //    return member;
        //}

        public Member UpdateMember(Member member, bool essentialFields)
        {
            Member memberUpdate = MemberByMemberId(member.Id);
            memberUpdate.FirstName = member.FirstName;
            memberUpdate.LastName = member.LastName;
            memberUpdate.PreferredName = member.PreferredName;
            memberUpdate.Email = member.Email;
            memberUpdate.ContactNumber = member.ContactNumber;
            memberUpdate.IsAvailablePublicMeeting = member.IsAvailablePublicMeeting;
            memberUpdate.IsAvailableWeekMeeting = member.IsAvailableWeekMeeting;
            if (essentialFields == false)
            {
                memberUpdate.MiddleName = member.MiddleName;
                memberUpdate.DateOfBirth = member.DateOfBirth;
                memberUpdate.BaptismDate = member.BaptismDate;
                memberUpdate.UserName = member.UserName;
                memberUpdate.Password = member.Password;
                memberUpdate.IsDeleted = member.IsDeleted;
                memberUpdate.LastLoginTime = DateTime.Now;
                memberUpdate.UpdateDate = DateTime.Now;
                memberUpdate.CongregationId = member.CongregationId;
            }


            repository.SaveChanges();
            return memberUpdate;

        }

        public Meeting UpdateMeeting(int meetingId, int meetingDescriptionId, DateTime meetingDate, int congregationId)
        {
            Meeting meeting = MeetingByMeetingId(meetingId);
            meeting.MeetingDate = meetingDate;
            meeting.MeetingDescriptionId = meetingDescriptionId;
            meeting.CongregationId = congregationId;
            meeting.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return meeting;
        }

        public Assignment UpdateAssignment(Assignment updatedAssignment)
        {
            Assignment ua = AssignmentByAssignmentId(updatedAssignment.Id);
            ua.Label = updatedAssignment.Label;
            ua.Description = updatedAssignment.Description;
            ua.AmountPerMeeting = updatedAssignment.AmountPerMeeting;
            ua.PositionOnSchedule = updatedAssignment.PositionOnSchedule;
            ua.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return ua;
        }

        public MeetingAssignment UpdateMeetingAssignment(MeetingAssignment meetingAssignment)
        {
            MeetingAssignment ma = MeetingAssignmentByMeetingAssignmentId(meetingAssignment.Id);
            ma.MeetingId = meetingAssignment.MeetingId;
            ma.AssignmentId = meetingAssignment.AssignmentId;
            ma.MemberId = meetingAssignment.MemberId;
            ma.ReferanceMark = meetingAssignment.ReferanceMark;
            ma.ScheduleDateId = meetingAssignment.ScheduleDateId;
            ma.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return ma;
        }

        public MemberAssignment UpdateMemberAssignment(int memberassignmentId, int memberId, int assignmentId)
        {
            MemberAssignment memberAssignment = MemberAssignmentByMemberAssignmentId(memberassignmentId);
            memberAssignment.AssignmentId = assignmentId;
            memberAssignment.MemberId = memberId;
            memberAssignment.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return memberAssignment;
        }

        public UnavailableDate UpdateUnavailableDate(int unavailableDateId, int memberId, DateTime dateUnavailable, string reason, bool meetingCancelled)
        {
            UnavailableDate ud = UnavailableDateByUnavailableDateId(unavailableDateId);
            ud.MemberId = memberId;
            ud.DateUnavailable = dateUnavailable;
            ud.Reason = reason;
            ud.MeetingCancelled = meetingCancelled;
            ud.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return ud;
        }

        public ScheduleDate UpdateScheduleDates(int scheduleDateId, DateTime startDate, DateTime endDate, int congregationId, int creatorId)
        {
            ScheduleDate sd = ScheduleDatesByScheduleDateId(scheduleDateId);
            sd.StartDate = startDate;
            sd.EndDate = endDate;
            sd.CongregationId = congregationId;
            sd.CreatorId = creatorId;
            sd.UpdateDate = DateTime.Now;

            repository.SaveChanges();
            return sd;
        }



        #endregion

        #region DELETE

        public void DeleteMemberAssignement(int memberAssignmentId)
        {
            MemberAssignment ma = MemberAssignmentByMemberAssignmentId(memberAssignmentId);
            repository.MemberAssignments.Remove(ma);
            repository.SaveChanges();
        }

        public void DeleteUnavailableDate(DateTime date, int memberId)
        {
            List<UnavailableDate> ud = UnavailableDateByMemberId(memberId);
            UnavailableDate ud1 = (from u in ud
                                   where u.DateUnavailable == date
                                   select u).Single();

            repository.UnavailableDates.Remove(ud1);
            repository.SaveChanges();

        }

        public void DeleteScheduleMeetingAssignments(ScheduleDate sd)
        {
            ScheduleDate sdate = (from d in repository.ScheduleDates
                                  where d.Id == sd.Id
                                  select d).Single();

            List<MeetingAssignment> ma = (from m in repository.MeetingAssignments
                                          where m.ScheduleDateId == sd.Id
                                          select m).ToList();
            List<Meeting> meetings = (from meet in repository.Meetings
                                      where meet.MeetingDate >= sd.StartDate && meet.MeetingDate <= sd.EndDate
                                      select meet).ToList();
            repository.ScheduleDates.Remove(sdate);
            foreach (MeetingAssignment l in ma)
            {
                repository.MeetingAssignments.Remove(l);
            }
            foreach (Meeting moo in meetings)
            {
                repository.Meetings.Remove(moo);
            }
            repository.SaveChanges();

            List<Member> deletedMembers = (from e in repository.Members
                                           where e.IsDeleted == true && e.MeetingAssignments.Count == 0
                                           select e).ToList();
            foreach (Member del in deletedMembers)
            {
                DeleteMemberHard(del.Id);
            }


        }

        public void DeleteMemberSoft(int memberId)
        {
            Member m = MemberByMemberId(memberId);


            foreach (MemberAssignment w in m.MemberAssignments)
            {
                repository.MemberAssignments.Remove(w);
            }

            foreach (UnavailableDate q in m.UnavailableDates)
            {
                repository.UnavailableDates.Remove(q);
            }

            if (m.MeetingAssignments.Count == 0)
            {
                DeleteMemberHard(memberId);
            }
            else
            {
                m.IsDeleted = true;
                m = UpdateMember(m, false);
            }


        }

        public void DeleteMemberHard(int memberId)
        {
            Member m = MemberByMemberId(memberId);

            repository.Members.Remove(m);
            repository.SaveChanges();

        }


        #endregion

        public IEnumerable<DateTime> EachDayLoop(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }

    }
}

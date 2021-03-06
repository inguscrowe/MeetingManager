//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public Member()
        {
            this.Assignments = new HashSet<Assignment>();
            this.MemberAssignments = new HashSet<MemberAssignment>();
            this.ScheduleDates = new HashSet<ScheduleDate>();
            this.ServiceGroups = new HashSet<ServiceGroup>();
            this.ServiceGroups1 = new HashSet<ServiceGroup>();
            this.UnavailableDates = new HashSet<UnavailableDate>();
            this.MeetingAssignments = new HashSet<MeetingAssignment>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> BaptismDate { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsAvailablePublicMeeting { get; set; }
        public Nullable<bool> IsAvailableWeekMeeting { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public int CongregationId { get; set; }
        public Nullable<int> ServiceGroupId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual Congregation Congregation { get; set; }
        public virtual ServiceGroup ServiceGroup { get; set; }
        public virtual ICollection<MemberAssignment> MemberAssignments { get; set; }
        public virtual ICollection<ScheduleDate> ScheduleDates { get; set; }
        public virtual ICollection<ServiceGroup> ServiceGroups { get; set; }
        public virtual ICollection<ServiceGroup> ServiceGroups1 { get; set; }
        public virtual ICollection<UnavailableDate> UnavailableDates { get; set; }
        public virtual ICollection<MeetingAssignment> MeetingAssignments { get; set; }
    }
}

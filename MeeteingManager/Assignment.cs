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
    
    public partial class Assignment
    {
        public Assignment()
        {
            this.MemberAssignments = new HashSet<MemberAssignment>();
            this.MeetingAssignments = new HashSet<MeetingAssignment>();
        }
    
        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public int CongregationId { get; set; }
        public int CreatorId { get; set; }
        public Nullable<int> AmountPerMeeting { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> PositionOnSchedule { get; set; }
    
        public virtual Congregation Congregation { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<MemberAssignment> MemberAssignments { get; set; }
        public virtual ICollection<MeetingAssignment> MeetingAssignments { get; set; }
    }
}
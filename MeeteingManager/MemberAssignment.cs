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
    
    public partial class MemberAssignment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int CongregationId { get; set; }
        public int AssignmentId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Assignment Assignment { get; set; }
        public virtual Congregation Congregation { get; set; }
        public virtual Member Member { get; set; }
    }
}

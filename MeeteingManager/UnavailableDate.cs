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
    
    public partial class UnavailableDate
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public System.DateTime DateUnavailable { get; set; }
        public Nullable<bool> MeetingCancelled { get; set; }
        public string Reason { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CongregationId { get; set; }
    
        public virtual Member Member { get; set; }
    }
}

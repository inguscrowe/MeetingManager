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
    
    public partial class ServiceGroup
    {
        public ServiceGroup()
        {
            this.Members = new HashSet<Member>();
        }
    
        public int Id { get; set; }
        public int OverseerId { get; set; }
        public Nullable<int> AssistantId { get; set; }
        public string ServiceMeetingLocation { get; set; }
        public string ServiceMeetingTime { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<Member> Members { get; set; }
        public virtual Member Member { get; set; }
        public virtual Member Member1 { get; set; }
    }
}

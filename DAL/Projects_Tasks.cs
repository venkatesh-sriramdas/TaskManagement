//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projects_Tasks
    {
        public long ProjectTaskId { get; set; }
        public long ProjectId { get; set; }
        public string Label { get; set; }
        public long CreatedById { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public short TaskStatusId { get; set; }
        public short PriorityStatusId { get; set; }
        public Nullable<long> ModifiedById { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Task_Status Task_Status { get; set; }
        public virtual TaskPriority TaskPriority { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceFix
    {
        public int ServiceFixId { get; set; }
        public string ServiceFixName { get; set; }
        public string Description { get; set; }
    
        public virtual RoomType_ServiceFix RoomType_ServiceFix { get; set; }
    }
}

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
    
    public partial class ReservationsRoom
    {
        public int ReservercationID { get; set; }
        public string RoomID { get; set; }
        public int ReservercationRoomID { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual Revervation Revervation { get; set; }
    }
}

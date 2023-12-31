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
    
    public partial class RoomType
    {
        public RoomType()
        {
            this.RevervationRoomTypes = new HashSet<RevervationRoomType>();
            this.Rooms = new HashSet<Room>();
            this.RoomType_Amenity = new HashSet<RoomType_Amenity>();
            this.RoomType_ServiceFix = new HashSet<RoomType_ServiceFix>();
        }
    
        public string RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Depcriptions { get; set; }
    
        public virtual ICollection<RevervationRoomType> RevervationRoomTypes { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<RoomType_Amenity> RoomType_Amenity { get; set; }
        public virtual ICollection<RoomType_ServiceFix> RoomType_ServiceFix { get; set; }
    }
}

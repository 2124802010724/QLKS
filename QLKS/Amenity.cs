//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Amenity
    {
        public string AmenityID { get; set; }
        public string AmenityName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string AmenityUnit { get; set; }
        public Nullable<bool> MiniBar { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual UseAmenity UseAmenity { get; set; }
    }
}

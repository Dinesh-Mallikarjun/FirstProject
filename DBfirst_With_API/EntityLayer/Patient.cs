//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int PatientBill { get; set; }
        public Nullable<int> DoctorId { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace presentationLayer.Models
{
    public class PatientModel
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int PatientBill { get; set; }
        public Nullable<int> DoctorId { get; set; }

        public virtual DoctorModel DoctorModel { get; set; }
    }
}
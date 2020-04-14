using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace presentationLayer.Models
{
    public class DoctorModel
    {
        public int DoctoreId { get; set; }
        public string DoctorName { get; set; }
        public int Salary { get; set; }
        public virtual ICollection<PatientModel> PatientModels { get; set; }
    }
}
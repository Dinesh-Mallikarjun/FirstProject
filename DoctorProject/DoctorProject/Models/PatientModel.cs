using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorProject.Models
{
    public class PatientModel
    {

        public int PatientId { set; get; }

        public string PatientName { set; get; }

        public int PatientBill { set; get; }

        public int DoctorId { set; get; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Patient
    {
        public int PatientId { set; get; }

        public string PatientName { set; get; }

        public int PatientBill { set; get; }

        public int DoctorId { set; get; }


    }
}

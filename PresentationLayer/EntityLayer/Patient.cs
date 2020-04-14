using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Entity
{
    public class Patient
    {
        public int _PatientId { set; get; }

        public string _PatientName { set; get; }

        public DateTime _Admitdate { set; get; }

        public int _PatientBill { set; get; }

        public int _DoctorId { set; get; }
    }
}

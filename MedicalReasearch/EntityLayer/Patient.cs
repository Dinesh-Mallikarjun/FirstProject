using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Patient
    {
          public int Patient_id { get; set; }
          public string Patient_name { get; set; }
          public Symptom Symptom_1 { get; set; }          
          public Symptom Symptom_2 { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical_Reaserch_Presentation_Layer.Models
{
    public class PatientModel
    {
        public int Patient_id { get; set; }
        public string Patient_name { get; set; }
        public SymptomModel Symptom_1 { get; set; }
        public SymptomModel Symptom_2 { get; set; }

    }
}
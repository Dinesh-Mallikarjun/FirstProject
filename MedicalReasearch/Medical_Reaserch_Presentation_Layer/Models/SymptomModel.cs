using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical_Reaserch_Presentation_Layer.Models
{
    public class SymptomModel
    {
        public int Symptom_id { get; set; }

        public DiseaseModel Disease_id { get; set; }

        public string Symptom_name { get; set; }

        public string Symptom_Description { get; set; }

    }
}
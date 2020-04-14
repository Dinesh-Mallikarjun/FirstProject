using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical_Reaserch_Presentation_Layer.Models
{
    public class DiseaseModel
    {
        public int Disease_id { get; set; }
        public string Disease_name { get; set; }
        public string severity { get; set; }
        public string cause { get; set; }
        public string Disease_description { get; set; }
    }
}
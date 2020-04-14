using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalResearch_PresentationLayer.Models
{
    public class DiseasesModel
    {
        public int Disease_Id { get; set; }
        public string Disease_Name { get; set; }
        public SeverityModel Disease_Severity_Id { get; set; }
        public CauseModel Disease_Cause_Id { get; set; }
        public string Disease_Description { get; set; }
        public List<SymptomModel> symptomModels { get; set; }
    }
}
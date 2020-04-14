using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalResearch_PresentationLayer.Models
{
    public class DiseasesWithSymptomModel
    {
        public int DiseaseSymptom_Id { get; set; }
        public DiseasesModel DsDisease_Id { get; set; }
        public SymptomModel DsSymptom_Id { get; set; }
        public string DiseaseSymptom_Description { get; set; }
    }
}
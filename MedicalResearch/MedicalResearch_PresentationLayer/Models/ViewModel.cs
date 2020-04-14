using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalResearch_PresentationLayer.Models
{
    public class ViewModel
    {
        public IEnumerable<SeverityModel> severityModels { get; set; }

        public IEnumerable<CauseModel> causeModels { get; set; }

        public IEnumerable<SymptomModel> symptomModels { get; set; }

        public IEnumerable<DiseasesModel> diseasesModels { get; set; }

        public IEnumerable<DiseasesWithSymptomModel> diseasesWithSymptomModels { get; set; }

    }
}
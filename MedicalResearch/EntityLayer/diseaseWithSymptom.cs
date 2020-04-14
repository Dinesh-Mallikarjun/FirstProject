using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class DiseaseWithSymptom
    {
        public int DiseaseSymptom_Id { get; set; }
        public Diseases DsDisease_Id { get; set; }
        public Symptom DsSymptom_Id { get; set; }
        public string DiseaseSymptom_Description { get; set; }
    }

}

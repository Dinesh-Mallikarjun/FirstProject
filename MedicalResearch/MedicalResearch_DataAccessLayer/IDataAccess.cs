using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch_DataAccessLayer
{
    interface IDataAccess
    {
         void AddDisease(Diseases diseases);
         List<Severity> DisplaySeverity();
         List<Cause> DisplayCause();
         List<Diseases> DisplayDiseases();
         List<Symptom> DisplaySymptoms();        
         void AddDiseaseWithSymptom(DiseaseWithSymptom diseaseWithSymptom);         
         List<DiseaseWithSymptom> DisplayDiagnose(string name,int id1, int id2);
         List<DiseaseWithSymptom> DisplayDiagnose(string name, int id1);
        // List<DiseaseWithSymptom> DisplayDiagnose(string name, int id2);
         List<int> SymptomCount(int id);
        void ExportToTextFile(List<DiseaseWithSymptom> diseaseWithSymptoms, string name);

    }
}

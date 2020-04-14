using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch_BusinessLayer
{
    interface IBusiness
    {
        void AddDisease(Diseases diseases);
        List<Severity> DisplaySeverity();
        List<Cause> DisplayCause();
        List<Diseases> DisplayDiseases();
        List<Symptom> DisplaySymptoms();
        void AddDiseaseWithSymptom(DiseaseWithSymptom diseaseWithSymptom);        
        void DiseaseName(Diseases diseases);
      //  void SymptomName(DiseaseWithSymptom symptom);
        List<DiseaseWithSymptom> DisplayDiagnose(string name,int id1, int id2);
        //List<DiseaseWithSymptom> DisplayDiagnoseWithOneSymptom(string name, int id1);
        //List<DiseaseWithSymptom> DisplayDiagnoseWithSecondSymptom(string name, int id2);
        void checkSymptom(int Diseaseid, int symptomid);
        void ExportToTextFile(List<DiseaseWithSymptom> diseaseWithSymptoms, string name);
    }
}

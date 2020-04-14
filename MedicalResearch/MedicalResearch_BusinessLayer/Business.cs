using EntityLayer;
using ExceptionLayer;
using MedicalResearch_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch_BusinessLayer
{
    public class Business:IBusiness
    {
        static DataAccess dataAccess = new DataAccess();
        public void AddDisease(Diseases diseases)
        {      
          dataAccess.AddDisease(diseases);            
        }
        public List<Severity> DisplaySeverity()
        {
           return dataAccess.DisplaySeverity();
        }
        public List<Cause> DisplayCause()
        {
            return dataAccess.DisplayCause();
        }
        public List<Diseases> DisplayDiseases()
        {
            return dataAccess.DisplayDiseases();
        }
        public List<Symptom> DisplaySymptoms()
        {
            return dataAccess.DisplaySymptoms();
        }
        public void AddDiseaseWithSymptom(DiseaseWithSymptom diseaseWithSymptom)
        {
             
             dataAccess.AddDiseaseWithSymptom(diseaseWithSymptom);
        }
            public List<DiseaseWithSymptom> DisplayDiagnose(string name,int id1, int id2)
            {
            if (id1 > 0 && id2 == 0)
            {
                return dataAccess.DisplayDiagnose(name, id1);
            }
            else if(id2>0 && id1 ==0)
            {
                return dataAccess.DisplayDiagnose(name, id2);
            }
            else if (id1==0 && id2==0)
            {
                throw new SymptomNotSelectedException("Please Select Symptom");                
            }
            else if(id1>0 && id2>0 || id1==id2)
            {
                return dataAccess.DisplayDiagnose(name, id1, id2);
            }


            List<DiseaseWithSymptom> diseaseWithSymptoms = new List<DiseaseWithSymptom>();
            diseaseWithSymptoms = dataAccess.DisplayDiagnose(name, id1, id2);
            return diseaseWithSymptoms;
        }
        public void DiseaseName(Diseases diseases)
        {
            List<Diseases> diseasess = dataAccess.DisplayDisease();
            foreach(var item in diseasess)
            {
                if(diseases.Disease_Name==item.Disease_Name)
                {
                    throw new NameAlreadyPresent("The disease name is already present");
                }
            }
            DataAccess dataAccess1 = new DataAccess();
            dataAccess1.AddDisease(diseases);
        }        
        public void checkSymptom(int Disease_Id, int Symptom_Id)
        {
            List<int> symptomcheck = dataAccess.SymptomCount(Disease_Id);           
            foreach(int id in symptomcheck)
            {
                if(Symptom_Id== id)
                {
                    throw new DiseaseAlreadyHasThisSymptom("Enter different Symptom");
                }
            }
            if(symptomcheck.Count>2)
            {
                throw new DiseaseHasTwoSymptomsAlready("Cannot add more then 2 symptoms");
            }
        }
        public void ExportToTextFile(List<DiseaseWithSymptom> diseaseWithSymptoms, string name)
        {
            dataAccess.ExportToTextFile(diseaseWithSymptoms, name);
        }
    }
}

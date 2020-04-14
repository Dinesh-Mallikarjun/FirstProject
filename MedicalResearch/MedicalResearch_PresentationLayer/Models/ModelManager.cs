using EntityLayer;
using MedicalResearch_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalResearch_PresentationLayer.Models
{
    public class ModelManager
    {
        public void AddDisease(DiseasesModel diseasesModel)
        {
            Diseases diseases = new Diseases();
            diseases.Disease_Name = diseasesModel.Disease_Name;
          
            diseases.Disease_Severity_Id = new Severity();
            diseases.Disease_Severity_Id.Severity_Id = diseasesModel.Disease_Severity_Id.Severity_Id;

            diseases.Disease_Cause_Id = new Cause();
            diseases.Disease_Cause_Id.Cause_ID = diseasesModel.Disease_Cause_Id.Cause_ID;
          
            diseases.Disease_Description = diseasesModel.Disease_Description;

            Business business = new Business();
            business.DiseaseName(diseases);
        }
        public List<SeverityModel> DisplaySeverity()
        {
            Business business = new Business();
            List<Severity> severities = business.DisplaySeverity();
            List<SeverityModel> severityModels = new List<SeverityModel>();
            foreach (var severity in severities)
            {
                SeverityModel severityModel = new SeverityModel();
                severityModel.Severity_Id = severity.Severity_Id;
                severityModel.Severity_Name = severity.Severity_Name;
                severityModels.Add(severityModel);
            }
        
            return severityModels;
        }
        public List<CauseModel> DisplayCause()
        {
            Business business = new Business();
            List<Cause> causes = business.DisplayCause();
            List<CauseModel> causeModels = new List<CauseModel>();
            foreach (var cause in causes)
            {
                CauseModel causeModel = new CauseModel();
                causeModel.Cause_ID = cause.Cause_ID;
                causeModel.Cause_Name = cause.Cause_Name;
                causeModels.Add(causeModel);
            }

            return causeModels;
        }
        public List<DiseasesModel> DisplayDiseases()
        {
            Business business = new Business();
            List<Diseases> diseases = business.DisplayDiseases();
            List<DiseasesModel> diseasesModels = new List<DiseasesModel>();
            foreach (var disease in diseases)
            {
                DiseasesModel diseasesModel = new DiseasesModel();
                diseasesModel.Disease_Id = disease.Disease_Id;
                diseasesModel.Disease_Name = disease.Disease_Name;
                diseasesModels.Add(diseasesModel);
            }
            return diseasesModels;
        }
        public List<SymptomModel> DisplaySymptoms()
        {
            Business business = new Business();
            List<Symptom> symptoms = business.DisplaySymptoms();
            List<SymptomModel> symptomModels = new List<SymptomModel>();
            foreach (var symptom in symptoms)
            {
                SymptomModel symptomModel = new SymptomModel();
                symptomModel.Symptom_Id = symptom.Symptom_Id;
                symptomModel.Symptom_Name = symptom.Symptom_Name;
                symptomModels.Add(symptomModel);
            }
            return symptomModels;
        }
        public void AddDiseaseWithSymptom(DiseasesWithSymptomModel diseasesWithSymptomModel)
        {
            DiseaseWithSymptom diseaseWithSymptom = new DiseaseWithSymptom();
            diseaseWithSymptom.DsDisease_Id = new Diseases();
            diseaseWithSymptom.DsDisease_Id.Disease_Id = diseasesWithSymptomModel.DsDisease_Id.Disease_Id;

            diseaseWithSymptom.DsSymptom_Id = new Symptom();
            diseaseWithSymptom.DsSymptom_Id.Symptom_Id = diseasesWithSymptomModel.DsSymptom_Id.Symptom_Id;
            

            diseaseWithSymptom.DiseaseSymptom_Description = diseasesWithSymptomModel.DiseaseSymptom_Description;

            Business business = new Business();
            business.AddDiseaseWithSymptom(diseaseWithSymptom);
        }
        public List<DiseasesWithSymptomModel> DisplayDiagnose(string name,int id1,int id2)
        {
            Business business = new Business();
            List<DiseaseWithSymptom> diseaseWithSymptoms = business.DisplayDiagnose(name,id1,id2);
            List<DiseasesWithSymptomModel> diseasesWithSymptomModels = new List<DiseasesWithSymptomModel>();
            foreach (var diseaseWithSymptom in diseaseWithSymptoms)
            {
                DiseasesWithSymptomModel diseasesWithSymptomModel = new DiseasesWithSymptomModel();
                diseasesWithSymptomModel.DsDisease_Id = new DiseasesModel();
                diseasesWithSymptomModel.DsDisease_Id.Disease_Name = diseaseWithSymptom.DsDisease_Id.Disease_Name;

                diseasesWithSymptomModel.DsDisease_Id.Disease_Severity_Id = new SeverityModel();
                diseasesWithSymptomModel.DsDisease_Id.Disease_Severity_Id.Severity_Name = diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id.Severity_Name;
                diseasesWithSymptomModel.DsSymptom_Id = new SymptomModel();
                diseasesWithSymptomModel.DsSymptom_Id.Symptom_Name = diseaseWithSymptom.DsSymptom_Id.Symptom_Name;
                diseasesWithSymptomModels.Add(diseasesWithSymptomModel);
            }            
            business.ExportToTextFile(diseaseWithSymptoms, name);
            return diseasesWithSymptomModels;
            
        }
        public void checkSymptom(DiseasesWithSymptomModel diseasesWithSymptomModel)
        {
            Business business = new Business();
            business.checkSymptom(diseasesWithSymptomModel.DsDisease_Id.Disease_Id, diseasesWithSymptomModel.DsSymptom_Id.Symptom_Id);
        }
    }
}
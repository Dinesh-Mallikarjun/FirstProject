using EntityLayer;
using Medical_Reaserch_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical_Reaserch_Presentation_Layer.Models
{
    public class ModelManager
    {
        public void AddDisease(DiseaseModel diseaseModel)
        {
            Disease disease = new Disease();
            disease.Disease_name = diseaseModel.Disease_name;
            disease.severity = diseaseModel.severity;
            disease.cause = diseaseModel.cause;
            disease.Disease_description = diseaseModel.Disease_description;
            Business business = new Business();
            business.AddDisease(disease);
        }
    }
}//@Disease_name,@severity,@cause,@Disease_description
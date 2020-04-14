using ExceptionLayer;
using MedicalResearch_BusinessLayer;
using MedicalResearch_PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalResearch_PresentationLayer.Controllers
{
    public class DiagnoseController : Controller
    {
        // GET: Diagnose
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayDiagnose()
        {
            ModelManager modelManager = new ModelManager();
            ViewModel viewModel = new ViewModel();
            viewModel.symptomModels = modelManager.DisplaySymptoms();      
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult ViewDiagnose(string name,int Symptom_Id1, int Symptom_Id2)
        {
            try
            {
                ModelManager modelManager = new ModelManager();
                List<DiseasesWithSymptomModel> diseasesWithSymptomModels = new List<DiseasesWithSymptomModel>();
                diseasesWithSymptomModels = modelManager.DisplayDiagnose(name, Symptom_Id1, Symptom_Id2);
                Business business = new Business();
               
                return View(diseasesWithSymptomModels);
            }
            catch (SymptomNotSelectedException e)
            {
                TempData["message"] = e.Message;
                return RedirectToAction("DisplayDiagnose");
            }
        }
       
    }
}
using ExceptionLayer;
using MedicalResearch_PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalResearch_PresentationLayer.Controllers
{
    public class DiseaseController : Controller
    {
        // GET: Disease
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult SuccessSymptom()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDisease()
        {            
            ModelManager modelManager = new ModelManager();
            ViewModel viewModel = new ViewModel();
            viewModel.severityModels = modelManager.DisplaySeverity();
            viewModel.causeModels = modelManager.DisplayCause();
            return View(viewModel);                     
        }
        [HttpPost]
        public ActionResult AddDisease(DiseasesModel diseasesModel)
        {
            try
            {
                ModelManager modelmanager = new ModelManager();
                modelmanager.AddDisease(diseasesModel);
                return Redirect("Success"); 
            }
            catch (NameAlreadyPresent e)
            {
                TempData["status"] = e.Message;
                return RedirectToAction("AddDisease");
            }
        }
        [HttpGet]
        public ActionResult AddDiseaseWithSymptom()
        {           
                ModelManager modelManager = new ModelManager();
                ViewModel viewModel = new ViewModel();
                viewModel.symptomModels = modelManager.DisplaySymptoms();
                viewModel.diseasesModels = modelManager.DisplayDiseases();
                return View(viewModel);           
        }
        [HttpPost]
        public ActionResult AddDiseaseWithSymptom(DiseasesWithSymptomModel diseasesWithSymptomModel)
        {
            try
            {
                ModelManager modelManager = new ModelManager();
                modelManager.checkSymptom(diseasesWithSymptomModel);
                modelManager.AddDiseaseWithSymptom(diseasesWithSymptomModel);
                return Redirect("SuccessSymptom");
            }
            catch(DiseaseHasTwoSymptomsAlready e)
            {
                TempData["message1"] = e.Message;
                return RedirectToAction("AddDiseaseWithSymptom");
            }
            catch(DiseaseAlreadyHasThisSymptom e)
            {
                TempData["message2"] = e.Message;
                return RedirectToAction("AddDiseaseWithSymptom");

            }

        }





            //try
            //{
            //    ModelManager modelmanager = new ModelManager();
            //    modelmanager.AddDiseaseWithSymptom(diseasesWithSymptomModel);
            //    return Redirect("SuccessSymptom");
            //}catch(SymptomAlreadyPresent e)
            //{
            //    TempData["status1"] = e.Message;
            //    return RedirectToAction("AddDiseaseWithSymptom");
            //}
        }

    }

       
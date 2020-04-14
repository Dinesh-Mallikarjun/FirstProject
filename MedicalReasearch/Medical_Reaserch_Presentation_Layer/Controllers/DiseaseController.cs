using Medical_Reaserch_Presentation_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Reaserch_Presentation_Layer.Controllers
{
    public class DiseaseController : Controller
    {
        // GET: Disease
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDisease()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult AddDisease(DiseaseModel diseaseModel)
        //{
        //    ModelManager modelManager = new ModelManager();
        //    modelManager.AddDisease(diseaseModel);
        //    return View();
        //}
        [HttpPost]
        public ActionResult AddDisease(DiseaseModel diseaseModel)
        {
            if (ModelState.IsValid)
            {
                ModelManager modelManager = new ModelManager();
                modelManager.AddDisease(diseaseModel);
                return Redirect("Success");
            }
            else
            {
                return Redirect("AddDisease");
            }
        }
    }
}
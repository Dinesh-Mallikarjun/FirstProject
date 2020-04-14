using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityPresentationLayer.Models;

namespace UniversityPresentationLayer.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUniversity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUniversity(UniversityModel universityModel)
        {
            ModelManager modelManager = new ModelManager();
            try
            {
                modelManager.AddUniversity(universityModel);
                
                return (RedirectToAction("AddUniversity"));
            }
            catch (Exception)
            {
                
                return (RedirectToAction("AddUniversity"));
            }

        }
        [HttpGet]
        public ActionResult ViewUniversities()
        {

            ModelManager modelManager = new ModelManager();
            List<UniversityModel> universities = modelManager.ViewUniversities();
            return View(universities);
        }

    }
}
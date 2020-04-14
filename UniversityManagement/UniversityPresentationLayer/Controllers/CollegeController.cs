using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityPresentationLayer.Models;

namespace UniversityPresentationLayer.Controllers
{
    public class CollegeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCollege()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCollege(CollegeModel collegeModel)
        {
            ModelManager modelManager = new ModelManager();
            try
            {
                modelManager.AddCollege(collegeModel);

                return (RedirectToAction("AddCollege"));
            }
            catch (Exception)
            {

                return (RedirectToAction("AddCollege"));
            }

        }
        [HttpGet]
        public ActionResult ViewColleges()
        {

            ModelManager modelManager = new ModelManager();
            List<CollegeModel> colleges = modelManager.ViewColleges();
            return View(colleges);
        }

        [HttpGet]
        public ActionResult ViewAllColleges()
        {
            ModelManager modelManager = new ModelManager();
            List<CollegeModel> allcolleges = modelManager.ViewAllColleges();
            return View(allcolleges);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
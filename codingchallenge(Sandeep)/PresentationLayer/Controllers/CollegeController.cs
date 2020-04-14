using EntityLayer;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class CollegeController : Controller
    {
        // GET: College
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCollege()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCollege(CollegeModel collegeModel )
        {
            ModelManager modelManager = new ModelManager();
            modelManager.AddCollege(collegeModel);
            return View();
        }

        [HttpGet]
        public ActionResult Display(  )
        {
            List<CollegeModel> collegeModels = new List<CollegeModel>();
            ModelManager modelManager = new ModelManager();
            collegeModels = modelManager.Display();
            return View(collegeModels);
        }



    }
}
using jsassignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jsassignment.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDemo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDemo(demomodel demomodel)
        {
            modelmanager modelManager = new modelmanager();
            modelManager.AddDemo(demomodel);
            return View();
        }

    }
}
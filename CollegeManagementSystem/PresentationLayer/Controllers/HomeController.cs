using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string name, string password)
        {
            if (name.Equals("Admin") && password.Equals("Admin"))
                return (RedirectToAction("ViewMenuAdmin"));
            else if (name.Equals("Student") && password.Equals("Student"))
                return (RedirectToAction("ViewMenuStudent"));
            else
                return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(string name, string pass)
        //{
        //    if (name.Equals("Admin") && pass.Equals("Admin"))
        //        return Redirect("ViewMenuAdmin");
        //    else if (name.Equals("Student") && pass.Equals("Student"))
        //        return Redirect("ViewMenuStudent");
        //    else
        //        return Redirect("Login");
        //}
       
        public ActionResult ViewMenuAdmin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewMenuStudent()
        {

            ModelManager modelManager = new ModelManager();
            List<CollegeModel> collegeModels = modelManager.ViewColleges();
            return View(collegeModels);
        }
        public ActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(StudentModel studentModel)
        {
            ModelManager modelManager = new ModelManager();
            int i = modelManager.Apply(studentModel);
            if (i > 0)
            {
                TempData["Message"] = "Applied Successfullyy college id:" + i;
                return (RedirectToAction("Apply"));
            }
            else
            {
                TempData["message"] = "something went wrong";
                return (RedirectToAction("Apply"));
            }

        }
    }
}















 
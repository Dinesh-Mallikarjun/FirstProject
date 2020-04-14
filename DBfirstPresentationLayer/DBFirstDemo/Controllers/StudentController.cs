//using DBFirstDemo.Models;
using DBFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstDemo.Controllers
{
    public class StudentController : Controller
    {
        StudentDatabaseEntities studentContext = new StudentDatabaseEntities();

        [HttpGet]
        public ActionResult AddCollege()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCollege(college collegeModel)
        {
            studentContext.colleges.Add(collegeModel);
            studentContext.SaveChanges();
            return View();
        }
        public ActionResult ViewCollege()
        {
            return View();
        }


    }
}

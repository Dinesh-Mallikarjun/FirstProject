//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace StudentMangementSystem.Controllers
//{
//    public class StudentController : Controller
//    {
//        // GET: Student
//        public ActionResult Index()
//        {
//            return View();
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer;
using StudentMangementSystem.Models;
using StudentMangementSystem;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ModelManager model = new ModelManager();
            List<CollegeEntity> list = new List<CollegeEntity>();
            list = model.displayCollege();
            return View(list);
        }
        public ActionResult AddStudent(string name, int collegeid, decimal Perc)
        {
            ModelManager model = new ModelManager();
            StudentEnt studentEnt = new StudentEnt();
            studentEnt.student = new student();
            studentEnt.student.Name = name;
            studentEnt.student.Collegeid = collegeid;
            studentEnt.student.PercentageObtained = Perc;
            if (model.AddStudent(studentEnt))
            {
                ViewBag.Data = studentEnt.student.id;
                return View();
            }
            else
            {
                return RedirectToAction("failure");
            }

        }
        public ActionResult failure()
        {
            return View();
        }
    }
}

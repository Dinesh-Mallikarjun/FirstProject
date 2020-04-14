using ExceptionLayer;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(StudentModel studentModel)
        {
            ModelManager modelManager = new ModelManager();
            modelManager.AddStudent(studentModel);
            return View();
        }
        public ActionResult SuccessStudent()
        {
            return View();
        }
        [HttpGet]
        public ActionResult displaystudents()
        {
            return View();
        }

        [HttpPost]
        public ActionResult displaystudents(int id)
        {
            try
            {
                ModelManager modelManager = new ModelManager();
                List<StudentModel> studentModels = modelManager.displaystudents(id);
                return View(studentModels);
            }
            catch(InvalidCollegeId e)
            {
                TempData["status"] = e.Message;
                return View();
            }
        }
        

        [HttpPost]
        public ActionResult studentsbelow50()
        {            
            ModelManager modelManager = new ModelManager();
            List<StudentModel> studentModels = modelManager.studentsbelow50();        
            return View(studentModels);
        }
        //[HttpGet]
        //public ActionResult getstudent()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult getstudents()
        {
            return View();
        }
        
        public ActionResult delete()
        {
            return View();
        }

        
        public ActionResult deletes(int id)
        {
            ModelManager modelManager = new ModelManager();
            modelManager.delete(id);
            return View();
        }       
    }
}
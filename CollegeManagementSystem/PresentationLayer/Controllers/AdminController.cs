using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Entities;

namespace PresentationLayer.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
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
                TempData["message"] = "data inserted successfully.";
                return (RedirectToAction("AddCollege"));
            }
            catch(Exception)
            {
                TempData["message"] = "Data can not be inserted";
                return (RedirectToAction("AddCollege"));
            }

        }
        public ActionResult ViewStudents()
        {
            return View();
        }  

        public ActionResult ViewStudentForCollege(int id)
        {
            ModelManager modelManager = new ModelManager();
            List<StudentModel> studentModels = modelManager.ViewStudentForCollege(id);
            if (studentModels != null)
                return (View(studentModels));
            else
            {
                TempData["message"] = "something went wrong!";
                return RedirectToAction("ViewStudents");
            }
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(int id,FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
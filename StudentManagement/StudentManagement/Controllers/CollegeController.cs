using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class CollegeController : Controller
    {
        StudentDatabaseEntities std = new StudentDatabaseEntities();
        // GET: College
        public ActionResult Index()
        {
            return View();
        }

        // GET: College/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: College/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: College/Create
        [HttpPost]
        public ActionResult Create(college clg)
        {
            std.colleges.Add(clg);
            std.SaveChanges();
            return View();
        }

        // GET: College/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: College/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: College/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: College/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using CollegeManagementEntities;
using CollegeManagementPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagementPresentationLayer.Controllers
{
    public class AdminController : Controller
    {
        collegemanagementsystemEntities clgEntities = new collegemanagementsystemEntities();
        // GET: Admin
        public ActionResult LoginAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAdmin(string name,string pass)
        {
            if (name.Equals("Admin") && pass.Equals("Admin"))
                return Redirect("Homepage");
            else
                return Redirect("LoginAdmin");
        }
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult AddCollege()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCollege(College college)
        {
            if(ModelState.IsValid)
            {
                clgEntities.Colleges.Add(college);
                clgEntities.SaveChanges();
                return Redirect("Success");
            }
            else
            {
                return Redirect("AddCollege");
            }
        }
        
        [HttpGet]
        public ActionResult DisplayStudents()
        {
            return View();
        }
        [HttpPost]
        public ActionResult  DisplayStudents(College college)
        {
            return RedirectToAction("DisplayStudentsList", new { Cid = college.CollegeId });
        }
        public ActionResult DisplayStudentsList(int Cid)
        {
            List<Student> students = new List<Student>();
            students = clgEntities.Students.ToList();
            List<Student> collegeStudents = new List<Student>();
            foreach(Student student in students)
            {
                if (student.CollegeId==Cid)
                    collegeStudents.Add(student);
            }
            return View(collegeStudents);
        }
     

    }
}
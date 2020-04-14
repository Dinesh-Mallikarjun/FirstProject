using CollegeManagementEntities;
using CollegeManagementPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagementPresentationLayer.Controllers
{
    public class StudentController : Controller
    {
        collegemanagementsystemEntities clgEntities = new collegemanagementsystemEntities();


        //public ActionResult StudentLogin()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult StudentLogin(string name, string pass)
        //{
        //    if (name.Equals("Student") && pass.Equals("Student"))
        //        return Redirect("HomePage");
        //    else
        //        return Redirect("StudentLogin");
        //}

        public ActionResult StudentLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentLogin(string name, string password)
        {
            if (name.Equals("Student") && password.Equals("Student"))
                return Redirect("home");
            else
                return Redirect("StudentLogin");
        }

        public ActionResult home()
        {
            return View();
        }
    
        
        [HttpGet]
        public ActionResult HomePage()
        {
            List<College> colleges = new List<College>();
            colleges = clgEntities.Colleges.ToList();
            List<College> Colleges = new List<College>();
            foreach (College college in colleges)
            {
                if (college.NumberOfSeatsAvailable >= 1)    
                {
                    Colleges.Add(college);
                }
            }
            return View(Colleges);
        }
        public ActionResult InsertStudent(int Id,string name, int Cid, decimal percentage)
        {
            List<College> colleges = new List<College>();
            colleges = clgEntities.Colleges.ToList();
            List<College> Colleges = new List<College>();
            foreach (College college in colleges)
            {
                if (college.NumberOfSeatsAvailable >= 1)
                {
                    Colleges.Add(college);
                }
            }
            int admissionGranted = 0, collegeFound = 0, NoOfSeats = 0;
            foreach (College college in Colleges)
            {
                if (college.CollegeId == Cid)
                {
                    if (college.CutOffPercentage <= percentage)
                    {
                        admissionGranted = 1;
                        collegeFound = 1;
                        NoOfSeats = (int)college.NumberOfSeatsAvailable - 1;
                        College clgObj = clgEntities.Colleges.Single(x => x.CollegeId == Cid);
                        clgObj.NumberOfSeatsAvailable = NoOfSeats;
                        clgEntities.SaveChanges();
                    }
                }
            }
            if (collegeFound == 0)
            {
                return RedirectToAction("CollegeNotFound");
            }
            else if (admissionGranted == 1 && collegeFound == 1)
            {
                Student student = new Student();
                student.Id = Id;
                student.CollegeId = Cid;
                student.PercentageObtained = percentage;
                student.Name = name;
                clgEntities.Students.Add(student);
                clgEntities.SaveChanges();
                ViewBag.CollegeId = Cid;
                return View();
            }
            else
                return View();

        }
        public ActionResult CollegeNotFound()
        {
            return View();
        }
    }
}
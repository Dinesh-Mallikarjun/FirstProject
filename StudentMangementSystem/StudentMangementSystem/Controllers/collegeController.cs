using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentMangementSystem.Models;
using EntityLayer;
using StudentMangementSystem;


namespace StudentMangementSystem.Controllers
{
    public class collegeController : Controller
    {
        // GET: college
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddCollege()
        {
            return View();
        }
        public ActionResult addcollegeDetails(string Collegename, string location, decimal CutoffPercentage, int NumberofSeatsAvailable)
        {
            ModelManager modelManger = new ModelManager();
            CollegeEntity collegeEntity = new CollegeEntity();

            collegeEntity.college = new college();
            collegeEntity.college.colegeName = Collegename;
            collegeEntity.college.location = location;
            collegeEntity.college.cutOffPercentage = CutoffPercentage;
            collegeEntity.college.NumberofseatsAvailable = NumberofSeatsAvailable;
            modelManger.InsertCollege(collegeEntity);

            return View();
        }
        public ActionResult displaystudent()
        {
            ModelManager model = new ModelManager();
            List<CollegeEntity> list = new List<CollegeEntity>();
            list = model.displayCollege();
            return View(list);
        }
        public ActionResult displaystud(int collegeid)
        {
            List<StudentEnt> list = new List<StudentEnt>();
            ModelManager model = new ModelManager();
            list = model.displaystudent(collegeid);
            return View(list);
        }





    }
}

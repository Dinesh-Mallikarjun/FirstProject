using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class Doctor_PatientController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDoctor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDoctor(Doctor_Model doctor_Model)
        {
            Model_Manager model_Manager = new Model_Manager();
            model_Manager.AddDoctor(doctor_Model);
            return View(); 
        }

    }
}
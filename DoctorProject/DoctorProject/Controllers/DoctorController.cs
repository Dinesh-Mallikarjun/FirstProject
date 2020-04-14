using DoctorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExceptionLayer;
namespace DoctorProject.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
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
        public ActionResult AddDoctor(DoctorModel doctorModel)
        {
            ModelManager modelManager = new ModelManager();
            modelManager.AddDoctor(doctorModel);
            return View();
        }


        [HttpGet]
        public ActionResult AddPatient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPatient(PatientModel patientModel)
        {
            try
            {

                ModelManager modelManager = new ModelManager();
                modelManager.AddPatient(patientModel);
                return View();
            }
            catch(InvalidData e)
            {
                TempData["status"] = e.Message;
                return View();
            }
        }

        [HttpGet]
        public ActionResult GetPatientDetials()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetPatientDetials(int id)
        {
            ModelManager mm = new ModelManager();
            List<PatientModel> patient_Models =  mm.GetPatientDetials(id);
            return View(patient_Models);
        }
        [HttpPost]
        public ActionResult GetDoctorName(string name)
        {
            ModelManager modelManager = new ModelManager();
            List<DoctorModel> doctorModels = new List<DoctorModel>();
            doctorModels = modelManager.GetDoctorName(name);
            return View(doctorModels);
        }

        [HttpGet]
        public ActionResult GetDoctorName()
        {
            return View();
        }
        [HttpGet]
        public ActionResult getPatients()
        {
            return View();
        }


        public ActionResult ShowDoctor()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult DisplayDoctors()
        {
            ModelManager modelManager = new ModelManager();
            List<DoctorModel> doctorModels = new List<DoctorModel>();
            doctorModels = modelManager.DisplayDoctors();            
            return View(doctorModels);
        }  
        
    }
}
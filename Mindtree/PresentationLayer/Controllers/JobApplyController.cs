using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class JobApplyController : Controller
    {
        // GET: JobApply
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Applyjob()
        {
            ModelManager modelManager = new ModelManager();
            ViewModel viewModel = new ViewModel();
            viewModel.genderModels = modelManager.DisplayGenders();
            viewModel.contactModels = modelManager.DisplayContacts();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Applyjob(ApplyForJobModel applyForJobModel)
        {            
                ModelManager modelManager = new ModelManager();
                modelManager.ApplyJob(applyForJobModel);
                return View("Success");            
        }
        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayApplications()
        {
            ModelManager modelManager = new ModelManager();
            List<ApplyForJobModel> applyForJobModels = new List<ApplyForJobModel>();
            applyForJobModels =  modelManager.DisplayApplications();
            return View(applyForJobModels);
        }
    }
}
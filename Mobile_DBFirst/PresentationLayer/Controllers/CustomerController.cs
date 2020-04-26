using BusinessLayer;
using ExceptionLayer;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            ModelManager modelManager = new ModelManager();
            ViewModel viewModel = new ViewModel();
            viewModel.mobileOperatorModels = modelManager.DisplayOperators();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerModel customerModel)
        {
            try
            {
                ModelManager modelManager = new ModelManager();
                modelManager.AddCustomer(customerModel);
                return View("SuccessCustomer");
            }
            catch (InValidOperatorIdException e)
            {
                TempData["status"] = e.Message;
                return RedirectToAction("AddCustomer");
            }
        }
        public ActionResult SuccessCustomer()
        {
            return View();
        }
        public ActionResult ExportToExcel()
        {
            ModelManager modelManager = new ModelManager();
            modelManager.exportToExcel();
            return View("ExcelSuccess");
        }
        [HttpGet]
        public ActionResult ExcelSuccess()
        {
            return View();
        }
    }
}
using BikeMVC.Models;
using BikeMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeMVC.Controllers
{
    public class BikeController : Controller
    {
      [HttpGet]
        public ActionResult GetAllBikeDetails()
            {
                BikeRepository BikeRepo = new BikeRepository();
                ModelState.Clear();
                return View(BikeRepo.GetAllBikes());
            }
            // GET: Employee/AddEmployee    
            [HttpGet]
            public ActionResult AddBike()
            {
                return View();
            }
        [HttpPost]
        public ActionResult AddBike(BikeModel Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BikeRepository EmpRepo = new BikeRepository();
                    if (EmpRepo.AddBike(Emp))
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult EditBikeDetails(int Price)
        {
            BikeRepository BikeRepo = new BikeRepository();
            return View(BikeRepo.GetAllBikes().Find(Bike => Bike.Price == Price));
        }
        [HttpPost]
        public ActionResult EditBikeDetails(int Price, BikeModel obj)
        {
            try
            {
                BikeRepository BikeRepo = new BikeRepository();

                BikeRepo.UpdateBike(obj);
                                             
                return RedirectToAction("GetAllBikeDetails");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult DeleteBike(string Name)
        {
            try
            {
                BikeRepository BikeRepo = new BikeRepository();
                if (BikeRepo.DeleteBike(Name))
                {
                    ViewBag.AlertMsg = "Bike details deleted successfully";
                }
                return RedirectToAction("GetAllBikeDetails");
            }
            catch
            {
                return View();
            }
        }
    }
}
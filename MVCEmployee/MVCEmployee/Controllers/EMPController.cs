using MVCEmployee.Models;
using MVCEmployee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmployee.Controllers
{
    public class EMPController : Controller
    {
        
     
 
        public ActionResult AddEmployee()
        {
            return View();
        }

        public ActionResult GetAllEmployees()
        {
            return View(GetAllEmployees());
        }





        [HttpPost]
        public ActionResult AddEmployee(Employee Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpRepository EmpRepo = new EmpRepository();

                    if (EmpRepo.AddEmployee(Emp))
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

    }
}
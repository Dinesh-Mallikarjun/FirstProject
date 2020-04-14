using presentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace presentationLayer.Controllers
{
    public class DoctorController : ApiController
    {
        [HttpGet]
        public IHttpActionResult AddDoctor(DoctorModel doctorModel)
        {
            ModelManager modelManager = new ModelManager();
            int result = modelManager.AddDoctor(doctorModel);
            if (result == 1)
            {
                return Ok("Record Inserted Successfully");
            }
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult DisplayDoctors()
        {
            ModelManager modelManager = new ModelManager();
            List<DoctorModel> doctorModels = new List<DoctorModel>();
            doctorModels = modelManager.DisplayDoctors();
            return Ok(doctorModels);
        }
    }
}

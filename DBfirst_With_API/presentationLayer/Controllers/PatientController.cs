using presentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace presentationLayer.Controllers
{
    public class PatientController : ApiController
    {
       
        [HttpGet]
        public IHttpActionResult AddPatients(PatientModel patientModel)
        {
            ModelManager modelManager = new ModelManager();
            int result = modelManager.AddPatients(patientModel);
            if (result == 1)
            {
                return Ok("Record Inserted Successfully");
            }
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult DisplayPatients(int id)
        {
            ModelManager modelManager = new ModelManager();
            List<PatientModel> patientModels = new List<PatientModel>();
            patientModels = modelManager.DisplayPatients(id);
            return Ok(patientModels);
        }

    }
}

using presentationlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace presentationlayer.Controllers
{
    public class GuestController : ApiController
    {
        // GET: api/Guest
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Guest/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Guest
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/Guest/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Guest/5
        //public void Delete(int id)
        //{

        //}
        ModelManager modelManager = new ModelManager();
        //[HttpGet]
        //[Route("api/Guest/ReserveTable")]
        //public IHttpActionResult ReserveTable()
        //{

        //    ViewModel viewModel = new ViewModel();
        //    viewModel.reservationModels = modelManager.DisplayReservation();
        //    return Ok(viewModel);
        //}
        [HttpPost]
        [Route("api/Guest/ReserveTable")]
        public IHttpActionResult ReserveTable(GuestModel guestModel)
        {
                ModelManager modelmanager = new ModelManager();
                modelmanager.ReserveTable(guestModel);
                return Ok("Successfully Reserved");
           
        }

        //[HttpGet]
        //[Route("api/Guest/UpdateBill")]

        //public IHttpActionResult UpdateBill()
        //{
        //    ViewModel viewModel = new ViewModel();
        //    viewModel.guestModels = modelManager.DisplayReservedTables();
        //    return Ok(viewModel);
        //}
        [HttpPost]
        [Route("api/Guest/UpdateBill")]
        public IHttpActionResult UpdateBill(GuestModel guestModel)
        {

            ModelManager modelmanager = new ModelManager();
            modelmanager.UpdateBill(guestModel);
            return Redirect("Bill updated Successfully");
        }
        [HttpGet]
        [Route("api/Guest/DisplayPresentGuests")]
        public IHttpActionResult DisplayPresentGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.DisplayPresentGuests();
            return Ok(guestModels);
        }
        [HttpGet]
        [Route("api/Guest/DisplayTop5BillGuests")]
        public IHttpActionResult DisplayTop5BillGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.DisplayTop5BillGuests();
            return Ok(guestModels);
        }
        [HttpGet]
        [Route("api/Guest/Displayleast5BillGuests")]
        public IHttpActionResult Displayleast5BillGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.Displayleast5BillGuests();
            return Ok(guestModels);
        }


    }
}

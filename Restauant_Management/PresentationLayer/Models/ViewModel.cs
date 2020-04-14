    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ViewModel
    {
        public IEnumerable<ReservationModel> reservationModels { get; set; }
        public IEnumerable<GuestModel> guestModels { get; set; }
    }
}
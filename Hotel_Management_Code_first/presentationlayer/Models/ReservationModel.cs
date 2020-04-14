using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace presentationlayer.Models
{
    public class ReservationModel
    {
        public int ReservationId { get; set; }
        public Nullable<int> TableStatus { get; set; }
        public virtual ICollection<GuestModel> Guests { get; set; }
    }
}
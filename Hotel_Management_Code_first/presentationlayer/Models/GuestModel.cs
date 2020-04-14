using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace presentationlayer.Models
{
    public class GuestModel
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int NumberOfPeople { get; set; }
        public Nullable<int> BillAmount { get; set; }
        public Nullable<int> Reservation_Id { get; set; }
        public virtual ReservationModel Reservation { get; set; }
    }
}
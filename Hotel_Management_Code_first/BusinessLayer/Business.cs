
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business
    {
        DataAccess dataAccess = new DataAccess();
        public Guest ReserveTable(Guest guest)
        {
            return dataAccess.ReserveTable(guest);
        }
        public List<Reservation> DisplayReservation()
        {
            return dataAccess.DisplayReservation();
        }
        public List<Guest> DisplayReservedTables()
        {
            return dataAccess.DisplayReservedTables();
        }
        public List<Guest> UpdateBill(Guest guest)
        {
            return dataAccess.UpdateBill(guest);
        }
        public List<Guest> DisplayPresentGuests()
        {
            return dataAccess.DisplayPresentGuests();
        }

        public List<Guest> DisplayTop5BillGuests()
        {
            return dataAccess.DisplayTop5BillGuests();
        }
        public List<Guest> Displayleast5BillGuests()
        {
            return dataAccess.Displayleast5BillGuests();
        }
    }
}

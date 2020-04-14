using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionLayer;

namespace BusinessLayer
{
    public class Business
    {
        static DataAccess dataAccess = new DataAccess();
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
        public List<Guest> DisplayGuests()
        {
            return dataAccess.DisplayGuests();
        }
        public Guest BookedTable(Guest guest)
        {
            DataAccess dataAccess = new DataAccess();
            List<Reservation> reservations = DisplayReservation();
            foreach (var item in reservations)
            {
                if (guest.Reservation.TableStatus == 1)
                {
                    throw new TableAlreadyBooked("This table is booked already ,SORRY for inconvinience");
                }
            }
            return  dataAccess.ReserveTable(guest);
        }
    }
}

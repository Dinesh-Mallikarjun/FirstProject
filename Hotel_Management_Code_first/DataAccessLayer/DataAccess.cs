using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        Hotel_Context hotel_ManagementEntities = new Hotel_Context();
        public List<Reservation> DisplayReservation()
        {
            return hotel_ManagementEntities.Reservations.ToList();

        }
        public Guest ReserveTable(Guest guest)
        {
            var result = hotel_ManagementEntities.Reservations.SingleOrDefault(b => b.ReservationId == guest.Reservation.ReservationId);
            result.TableStatus = 1;
            guest.Reservation_Id = guest.Reservation.ReservationId;
            guest.Reservation = null;
            Guest guestt = hotel_ManagementEntities.Guests.Add(guest);
            hotel_ManagementEntities.SaveChanges();
            return guestt;
        }

        public List<Guest> DisplayReservedTables()
        {
            return hotel_ManagementEntities.Guests.Where(b => b.Reservation.TableStatus == 1).ToList();
        }
        public List<Guest> UpdateBill(Guest guest)
        {
            var entity = hotel_ManagementEntities.Guests.Single(m => m.GuestId == guest.GuestId);
            var data = hotel_ManagementEntities.Reservations.Single(m => m.ReservationId == entity.Reservation_Id);
            data.TableStatus = 0;
            entity.BillAmount = guest.BillAmount;
            hotel_ManagementEntities.SaveChanges();
            return hotel_ManagementEntities.Guests.Where(a => a.GuestId == guest.GuestId).ToList();
        }
        public List<Guest> DisplayPresentGuests()
        {
            return hotel_ManagementEntities.Guests.Where(b => b.Reservation.TableStatus == 1).ToList();
        }
        public List<Guest> DisplayTop5BillGuests()
        {
            List<Guest> guests = new List<Guest>();
            guests = (from t in hotel_ManagementEntities.Guests
                      orderby t.BillAmount descending
                      select t).Take(5).ToList();
            return guests;
        }
        public List<Guest> Displayleast5BillGuests()
        {
            List<Guest> guests = new List<Guest>();
            guests = (from t in hotel_ManagementEntities.Guests
                      orderby t.BillAmount ascending
                      select t).Take(5).ToList();
            return guests;
        }
    }
}

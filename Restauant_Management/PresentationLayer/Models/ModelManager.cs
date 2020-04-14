using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ModelManager
    {
        public Guest ReserveTable(GuestModel guestModel)
        {
            Business business = new Business();
           
            Guest guest = new Guest();
            guest.GuestName = guestModel.GuestName;

            guest.NumberOfPeople = guestModel.NumberOfPeople;
            guest.BillAmount = guestModel.BillAmount;

            guest.Reservation = new Reservation();
            guest.Reservation.ReservationId = guestModel.Reservation.ReservationId;

            return business.BookedTable(guest);
        }
        public List<ReservationModel> DisplayReservation()
        {
            Business business = new Business();
            List<Reservation> reservations = business.DisplayReservation();
            List<ReservationModel> reservationModels = new List<ReservationModel>();
            foreach (var reservation in reservations)
            {
                ReservationModel reservationModel = new ReservationModel();
                reservationModel.ReservationId = reservation.ReservationId;
                reservationModel.TableStatus = reservation.TableStatus;
                reservationModels.Add(reservationModel);
            }
            return reservationModels;
        }
        public List<GuestModel> DisplayReservedTables()
        {
            Business business = new Business();
            List<Guest> guests = business.DisplayReservedTables();
            List<GuestModel> guestModels = new List<GuestModel>();
            foreach (var guest in guests)
            {
                GuestModel guestModel = new GuestModel();
                guestModel.GuestId = guest.GuestId;
                guestModel.GuestName = guest.GuestName;
                guestModel.Reservation_Id = guest.Reservation_Id;
                guestModel.NumberOfPeople = guest.NumberOfPeople;
                guestModel.Reservation = new ReservationModel();
                guestModel.Reservation.TableStatus = guest.Reservation.TableStatus;
                guestModels.Add(guestModel);
            }
            return guestModels;
        }
        public List<GuestModel> UpdateBill(GuestModel guest)
        {
            Guest guest1 = new Guest();
            guest1.BillAmount = guest.BillAmount;
            guest1.GuestId = guest.GuestId;
            Business business = new Business();            
            List<Guest> guests = business.UpdateBill(guest1);
            List<GuestModel> guestModels = new List<GuestModel>();
            foreach (var i in guests)
            {
                GuestModel guestModel = new GuestModel();
                guestModel.GuestId = i.GuestId;
                guestModel.GuestName = i.GuestName;
                guestModel.Reservation_Id = i.Reservation_Id;
                guestModel.NumberOfPeople = i.NumberOfPeople;
                guestModel.BillAmount = i.BillAmount;
                guestModel.Reservation = new ReservationModel();
                guestModel.Reservation.TableStatus = i.Reservation.TableStatus;
                guestModels.Add(guestModel);
            }
            return guestModels;
        }
        public List<GuestModel> DisplayPresentGuests()
        {
            Business business = new Business();
            ListOfGuest listOfGuest = new ListOfGuest();
           //List<Guest> guests = Models.SortGuests();
            List<Guest> guests = business.DisplayPresentGuests();
            List<GuestModel> guestModels = new List<GuestModel>();
            foreach (var guest in guests)
            {
                GuestModel guestModel = new GuestModel();
                guestModel.GuestId = guest.GuestId;
                guestModel.GuestName = guest.GuestName;
                guestModel.Reservation_Id = guest.Reservation_Id;
                guestModel.NumberOfPeople = guest.NumberOfPeople;
                guestModel.Reservation = new ReservationModel();
                guestModel.Reservation.TableStatus = guest.Reservation.TableStatus;
                guestModels.Add(guestModel);
            }
            listOfGuest.SortGuests();
            return guestModels;
        }
        public List<GuestModel> DisplayTop5BillGuests()
        {
            Business business = new Business();
            List<Guest> guests = business.DisplayTop5BillGuests();
            List<GuestModel> guestModels = new List<GuestModel>();
            foreach(var guest in guests)
            {
                GuestModel guestModel = new GuestModel();
                guestModel.GuestId = guest.GuestId;
                guestModel.GuestName = guest.GuestName;
                guestModel.BillAmount = guest.BillAmount;
                guestModels.Add(guestModel);
            }
            return guestModels;
        }        
         public List<GuestModel> Displayleast5BillGuests()
        {
            Business business = new Business();
            List<Guest> guests = business.Displayleast5BillGuests();
            List<GuestModel> guestModels = new List<GuestModel>();
            foreach (var guest in guests)
            {
                GuestModel guestModel = new GuestModel();
                guestModel.GuestId = guest.GuestId;
                guestModel.GuestName = guest.GuestName;
                guestModel.BillAmount = guest.BillAmount;
                guestModels.Add(guestModel);
            }
            return guestModels;
        }
        public ArrayList DispllayAll()
        {
            ModelManager modelManager = new ModelManager();
            ArrayList arrayList = new ArrayList();
            arrayList.Add(modelManager.DisplayGuests());
            arrayList.Add(modelManager.DisplayPresentGuests());
            arrayList.Add(modelManager.DisplayTop5BillGuests());
            arrayList.Add(modelManager.Displayleast5BillGuests());
            return arrayList;
        }
        public List<GuestModel> DisplayGuests()
        {
            Business business = new Business();
            ListOfGuest listOfGuest = new ListOfGuest();           
            List<Guest> guests = business.DisplayGuests();
            List<GuestModel> guestModels = new List<GuestModel>();
            foreach (var guest in guests)
            {
                GuestModel guestModel = new GuestModel();
                guestModel.GuestId = guest.GuestId;
                guestModel.GuestName = guest.GuestName;
                guestModel.Reservation_Id = guest.Reservation_Id;
                guestModel.NumberOfPeople = guest.NumberOfPeople;
                guestModel.Reservation = new ReservationModel();
                guestModel.Reservation.TableStatus = guest.Reservation.TableStatus;
                guestModels.Add(guestModel);
            }
            listOfGuest.SortGuests();
            return guestModels;
        }
    }
}
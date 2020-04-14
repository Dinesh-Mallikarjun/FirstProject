using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ListOfGuest:IComparable
    {
        List<ListOfGuest> listOfGuests = new List<ListOfGuest>();
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int NumberOfPeople { get; set; }
        public Nullable<int> BillAmount { get; set; }
        public Nullable<int> Reservation_Id { get; set; }

        public int CompareTo(object ob)
        {
            ListOfGuest listOfGuest = (ListOfGuest)ob;
            if(Reservation_Id ==listOfGuest.Reservation_Id)
            {
                return 0;
            }
            else if(Reservation_Id>listOfGuest.Reservation_Id)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public void Add(ListOfGuest listOfGuest)
        {
            listOfGuests.Add(listOfGuest);
        }
        public List<ListOfGuest> GetDetails()
        {
            return listOfGuests;
        }
        public void SortGuests()
        {
            listOfGuests.Sort();
        }
    }
}
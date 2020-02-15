using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExploreTrips.Models
{
    public class BookingDestination
    {
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int CantAdults { get; set; } 
        public int CantChildren { get; set; }
        public int CantDays { set; get; } //Observable!
        public Decimal BasePrice { get; set; }
        public Decimal FinalPrice { get; set; } //Observable



    }
}

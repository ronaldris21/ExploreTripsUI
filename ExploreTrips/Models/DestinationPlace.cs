using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreTrips.Models
{
    using Xamarin.Forms;
    public class DestinationPlace
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public string Name { get; set; }
        public double Ranking { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }



        private Xamarin.Forms.Command _CommandObjectTapped;
        public Xamarin.Forms.Command CommandObjectTapped
        {
            get => _CommandObjectTapped ?? (_CommandObjectTapped = new Xamarin.Forms.Command(MoveBookingPage));
        }
        private async void MoveBookingPage(object obj)
        {
            Plugin.SharedTransitions.SharedTransitionNavigationPage.SetTransitionSelectedGroup(App.Current.MainPage, Id.ToString());
            await App.Current.MainPage.Navigation.PushAsync(new Pages.BookingPage(this));
        }


    }
}

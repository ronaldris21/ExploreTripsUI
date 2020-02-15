using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExploreTrips.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingPage : ContentPage
    {
        public BookingPage(Models.DestinationPlace place)
        {
            InitializeComponent();
            BindingContext = new ViewModels.BookingPlaceViewModel(place);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }
    }
}
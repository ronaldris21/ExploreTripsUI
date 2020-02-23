using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExploreTrips
{
    using Pages.MasterFolder;
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Task.Delay(500);
            await App.Current.MainPage.Navigation.PushAsync(new Pages.MasterFolder.MasterMain());
        }

        private async void Button_Clicked_Explorar(object sender, EventArgs e)
        {
            await Task.Delay(500);
            await App.Current.MainPage.Navigation.PushAsync(new Pages.MasterFolder.MasterMain());

        }
        private async void Button_Clicked_Reservados(object sender, EventArgs e)
        {
            var pageto = new Pages.MasterFolder.MasterMain();
            pageto.ActivateDetailPage(Pages.MasterFolder.MenuItem.ReservedPlaces);
            await Task.Delay(500);
            await App.Current.MainPage.Navigation.PushAsync(pageto);
        }

        private async void Button_Clicked_Guardados(object sender, EventArgs e)
        {
            var pageto = new Pages.MasterFolder.MasterMain();
            pageto.ActivateDetailPage(Pages.MasterFolder.MenuItem.PlacesToBookLater);
            await Task.Delay(500);
            await App.Current.MainPage.Navigation.PushAsync(pageto);
        }
    }
}

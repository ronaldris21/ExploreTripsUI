using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExploreTrips.Pages.MasterFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMain : MasterDetailPage
    {
        Color TabColor { get; set; }
        public MasterMain()
        {
            InitializeComponent();
            TabColor = Color.FromHex("009dbe");
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterMainMasterMenuItem;
            if (item == null)
                return;

            ActivateDetailPage(item.PageToGo);
            
            MasterPage.ListView.SelectedItem = null;
        }

        public void ActivateDetailPage(MenuItem PageToGo)
        {
            switch (PageToGo)
            {
                case MenuItem.PlacesPage:
                    Detail = new SharedTransitionNavigationPage(new Pages.PlacesPage()) { BarBackgroundColor = TabColor };
                    break;
                case MenuItem.PlacesToBookLater:
                    Detail = new SharedTransitionNavigationPage(new Pages.PlacesToBookLater()) { BarBackgroundColor = TabColor };
                    break;
                case MenuItem.ReservedPlaces:
                    Detail = new SharedTransitionNavigationPage(new Pages.ReservedPlacesPage()) { BarBackgroundColor = TabColor };
                    break;
                default:
                    break;
            }
            IsPresented = false;
        }

    }
}
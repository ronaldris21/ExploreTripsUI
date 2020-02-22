using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExploreTrips.Pages.MasterFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMainMaster : ContentPage
    {
        public ListView ListView;

        public MasterMainMaster()
        {
            InitializeComponent();

            BindingContext = new MasterMainMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterMainMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterMainMasterMenuItem> MenuItems { get; set; }

            public MasterMainMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterMainMasterMenuItem>(new[]
                {
                    new MasterMainMasterMenuItem {  Title = "Explorar" ,PageToGo=MenuItem.PlacesPage},
                    new MasterMainMasterMenuItem {  Title = "Viajes Reservados", PageToGo = MenuItem.ReservedPlaces},
                    new MasterMainMasterMenuItem { Title = "Reservar Ahora" ,PageToGo=MenuItem.PlacesToBookLater }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;

            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
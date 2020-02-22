
namespace ExploreTrips.Infraestructure
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using ViewModels;
    public class Singleton : MvvmHelpers.ObservableObject
    {
        public Singleton()
        {
            //Lo igualo porque unicamente ha sido intanciado en APP.XAML
            if (instance == null)
            {
                instance = this;
                LoadMenu();
            }
        }



        private static Singleton instance;
        public static Singleton Instance => instance ?? (instance = new Singleton());


        #region Atributos y Propiedades
        private DestinationPlace _selectedPlace;
        public DestinationPlace SelectedPlace
        {
            get { return _selectedPlace; }
            set
            {
                SetProperty(ref _selectedPlace, value);
                BookingBeingMade = new BookingDestination() { BasePrice = value.Price, Id_DestinationPlace = value.Id }; //Actualizo la reservación que haré
            }
        }

        private BookingDestination _BookingBeingMade;
        public BookingDestination BookingBeingMade
        {
            get { return _BookingBeingMade; }
            set
            {
                SetProperty(ref _BookingBeingMade, value);
            }
        }


        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }



        #endregion



        #region Metodos
        private void LoadMenu()
        {
            MenuItems = new ObservableCollection<MenuItemViewModel>();
            MenuItems.Add(new MenuItemViewModel()
            {
                Icon="",
                PageName = MenuItem.PlacesPage,
                Title = "Explorar"
            });

            MenuItems.Add(new MenuItemViewModel()
            {
                Icon = "",
                PageName = MenuItem.PlacesToBookLater,
                Title = "Reservar Luego"
            });

            MenuItems.Add(new MenuItemViewModel()
            {
                Icon = "",
                PageName = MenuItem.ReservedPlaces,
                Title = "Reservados"
            });


        }
        #endregion



        #region Comandos

        #endregion
    }
}


namespace ExploreTrips.Infraestructure
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using ViewModels;
    public class Singleton : MvvmHelpers.ObservableObject
    {
        #region Singleton 
        public Singleton()
        {
            //Lo igualo porque unicamente ha sido intanciado en APP.XAML
            if (instance == null)
            {
                instance = this;
                Sqlite = new DataStorage.SQLiteHandler();
                Sqlite.InitTablesAsync();
                LoadMenu();
            }
        }
        private static Singleton instance;
        public static Singleton Instance => instance ?? (instance = new Singleton());
        #endregion

        #region Utils
        public DataStorage.SQLiteHandler Sqlite { get; set; }
        #endregion


        #region Reservados
        public ObservableCollection<Models.BookingDestination> ViajesReservados { get; set; }
        #endregion


        #region Booking Procces
        private DestinationPlace _selectedPlace;
        public DestinationPlace SelectedPlace
        {
            get { return _selectedPlace; }
            set
            {
                SetProperty(ref _selectedPlace, value);
                BookingBeingMade = new BookingDestination() { 
                    BasePrice = value.Price, 
                    Id_DestinationPlace = value.Id, 
                    DepartureDate=DateTime.Now,
                    ArrivalDate=DateTime.Now,
                    CantDays=1,
                    CantAdults=1
                }; //Actualizo la reservación que haré
                BookingStep = 0;
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
        private int _BookingStep = 0;
        public int BookingStep
        {
            get { return _BookingStep; }
            set { SetProperty(ref _BookingStep, value); }
        }

        private Xamarin.Forms.Command _NextStepCommand => new Xamarin.Forms.Command(NextStepMethod);
        public Xamarin.Forms.Command NextStepCommand { get => _NextStepCommand; }
        private void NextStepMethod()
        {
            BookingStep++;
        }
        private Xamarin.Forms.Command _PreviousStepCommand => new Xamarin.Forms.Command(PreviousStepMethod);
        public Xamarin.Forms.Command PreviousStepCommand { get => _PreviousStepCommand; }
        private void PreviousStepMethod()
        {
            BookingStep--;
        }
        #endregion



        #region Master MENU
        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }
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

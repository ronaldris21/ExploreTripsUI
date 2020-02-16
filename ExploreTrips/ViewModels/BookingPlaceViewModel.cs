using ExploreTrips.Models;

namespace ExploreTrips.ViewModels
{
    internal class BookingPlaceViewModel : MvvmHelpers.BaseViewModel
    {
        public BookingPlaceViewModel(DestinationPlace place)
        {
            this.Place = place;
            RatingCan = 4;
        }


        public DestinationPlace Place { get; set; } //Observable
        private BookingDestination _ReservationBooked;
        public BookingDestination ReservationBooked
        {
            get { return _ReservationBooked; }
            set { SetProperty(ref _ReservationBooked, value); }
        }
        private int _ratingCan;
        public int RatingCan
        {
            get => _ratingCan;
            set => SetProperty(ref _ratingCan, value);
        }

        



        private Xamarin.Forms.Command _ShowDetailsCommand;
        public Xamarin.Forms.Command ShowDetailsCommand
        {
            get => _ShowDetailsCommand ?? (_ShowDetailsCommand = new Xamarin.Forms.Command(ShowDetailsMethod));
        }
        private void ShowDetailsMethod(object obj)
        {

        }
    }
}
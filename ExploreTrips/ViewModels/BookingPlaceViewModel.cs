using ExploreTrips.Models;

namespace ExploreTrips.ViewModels
{
    internal class BookingPlaceViewModel : MvvmHelpers.BaseViewModel
    {
        private int _ratingCan;
        public int RatingCan
        {
            get => _ratingCan;
            set => SetProperty(ref _ratingCan, value);
        }

        public DestinationPlace Place { get; set; } //Observable
        public BookingPlaceViewModel(DestinationPlace place)
        {
            this.Place = place;
            RatingCan = 4;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreTrips.ViewModels
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }

        public string Title { get; set; }

        public MenuItem PageName { get; set; }
    }


    public enum MenuItem
    {
        PlacesPage,
        PlacesToBookLater,
        ReservedPlaces
    }
}

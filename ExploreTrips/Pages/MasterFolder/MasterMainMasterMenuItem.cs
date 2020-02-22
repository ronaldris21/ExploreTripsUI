using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreTrips.Pages.MasterFolder
{

    public class MasterMainMasterMenuItem
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public MenuItem PageToGo { get; set; }
    }

    public enum MenuItem
    {
        PlacesPage,
        PlacesToBookLater,
        ReservedPlaces
    }
}
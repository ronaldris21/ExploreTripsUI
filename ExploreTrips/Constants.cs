using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreTrips
{
    public static class Constants
    {
        private static double screenWidth = Xamarin.Forms.Application.Current.MainPage.Width;
        public static double ScreenWidth { get => screenWidth; set => screenWidth = value; }
    }
}

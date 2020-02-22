﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExploreTrips.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaceImagesCardViewPage : ContentPage
    {


        public PlaceImagesCardViewPage()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.BookingPlaceViewModel(place);
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var item = sender as FFImageLoading.Forms.CachedImage;
            if (item == null)
            {
                return;
            }
            item.ReloadImage();
        }
    }
}
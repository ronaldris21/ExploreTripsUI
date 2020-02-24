using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExploreTrips.Models
{
    public class BookingDestination : MvvmHelpers.ObservableObject
    {
        public int Id_DestinationPlace { get; set; }
        private DateTime _ArrivalDate;
        public DateTime ArrivalDate
        {
            get { return _ArrivalDate; }
            set
            {
                ValidArrivalDate = value.Date >= DateTime.Today ? true : false;
                if (ValidArrivalDate)
                {
                    ValidArrivalDate = (DepartureDate - value).Days >= 0;
                    if (ValidArrivalDate)
                    {
                        SetProperty(ref _ArrivalDate, value);
                        UpdateCantDays();
                    }
                    else
                    {
                        Plugin.Toast.CrossToastPopUp.Current.ShowToastError("La fecha de ingreso debe ser antes que la de sálida", Plugin.Toast.Abstractions.ToastLength.Long);
                    }
                }
                else
                {
                    Plugin.Toast.CrossToastPopUp.Current.ShowToastError("No se aceptan fechas antes de hoy");
                    SetProperty(ref _ArrivalDate, DateTime.Now);
                }
            }
        }
        private DateTime _DepartureDate;
        public DateTime DepartureDate
        {
            get { return _DepartureDate; }
            set
            {
                ValidDepartureDate = value.Date >= DateTime.Today ? true : false;
                if (ValidDepartureDate)
                {
                    ValidDepartureDate = (value - ArrivalDate).Days >= 0;
                    if (ValidDepartureDate)
                    {
                        SetProperty(ref _DepartureDate, value);
                        UpdateCantDays();
                    }
                    else
                    {
                        Plugin.Toast.CrossToastPopUp.Current.ShowToastError("La fecha de salida debe ser posterior a la de ingreso",Plugin.Toast.Abstractions.ToastLength.Long);
                    }
                }
                else
                {
                    Plugin.Toast.CrossToastPopUp.Current.ShowToastError("No se aceptan fechas antes de hoy");
                    SetProperty(ref _DepartureDate, DateTime.Now);
                }
            }
        }

        private int _CantAdults;
        public int CantAdults
        {
            get { return _CantAdults; }
            set
            {
                if (value >= 0)
                {
                    SetProperty(ref _CantAdults, value); UpdatePrice();
                }
            }
        }
        private int _CantChildren;
        public int CantChildren
        {
            get { return _CantChildren; }
            set
            {
                if (value >= 0)
                {
                    SetProperty(ref _CantChildren, value); UpdatePrice();
                }
            }
        }
        public int CantDays { set; get; } //Observable!
        public int RatingBookingExperience { get; set; } = 5;
        public double BasePrice { get; set; }
        public double FinalPrice { get; set; } //Observable

        private bool _ValidDepartureDate;
        public bool ValidDepartureDate
        {
            get { return _ValidDepartureDate; }
            set { SetProperty(ref _ValidDepartureDate, value); }
        }

        private bool _ValidArrivalDate;
        public bool ValidArrivalDate
        {
            get { return _ValidArrivalDate; }
            set { SetProperty(ref _ValidArrivalDate, value); }
        }


        private void UpdateCantDays()
        {
            if (DepartureDate>=DateTime.Today && ArrivalDate>=DateTime.Today)
            {
                if ((DepartureDate - ArrivalDate).Days > 0)
                {
                    CantDays = (DepartureDate - ArrivalDate).Days;
                    Plugin.Toast.CrossToastPopUp.Current.ShowToastMessage("Reservar " + CantDays.ToString() + " días ");
                }

                if (CantAdults==0)
                {
                    CantAdults = 1;
                }
                UpdatePrice();
            }
            
        }
        private void UpdatePrice()
        {
            FinalPrice = BasePrice * (CantAdults + CantChildren * 0.8) * CantDays;
        }


    }
}

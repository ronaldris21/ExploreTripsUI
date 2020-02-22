using ExploreTrips.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExploreTrips.ViewModels
{
    public class PlacesPageViewModel
    {
        public ObservableCollection<DestinationPlace> Lugares { get; set; }


        public PlacesPageViewModel()
        {
            Lugares = new ObservableCollection<DestinationPlace>();
            var santorini = new DestinationPlace()
            {
                Category = "Explore",
                Name = "Santorini - Grecia",
                Id = 1,
                Img = "Santorini00.jpg",
                Price = 995,
                Ranking = 5,
                ImgList = new List<string>()
                {
                    "Santorini00.jpg",
                    "Santorini01.jpg",
                    "Santorini02.jpg",
                    "Santorini03.jpg",
                    "Santorini04.jpg"
                }
            };
            var venece = new DestinationPlace()
            {
                Name = "Italia - Venecia",
                Category = "Explore",
                Id = 2,
                Img = "Venece00.jpg",
                Price = 1200,
                Ranking = 4,
                ImgList = new List<string>()
                {
                    "Venece00.jpg",
                    "Venece01.jpg",
                    "Venece02.jpg",
                    "Venece03.jpg",
                    "Venece04.jpg"
                }
            };
            var playita = new DestinationPlace()
            {
                Name = "Playa Beach",
                Category = "Relax and Confort",
                Id = 3,
                Img = "Beach00.jpg",
                Price = 1300,
                Ranking = 5,
                ImgList = new List<string>()
                {
                    "Beach00.jpg",
                    "Beach01.jpg",
                    "Beach02.jpg",
                    "Beach03.jpg",
                    "Beach04.jpg"
                }

            };
            var paris = new DestinationPlace()
            {
                Name = "Torre Eifel",
                Category = "Relax and Confort",
                Id = 4,
                Img = "Paris00.jpg",
                Price = 1400,
                Ranking = 4.6,
                ImgList = new List<string>()
                {
                    "Paris00.jpg",
                    "Paris01.jpg",
                    "Paris02.jpg",
                    "Paris03.jpg",
                }
            };


            for (int i = 0; i < 4; i++)
            {
                Lugares.Add(santorini);
                Lugares.Add(venece);
                Lugares.Add(playita);
                Lugares.Add(paris);
            }
        }
    }
}

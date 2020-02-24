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
                Description = "Santorini es una de las islas Cícladas en el mar Egeo. Fue devastada por una erupción volcánica en el siglo XVI a. C., que dio forma a su paisaje accidentado.",
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
                Description= "Venecia, la capital de la región de Véneto en el norte de Italia, abarca más de 100 islas pequeñas en una laguna del mar Adriático. No tiene caminos, sino solo canales, incluida la vía pública del Gran Canal, bordeada de palacios renacentistas y góticos.",
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
                Name = "Playa del Carmen",
                Category = "Relax and Confort",
                Id = 3,
                Img = "Beach00.jpg",
                Description= "Playa del Carmen es un balneario costero de México que se ubica a lo largo de la costa caribeña de la Riviera Maya, en la Península de Yucatán.",
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
                Description= "La Torre Eiffel es el símbolo de París, fue construida para la Exposición Universal de París de 1889 y actualmente es el monumento más visitado del mundo.",
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

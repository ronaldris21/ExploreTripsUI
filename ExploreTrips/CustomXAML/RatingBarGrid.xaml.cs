
namespace ExploreTrips.CustomXAML
{


    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using FFImageLoading.Svg.Forms;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingBarGrid : Grid
    {
        private string imgEmpty = "estrellaEmpty.svg";
        private string imgFull = "estrellaFull.svg";
        private double CantPrevia;
        public RatingBarGrid()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            int cantStars = Convert.ToInt32(((FFImageLoading.Svg.Forms.SvgCachedImage)sender).ClassId);
            if (cantStars!=CantPrevia)
                PaintStars(cantStars);
            
        }

        private void Grid_BindingContextChanged(object sender, EventArgs e)
        {

            if (CantPrevia == (double)BindingContext)
                return;

            PaintStars((double)BindingContext);
        }

        private async void PaintStars(double cant)
        {
            foreach (SvgCachedImage SVGImage in this.Children)
            {
                SVGImage.Source = imgEmpty;
            }

            foreach (SvgCachedImage SVGImage in this.Children)
            {
                int PosStar = Convert.ToInt32(SVGImage.ClassId);
                await System.Threading.Tasks.Task.Delay(10);
                if (PosStar <= cant)
                {
                    SVGImage.Source = imgFull;
                }
            }
            CantPrevia = cant;
            this.BindingContext = cant;
        }
    }
}
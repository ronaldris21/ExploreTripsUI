
namespace ExploreTrips.CustomXAML
{


    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using FFImageLoading.Svg.Forms;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingBarGrid : Grid
    {
        private readonly string imgEmpty = "estrellaEmpty.svg";
        private readonly string imgFull = "estrellaFull.svg";
        private double CantPreviaDouble;
        private int CantPreviaInt;
        public RatingBarGrid()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Siempre es int ya que toma el ClassID
            PaintStarsInt(Convert.ToInt32(((FFImageLoading.Svg.Forms.SvgCachedImage)sender).ClassId));
        }

        private void Grid_BindingContextChanged(object sender, EventArgs e)
        {
            double actual;
            if (double.TryParse(BindingContext.ToString(), out actual) && actual != CantPreviaDouble)
            {
                PaintStarsDouble(actual);
                return;
            }

            int actualint;
            if (int.TryParse(BindingContext.ToString(), out actualint) && actualint != CantPreviaInt)
            {
                PaintStarsInt((int)BindingContext);
                return;
            }
        }

        private async void PaintStarsInt(int cant)
        {
            if (CantPreviaInt == cant)
                return;

            foreach (SvgCachedImage SVGImage in this.Children)
            {
                SVGImage.Source = imgEmpty;
            }

            foreach (SvgCachedImage SVGImage in this.Children)
            {
                int PosStar = Convert.ToInt32(SVGImage.ClassId);
                await System.Threading.Tasks.Task.Delay(5);
                if (PosStar <= cant)
                {
                    SVGImage.Source = imgFull;
                }
            }
            CantPreviaInt = cant;
            CantPreviaDouble = Convert.ToDouble(cant);
            this.BindingContext = cant;
        }

        private async void PaintStarsDouble(double cant)
        {
            if (CantPreviaDouble == cant)
                return;

            foreach (SvgCachedImage SVGImage in this.Children)
            {
                SVGImage.Source = imgEmpty;
            }

            foreach (SvgCachedImage SVGImage in this.Children)
            {
                int PosStar = Convert.ToInt32(SVGImage.ClassId);
                await System.Threading.Tasks.Task.Delay(5);
                if (PosStar <= cant)
                {
                    SVGImage.Source = imgFull;
                }
            }
            CantPreviaDouble = cant;
            CantPreviaInt = Convert.ToInt32(cant);
            this.BindingContext = Convert.ToDouble(cant);
        }
    }
}
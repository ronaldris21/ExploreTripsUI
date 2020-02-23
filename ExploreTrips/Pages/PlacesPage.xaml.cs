using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExploreTrips.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacesPage : ContentPage
    {
        public PlacesPage()
        {
            InitializeComponent();
            PaintLabelAsync();
        }

        private async void PaintLabelAsync()
        {
            

            await lblBestExperience.TranslateTo(-2000, 0, 50, Easing.BounceOut);
            await Task.Delay(1500);
            await lblBestExperience.TranslateTo(0, 20, 500, Easing.BounceOut);

            //probando Escribir en tiempo de ejecución!
            //string txtbestExperience = "Vive la mejor experiencia de tu vida!";
            //try
            //{
            //    for (int i = 0; i < txtbestExperience.Length; i++)
            //    {
            //        lblBestExperience.Text += txtbestExperience[i];
            //        await Task.Delay(5);
            //    }
            //}
            //catch (Exception)
            //{
            //    Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
            //    {
            //        lblBestExperience.Text = txtbestExperience;
            //    });
            //}

        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var imageff = sender as FFImageLoading.Forms.CachedImage;
            if (imageff==null)
            {
                return;
            }
            imageff.ReloadImage();
        }
    }
}
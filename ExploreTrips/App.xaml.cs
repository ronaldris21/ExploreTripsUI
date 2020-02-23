using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExploreTrips
{
    using Plugin.SharedTransitions;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedTransitionNavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#009dbe") };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

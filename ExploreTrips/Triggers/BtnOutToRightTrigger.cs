
namespace ExploreTrips.Triggers
{
    using Xamarin.Forms;
    public class BtnScaleBiggerTrigger : TriggerAction<VisualElement>
    {
        protected override async void Invoke(VisualElement sender)
        {
            sender.IsEnabled = false;
            await sender.ScaleTo(1.2,250, Easing.SpringOut);
            await sender.ScaleTo(1,250, Easing.SpringOut);
            sender.IsEnabled = true;
        }
    }
}

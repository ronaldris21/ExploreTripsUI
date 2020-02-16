
namespace ExploreTrips.Triggers
{
    using Xamarin.Forms;
    public class BtnTranslateRightTrigger : TriggerAction<VisualElement>
    {
        protected override async void Invoke(VisualElement sender)
        {
            sender.IsEnabled = false;
            await sender.TranslateTo(200, 0, 200, Easing.BounceOut);
            await sender.TranslateTo(0, 0, 200, Easing.BounceOut);
            sender.IsEnabled = true;
        }
    }
}

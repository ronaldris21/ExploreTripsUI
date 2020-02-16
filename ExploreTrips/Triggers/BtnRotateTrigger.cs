using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreTrips.Triggers
{
    using Xamarin.Forms;
    public class BtnRotateTrigger : TriggerAction<VisualElement>
    {
        protected override async void Invoke(VisualElement sender)
        {
            sender.IsEnabled = false;
            await sender.RotateTo(180);
            await sender.RotateTo(0, 250, Easing.SpringOut);
            sender.IsEnabled = true;
        }
    }
}

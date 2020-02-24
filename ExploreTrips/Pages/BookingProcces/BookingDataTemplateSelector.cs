namespace ExploreTrips.Pages.BookingProcces
{
    using Xamarin.Forms;
    public class BookingDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DatesTemplate { get; set; }
        public DataTemplate PeopleAmountTemplate { get; set; }
        public DataTemplate PriceTemplate { get; set; }
        public DataTemplate DetailsTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (((BookingClassObject)item).EnumTemplate)
            {
                case BookingTemplates.DatesTemplate:
                    return DatesTemplate;
                case BookingTemplates.PeopleAmountTemplate:
                    return PeopleAmountTemplate;
                case BookingTemplates.PriceTemplate:
                    return PriceTemplate;
                case BookingTemplates.DetailsTemplate:
                    return DetailsTemplate;
                default:
                    return DatesTemplate;
            }
        }
    }

    public enum BookingTemplates
    {
        DatesTemplate,
        PeopleAmountTemplate,
        PriceTemplate,
        DetailsTemplate
    }

    public class BookingClassObject
    {
        public BookingTemplates EnumTemplate { get; set; }
        public Models.BookingDestination BookingBeingMade
        {
            get => Infraestructure.Singleton.Instance.BookingBeingMade;
            set => Infraestructure.Singleton.Instance.BookingBeingMade = value;
        }
        public Xamarin.Forms.Command NextStepCommand => Infraestructure.Singleton.Instance.NextStepCommand;
        public Xamarin.Forms.Command PreviousStepCommand => Infraestructure.Singleton.Instance.PreviousStepCommand;
    }
}

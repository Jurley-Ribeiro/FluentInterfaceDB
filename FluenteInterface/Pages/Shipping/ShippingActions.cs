namespace FluenteInterface.Pages.Shipping
{
    public class ShippingActions : PageBase
    {
        public ShippingElements Home { get { return new ShippingElements(); } }

        public ShippingActions AcceptTerms ()
        {
            Home.CheckedTerms.Click();
            return this;
        }

        public void GoToPayment()
        {
            Home.ShippingButton.Click();
        }
    }
}
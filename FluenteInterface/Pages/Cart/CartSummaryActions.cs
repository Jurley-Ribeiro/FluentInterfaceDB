namespace FluenteInterface.Pages.Cart
{
    public class CartSummaryActions : PageBase
    {
        public CartSummaryElements CartSummary { get { return new CartSummaryElements(); } }

        public CartSummaryActions GoToUrl()
        {
            Driver.Navigate().GoToUrl(BaseAddress + "?controller=order");
            return this;
        }

        public void GoToAuthentication()
        {
            CartSummary.ProceedToCheckout.Click();
        }
    }
}
namespace FluenteInterface.Pages.OrderConfirmationPage
{
    public class OrderConfirmationActions
    {
        private OrderConfirmationElements OrderPage { get { return new OrderConfirmationElements(); } }

        public void ConfirmOrder()
        {
            OrderPage.ConfirmOrderButton.Click();
        }
    }
}
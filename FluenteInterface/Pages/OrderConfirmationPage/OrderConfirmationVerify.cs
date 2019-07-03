using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluenteInterface.Pages.OrderConfirmationPage
{
    public class OrderConfirmationVerify
    {
        private OrderConfirmationElements OrderPage { get { return new OrderConfirmationElements(); } }

        public void ConfirmationMessageIsDisplayed()
        {
            Assert.AreEqual("Your order on My Store is complete.", OrderPage.ConfirmationMessage.Text);
        }
    }
}
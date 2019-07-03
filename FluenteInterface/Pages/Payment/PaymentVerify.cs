using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluenteInterface.Pages.Payment
{
    public class PaymentVerify
    {
        private PaymentElements PaymentPage { get { return new PaymentElements(); } }
        public void PriceIsCorrect(string price)
        {
            Assert.AreEqual(price, PaymentPage.TotalPrice.Text);

        }
    }
}
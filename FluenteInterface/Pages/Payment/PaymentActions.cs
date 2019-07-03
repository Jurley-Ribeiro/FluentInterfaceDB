namespace FluenteInterface.Pages.Payment
{
    public class PaymentActions : PageBase
    {
        public PaymentElements Home { get { return new PaymentElements(); } }
        public void GoToPayBank()
        {
            Home.PayBankButton.Click();
        }
    }
}
using OpenQA.Selenium;

namespace FluenteInterface.Pages.Address
{
    public class AddressElements : PageBase
    {
        public IWebElement AddressBox { get { return GetAddressBox(); } }

        public IWebElement AddressButton { get { return GetAddressButton(); } }

        private IWebElement GetAddressBox()
        {
            return Driver.FindElement(By.Id("address_delivery"));
        }

        private IWebElement GetAddressButton()
        {
            return Driver.FindElement(By.Name("processAddress"));
        }
    }
}
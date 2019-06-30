using OpenQA.Selenium;

namespace FluenteInterface.Pages
{
    public class HomePageElements : PageBase
    {
        public IWebElement Logo { get { return GetLogo(); } }

        private IWebElement GetLogo()
        {
            return Driver.FindElement(By.Id("header_logo"));
        }
    }
}
namespace FluenteInterface.Pages
{
    public class HomePageActions : PageBase
    {
        public HomePageElements Home { get { return new HomePageElements(); } }

        public HomePageActions GoToUrl()
        {
            Driver.Navigate().GoToUrl(BaseAddress);
            return this;
        }

        public HomePageActions ClickLogo()
        {
            Home.Logo.Click();
            return this;
        }
    }
}
namespace FluenteInterface.Pages
{
    public class HomePageVerify
    {
        private HomePageElements HomePage { get { return new HomePageElements(); } }

        public bool LogoIsDisplayed()
        {
            return HomePage.Logo.Displayed;
        }
    }
}
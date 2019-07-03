using OpenQA.Selenium;

namespace FluenteInterface.Pages.Authentication
{
    public class AuthenticationElements : PageBase
    {
        public IWebElement Email { get { return GetEmail(); } }

        public IWebElement CreateAccountButton { get { return GetCreateAccountButton(); } }

        private IWebElement GetEmail()
        {
            return Driver.FindElement(By.Id("email_create"));
        }

        private IWebElement GetCreateAccountButton()
        {
            return Driver.FindElement(By.Id("SubmitCreate"));
        }
    }
}

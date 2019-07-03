using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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

        public HomePageActions AddProductToCart()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", Home.Product);

            //Home.Product.Click();
            return this;
        }

        public void GoToCartSummary ()
        {
            Home.ProceedToCheckoutButton.Click();
        }
    }
}
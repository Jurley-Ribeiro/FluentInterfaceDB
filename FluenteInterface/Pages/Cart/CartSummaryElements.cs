using OpenQA.Selenium;

namespace FluenteInterface.Pages.Cart
{
    public class CartSummaryElements : PageBase
    {
        public IWebElement Product { get { return GetProduct(); } }

        public IWebElement ProceedToCheckout { get { return GetProceedToCheckout(); }  }

        private IWebElement GetProduct()
        {
            return Driver.FindElement(By.XPath("//*[@id='product_1_1_0_0']/td[2]/p/a"));
        }

        private IWebElement GetProceedToCheckout()
        {
            return Driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));
        }
    }
}
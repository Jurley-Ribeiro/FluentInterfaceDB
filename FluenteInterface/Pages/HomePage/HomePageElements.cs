using System;
using OpenQA.Selenium;

namespace FluenteInterface.Pages
{
    public class HomePageElements : PageBase
    {

        public IWebElement Product { get { return GetProduct(); } }

        public IWebElement ProceedToCheckoutButton { get { return GetProceedToCheckoutButton(); } }

        private IWebElement GetProduct()
        {
            return Driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/div[2]/a[1]"));
        }

        private IWebElement GetProceedToCheckoutButton()
        {
            return Driver.FindElement(By.XPath("//a[@title = 'Proceed to checkout']"));
        }
    
    }
}
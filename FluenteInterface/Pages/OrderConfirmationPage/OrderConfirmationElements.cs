using System;
using OpenQA.Selenium;

namespace FluenteInterface.Pages.OrderConfirmationPage
{
    public class OrderConfirmationElements : PageBase
    {
        public IWebElement ConfirmOrderButton { get { return GetConfirmOrderButton(); } }

        public IWebElement ConfirmationMessage { get { return GetConfirmationMessage(); } }

        
        private IWebElement GetConfirmationMessage()
        {
            return Driver.FindElement(By.XPath("//*[@id='center_column']/div/p/strong"));
        }

        private IWebElement GetConfirmOrderButton()
        {
            return Driver.FindElement(By.XPath("//*[@id='cart_navigation']/button"));
        }
    }
}
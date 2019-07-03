using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Payment
{
    public class PaymentElements : PageBase
    {
        public IWebElement TotalPrice { get { return GetTotalPrice(); } }

        public IWebElement PayBankButton { get { return GetPayBank(); } }

        private IWebElement GetTotalPrice()
        {
            return Driver.FindElement(By.Id("total_price_container"));
        }

        private IWebElement GetPayBank()
        {
            return Driver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[1]/div/p/a"));
        }
    }
}

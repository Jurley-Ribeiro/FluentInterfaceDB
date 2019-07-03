using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Shipping
{
    public class ShippingElements : PageBase
    {
        public IWebElement ShippingButton { get { return GetShippingButton(); } }
        public IWebElement CheckedTerms { get { return GetCheckedTerms(); } }

        private IWebElement GetCheckedTerms()
        {
            return Driver.FindElement(By.Id("cgv"));
        }

        private IWebElement GetShippingButton()
        {
            return Driver.FindElement(By.Name("processCarrier"));

        }
    }
}

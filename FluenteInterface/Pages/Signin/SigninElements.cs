using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Signin
{
    public class SigninElements : PageBase
    {
        public IWebElement MrRadioButton { get { return GetMrRadioButton(); } }
        public IWebElement FirstName { get { return GetFirstName(); } }
        public IWebElement LastName { get { return GetLastName(); } }
        public IWebElement Password { get { return GetPassword(); } }
        public IWebElement Address { get { return GetAddress(); } }
        public IWebElement City { get { return GetCity(); } }
        public SelectElement State { get { return GetStateSelect(); } }
        public IWebElement ZipCode { get { return GetZipCode(); } }
        public SelectElement Country { get { return GetCountry(); } }
        public IWebElement MobilePhone { get { return GetMobilePhone(); } }
        public IWebElement RegisterButton { get { return GetRegisterButton(); } }

        private IWebElement GetFirstName()
        {
            return Driver.FindElement(By.Id("customer_firstname"));
        }

        private IWebElement GetLastName()
        {
            return Driver.FindElement(By.Id("customer_lastname"));
        }

        private IWebElement GetPassword()
        {
            return Driver.FindElement(By.Id("passwd"));
        }

        private IWebElement GetAddress()
        {
            return Driver.FindElement(By.Id("address1"));
        }

        private IWebElement GetCity()
        {
            return Driver.FindElement(By.Id("city"));
        }

        private SelectElement GetStateSelect()
        {
            return new SelectElement(Driver.FindElement(By.Id("id_state")));
        }

        private IWebElement GetZipCode()
        {
            return Driver.FindElement(By.Id("postcode"));

        }

        private SelectElement GetCountry()
        {
            return new SelectElement(Driver.FindElement(By.Id("id_country")));
        }

        private IWebElement GetMrRadioButton()
        {
            //Best implemented with 'Explicit wait'
            Thread.Sleep(1000);
            return Driver.FindElement(By.Id("uniform-id_gender1"));
        }

        private IWebElement GetMobilePhone()
        {
            return Driver.FindElement(By.Id("phone_mobile"));
        }

        private IWebElement GetRegisterButton()
        {
            return Driver.FindElement(By.Id("submitAccount"));
        }
    }
}

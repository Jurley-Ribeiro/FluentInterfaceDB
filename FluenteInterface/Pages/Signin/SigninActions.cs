using System;
using FluenteInterface.Pages.Signin;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FluenteInterface.Pages
{
    public class SigninActions : PageBase
    {
        public SigninElements Signin { get { return new SigninElements(); } }

        public SigninActions SetTitle()
        {
            Signin.MrRadioButton.Click();
            return this;
        }

        public SigninActions SetFirstName()
        {
            Signin.FirstName.SendKeys("Jurley");
            return this;
        }

        public SigninActions SetLastName()
        {
            Signin.LastName.SendKeys("Colares");
            return this;
        }

        public SigninActions SetPassword()
        {
            Signin.Password.SendKeys("12345");
            return this;
        }

        public SigninActions SetAddress()
        {
            Signin.Address.SendKeys("Av. Bento Gonçalves");
            return this;
        }

        public SigninActions SetCity()
        {
            Signin.City.SendKeys("POA");
            return this;
        }

        public SigninActions SetState()
        {
            Signin.State.SelectByText("Kansas");
            return this;
        }

        public SigninActions SetZipCode()
        {
            Signin.ZipCode.SendKeys("12345");
            return this;
        }

        public SigninActions SetMobilePhone()
        {
            Signin.MobilePhone.SendKeys("12345");
            return this;
        }

        public void Register()
        {
            Signin.RegisterButton.Click();
        }
    }
}
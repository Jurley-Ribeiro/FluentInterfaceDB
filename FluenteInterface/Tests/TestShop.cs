using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluenteInterface.Pages;
using FluentAssertions;
using FluenteInterface.Pages.Cart;
using FluenteInterface.Pages.Authentication;

namespace FluenteInterface.Tests
{
    [TestClass]
    public class TestShop : TestBase
    {
        public HomePage HomePage => new HomePage();

        public CartSummaryPage CartPage => new CartSummaryPage();

        public AuthenticationPage AuthenticationPage => new AuthenticationPage();

        public SigninPage SigninPage => new SigninPage();


        [TestMethod]
        public void LogoIsDisplayed()
        {
            //Arrange
            HomePage.Actions()
                .GoToUrl();

            HomePage.Actions()
                .AddProductToCart()
                .GoToCartSummary();
            
            CartPage.Verify()
              .ProductWasAdd("Faded Short Sleeve T-shirts");

            CartPage.Actions()
                .GoToAuthentication();

            AuthenticationPage.Actions()
                .SetEmail("user1@jurley.com")
                .GoToPersonalFormulary();

            SigninPage.Actions()
                .SetTitle()
                .SetFirstName()
                .SetLastName()
                .SetPassword()
                .SetAddress()
                .SetCity()
                .SetState()
                .SetZipCode()
                .SetMobilePhone()
                .Register();
        }

    }
}

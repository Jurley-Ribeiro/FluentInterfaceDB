﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using FluenteInterface.Pages.Address;
using FluenteInterface.Pages.Shipping;
using FluenteInterface.Pages.Payment;
using FluenteInterface.Pages.OrderConfirmationPage;

namespace FluenteInterface.Tests
{
    [TestClass]
    public class TestShop : TestBase
    {
        public HomePage HomePage => new HomePage();

        public CartSummaryPage CartPage => new CartSummaryPage();

        public AuthenticationPage AuthenticationPage => new AuthenticationPage();

        public SigninPage SigninPage => new SigninPage();

        public AddressPage AddressPage => new AddressPage();

        public ShippingPage ShippingPage => new ShippingPage();

        public PaymentPage PaymentPage => new PaymentPage();

        public OrderConfirmationPage OrderPage => new OrderConfirmationPage();

        [TestMethod]
        public void PurchaseItemTest()
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
                .SetEmail(DateTime.Now.Millisecond.ToString() + "@jurley.com")
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

            AddressPage.Verify()
                .AssertAddressIsCorrect("Av. Bento Gonçalves")
                .AssertAddressIsCorrect("POA, Kansas 12345")
                .AssertAddressIsCorrect("United States")
                .AssertAddressIsCorrect("12345");

            AddressPage.Actions()
                .GoToShipping();

            ShippingPage.Actions()
                .AcceptTerms()
                .GoToPayment();

            PaymentPage.Verify()
                .PriceIsCorrect("$18.51");

            PaymentPage.Actions()
                .GoToPayBank();

            OrderPage.Actions().ConfirmOrder();

            OrderPage.Verify().ConfirmationMessageIsDisplayed();
        }

    }
}

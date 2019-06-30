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

namespace FluenteInterface.Tests
{
    [TestClass]
    public class TestShop : TestBase
    {
        public HomePage HomePage => new HomePage();


        [TestMethod]
        public void LogoIsDisplayed()
        {
            //Arrange
            HomePage.Actions()
                .GoToUrl();

            //Act

            HomePage.Actions();


            //Assert
            HomePage.Verify()
                 .LogoIsDisplayed()
                 .Should()
                 .BeTrue();
        }

    }
}

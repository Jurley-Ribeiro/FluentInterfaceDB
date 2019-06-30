using FluenteInterface.WebDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FluenteInterface.Tests
{
    [TestClass]
    public class TestBase
    {
        private IWebDriver Driver => DriverFactory.GetDriver();

        [TestCleanup]
        public void DoCleanup()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }


    }
}

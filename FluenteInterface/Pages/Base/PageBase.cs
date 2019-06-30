using FluenteInterface.WebDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages
{
    public class PageBase
    {
        public string BaseAddress => Environments.Environment.Application;

        public IWebDriver Driver => DriverFactory.GetDriver();

    }
}

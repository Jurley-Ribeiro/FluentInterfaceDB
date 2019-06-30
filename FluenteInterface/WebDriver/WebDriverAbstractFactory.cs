using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.WebDriver
{
    public abstract class WebDriverAbstractFactory
    {
        protected IWebDriver driver;

        public WebDriverAbstractFactory()
        {
            SetDriverOptions();
            CreateDriver();
            MaximizeWindow();
            SetTimeouts();
        }

        private void SetTimeouts()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        private void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        protected abstract void SetDriverOptions();
        protected abstract void CreateDriver();
    }
}

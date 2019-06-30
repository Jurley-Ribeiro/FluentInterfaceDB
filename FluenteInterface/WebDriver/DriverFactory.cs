using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.WebDriver
{
    public static class DriverFactory
    {
        private static IWebDriver driver;

        public static string Browser { get; set; }


        public static IWebDriver GetDriver()
        {
            //C# Null Coalescing Operator  - create with null
            return driver ?? (driver = CreateDriver());
        } 

        private static IWebDriver CreateDriver()
        {
            if (string.IsNullOrEmpty(Browser)) throw new ArgumentNullException("Browser can't not be Empty.");

            if (Browser == "Chrome")
            {
                return new ChromeFactory().GetDriver();
            }
            else
            {
                throw new ArgumentException($"{Browser} is not a valid value. Provide a valid value.");
            } 
        }
    }
}

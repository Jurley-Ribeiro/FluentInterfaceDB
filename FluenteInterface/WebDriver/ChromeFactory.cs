using OpenQA.Selenium.Chrome;

namespace FluenteInterface.WebDriver
{
    public class ChromeFactory : WebDriverAbstractFactory
    {
        private ChromeOptions options;

        protected override void CreateDriver()
        {
            driver = new ChromeDriver(options);
        }

        protected override void SetDriverOptions()
        {
            options = new ChromeOptions();
        }
    }
}
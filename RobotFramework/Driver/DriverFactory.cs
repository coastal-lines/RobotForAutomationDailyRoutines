using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace RobotFramework.Driver
{
    public class DriverFactory
    {
        public IWebDriver CreateDriver(Browser browser = Browser.Chrome)
        {
            IWebDriver driver = null;

            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    break;

                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    break;
            }

            return driver;
        }
    }
}
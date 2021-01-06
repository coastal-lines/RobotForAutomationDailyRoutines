using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace RobotFramework.Driver
{
    public class DriverFactory
    {
        public IWebDriver CreateDriver(IWebDriver driver, Browser browser = Browser.Chrome)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver(ConfigurationManager.AppSettings["PathDriver"]);
                    //driver = new ChromeDriver("/home/user/Desktop/Project/Driver/");
                    break;

                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    break;
            }

            return driver;
        }
    }
}
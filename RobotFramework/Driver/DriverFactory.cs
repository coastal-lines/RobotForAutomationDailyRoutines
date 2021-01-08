using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace RobotFramework.Driver
{
    public class DriverFactory
    {
        private IWebDriver driver;

        public IWebDriver CreateDriver(Browser browser = Browser.Chrome)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver(@"C:\Repos\MyGit\Robot\RobotFramework\bin\Debug\netcoreapp2.1");
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
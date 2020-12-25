using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace RobotFramework.Driver
{
    public class DriverFactory
    {
        public IWebDriver CreateDriver(IWebDriver driver, Browser browser = Browser.Chrome)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver(@"C:\Repos\MyGit\Robot\RobotFramework\bin\Debug\netcoreapp2.1\");
                    break;

                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    break;
            }

            return driver;
        }
    }
}
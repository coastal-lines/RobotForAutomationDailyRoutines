using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RobotFramework.Driver;
using RobotFramework.Utils;
using RobotFramework.Waits;

namespace RobotFramework.BasePage
{
    public class MainClass
    {
        private static IWebDriver driver;
        private DriverClass driverClass;

        private WaitMethods WaitMethods;

        public void StartDriverWorkflow()
        {
            driverClass = new DriverClass();
            driver = driverClass.CreateDriver();
        }
        
        public WaitMethods GetWaitMethods()
        {
            if (WaitMethods != null)
            {
                return this.WaitMethods;
            }
            else
            {
                WaitMethods = new WaitMethods(driver);
                return WaitMethods;
            }
        }
        
        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = driverClass.CreateDriver();
                return driver;
            }
            else
            {
                return driver;
            }
        }
    }
}
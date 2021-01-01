using OpenQA.Selenium;
using RobotFramework.Driver;
using RobotFramework.Waits;
using SeleniumExtras.PageObjects;

namespace RobotFramework.BasePage
{
    public class MainClass
    {
        private IWebDriver driver;
        private WaitMethods WaitMethods;
        private DriverClass driverClass;

        public void StartDriverWorkflow()
        {
            driverClass = new DriverClass();
            driver = driverClass.CreateDriver(this.driver);
            //WaitMethods = new WaitMethods();
        }
        
        public WaitMethods GetWaitMethods()
        {
            if (WaitMethods != null)
            {
                return this.WaitMethods;
            }
            else
            {
                WaitMethods = new WaitMethods(this.driver);
                return WaitMethods;
            }
        }
        
        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                this.driver = driverClass.CreateDriver(this.driver);
                return driver;
            }
            else
            {
                return driver;
            }
        }
    }
}
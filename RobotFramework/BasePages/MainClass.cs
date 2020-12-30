using OpenQA.Selenium;
using RobotFramework.Driver;
using RobotFramework.Waits;
using SeleniumExtras.PageObjects;

namespace RobotFramework.BasePage
{
    public class MainClass : DriverClass
    {
        private IWebDriver driver;
        private WaitMethods waitMethods;

        public void StartDriverWorkflow()
        {
            driver = GetDriver();
            waitMethods = new WaitMethods(driver);
        }

        public WaitMethods GetWaitMethods()
        {
            return this.waitMethods;
        }
    }
}
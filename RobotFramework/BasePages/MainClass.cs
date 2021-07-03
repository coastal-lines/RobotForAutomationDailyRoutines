using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RobotFramework.Driver;
using RobotFramework.Utils;
using RobotFramework.Waits;
using System.Diagnostics;

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

        public void TeadDownDriver()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();

            //TODO
            //Linux?????
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }

            //TODO
            //Linux?????
            //Process dotnetProcesses = Process.GetProcessesByName("dotnet")[0];
            //dotnetProcesses.Kill();

            //TODO
            //add firefox driver
        }
    }
}
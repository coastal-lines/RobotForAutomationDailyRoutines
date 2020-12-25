using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RobotFramework.Driver
{
    public class DriverClass : DriverFactory
    {
        private IWebDriver driver;

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                CreateDriver();
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

            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }

            //TODO
            //add firefox driver
        }
    }
}

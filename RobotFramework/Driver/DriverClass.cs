using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RobotFramework.Driver
{
    public class DriverClass : DriverFactory
    {

        //TODO
        //This class probably should be for Driver Parameters and ETC

        private IWebDriver driver;

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
            Process dotnetProcesses = Process.GetProcessesByName("dotnet")[0];
            dotnetProcesses.Kill();

            //TODO
            //add firefox driver
        }
    }
}

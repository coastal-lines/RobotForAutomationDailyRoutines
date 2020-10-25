using OneMoreCSharpFramework.src.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace OneMoreCSharpFramework.src.driver
{
    public class DriverClass
    {
        private static IWebDriver driver;

        public DriverClass()
        {

        }

        public static IWebDriver StartDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(Environment.CurrentDirectory);
                return driver;
            }
            else
            {
                return driver;
            }
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public void CloseDriverProcess()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();

            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
    }
}
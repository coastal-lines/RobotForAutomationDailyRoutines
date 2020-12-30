using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RobotFramework.Driver;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFramework.Waits
{
    public class WaitMethods
    {
        private IWebDriver driver;
        private const int ExplicitWaitingTime = 10;

        public WaitMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitElement(IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(ExplicitWaitingTime));
            wait.Until(d => element.Displayed);
        }
    }
}
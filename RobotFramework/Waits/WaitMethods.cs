﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RobotFramework.Driver;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFramework.Waits
{
    public class WaitMethods : DriverClass
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
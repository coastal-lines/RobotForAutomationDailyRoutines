using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RobotFramework.BasePage;
using RobotFramework.Driver;
using RobotFramework.Waits;
using SeleniumExtras.PageObjects;

namespace RobotFramework.BasePages
{
    public class PageObject : MainClass
    {
        private WaitMethods wait;
        private IWebDriver driver;

        public PageObject(IWebDriver driver, WaitMethods wait)
        {
            this.wait = wait;
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public WaitMethods Waits
        {
            get
            {
                return wait;
            }
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
    }
}
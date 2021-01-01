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
    public class PageObject
    {
        private WaitMethods wait;

        public PageObject(IWebDriver driver, WaitMethods wait)
        {
            this.wait = wait;
            PageFactory.InitElements(driver, this);
        }

        public WaitMethods Waits
        {
            get
            {
                return wait;
            }
        }
    }
}
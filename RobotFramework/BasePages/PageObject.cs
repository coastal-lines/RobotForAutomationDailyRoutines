using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RobotFramework.BasePages
{
    public class PageObject
    {
        public PageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
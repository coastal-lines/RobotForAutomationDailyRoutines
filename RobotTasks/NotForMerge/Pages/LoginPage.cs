using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RobotFramework.BasePage;
using RobotFramework.Driver;
using RobotFramework.Waits;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotTasks.NotForMerge.Pages
{
    public class LoginPage : PageObject
    {
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement UserLogin { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }


    }
}

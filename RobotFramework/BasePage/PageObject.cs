using OpenQA.Selenium;
using RobotFramework.Waits;
using SeleniumExtras.PageObjects;

namespace RobotFramework.BasePage
{
    public class PageObject : WaitMethods
    {
        public PageObject(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
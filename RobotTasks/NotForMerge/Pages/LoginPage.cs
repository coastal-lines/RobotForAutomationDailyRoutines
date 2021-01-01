using OpenQA.Selenium;
using RobotFramework.BasePage;
using RobotFramework.BasePages;
using RobotFramework.Waits;
using SeleniumExtras.PageObjects;

namespace RobotTasks.NotForMerge.Pages
{
    public class LoginPage : PageObject
    {
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement InputLogin { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement InputPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Login']")]
        public IWebElement ButtonLogin { get; set; }        

        public LoginPage(IWebDriver driver, WaitMethods Waits) : base(driver, Waits)
        {
            
        }
        
        public void EnterIntoServer()
        {
            Waits.WaitElement(InputLogin);
            InputLogin.SendKeys("superuser");
            Waits.WaitElement(InputPassword);
            InputPassword.SendKeys("456789");
            Waits.WaitElement(ButtonLogin);
            ButtonLogin.Click();
        }
    }
}

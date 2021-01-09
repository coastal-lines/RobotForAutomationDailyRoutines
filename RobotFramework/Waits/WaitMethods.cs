using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RobotFramework.BasePage;
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

        //TODO combine with just WAITELEMENT
        public void WaitElementAppear(IWebElement element, int timer = 2)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timer));
                wait.Until(d => element.Displayed);
            }
            catch (NoSuchElementException er)
            {
                Console.WriteLine(er.Message);
            }
            catch (WebDriverTimeoutException er)
            {
                Console.WriteLine(er.Message);
            }
            catch(StaleElementReferenceException er)
            {
                Console.WriteLine(er.Message);
            }
            catch(NotFoundException er)
            {
                Console.WriteLine(er.Message);
            }
        }

        public void WaitElementClickable(IWebElement element, int timer = 2)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timer));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}
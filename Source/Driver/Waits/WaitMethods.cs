using OneMoreCSharpFramework.src.driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneMoreCSharpFramework.Source.Driver.Waits
{
    public class WaitMethods : DriverClass
    {
        private WebDriverWait wait;
        private IWebDriver driver;

        public WaitMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitElement(IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(
                driver =>
                {
                    try
                    {
                        return element.Displayed;
                    }

                    catch (NoSuchElementException er)
                    {
                        Console.WriteLine(er.Message);
                    }
                    return false;
                });
        }
    }
}
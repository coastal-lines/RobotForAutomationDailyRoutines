using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OneMoreCSharpFramework.src.pages
{
    public class PentaPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "main_search")]
        private IWebElement InputFind { get; set; }

        public void Search()
        {
            driver.Navigate().GoToUrl("https://www.penta-club.ru/forum/");
            WaitMethods.WaitElement(InputFind);
            InputFind.Click();
            InputFind.SendKeys("12345");
        }
    }
}
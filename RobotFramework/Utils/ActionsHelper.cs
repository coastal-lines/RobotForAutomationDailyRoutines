using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFramework.Utils
{
    public static class ActionsHelper
    {
        private static Actions action;

        public static void PressKeyboardButton(IWebDriver driver, string key)
        {
            action = new Actions(driver);
            action.KeyDown(key).Build().Perform();
        }
    }
}

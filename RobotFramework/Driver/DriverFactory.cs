using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFramework.Driver
{
    class DriverFactory
    {
        public void CreateDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    break;

                case Browser.Firefox:
                    break;
            }
        }
    }
}
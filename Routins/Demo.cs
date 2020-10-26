using OneMoreCSharpFramework.src.driver;
using OneMoreCSharpFramework.src.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneMoreCSharpFramework.routins
{
    public class Demo 
    {
        public void MyTest()
        {
            PentaPage p = new PentaPage();
            p.Search();
        }
    }
}

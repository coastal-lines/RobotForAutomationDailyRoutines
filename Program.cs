using OneMoreCSharpFramework.routins;
using OneMoreCSharpFramework.src.driver;
using OneMoreCSharpFramework.src.pages;
using System;

namespace OneMoreCSharpFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverClass.StartDriver();
            Demo d = new Demo();
            d.MyTest();
        }
    }
}
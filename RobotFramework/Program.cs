using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RobotFramework.Driver;
using System;
using System.IO;
using System.Text;

namespace RobotFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DirectoryInfo d = new DirectoryInfo(@"c:\Temp2\FilesForRobot\Files\All\GroupImg\2\");
            FileInfo[] files = d.GetFiles();

            StringBuilder sb = new StringBuilder();
            foreach (var f in files)
            {
                sb.AppendLine(f.FullName);
                sb.Append(" ");
            }



            //DriverFactory dr = new DriverFactory();
            //dr.CreateDriver();
        }
    }
}
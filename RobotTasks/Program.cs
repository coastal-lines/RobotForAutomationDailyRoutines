using RobotFramework;
using System;

namespace RobotTasks
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Temp t = new Temp();
            t.Demo();
        }
    }

    class Temp : RobotBase
    {
        public void OpenMediaLibrary()
        {

        }

        public void Demo()
        {
            GetDriver().Navigate().GoToUrl("https://www.penta-club.ru/forum/");
            GetDriver().Navigate().GoToUrl("https://metanit.com/sharp/patterns/2.3.php");
            TeadDownDriver();
        }
    }
}
using RobotFramework;
using System;

namespace RobotTasks
{
    class Program : RobotBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Temp t = new Temp();
            t.Demo();
        }
    }

    class Temp
    {
        public void Demo()
        {

        }
    }
}

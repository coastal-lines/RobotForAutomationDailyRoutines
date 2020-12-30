using RobotFramework;
using RobotFramework.BasePage;
using RobotTasks.NotForMerge.Pages;
using RobotTasks.NotForMerge.Tasks;
using System;

namespace RobotTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //only for debugging - all methdos should be run by API
            MediaLibraryTasks m = new MediaLibraryTasks();
            m.OpenMediaLibrary();
        }
    }
}
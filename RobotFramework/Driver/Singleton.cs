using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFramework.Driver
{
    class Singleton
    {
        private static Singleton single;

        private Singleton()
        {

        }

        private static Singleton GetSingletonInstance()
        {
            if (single == null)
            {
                single = new Singleton();
            }

            return single;
        }
    }
}

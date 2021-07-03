using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RobotFramework.Utils
{
    public static class RegexpHelper
    {
        public static string Matching(string what, string where, int group)
        {
            var regex = new Regex(what);
            var matches = regex.Matches(where);

            return matches[0].Groups[group].Value;
        }

        public static string Matching(string what, string where)
        {
            var regex = new Regex(what);
            var matches = regex.Matches(where);

            return matches[0].Value;
        }
    }
}

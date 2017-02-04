using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.UserVillages
{
    class FindBuildqueue
    {
        public static int findqueue(string response)
        {
            var buildqueue = FindInfo(response, @"BuildingMain.order_count = (.*?);");
            if (buildqueue == string.Empty)
            {
                return 0;
            }
            else
            {
                return int.Parse(buildqueue, CultureInfo.InvariantCulture);
            }
        }

        public static string FindInfo(string content, string toFind)
        {
            Match match = Regex.Match(content, toFind);
            if (!match.Success)
                return "";
            return match.Groups[1].Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.BuildQueue
{
    class TimeFinder
    {
        public static double finder(string target)
        {
            string strRegex = @"""date_complete"":(.*?),";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = target;
            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    return double.Parse(myMatch.Groups[1].Value, CultureInfo.InvariantCulture);
                }
            }
            return 0;
        }

        public static string idfinder(string target)
        {
            string strRegex = @"BuildingMain.change_order\S(.*?), 'BuildTimeReduction'";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = target;
            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    return myMatch.Groups[1].Value;
                }
            }
            return "0";
        }
    }
}

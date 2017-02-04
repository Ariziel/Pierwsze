using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.Attack
{
    class FindServerUTC
    {
        public static string utc(string target)
        {
            string strRegex = @"var server_utc_diff = (.*?);" + "\n";
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

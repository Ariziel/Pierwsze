using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.Attack
{
    class RegexFindCHandAction
    {
        public static string FindCH(string response)
        {
            string strRegex = @"name=""ch"" value=""(.*?)""";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = response;

            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    return myMatch.Groups[1].Value;
                }
            }
            return "0";
        }

        public static string FindAction(string response)
        {
            string strRegex = @"name=""action_id"" value=""(.*?)""";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = response;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.PremiumFarming
{
    class GetTargets
    {
        public static List<string> Targets(string response, List<string> Lista)
        {
            string strRegex = @"tr id=""village_(.*?)""";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = response;
            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    Lista.Add(myMatch.Groups[1].Value);
                }
            }
            return Lista;
        }
    }
}

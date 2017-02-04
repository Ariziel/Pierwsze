using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.UserVillages
{
    class FindVillages
    {
        public static void find(string target)
        {
            string strRegex = @"data-id=""(.*?)""";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = target;

            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    MainWindow.MyvillOnlyID.Add(myMatch.Groups[1].Value);
                }
            }

        }
    }
}

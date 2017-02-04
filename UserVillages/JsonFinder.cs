using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.UserVillages
{
    class JsonFinder
    {
        public static string Jsonfind(string response)
        {
            string strRegex = @"TribalWars.updateGameData\S(.*?)}\S;";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            foreach (Match myMatch in myRegex.Matches(response))
            {
                if (myMatch.Success)
                {
                    var fix = "}";
                    return myMatch.Groups[1].Value + fix;
                }
            }
            return "error";
        }

        public static string FindJsonBuildings(string response)
        {
            string strRegex = @"BuildingMain.buildings = (.*?)};";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            foreach (Match myMatch in myRegex.Matches(response))
            {
                if (myMatch.Success)
                {
                    var fix = "}";
                    return myMatch.Groups[1].Value + fix;
                }
            }
            return "error";
        }
    }
}

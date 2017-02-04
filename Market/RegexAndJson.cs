using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SilverBot.UserVillages;

namespace SilverBot.Market
{
    class RegexAndJson
    {
        public static string GetJson(string response)
        {
            string strRegex = @"PremiumExchange.receiveData\S(.*?)\S;";
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

        public static void SerialiseJson(string target)
        {
            var temp = JsonConvert.DeserializeObject<SilverBot.Structure.User.Market.MarketStructure.RootObject>(target);
            StaticVariables.MarketStructures.Add(temp);
        }

        public static string RateFinder(string response)
        {
            string strRegex = @"""rate_hash"":""(.*?)""";
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

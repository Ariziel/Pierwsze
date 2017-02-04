using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.AttackDetector
{
    class FindAttackRegex
    {
        public static void Find(string target, string idvillage)
        {
            string strRegex = @"<td><span class=""widget-command-timer"" data-endtime=""(.*?)""";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = target;
            double landtime = 0;
            string id = "";
            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    landtime = double.Parse(myMatch.Groups[1].Value, CultureInfo.InvariantCulture);
                    id = idvillage;
                }
            }
            if (StaticVariables.Incomingattacks.Count == 0)
            {
                StaticVariables.Incomingattacks.Add(new Structure()
                {
                    idvillage = id,
                    LandTime = landtime
                });
            }
            else
            {
                foreach (var VARIABLE in StaticVariables.Incomingattacks)
                {
                    if (VARIABLE.LandTime != landtime)
                    {
                        StaticVariables.Incomingattacks.Add(new Structure()
                        {
                            idvillage = id,
                            LandTime = landtime
                        });
                    }
                }
            }
        }
    }
}

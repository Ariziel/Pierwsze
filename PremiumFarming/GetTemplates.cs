using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.PremiumFarming
{
    class GetTemplates
    {
        public static void regexTemplateFinder(string response)
        {
            string strRegex = @"Accountmanager.farm.templates\S't_(.*?)'";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = response;

            foreach (Match myMatch in myRegex.Matches(strTargetString))
            {
                if (myMatch.Success)
                {
                    StaticVariables.Templates.Add(myMatch.Groups[1].Value);
                }
            }
            StaticVariables.Templates = StaticVariables.Templates.Distinct().ToList();
        }
    }
}

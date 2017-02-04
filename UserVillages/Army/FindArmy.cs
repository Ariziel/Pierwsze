using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.UserVillages
{
    class FindArmy
    {
        public static string GetDetailsSpear(string document)
        {
            var spear = FindInfo(document, @"class='unit-item unit-item-spear' >(.*?)</td>");
            if (spear == string.Empty)
            {
                return "0";
            }
            else
            {
                return spear;
            }
        }

        public static string GetDetailsSword(string document)
        {
            var sword = FindInfo(document, @"class='unit-item unit-item-sword' >(.*?)</td>");
            if (sword == string.Empty)
            {
                return "0";
            }
            else
            {
                return sword;
            }
        }

        public static string GetDetailsAxe(string document)
        {
            var Axe = FindInfo(document, @"class='unit-item unit-item-axe' >(.*?)</td>");
            if (Axe == string.Empty)
            {
                return "0";
            }
            else
            {
                return Axe;
            }
        }

        public static string GetDetailsArcher(string document)
        {
            var Archer = FindInfo(document, @"class='unit-item unit-item-archer' >(.*?)</td>");
            if (Archer == string.Empty)
            {
                return "0";
            }
            else
            {
                return Archer;
            }
        }

        public static string GetDetailsSpy(string document)
        {
            var Spy = FindInfo(document, @"class='unit-item unit-item-spy' >(.*?)</td>");
            if (Spy == string.Empty)
            {
                return "0";
            }
            else
            {
                return Spy;
            }
        }

        public static string GetDetailsLight(string document)
        {
            var Light = FindInfo(document, @"class='unit-item unit-item-light' >(.*?)</td>");
            if (Light == string.Empty)
            {
                return "0";
            }
            else
            {
                return Light;
            }
        }

        public static string GetDetailsMarcher(string document)
        {
            var Marcher = FindInfo(document, @"class='unit-item unit-item-marcher' >(.*?)</td>");
            if (Marcher == string.Empty)
            {
                return "0";
            }
            else
            {
                return Marcher;
            }
        }

        public static string GetDetailsHeavy(string document)
        {
            var Heavy = FindInfo(document, @"class='unit-item unit-item-heavy' >(.*?)</td>");
            if (Heavy == string.Empty)
            {
                return "0";
            }
            else
            {
                return Heavy;
            }
        }

        public static string GetDetailsRam(string document)
        {
            var Ram = FindInfo(document, @"class='unit-item unit-item-ram' >(.*?)</td>");
            if (Ram == string.Empty)
            {
                return "0";
            }
            else
            {
                return Ram;
            }
        }

        public static string GetDetailsCatapult(string document)
        {
            var Catapult = FindInfo(document, @"class='unit-item unit-item-catapult' >(.*?)</td>");
            if (Catapult == string.Empty)
            {
                return "0";
            }
            else
            {
                return Catapult;
            }
        }

        public static string GetDetailsKnight(string document)
        {
            var Knight = FindInfo(document, @"class='unit-item unit-item-knight' >(.*?)</td>");
            if (Knight == string.Empty)
            {
                return "0";
            }
            else
            {
                return Knight;
            }
        }

        public static string GetDetailsSnob(string document)
        {
            var Snob = FindInfo(document, @"class='unit-item unit-item-snob' >(.*?)</td>");
            if (Snob == string.Empty)
            {
                return "0";
            }
            else
            {
                return Snob;
            }
        }

        public static string GetDetailsMilitia(string document)
        {
            var Militia = FindInfo(document, @"class='unit-item unit-item-militia' >(.*?)</td>");
            if (Militia == string.Empty)
            {
                return "0";
            }
            else
            {
                return Militia;
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Attack
{
    class RoadTime
    {
        public static DateTime Road(bool spear, bool sword, bool axe, bool archer, bool spy, bool light, bool marcher, bool heavy, bool ram, bool catapult, bool knight, bool snob, int sx, int sy, int dx, int dy)
        {
            double speed = 0;
            if (spy)
            {
                speed = 9;
            }
            if (light || marcher || knight)
            {
                speed = 10;
            }
            if (heavy)
            {
                speed = 11;
            }
            if (spear || axe || archer)
            {
                speed = 18;
            }
            if (sword)
            {
                speed = 22;
            }
            if (ram || catapult)
            {
                speed = 30;
            }
            if (snob)
            {
                speed = 35;
            }
            speed /= double.Parse(StaticVariables.WorldSettings.Unit_speed, CultureInfo.InvariantCulture);
            speed /= double.Parse(StaticVariables.WorldSettings.Speed, CultureInfo.InvariantCulture);
            double dist = Math.Sqrt(Math.Pow(sx - dx, 2) + Math.Pow(sy - dy, 2));
            dist = Math.Round(dist, 3);
            double arrival_time = (speed * dist * 60 * 1000);
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(arrival_time).ToLocalTime();
            Console.WriteLine("Army road time in UNIX: " + arrival_time);
            return dtDateTime;
        }
    }
}

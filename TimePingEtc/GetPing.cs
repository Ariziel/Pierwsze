using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SilverBot.TimePingEtc
{
    class GetPing
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static long GetCurrentUnixTimestampMillis()
        {
            return (long)(DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }
        public static long MyTimeUnix = GetCurrentUnixTimestampMillis();
        public static long ServerTimeUnix = 0;
        public static long TimeDiffrence = 0;
        public static long Ping = 0;
        public static List<long> PingList = new List<long>();
        public static List<long> TimeDiffList = new List<long>();
        public static async Task Sync(string VillageID)
        {

            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server+ "/game.php?village=" + VillageID + "&screen=map");
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");

                for (int i = 0; i < 10; i++)
                {
                    Stopwatch s = Stopwatch.StartNew();
                    var response = await client.GetStringAsync(url);
                    string strRegex = @"""time_generated"":(.*?)}";
                    Regex myRegex = new Regex(strRegex, RegexOptions.None);
                    string strTargetString = response;

                    foreach (Match myMatch in myRegex.Matches(strTargetString))
                    {
                        if (myMatch.Success)
                        {
                            ServerTimeUnix = long.Parse(myMatch.Groups[1].Value, CultureInfo.InvariantCulture);
                        }
                    }

                    //timediff
                    MyTimeUnix = GetCurrentUnixTimestampMillis();
                    TimeDiffrence = MyTimeUnix - ServerTimeUnix;
                    TimeDiffList.Add(TimeDiffrence);

                    //ping
                    s.Stop();
                    Ping = s.ElapsedMilliseconds;
                    PingList.Add(Ping);
                    await Task.Delay(200);
                }
                foreach (var VARIABLE in PingList)
                {
                    Console.WriteLine("Ping: " + VARIABLE);
                }
                foreach (var VARIABLE in TimeDiffList)
                {
                    Console.WriteLine("TimeDiff: " + VARIABLE);
                }
                StaticVariables.TimeDiff = TimeDiffList.Average();
                StaticVariables.Ping = PingList.Average();
                Console.WriteLine("Avg ping: " + PingList.Average());
                Console.WriteLine("Avg time: " + TimeDiffList.Average());
            }
        }
    }
}

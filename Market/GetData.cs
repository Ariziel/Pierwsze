using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Market
{
    class GetData
    {
        public static async Task<string> CheckMarket(string source)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&mode=exchange");
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
    }
}

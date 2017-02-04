using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.UserVillages
{
    class ArmyRequest
    {
        public static async Task<string> Download(string id)
        {
            var Url = new Uri("http://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + id + "&screen=place&mode=units");
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(Url);
            using (var client = new HttpClient(handler))
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var result = await client.GetStringAsync(Url);
                return result;
            }
        }
    }
}

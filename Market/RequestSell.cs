using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Market
{
    class RequestSell
    {
        public static async Task<string> SellWoodFirst(string wood, string source)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&ajaxaction=exchange_begin&h=" + StaticVariables.MyVillages.FirstOrDefault().csrf + "&client_time=" + unixTimestamp);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var values = new Dictionary<string, string>
                {
                    {"sell_wood", wood}
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }
        public static async Task<string> SellWoodSecond(string wood, string source, string Rate_wood, string mb)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&ajaxaction=exchange_confirm&h=" + StaticVariables.MyVillages.FirstOrDefault().csrf + "&client_time=" + unixTimestamp);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var values = new Dictionary<string, string>
                {
                    {"rate_wood", Rate_wood},
                    {"sell_wood", wood},
                    {"mb", mb},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> SellStoneFirst(string stone, string source)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&ajaxaction=exchange_begin&h=" + StaticVariables.MyVillages.FirstOrDefault().csrf + "&client_time=" + unixTimestamp);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var values = new Dictionary<string, string>
                {
                    {"sell_stone", stone}
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }
        public static async Task<string> SellStoneSecond(string stone, string source, string Rate_stone, string mb)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&ajaxaction=exchange_confirm&h=" + StaticVariables.MyVillages.FirstOrDefault().csrf + "&client_time=" + unixTimestamp);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var values = new Dictionary<string, string>
                {
                    {"rate_stone", Rate_stone},
                    {"sell_stone", stone},
                    {"mb", mb},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> SellIronFirst(string iron, string source)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&ajaxaction=exchange_begin&h=" + StaticVariables.MyVillages.FirstOrDefault().csrf + "&client_time=" + unixTimestamp);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var values = new Dictionary<string, string>
                {
                    {"sell_iron", iron}
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }
        public static async Task<string> SellIronSecond(string iron, string source, string Rate_iron, string mb)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=market&ajaxaction=exchange_confirm&h=" + StaticVariables.MyVillages.FirstOrDefault().csrf + "&client_time=" + unixTimestamp);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                var values = new Dictionary<string, string>
                {
                    {"rate_iron", Rate_iron},
                    {"sell_iron", iron},
                    {"mb", mb},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}

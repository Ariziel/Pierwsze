using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.PremiumFarming
{
    class ChangeSettings
    {
        public static async Task<string> Settings1(string From, string allvillages)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + From + "&screen=am_farm&ajaxaction=toggle_show_all_villages&json=1&&h=" + StaticVariables.Token +"&client_time=" + unixTimestamp );
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
                     { "extended", "1" },
                     { "target_screen", "am_farm" },
                     { "all_villages", allvillages },
                    };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> Settings2(string From, string show_attacked)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + From + "&screen=am_farm&ajaxaction=toggle_show_attacked&json=1&&h=" + StaticVariables.Token + "&client_time=" + unixTimestamp);
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
                     { "extended", "1" },
                     { "target_screen", "am_farm" },
                     { "show_attacked", show_attacked },
                    };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> Settings3(string From, string toggle_only_full_hauls)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + From + "&screen=am_farm&ajaxaction=toggle_only_full_hauls&json=1&&h=" + StaticVariables.Token + "&client_time=" + unixTimestamp);
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
                     { "extended", "1" },
                     { "target_screen", "am_farm" },
                     { "only_full_hauls", toggle_only_full_hauls },
                    };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> Settings4(string From, string full_losses)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + From + "&screen=am_farm&ajaxaction=toggle_show_full_losses&json=1&&h=" + StaticVariables.Token + "&client_time=" + unixTimestamp);
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
                     { "extended", "1" },
                     { "target_screen", "am_farm" },
                     { "full_losses", full_losses },
                    };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task<string> Settings5(string From, string partial_losses)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + From + "&screen=am_farm&ajaxaction=toggle_show_partial_losses&json=1&&h=" + StaticVariables.Token + "&client_time=" + unixTimestamp);
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
                     { "extended", "1" },
                     { "target_screen", "am_farm" },
                     { "partial_losses", partial_losses },
                    };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }


        public static async Task<string> SettingsPageSize(string From, string Page)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + From + "&screen=am_overview&ajaxaction=set_page_size&h=" + StaticVariables.Token + "&client_time=" + unixTimestamp);
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
                     { "widget_id", "Farm" },
                     { "page_size", Page },
                    };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}

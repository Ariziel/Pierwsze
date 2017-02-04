using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Attack
{
    class SendAttack
    {
        public static async Task<string> FirstRequest(string source, string spear, string sword, string axe, string archer, string spy, string light, string marcher, string heavy, string ram, string catapult, string knight, string snob, string x, string y, string building)
        {
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=place&try=confirm");
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
                    {"c2993f1f859b5960b455da", "59d08f8fc2993f"},
                    {"template_id", ""},
                    {"source_village", source},
                    {"spear", spear},
                    {"sword", sword},
                    {"axe", axe},
                    {"archer", archer},
                    {"spy", spy},
                    {"light", light},
                    {"marcher", marcher},
                    {"heavy", heavy},
                    {"ram", ram},
                    {"catapult", catapult},
                    {"knight", knight},
                    {"snob", snob},
                    {"x", x},
                    {"y", y},
                    {"target_type", "coord"},
                    {"input", x + "|" + y},
                    {"attack", "true"},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();
                var ch = Attack.RegexFindCHandAction.FindCH(result);
                if (ch == "0")
                {
                    return "errorxd";
                }
                var action_id = Attack.RegexFindCHandAction.FindAction(result);
                return
                    await
                        SecondRequest(source, spear, sword, axe, archer, spy, light, marcher, heavy, ram, catapult,
                            knight, snob, x, y, ch, action_id, building);
            }
        }

        public static async Task<string> SecondRequest(string source, string spear, string sword, string axe, string archer, string spy, string light, string marcher, string heavy, string ram, string catapult, string knight, string snob, string x, string y, string ch, string action_id, string building)
        {
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=place&action=command&h=" + StaticVariables.Token);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                if (spear == "")
                {
                    spear = "0";
                }
                if (sword == "")
                {
                    sword = "0";
                }
                if (axe == "")
                {
                    axe = "0";
                }
                if (archer == "")
                {
                    archer = "0";
                }
                if (spy == "")
                {
                    spy = "0";
                }
                if (light == "")
                {
                    light = "0";
                }
                if (marcher == "")
                {
                    marcher = "0";
                }
                if (heavy == "")
                {
                    heavy = "0";
                }
                if (ram == "")
                {
                    ram = "0";
                }
                if (catapult == "")
                {
                    catapult = "0";
                }
                if (knight == "")
                {
                    knight = "0";
                }
                if (snob == "")
                {
                    snob = "0";
                }
                var values = new Dictionary<string, string>
                {
                    {"attack", "true"},
                    {"ch", ch},
                    {"x", x},
                    {"y", y},
                    {"source_village", source},
                    {"action_id", action_id},
                    {"spear", spear},
                    {"sword", sword},
                    {"axe", axe},
                    {"archer", archer},
                    {"spy", spy},
                    {"light", light},
                    {"marcher", marcher},
                    {"heavy", heavy},
                    {"ram", ram},
                    {"catapult", catapult},
                    {"knight", knight},
                    {"snob", snob},
                    {"building", building.ToLower()},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }

        public static async Task<string> FirstRequestSupport(string source, string spear, string sword, string axe, string archer, string spy, string light, string marcher, string heavy, string ram, string catapult, string knight, string snob, string x, string y, string building)
        {
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=place&try=confirm");
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
                    {"c2993f1f859b5960b455da", "59d08f8fc2993f"},
                    {"template_id", ""},
                    {"source_village", source},
                    {"spear", spear},
                    {"sword", sword},
                    {"axe", axe},
                    {"archer", archer},
                    {"spy", spy},
                    {"light", light},
                    {"marcher", marcher},
                    {"heavy", heavy},
                    {"ram", ram},
                    {"catapult", catapult},
                    {"knight", knight},
                    {"snob", snob},
                    {"x", x},
                    {"y", y},
                    {"target_type", "coord"},
                    {"input", x + "|" + y},
                    {"support", "true"},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();
                var ch = Attack.RegexFindCHandAction.FindCH(result);
                var action_id = Attack.RegexFindCHandAction.FindAction(result);
                return
                    await
                        SecondRequestSupport(source, spear, sword, axe, archer, spy, light, marcher, heavy, ram, catapult,
                            knight, snob, x, y, ch, action_id, building);
            }
        }

        public static async Task<string> SecondRequestSupport(string source, string spear, string sword, string axe, string archer, string spy, string light, string marcher, string heavy, string ram, string catapult, string knight, string snob, string x, string y, string ch, string action_id, string building)
        {
            HttpClientHandler handler = new HttpClientHandler();
            Uri url = new Uri("https://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/game.php?village=" + source + "&screen=place&action=command&h=" + StaticVariables.Token);
            handler.CookieContainer = Cookies.Cookie.GetUriCookieContainer(url);
            using (var client = new HttpClient(handler))
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                if (spear == "")
                {
                    spear = "0";
                }
                if (sword == "")
                {
                    sword = "0";
                }
                if (axe == "")
                {
                    axe = "0";
                }
                if (archer == "")
                {
                    archer = "0";
                }
                if (spy == "")
                {
                    spy = "0";
                }
                if (light == "")
                {
                    light = "0";
                }
                if (marcher == "")
                {
                    marcher = "0";
                }
                if (heavy == "")
                {
                    heavy = "0";
                }
                if (ram == "")
                {
                    ram = "0";
                }
                if (catapult == "")
                {
                    catapult = "0";
                }
                if (knight == "")
                {
                    knight = "0";
                }
                if (snob == "")
                {
                    snob = "0";
                }
                var values = new Dictionary<string, string>
                {
                    {"support", "true"},
                    {"ch", ch},
                    {"x", x},
                    {"y", y},
                    {"source_village", source},
                    {"action_id", action_id},
                    {"spear", spear},
                    {"sword", sword},
                    {"axe", axe},
                    {"archer", archer},
                    {"spy", spy},
                    {"light", light},
                    {"marcher", marcher},
                    {"heavy", heavy},
                    {"ram", ram},
                    {"catapult", catapult},
                    {"knight", knight},
                    {"snob", snob},
                    {"building", building.ToLower()},
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
    }
}

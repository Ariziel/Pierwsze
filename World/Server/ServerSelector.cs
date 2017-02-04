using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.World
{
    class ServerSelector
    {
        public static string Server(string server)
        {
            switch (server)
            {
                case "plemiona.pl":
                    return "pl";
                case "die-staemme.de":
                    return "de";
                case "tribalwars.net":
                    return "en";
                case "staemme.ch":
                    return "ch";
                case "tribalwars.nl":
                    return "nl";
                case "tribalwars.se":
                    return "sv";
                case "tribalwars.com.br":
                    return "br";
                case "tribalwars.com.pt":
                    return "pt";
                case "divokekmeny.cz":
                    return "cs";
                case "triburile.ro":
                    return "ro";
                case "voyna-plemyon.ru":
                    return "ru";
                case "fyletikesmaxes.gr":
                    return "gr";
                case "tribalwars.no.com":
                    return "no";
                case "divoke-kmene.sk":
                    return "sk";
                case "klanhaboru.hu":
                    return "hu";
                case "tribalwars.dk":
                    return "dk";
                default:
                    break;
            }
            return "ServerMissing";
        }
    }
}

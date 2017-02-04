using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SilverBot.World
{
    class DownloadWorldSettings
    {
        public static async Task World()
        {
            var Url = "http://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/interface.php?func=get_config";
            var Url2 = "http://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/interface.php?func=get_building_info";
            var Url3 = "http://" + StaticVariables.ServerShort + StaticVariables.World + "." + StaticVariables.Server + "/interface.php?func=get_unit_info";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json, text/javascript, */*; q=0.01");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");

                var result = await client.GetStringAsync(Url);
                byte[] byteArray = Encoding.UTF8.GetBytes(result);
                MemoryStream stream = new MemoryStream(byteArray);
                XmlSerializer serializer = new XmlSerializer(typeof(World.WorldStructure.Config));
                var deserialized2 = (World.WorldStructure.Config)serializer.Deserialize(stream);
                StaticVariables.WorldSettings = deserialized2;


                var result2 = await client.GetStringAsync(Url2);
                byte[] byteArray2 = Encoding.UTF8.GetBytes(result2);
                MemoryStream stream2 = new MemoryStream(byteArray2);
                XmlSerializer serializer2 = new XmlSerializer(typeof(World.WorldBuildStructure.Config));
                var deserialized = (World.WorldBuildStructure.Config)serializer2.Deserialize(stream2);
                StaticVariables.WorldSettingsBuildings = deserialized;


                var result3 = await client.GetStringAsync(Url3);
                byte[] byteArray3 = Encoding.UTF8.GetBytes(result3);
                MemoryStream stream3 = new MemoryStream(byteArray3);
                XmlSerializer serializer3 = new XmlSerializer(typeof(World.WorldUnitStructure.Config));
                var deserialized3 = (World.WorldUnitStructure.Config)serializer3.Deserialize(stream3);
                StaticVariables.WorldUnitInfo = deserialized3;
            }
        }
    }
}

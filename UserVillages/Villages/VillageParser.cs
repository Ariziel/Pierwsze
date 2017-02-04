using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SilverBot.UserVillages
{
    class VillageParser
    {
        public static async Task<VillageStructure.Example> Parser(string Response)
        {

            var temp = JsonConvert.DeserializeObject<VillageStructure.Example>(Response, new JsonSerializerSettings
            {
                Error = HandleDeserializationError
            });
            //StaticVariables.MyVillages.Add(temp);
            return temp;
        }

        public static async Task<VillageStructure.RootObject> ParserBuild(string Response)
        {
            //Console.WriteLine(Response);
            var temp = JsonConvert.DeserializeObject<VillageStructure.RootObject>(Response, new JsonSerializerSettings
            {
                Error = HandleDeserializationError
            });
            //StaticVariables.MyVillagesBuildings.Add(temp);
            return temp;
        }

        private static void HandleDeserializationError(object sender, ErrorEventArgs e)
        {
            var currentError = e.ErrorContext.Error.Message;
            MessageBox.Show(currentError);
        }
    }
}

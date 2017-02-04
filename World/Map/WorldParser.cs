using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.World
{
    class WorldParser
    {
        public static async Task Parser()
        {
            List<string> OneVillage = new List<string>();
            using (StringReader reader = new StringReader(StaticVariables.WorldNotParsed))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int end = 0;
                    string Content = string.Empty;
                    foreach (char item in line)
                    {
                        if (end == 6)
                        {
                            StaticVariables.WorldVillages.Add(new World.WorldVillagesStructure { ID = OneVillage.ElementAt(0), Name = OneVillage.ElementAt(1), X = OneVillage.ElementAt(2), Y = OneVillage.ElementAt(3), IDPlayer = OneVillage.ElementAt(4), Points = OneVillage.ElementAt(5) });
                            OneVillage.Clear();
                            break;
                        }
                        if (item != ',')
                        {
                            Content += item;
                        }
                        else
                        {
                            OneVillage.Add(Content);
                            Content = string.Empty;
                            end++;
                        }

                    }
                }
            }
        }
    }
}

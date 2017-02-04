using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilverBot.World;

namespace SilverBot.Farming
{
    public class FarmingTemplateStructure
    {
        public string Name { get; set; }
        public bool Barbarian { get; set; }
        public double PointsMin { get; set; }
        public double PointsMax { get; set; }
        public double Radius { get; set; }
        public int Spear { get; set; }
        public int Sword { get; set; }
        public int Axe { get; set; }
        public int Archer { get; set; }
        public int Spy { get; set; }
        public int Light { get; set; }
        public int Marcher { get; set; }
        public int Heavy { get; set; }
        public int Ram { get; set; }
        public int Catapult { get; set; }
        public int Knight { get; set; }
        public int Snob { get; set; }
    }
}

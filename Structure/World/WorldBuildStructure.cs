using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SilverBot.World
{
    public class WorldBuildStructure
    {
        [XmlRoot(ElementName = "main")]
        public class Main
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "barracks")]
        public class Barracks
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "watchtower")]
        public class Watchtower
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "church")]
        public class Church
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }


        [XmlRoot(ElementName = "church_f")]
        public class Church_f
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }


        [XmlRoot(ElementName = "stable")]
        public class Stable
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "garage")]
        public class Garage
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "snob")]
        public class Snob
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "smith")]
        public class Smith
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "place")]
        public class Place
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "statue")]
        public class Statue
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "market")]
        public class Market
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "wood")]
        public class Wood
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "stone")]
        public class Stone
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "iron")]
        public class Iron
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "farm")]
        public class Farm
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "storage")]
        public class Storage
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "hide")]
        public class Hide
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "wall")]
        public class Wall
        {
            [XmlElement(ElementName = "max_level")]
            public string Max_level { get; set; }
            [XmlElement(ElementName = "min_level")]
            public string Min_level { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "wood_factor")]
            public string Wood_factor { get; set; }
            [XmlElement(ElementName = "stone_factor")]
            public string Stone_factor { get; set; }
            [XmlElement(ElementName = "iron_factor")]
            public string Iron_factor { get; set; }
            [XmlElement(ElementName = "pop_factor")]
            public string Pop_factor { get; set; }
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "build_time_factor")]
            public string Build_time_factor { get; set; }
        }

        [XmlRoot(ElementName = "config")]
        public class Config
        {
            [XmlElement(ElementName = "main")]
            public Main Main { get; set; }
            [XmlElement(ElementName = "barracks")]
            public Barracks Barracks { get; set; }
            [XmlElement(ElementName = "stable")]
            public Stable Stable { get; set; }
            [XmlElement(ElementName = "garage")]
            public Garage Garage { get; set; }
            [XmlElement(ElementName = "snob")]
            public Snob Snob { get; set; }
            [XmlElement(ElementName = "smith")]
            public Smith Smith { get; set; }
            [XmlElement(ElementName = "place")]
            public Place Place { get; set; }
            [XmlElement(ElementName = "statue")]
            public Statue Statue { get; set; }
            [XmlElement(ElementName = "market")]
            public Market Market { get; set; }
            [XmlElement(ElementName = "wood")]
            public Wood Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public Stone Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public Iron Iron { get; set; }
            [XmlElement(ElementName = "farm")]
            public Farm Farm { get; set; }
            [XmlElement(ElementName = "storage")]
            public Storage Storage { get; set; }
            [XmlElement(ElementName = "hide")]
            public Hide Hide { get; set; }
            [XmlElement(ElementName = "wall")]
            public Wall Wall { get; set; }
            [XmlElement(ElementName = "church")]
            public Church Church { get; set; }
            [XmlElement(ElementName = "church_f")]
            public Church_f Church_f { get; set; }
            [XmlElement(ElementName = "watchtower")]
            public Watchtower Watchtower { get; set; }
        }
    }
}

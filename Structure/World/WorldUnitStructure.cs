using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SilverBot.World
{
    public class WorldUnitStructure
    {
        [XmlRoot(ElementName = "spear")]
        public class Spear
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "sword")]
        public class Sword
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "axe")]
        public class Axe
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "archer")]
        public class Archer
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "spy")]
        public class Spy
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "light")]
        public class Light
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "marcher")]
        public class Marcher
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "heavy")]
        public class Heavy
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "ram")]
        public class Ram
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "catapult")]
        public class Catapult
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "knight")]
        public class Knight
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "snob")]
        public class Snob
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "militia")]
        public class Militia
        {
            [XmlElement(ElementName = "build_time")]
            public string Build_time { get; set; }
            [XmlElement(ElementName = "wood")]
            public string Wood { get; set; }
            [XmlElement(ElementName = "stone")]
            public string Stone { get; set; }
            [XmlElement(ElementName = "iron")]
            public string Iron { get; set; }
            [XmlElement(ElementName = "pop")]
            public string Pop { get; set; }
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "attack")]
            public string Attack { get; set; }
            [XmlElement(ElementName = "defense")]
            public string Defense { get; set; }
            [XmlElement(ElementName = "defense_cavalry")]
            public string Defense_cavalry { get; set; }
            [XmlElement(ElementName = "defense_archer")]
            public string Defense_archer { get; set; }
            [XmlElement(ElementName = "carry")]
            public string Carry { get; set; }
        }

        [XmlRoot(ElementName = "config")]
        public class Config
        {
            [XmlElement(ElementName = "spear")]
            public Spear Spear { get; set; }
            [XmlElement(ElementName = "sword")]
            public Sword Sword { get; set; }
            [XmlElement(ElementName = "axe")]
            public Axe Axe { get; set; }
            [XmlElement(ElementName = "archer")]
            public Archer Archer { get; set; }
            [XmlElement(ElementName = "spy")]
            public Spy Spy { get; set; }
            [XmlElement(ElementName = "light")]
            public Light Light { get; set; }
            [XmlElement(ElementName = "marcher")]
            public Marcher Marcher { get; set; }
            [XmlElement(ElementName = "heavy")]
            public Heavy Heavy { get; set; }
            [XmlElement(ElementName = "ram")]
            public Ram Ram { get; set; }
            [XmlElement(ElementName = "catapult")]
            public Catapult Catapult { get; set; }
            [XmlElement(ElementName = "knight")]
            public Knight Knight { get; set; }
            [XmlElement(ElementName = "snob")]
            public Snob Snob { get; set; }
            [XmlElement(ElementName = "militia")]
            public Militia Militia { get; set; }
        }
    }
}

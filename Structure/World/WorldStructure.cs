using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SilverBot.World
{
    public class WorldStructure
    {
        [XmlRoot(ElementName = "build")]
        public class Build
        {
            [XmlElement(ElementName = "destroy")]
            public string Destroy { get; set; }
            [XmlElement(ElementName = "buildtime_reduce")]
            public string Buildtime_reduce { get; set; }
            [XmlElement(ElementName = "buildtime_reduce_points")]
            public string Buildtime_reduce_points { get; set; }
        }

        [XmlRoot(ElementName = "misc")]
        public class Misc
        {
            [XmlElement(ElementName = "log_losses")]
            public string Log_losses { get; set; }
            [XmlElement(ElementName = "kill_ranking")]
            public string Kill_ranking { get; set; }
            [XmlElement(ElementName = "tutorial")]
            public string Tutorial { get; set; }
            [XmlElement(ElementName = "millis_arrival")]
            public string Millis_arrival { get; set; }
            [XmlElement(ElementName = "command_cancel_time")]
            public string Command_cancel_time { get; set; }
            [XmlElement(ElementName = "trade_cancel_time")]
            public string Trade_cancel_time { get; set; }
            [XmlElement(ElementName = "free_premium_points")]
            public string Free_premium_points { get; set; }
            [XmlElement(ElementName = "free_premium_points2")]
            public string Free_premium_points2 { get; set; }
            [XmlElement(ElementName = "online_time")]
            public string Online_time { get; set; }
            [XmlElement(ElementName = "more_premium")]
            public string More_premium { get; set; }
            [XmlElement(ElementName = "start_christmas_tree")]
            public string Start_christmas_tree { get; set; }
            [XmlElement(ElementName = "end_christmas_tree")]
            public string End_christmas_tree { get; set; }
        }

        [XmlRoot(ElementName = "newbie")]
        public class Newbie
        {
            [XmlElement(ElementName = "days")]
            public string Days { get; set; }
            [XmlElement(ElementName = "ratio_days")]
            public string Ratio_days { get; set; }
            [XmlElement(ElementName = "ratio")]
            public string Ratio { get; set; }
        }

        [XmlRoot(ElementName = "game")]
        public class Game
        {
            [XmlElement(ElementName = "base_config")]
            public string Base_config { get; set; }
            [XmlElement(ElementName = "knight")]
            public string Knight { get; set; }
            [XmlElement(ElementName = "knight_new_items")]
            public string Knight_new_items { get; set; }
            [XmlElement(ElementName = "archer")]
            public string Archer { get; set; }
            [XmlElement(ElementName = "tech")]
            public string Tech { get; set; }
            [XmlElement(ElementName = "spy")]
            public string Spy { get; set; }
            [XmlElement(ElementName = "farm_limit")]
            public string Farm_limit { get; set; }
            [XmlElement(ElementName = "church")]
            public string Church { get; set; }
            [XmlElement(ElementName = "fake_limit")]
            public string Fake_limit { get; set; }
            [XmlElement(ElementName = "barbarian_rise")]
            public string Barbarian_rise { get; set; }
            [XmlElement(ElementName = "barbarian_max_points")]
            public string Barbarian_max_points { get; set; }
            [XmlElement(ElementName = "hauls")]
            public string Hauls { get; set; }
        }

        [XmlRoot(ElementName = "buildings")]
        public class Buildings
        {
            [XmlElement(ElementName = "base_setting")]
            public string Base_setting { get; set; }
            [XmlElement(ElementName = "hb_offset")]
            public string Hb_offset { get; set; }
            [XmlElement(ElementName = "hb_factor")]
            public string Hb_factor { get; set; }
            [XmlElement(ElementName = "custom_main")]
            public string Custom_main { get; set; }
            [XmlElement(ElementName = "custom_farm")]
            public string Custom_farm { get; set; }
            [XmlElement(ElementName = "custom_storage")]
            public string Custom_storage { get; set; }
            [XmlElement(ElementName = "custom_place")]
            public string Custom_place { get; set; }
            [XmlElement(ElementName = "custom_barracks")]
            public string Custom_barracks { get; set; }
            [XmlElement(ElementName = "custom_church")]
            public string Custom_church { get; set; }
            [XmlElement(ElementName = "custom_church_f")]
            public string Custom_church_f { get; set; }
            [XmlElement(ElementName = "custom_smith")]
            public string Custom_smith { get; set; }
            [XmlElement(ElementName = "custom_wood")]
            public string Custom_wood { get; set; }
            [XmlElement(ElementName = "custom_stone")]
            public string Custom_stone { get; set; }
            [XmlElement(ElementName = "custom_iron")]
            public string Custom_iron { get; set; }
            [XmlElement(ElementName = "custom_market")]
            public string Custom_market { get; set; }
            [XmlElement(ElementName = "custom_stable")]
            public string Custom_stable { get; set; }
            [XmlElement(ElementName = "custom_wall")]
            public string Custom_wall { get; set; }
            [XmlElement(ElementName = "custom_garage")]
            public string Custom_garage { get; set; }
            [XmlElement(ElementName = "custom_hide")]
            public string Custom_hide { get; set; }
            [XmlElement(ElementName = "custom_snob")]
            public string Custom_snob { get; set; }
            [XmlElement(ElementName = "custom_statue")]
            public string Custom_statue { get; set; }
        }

        [XmlRoot(ElementName = "snob")]
        public class Snob
        {
            [XmlElement(ElementName = "gold")]
            public string Gold { get; set; }
            [XmlElement(ElementName = "cheap_rebuild")]
            public string Cheap_rebuild { get; set; }
            [XmlElement(ElementName = "simple")]
            public string Simple { get; set; }
            [XmlElement(ElementName = "rise")]
            public string Rise { get; set; }
            [XmlElement(ElementName = "max_dist")]
            public string Max_dist { get; set; }
            [XmlElement(ElementName = "factor")]
            public string Factor { get; set; }
            [XmlElement(ElementName = "coin_wood")]
            public string Coin_wood { get; set; }
            [XmlElement(ElementName = "coin_stone")]
            public string Coin_stone { get; set; }
            [XmlElement(ElementName = "coin_iron")]
            public string Coin_iron { get; set; }
        }

        [XmlRoot(ElementName = "ally")]
        public class Ally
        {
            [XmlElement(ElementName = "wars_enabled")]
            public string Wars_enabled { get; set; }
            [XmlElement(ElementName = "no_harm")]
            public string No_harm { get; set; }
            [XmlElement(ElementName = "no_other_support")]
            public string No_other_support { get; set; }
            [XmlElement(ElementName = "no_leave")]
            public string No_leave { get; set; }
            [XmlElement(ElementName = "no_admin")]
            public string No_admin { get; set; }
            [XmlElement(ElementName = "limit")]
            public string Limit { get; set; }
            [XmlElement(ElementName = "fixed_allies")]
            public string Fixed_allies { get; set; }
            [XmlElement(ElementName = "diplomacy")]
            public string Diplomacy { get; set; }
            [XmlElement(ElementName = "reservation_manager")]
            public string Reservation_manager { get; set; }
            [XmlElement(ElementName = "points_member_count")]
            public string Points_member_count { get; set; }
            [XmlElement(ElementName = "bypass_igm_block")]
            public string Bypass_igm_block { get; set; }
            [XmlElement(ElementName = "admin_bypass_igm_block")]
            public string Admin_bypass_igm_block { get; set; }
            [XmlElement(ElementName = "wars_member_requirement")]
            public string Wars_member_requirement { get; set; }
            [XmlElement(ElementName = "wars_points_requirement")]
            public string Wars_points_requirement { get; set; }
        }

        [XmlRoot(ElementName = "win")]
        public class Win
        {
            [XmlElement(ElementName = "check")]
            public string Check { get; set; }
            [XmlElement(ElementName = "points")]
            public string Points { get; set; }
            [XmlElement(ElementName = "villages")]
            public string Villages { get; set; }
            [XmlElement(ElementName = "hours")]
            public string Hours { get; set; }
        }

        [XmlRoot(ElementName = "coord")]
        public class Coord
        {
            [XmlElement(ElementName = "map_size")]
            public string Map_size { get; set; }
            [XmlElement(ElementName = "func")]
            public string Func { get; set; }
            [XmlElement(ElementName = "empty_villages")]
            public string Empty_villages { get; set; }
            [XmlElement(ElementName = "bonus_villages")]
            public string Bonus_villages { get; set; }
            [XmlElement(ElementName = "bonus_new")]
            public string Bonus_new { get; set; }
            [XmlElement(ElementName = "inner")]
            public string Inner { get; set; }
            [XmlElement(ElementName = "select_start")]
            public string Select_start { get; set; }
            [XmlElement(ElementName = "village_move_wait")]
            public string Village_move_wait { get; set; }
            [XmlElement(ElementName = "noble_restart")]
            public string Noble_restart { get; set; }
            [XmlElement(ElementName = "worldmap")]
            public string Worldmap { get; set; }
            [XmlElement(ElementName = "legacy_scenery")]
            public string Legacy_scenery { get; set; }
        }

        [XmlRoot(ElementName = "sitter")]
        public class Sitter
        {
            [XmlElement(ElementName = "allow")]
            public string Allow { get; set; }
        }

        [XmlRoot(ElementName = "sleep")]
        public class Sleep
        {
            [XmlElement(ElementName = "active")]
            public string Active { get; set; }
            [XmlElement(ElementName = "delay")]
            public string Delay { get; set; }
            [XmlElement(ElementName = "min")]
            public string Min { get; set; }
            [XmlElement(ElementName = "max")]
            public string Max { get; set; }
            [XmlElement(ElementName = "min_awake")]
            public string Min_awake { get; set; }
            [XmlElement(ElementName = "max_awake")]
            public string Max_awake { get; set; }
            [XmlElement(ElementName = "warn_time")]
            public string Warn_time { get; set; }
        }

        [XmlRoot(ElementName = "night")]
        public class Night
        {
            [XmlElement(ElementName = "active")]
            public string Active { get; set; }
            [XmlElement(ElementName = "start_hour")]
            public string Start_hour { get; set; }
            [XmlElement(ElementName = "end_hour")]
            public string End_hour { get; set; }
            [XmlElement(ElementName = "def_factor")]
            public string Def_factor { get; set; }
        }

        [XmlRoot(ElementName = "config")]
        public class Config
        {
            [XmlElement(ElementName = "speed")]
            public string Speed { get; set; }
            [XmlElement(ElementName = "unit_speed")]
            public string Unit_speed { get; set; }
            [XmlElement(ElementName = "moral")]
            public string Moral { get; set; }
            [XmlElement(ElementName = "build_queue")]
            public string Build_queue { get; set; }
            [XmlElement(ElementName = "build")]
            public Build Build { get; set; }
            [XmlElement(ElementName = "misc")]
            public Misc Misc { get; set; }
            [XmlElement(ElementName = "newbie")]
            public Newbie Newbie { get; set; }
            [XmlElement(ElementName = "game")]
            public Game Game { get; set; }
            [XmlElement(ElementName = "buildings")]
            public Buildings Buildings { get; set; }
            [XmlElement(ElementName = "snob")]
            public Snob Snob { get; set; }
            [XmlElement(ElementName = "ally")]
            public Ally Ally { get; set; }
            [XmlElement(ElementName = "win")]
            public Win Win { get; set; }
            [XmlElement(ElementName = "coord")]
            public Coord Coord { get; set; }
            [XmlElement(ElementName = "sitter")]
            public Sitter Sitter { get; set; }
            [XmlElement(ElementName = "sleep")]
            public Sleep Sleep { get; set; }
            [XmlElement(ElementName = "night")]
            public Night Night { get; set; }
        }
    }
}

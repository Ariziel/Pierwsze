using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SilverBot.UserVillages
{
    public class VillageStructure
    {
        public class Player
        {
            public string id { get; set; }
            public string name { get; set; }
            public string ally { get; set; }
            public string sitter { get; set; }
            public string sleep_start { get; set; }
            public string sitter_type { get; set; }
            public string sleep_end { get; set; }
            public string sleep_last { get; set; }
            public string doubleerstitial { get; set; }
            public string email_valid { get; set; }
            public string villages { get; set; }
            public string incomings { get; set; }
            public double supports { get; set; }
            public object knight_location { get; set; }
            public object knight_unit { get; set; }
            public double rank { get; set; }
            public string podoubles { get; set; }
            public string date_started { get; set; }
            public string is_guest { get; set; }
            public string birthdate { get; set; }
            public string quest_progress { get; set; }
            public bool premium { get; set; }
            public bool account_manager { get; set; }
            public bool farm_manager { get; set; }
            public string podoubles_formatted { get; set; }
            public string rank_formatted { get; set; }
            public string pp { get; set; }
            public double new_ally_application { get; set; }
            public string new_ally_invite { get; set; }
            public string new_buddy_request { get; set; }
            public string new_daily_bonus { get; set; }
            public double new_forum_post { get; set; }
            public string new_igm { get; set; }
            public string new_items { get; set; }
            public string new_report { get; set; }
            public string fire_pixel { get; set; }
            public string new_quest { get; set; }
        }

        public class Buildings
        {
            public RootObject buildingsReq { get; set; }
            public double village { get; set; }
            public double main { get; set; }
            public double farm { get; set; }
            public double storage { get; set; }
            public double place { get; set; }
            public double barracks { get; set; }
            public double church { get; set; }
            public double church_f { get; set; }
            public double smith { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double market { get; set; }
            public double stable { get; set; }
            public double wall { get; set; }
            public double garage { get; set; }
            public double hide { get; set; }
            public double snob { get; set; }
            public double statue { get; set; }
            public double watchtower { get; set; }
        }

        public class Village
        {
            public double id { get; set; }
            public string name { get; set; }
            public double wood_prod { get; set; }
            public double stone_prod { get; set; }
            public double iron_prod { get; set; }
            public double storage_max { get; set; }
            public double pop_max { get; set; }
            public double wood_float { get; set; }
            public double stone_float { get; set; }
            public double iron_float { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double x { get; set; }
            public double y { get; set; }
            public double trader_away { get; set; }
            public object bonus_id { get; set; }
            public object bonus { get; set; }
            public Buildings buildings { get; set; }
            public string spear { get; set; }
            public string sword { get; set; }
            public string axe { get; set; }
            public string archer { get; set; }
            public string spy { get; set; }
            public string light { get; set; }
            public string marcher { get; set; }
            public string heavy { get; set; }
            public string ram { get; set; }
            public string catapult { get; set; }
            public string knight { get; set; }
            public string snob { get; set; }
            public string militia { get; set; }
            public string player_id { get; set; }
            public double buildqueue { get; set; }
            public double modifications { get; set; }
            public double podoubles { get; set; }
            public long last_res_tick { get; set; }
            public IList<double> res { get; set; }
            public string coord { get; set; }
            public bool is_farm_upgradable { get; set; }
        }

        public class Nav
        {
            public double parent { get; set; }
        }

        public class Example
        {
            public Player player { get; set; }
            public Village village { get; set; }
            public Nav nav { get; set; }
            public string link_base { get; set; }
            public string link_base_pure { get; set; }
            public string csrf { get; set; }
            public string world { get; set; }
            public string market { get; set; }
            public bool RTL { get; set; }
            public string version { get; set; }
            public string majorVersion { get; set; }
            public string screen { get; set; }
            public object mode { get; set; }
            public string device { get; set; }
            public bool pregame { get; set; }
            public long time_generated { get; set; }
        }


        public class Main
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public string error { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Req
        {
            public double main { get; set; }
        }

        public class Main2
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Require
        {
            public Main2 main { get; set; }
        }

        public class Barracks
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public Req req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require require { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Req2
        {
            public double main { get; set; }
            public double barracks { get; set; }
            public double smith { get; set; }
        }

        public class Main3
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Barracks2
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Smith
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Require2
        {
            public Main3 main { get; set; }
            public Barracks2 barracks { get; set; }
            public Smith smith { get; set; }
        }

        public class Stable
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public Req2 req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require2 require { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Req3
        {
            public double main { get; set; }
            public double smith { get; set; }
        }

        public class Main4
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Smith2
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Require3
        {
            public Main4 main { get; set; }
            public Smith2 smith { get; set; }
        }

        public class Garage
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public Req3 req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require3 require { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Church
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<object> image_levels { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public bool complete { get; set; }
            public string build_link { get; set; }
        }

        public class Watchtower
        {
            public string name { get; set; }
            public string image { get; set; }
            public int max_level { get; set; }
            public int min_level { get; set; }
            public List<int> image_levels { get; set; }
            public Req2 req { get; set; }
            public int wood { get; set; }
            public int stone { get; set; }
            public int iron { get; set; }
            public int pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public int build_time { get; set; }
            public double build_time_factor { get; set; }
            public int build_time_min { get; set; }
            public int points { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public int level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require2 require { get; set; }
            public int wood_cheap { get; set; }
            public int stone_cheap { get; set; }
            public int iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public string error { get; set; }
            public int wood_queue_factor { get; set; }
            public int stone_queue_factor { get; set; }
            public int iron_queue_factor { get; set; }
        }


        public class ChurchF
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<object> image_levels { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public bool complete { get; set; }
            public string build_link { get; set; }
        }

        public class Req4
        {
            public double main { get; set; }
            public double barracks { get; set; }
        }

        public class Main5
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Barracks3
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Require4
        {
            public Main5 main { get; set; }
            public Barracks3 barracks { get; set; }
        }

        public class Smith3
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public Req4 req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require4 require { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public string error { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Place
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<object> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public bool complete { get; set; }
            public string build_link { get; set; }
        }

        public class Statue
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<object> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public bool complete { get; set; }
            public string build_link { get; set; }
        }

        public class Req5
        {
            public double main { get; set; }
            public double storage { get; set; }
        }

        public class Main6
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Storage
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Require5
        {
            public Main6 main { get; set; }
            public Storage storage { get; set; }
        }

        public class Market
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public Req5 req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require5 require { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Wood
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Stone
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Iron
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Farm
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Storage2
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Hide
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<object> image_levels { get; set; }
            public List<object> req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Req6
        {
            public double barracks { get; set; }
        }

        public class Barracks4
        {
            public double level { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public bool met { get; set; }
        }

        public class Require6
        {
            public Barracks4 barracks { get; set; }
        }

        public class Wall
        {
            public string name { get; set; }
            public string image { get; set; }
            public double max_level { get; set; }
            public double min_level { get; set; }
            public List<double> image_levels { get; set; }
            public Req6 req { get; set; }
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
            public double pop { get; set; }
            public double wood_factor { get; set; }
            public double stone_factor { get; set; }
            public double iron_factor { get; set; }
            public double pop_factor { get; set; }
            public double build_time { get; set; }
            public double build_time_factor { get; set; }
            public double build_time_min { get; set; }
            public double podoubles { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public double level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require6 require { get; set; }
            public double wood_cheap { get; set; }
            public double stone_cheap { get; set; }
            public double iron_cheap { get; set; }
            public bool cheap { get; set; }
            public bool cheap_possible { get; set; }
            public string cheap_error { get; set; }
            public string tooltip { get; set; }
            public double wood_queue_factor { get; set; }
            public double stone_queue_factor { get; set; }
            public double iron_queue_factor { get; set; }
            public string build_link { get; set; }
        }

        public class Snob
        {
            public string name { get; set; }
            public string image { get; set; }
            public int max_level { get; set; }
            public int min_level { get; set; }
            public List<object> image_levels { get; set; }
            public Req4 req { get; set; }
            public int wood { get; set; }
            public int stone { get; set; }
            public int iron { get; set; }
            public int pop { get; set; }
            public int wood_factor { get; set; }
            public int stone_factor { get; set; }
            public int iron_factor { get; set; }
            public double pop_factor { get; set; }
            public int build_time { get; set; }
            public double build_time_factor { get; set; }
            public object build_time_min { get; set; }
            public int points { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public string level { get; set; }
            public int level_next { get; set; }
            public string link { get; set; }
            public bool can_build { get; set; }
            public string big_image { get; set; }
            public Require4 require { get; set; }
            public int wood_queue_factor { get; set; }
            public int stone_queue_factor { get; set; }
            public int iron_queue_factor { get; set; }
            public bool complete { get; set; }
            public string build_link { get; set; }
        }

        public class RootObject
        {
            public Main main { get; set; }
            public Barracks barracks { get; set; }
            public Stable stable { get; set; }
            public Garage garage { get; set; }
            public Church church { get; set; }
            public ChurchF church_f { get; set; }
            public Smith3 smith { get; set; }
            public Place place { get; set; }
            public Statue statue { get; set; }
            public Market market { get; set; }
            public Wood wood { get; set; }
            public Stone stone { get; set; }
            public Iron iron { get; set; }
            public Farm farm { get; set; }
            public Storage2 storage { get; set; }
            public Hide hide { get; set; }
            public Wall wall { get; set; }
            public Snob snob { get; set; }
            public Watchtower watchtower { get; set; }
        }
    }
}

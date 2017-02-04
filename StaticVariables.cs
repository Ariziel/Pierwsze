using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using SilverBot.Attack;
using SilverBot.Farming;
using SilverBot.Structure.User.Market;
using SilverBot.Structure.User.Recruit;
using SilverBot.UserVillages;
using SilverBot.World;

namespace SilverBot
{
    class StaticVariables
    {
        public static string gameversion = "8.71";
        public static string Server = string.Empty;
        public static bool CustomWorldCheckBox = false;
        public static string ServerShort = string.Empty;
        public static string World = string.Empty;
        public static bool WorldDownloaded = false;
        public static bool Sync = false;
        public static double maxBuildQueue = 2;
        public static string WorldNotParsed = string.Empty;
        public static bool BuildEnabled = false;
        public static bool MyVillageSync = true;
        public static double MyVillageSyncSlider = 2;
        public static bool WorldSync = true;
        public static string ErrorMessage = string.Empty;
        public static bool AutoStorage = false;
        public static bool AutoFarm = false;
        public static double AutoFarmLeftSpace = 10;
        public static bool DynamicStorage = false;
        public static List<WorldVillagesStructure> WorldVillages = new List<WorldVillagesStructure>();
        public static World.WorldStructure.Config WorldSettings = new WorldStructure.Config();
        public static World.WorldBuildStructure.Config WorldSettingsBuildings = new WorldBuildStructure.Config();
        public static World.WorldUnitStructure.Config WorldUnitInfo = new WorldUnitStructure.Config();
        public static List<UserVillages.VillageStructure.Example> MyVillages = new List<UserVillages.VillageStructure.Example>();
        public static List<List<UserVillages.BuildStructure>> MyVillagesBuild = new List<List<UserVillages.BuildStructure>>();
        public static List<UserVillages.VillageStructure.RootObject> MyVillagesBuildings = new List<VillageStructure.RootObject>();
        public static bool LootAssistantEnabled = false;
        public static bool Method = true;
        public static double Template = 0;
        public static double LootAssistantDelay = 3;
        public static bool LootAssistantOption1 = true;
        public static bool LootAssistantOption2 = false;
        public static bool LootAssistantOption3 = false;
        public static bool LootAssistantOption4 = false;
        public static bool LootAssistantOption5 = false;
        public static double AttackCountFarmPremium = 100;
        public static List<string> Templates = new List<string>();
        public static double AttackPremiumDelay = 300;
        public static bool RandomDelayPremiumFarming = true;
        public static bool DynamicTemaplate = false;
        public static double Ping = 0;
        public static double TimeDiff = 0;
        public static List<Attack.Structure> AttackList = new List<Attack.Structure>();
        public static int AttackID = 0;
        public static bool PremiumExchange = false;
        public static double RefreshSlider = 5;
        public static List<SilverBot.Structure.User.Market.MarketStructure.RootObject> MarketStructures = new List<MarketStructure.RootObject>();
        public static List<Farming.FarmingTemplateStructure> CustomTemplates = new List<Farming.FarmingTemplateStructure>();
        public static List<VillagesTemplateStucture> VillagesTemplate = new List<VillagesTemplateStucture>();
        public static bool NormalFarming = false;
        public static double FarmingInterval = 5;
        public static string CatapultTargetFarming = "Wall";
        public static string Token = "";
        public static bool AutoResizeMap = true;
        public static double Size = 15;
        public static List<RecruitStructure> RecruitList = new List<RecruitStructure>();
        public static bool EnableRecruit = false;
        public static double MinimumInfantryPackage = 5;
        public static double MinimumCavalaryPackage = 2;
        public static double MinimumOthersPackage = 1;
        public static double RecruitDelay = 5;
        public static List<string> LogsList = new List<string>();
        public static bool EnableAttack = false;
        public static double TimeFix = 0;
        public static List<AttackDetector.Structure> Incomingattacks = new List<AttackDetector.Structure>();
        public static bool AttackDetector = false;
        public static double AttackDetectorInterval = 50;
        public static string AttackDetectorOption = "Nothing";
        public static double serverUTC = 0;

        //stat
        public static int Lootassistantattackssent = 0;
        public static int BuildRequestSent = 0;
    }
}

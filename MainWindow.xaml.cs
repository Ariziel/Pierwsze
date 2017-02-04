using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using SilverBot.BuildQueue;
using SilverBot.Windows;

namespace SilverBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        System.Windows.Threading.DispatcherTimer MyVillagesTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer WorldTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer BuildTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer LootAssistantTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer MarketTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer FarmingTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer RecruitTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer AttackTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer DynamicResourceTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer AttackDetectorTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer AttackAvoidTimer = new System.Windows.Threading.DispatcherTimer();
        public static List<string> MyvillOnlyID = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Browser.Navigated += new NavigatedEventHandler(wbMain_Navigated);
            MyVillagesTimer.Tick += MyVillagesTimer_Tick;
            MyVillagesTimer.Interval = new TimeSpan(0, Convert.ToInt32(StaticVariables.MyVillageSyncSlider), 0);
            MyVillagesTimer.Start();
            WorldTimer.Tick += WorldTimer_Tick;
            WorldTimer.Interval = new TimeSpan(0, 60, 0);
            WorldTimer.Start();
            BuildTimer.Tick += BuildTimer_Tick;
            BuildTimer.Interval = new TimeSpan(0, 0, 3);
            BuildTimer.Start();
            LootAssistantTimer.Tick += LootAssistantTimer_Tick;
            LootAssistantTimer.Interval = new TimeSpan(0, Convert.ToInt32(StaticVariables.LootAssistantDelay), 0);
            LootAssistantTimer.Start();
            MarketTimer.Tick += MarketTimer_Tick;
            MarketTimer.Interval = new TimeSpan(0, 0, Convert.ToInt32(StaticVariables.RefreshSlider));
            MarketTimer.Start();
            FarmingTimer.Tick += FarmingTimer_Tick;
            FarmingTimer.Interval = new TimeSpan(0, Convert.ToInt32(StaticVariables.FarmingInterval), 0);
            FarmingTimer.Start();
            RecruitTimer.Tick += RecruitTimer_Tick;
            RecruitTimer.Interval = new TimeSpan(0, 0, Convert.ToInt32(StaticVariables.RecruitDelay), 0, 0);
            RecruitTimer.Start();
            AttackTimer.Tick += AttackTimer_Tick;
            AttackTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            AttackTimer.Start();
            DynamicResourceTimer.Tick += DynamicResourceTimer_Tick;
            DynamicResourceTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            DynamicResourceTimer.Start();
            AttackDetectorTimer.Tick += AttackDetectorTimer_Tick;
            AttackDetectorTimer.Interval = new TimeSpan(0, 0, 0, Convert.ToInt32(StaticVariables.AttackDetectorInterval),
                0);
            AttackDetectorTimer.Start();
            AttackAvoidTimer.Tick += AttackAvoidTimer_Tick;
            AttackAvoidTimer.Interval = new TimeSpan(0, 0, 0, 3, 0);
            AttackAvoidTimer.Start();
            StaticVariables.LogsList.Add(DateTime.Now + " Loading complete");
        }

        private async void AttackAvoidTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.AttackDetector)
                {
                    if (StaticVariables.AttackDetectorOption == "Avoid attack")
                    {
                        foreach (var VARIABLE in StaticVariables.Incomingattacks.ToList())
                        {
                            var dataland = UnixTimeStampToDateTime(VARIABLE.LandTime);
                            if (dataland.AddSeconds(-5) <= DateTime.Now)
                            {
                                var firstbarb = StaticVariables.WorldVillages.FirstOrDefault(x => x.IDPlayer == "0");
                                var myvill =
                                    StaticVariables.MyVillages.Find(x => x.village.id.ToString() == VARIABLE.idvillage);
                                var result =
                                    await
                                        Attack.SendAttack.FirstRequest(myvill.village.id.ToString(),
                                            myvill.village.spear,
                                            myvill.village.sword, myvill.village.axe, myvill.village.archer,
                                            myvill.village.spy, myvill.village.light, myvill.village.marcher,
                                            myvill.village.heavy, myvill.village.ram, myvill.village.catapult,
                                            myvill.village.knight, myvill.village.snob, firstbarb.X, firstbarb.Y, "main");
                                StaticVariables.Incomingattacks.Remove(VARIABLE);
                                Console.WriteLine("avoid send");
                                //test it ? and return attack
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private async void AttackDetectorTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.AttackDetector)
                {
                    AttackAvoidTimer.Interval = new TimeSpan(0, 0, 0,
                        Convert.ToInt32(StaticVariables.AttackDetectorInterval), 0);
                    foreach (var VARIABLE in StaticVariables.MyVillages)
                    {
                        var result = await AttackDetector.PlaceRequest.place(VARIABLE.village.id.ToString());
                        AttackDetector.FindAttackRegex.Find(result, VARIABLE.village.id.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void DynamicResourceTimer_Tick(object sender, EventArgs e)
        {
            //foreach (var VARIABLE in StaticVariables.MyVillages)
            //{
            //    VARIABLE.village.wood += VARIABLE.village.wood_prod;
            //    VARIABLE.village.stone += VARIABLE.village.stone_prod;
            //    VARIABLE.village.iron += VARIABLE.village.iron_prod;
            //}
        }

        private async void AttackTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.EnableAttack)
                {
                    foreach (var VARIABLE in StaticVariables.AttackList.ToList())
                    {
                        var datecast = DateTime.Parse(VARIABLE.casttime, CultureInfo.InvariantCulture);
                        datecast = datecast.AddMilliseconds(StaticVariables.TimeDiff);
                        datecast = datecast.AddMilliseconds((StaticVariables.Ping*(-1)));
                        datecast = datecast.AddMilliseconds((StaticVariables.Ping*(-1)));
                        if (datecast < DateTime.Now)
                        {
                            for (int i = 0; i < int.Parse(VARIABLE.count, CultureInfo.InvariantCulture); i++)
                            {
                                Attack.SendAttack.FirstRequest(VARIABLE.id, VARIABLE.spear, VARIABLE.sword, VARIABLE.axe,
                                    VARIABLE.archer, VARIABLE.spy, VARIABLE.light, VARIABLE.marcher, VARIABLE.heavy,
                                    VARIABLE.ram, VARIABLE.catapult, VARIABLE.knight, VARIABLE.snob, VARIABLE.x,
                                    VARIABLE.y, VARIABLE.catapulttarget);
                            }
                            StaticVariables.AttackList.Remove(VARIABLE);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private async void RecruitTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.EnableRecruit)
                {
                    RecruitTimer.Interval = new TimeSpan(0, 0, Convert.ToInt32(StaticVariables.RecruitDelay), 0, 0);
                    foreach (var VARIABLE in StaticVariables.RecruitList)
                    {
                        var SpearResult = Recruit.Core.CheckSpear(VARIABLE.spear, VARIABLE.id);
                        if (SpearResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit spear " +
                                                         SpearResult + " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitSpear(VARIABLE.id.ToString(), SpearResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var spear = int.Parse(VARIABLE.spear, CultureInfo.InvariantCulture);
                                spear -= Convert.ToInt32(SpearResult);
                                VARIABLE.spear = spear.ToString();
                                Recruit.Core.RemoveResourcesSpear(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }
                        var SwordResult = Recruit.Core.CheckSword(VARIABLE.sword, VARIABLE.id);
                        if (SwordResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit sword " +
                                                         SwordResult + " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitSword(VARIABLE.id.ToString(), SwordResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var sword = int.Parse(VARIABLE.sword, CultureInfo.InvariantCulture);
                                sword -= Convert.ToInt32(SwordResult);
                                VARIABLE.sword = sword.ToString();
                                Recruit.Core.RemoveResourcesSword(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }

                        var AxeResult = Recruit.Core.CheckAxe(VARIABLE.axe, VARIABLE.id);
                        if (AxeResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit axe " + AxeResult +
                                                         " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitAxe(VARIABLE.id.ToString(), AxeResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var axe = int.Parse(VARIABLE.axe, CultureInfo.InvariantCulture);
                                axe -= Convert.ToInt32(AxeResult);
                                VARIABLE.axe = axe.ToString();
                                Recruit.Core.RemoveResourcesAxe(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }
                        if (int.Parse(VARIABLE.archer, CultureInfo.InvariantCulture) != 0)
                        {
                            var ArcherResult = Recruit.Core.CheckArcher(VARIABLE.archer, VARIABLE.id);
                            if (ArcherResult != 0)
                            {
                                StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit archer " +
                                                             ArcherResult + " in village " + VARIABLE.id);
                                var req =
                                    await Recruit.Request.RecruitArcher(VARIABLE.id.ToString(), ArcherResult.ToString());
                                if (req.Contains("success"))
                                {
                                    //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                    var archer = int.Parse(VARIABLE.archer, CultureInfo.InvariantCulture);
                                    archer -= Convert.ToInt32(ArcherResult);
                                    VARIABLE.archer = archer.ToString();
                                    Recruit.Core.RemoveResourcesArcher(VARIABLE.id);
                                }
                                else
                                {
                                    //smth wrong
                                }
                            }
                        }


                        var SpyResult = Recruit.Core.CheckSpy(VARIABLE.spy, VARIABLE.id);
                        if (SpyResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit spy " + SpyResult +
                                                         " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitSpy(VARIABLE.id.ToString(), SpyResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var spy = int.Parse(VARIABLE.spy, CultureInfo.InvariantCulture);
                                spy -= Convert.ToInt32(SpyResult);
                                VARIABLE.spy = spy.ToString();
                                Recruit.Core.RemoveResourcesSpy(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }

                        var LightResult = Recruit.Core.CheckLight(VARIABLE.light, VARIABLE.id);
                        if (LightResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit light " +
                                                         LightResult + " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitLight(VARIABLE.id.ToString(), LightResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var light = int.Parse(VARIABLE.light, CultureInfo.InvariantCulture);
                                light -= Convert.ToInt32(LightResult);
                                VARIABLE.light = light.ToString();
                                Recruit.Core.RemoveResourcesLight(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }

                        if (int.Parse(VARIABLE.marcher, CultureInfo.InvariantCulture) != 0)
                        {
                            var MarcherResult = Recruit.Core.CheckMarcher(VARIABLE.marcher, VARIABLE.id);
                            if (MarcherResult != 0)
                            {
                                StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit marcher " +
                                                             MarcherResult + " in village " + VARIABLE.id);
                                var req =
                                    await
                                        Recruit.Request.RecruitMarcher(VARIABLE.id.ToString(), MarcherResult.ToString());
                                if (req.Contains("success"))
                                {
                                    //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                    var marcher = int.Parse(VARIABLE.marcher, CultureInfo.InvariantCulture);
                                    marcher -= Convert.ToInt32(MarcherResult);
                                    VARIABLE.marcher = marcher.ToString();
                                    Recruit.Core.RemoveResourcesMarcher(VARIABLE.id);
                                }
                                else
                                {
                                    //smth wrong
                                }
                            }
                        }


                        var HeavyResult = Recruit.Core.CheckHeavy(VARIABLE.heavy, VARIABLE.id);
                        if (HeavyResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit heavy " +
                                                         HeavyResult + " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitHeavy(VARIABLE.id.ToString(), HeavyResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var heavy = int.Parse(VARIABLE.heavy, CultureInfo.InvariantCulture);
                                heavy -= Convert.ToInt32(HeavyResult);
                                VARIABLE.heavy = heavy.ToString();
                                Recruit.Core.RemoveResourcesHeavy(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }

                        var RamResult = Recruit.Core.CheckRam(VARIABLE.ram, VARIABLE.id);
                        if (RamResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit ram " + RamResult +
                                                         " in village " + VARIABLE.id);
                            var req = await Recruit.Request.RecruitRam(VARIABLE.id.ToString(), RamResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var ram = int.Parse(VARIABLE.ram, CultureInfo.InvariantCulture);
                                ram -= Convert.ToInt32(RamResult);
                                VARIABLE.ram = ram.ToString();
                                Recruit.Core.RemoveResourcesRam(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }

                        var CatapultResult = Recruit.Core.CheckCatapult(VARIABLE.catapult, VARIABLE.id);
                        if (CatapultResult != 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to recruit catapult " +
                                                         CatapultResult + " in village " + VARIABLE.id);
                            var req =
                                await Recruit.Request.RecruitCatapult(VARIABLE.id.ToString(), CatapultResult.ToString());
                            if (req.Contains("success"))
                            {
                                //StaticVariables.LogsList.Add(DateTime.Now + " Request recruit spear " + SpearResult + " in village " + VARIABLE.id + " Success");
                                var catapult = int.Parse(VARIABLE.catapult, CultureInfo.InvariantCulture);
                                catapult -= Convert.ToInt32(CatapultResult);
                                VARIABLE.catapult = catapult.ToString();
                                Recruit.Core.RemoveResourcesCatapult(VARIABLE.id);
                            }
                            else
                            {
                                //smth wrong
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private async void FarmingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.NormalFarming)
                {
                    FarmingTimer.Interval = new TimeSpan(0, Convert.ToInt32(StaticVariables.FarmingInterval), 0);
                    foreach (var VARIABLE in StaticVariables.VillagesTemplate)
                    {
                        foreach (var VARIABLE2 in VARIABLE.Villages.Skip(VARIABLE.BreakPoint))
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Sending request to attack village (" +
                                                         VARIABLE2.X + "|" + VARIABLE2.Y + ")" + " from " +
                                                         VARIABLE.IDVillage);
                            var request =
                                await Attack.SendAttack.FirstRequest(VARIABLE.IDVillage, VARIABLE.Spear.ToString(),
                                    VARIABLE.Sword.ToString(), VARIABLE.Axe.ToString(), VARIABLE.Archer.ToString(),
                                    VARIABLE.Spy.ToString(), VARIABLE.Light.ToString(), VARIABLE.Marcher.ToString(),
                                    VARIABLE.Heavy.ToString(), VARIABLE.Ram.ToString(), VARIABLE.Catapult.ToString(),
                                    VARIABLE.Knight.ToString(), VARIABLE.Snob.ToString(), VARIABLE2.X.ToString(),
                                    VARIABLE2.Y.ToString(), StaticVariables.CatapultTargetFarming.ToLower());
                            if (request.Contains("errorxd"))
                            {
                                break;
                            }
                            else
                            {
                                VARIABLE.BreakPoint++;
                                if (VARIABLE.BreakPoint >= VARIABLE.Villages.Count)
                                {
                                    VARIABLE.BreakPoint = 0;
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private async void MarketTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.PremiumExchange)
                {
                    MarketTimer.Interval = new TimeSpan(0, 0, Convert.ToInt32(StaticVariables.RefreshSlider));
                    foreach (var VARIABLE in StaticVariables.MyVillages.ToList())
                    {
                        var x = await Market.GetData.CheckMarket(VARIABLE.village.id.ToString());
                        var json = Market.RegexAndJson.GetJson(x);
                        Market.RegexAndJson.SerialiseJson(json);
                        Market.Core.CalcRes(VARIABLE);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private async void LootAssistantTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.LootAssistantEnabled)
                {
                    LootAssistantTimer.Interval = new TimeSpan(0, Convert.ToInt32(StaticVariables.LootAssistantDelay), 0);
                    var villageid = StaticVariables.MyVillages.FirstOrDefault().village.id.ToString();
                    if (StaticVariables.LootAssistantOption1)
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings1(
                            villageid, "1");
                    }
                    else
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings1(
                            villageid, "0");
                    }

                    if (StaticVariables.LootAssistantOption2)
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings2(
                            villageid, "1");
                    }
                    else
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings2(
                            villageid, "0");
                    }

                    if (StaticVariables.LootAssistantOption3)
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings3(
                            villageid, "1");
                    }
                    else
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings3(
                            villageid, "0");
                    }

                    if (StaticVariables.LootAssistantOption4)
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings4(
                            villageid, "1");
                    }
                    else
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings4(
                            villageid, "0");
                    }


                    if (StaticVariables.LootAssistantOption5)
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings5(
                            villageid, "1");
                    }
                    else
                    {
                        await SilverBot.PremiumFarming.ChangeSettings.Settings5(
                            villageid, "0");
                    }

                    //pagesize
                    await
                        SilverBot.PremiumFarming.ChangeSettings.SettingsPageSize(
                            villageid,
                            Math.Ceiling(StaticVariables.AttackCountFarmPremium).ToString());
                    //gettemplates
                    var x =
                        await
                            SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                                villageid);
                    SilverBot.PremiumFarming.GetTemplates.regexTemplateFinder(x);
                    foreach (var VARIABLE in StaticVariables.Templates)
                    {
                        Console.WriteLine(VARIABLE);
                    }

                    if (StaticVariables.Method)
                    {
                        if (StaticVariables.Template == 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Selected method HttpClient and template A");
                            foreach (var VARIABLE in StaticVariables.MyVillages)
                            {
                                var targets = new List<string>();
                                var sq =
                                    await
                                        SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                                            VARIABLE.village.id.ToString());
                                targets = SilverBot.PremiumFarming.GetTargets.Targets(sq, targets);
                                foreach (var target in targets)
                                {
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending attack from " +
                                                                 VARIABLE.village.id.ToString() + " on target " + target);
                                    var s1 =
                                        await
                                            SilverBot.PremiumFarming.SendAttack.PremiumAttack(
                                                VARIABLE.village.id.ToString(), StaticVariables.Templates.ElementAt(0),
                                                target);
                                    if (s1.Contains("error") && StaticVariables.DynamicTemaplate)
                                    {
                                        StaticVariables.LogsList.Add(DateTime.Now +
                                                                     " Not enough army trying other template");
                                        var s2 =
                                            await
                                                SilverBot.PremiumFarming.SendAttack.PremiumAttack(
                                                    VARIABLE.village.id.ToString(),
                                                    StaticVariables.Templates.ElementAt(1), target);
                                        if (s2.Contains("error"))
                                        {
                                            break;
                                        }
                                    }
                                    var delay = Convert.ToInt32(StaticVariables.AttackPremiumDelay);
                                    if (StaticVariables.RandomDelayPremiumFarming)
                                    {
                                        Random rand = new Random();
                                        delay += rand.Next(0, 200);
                                    }
                                    StaticVariables.Lootassistantattackssent++;
                                    await Task.Delay(delay);
                                }
                            }
                        }
                        else if (StaticVariables.Template == 1)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Selected method HttpClient and template B");
                            foreach (var VARIABLE in StaticVariables.MyVillages)
                            {
                                var targets = new List<string>();
                                var sq =
                                    await
                                        SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                                            VARIABLE.village.id.ToString());
                                targets = SilverBot.PremiumFarming.GetTargets.Targets(sq, targets);
                                foreach (var target in targets)
                                {
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending attack from " +
                                                                 VARIABLE.village.id.ToString() + " on target " + target);
                                    var s1 =
                                        await
                                            SilverBot.PremiumFarming.SendAttack.PremiumAttack(
                                                VARIABLE.village.id.ToString(), StaticVariables.Templates.ElementAt(1),
                                                target);
                                    if (s1.Contains("error") && StaticVariables.DynamicTemaplate)
                                    {
                                        StaticVariables.LogsList.Add(DateTime.Now +
                                                                     " Not enough army trying other template");
                                        var s2 =
                                            await
                                                SilverBot.PremiumFarming.SendAttack.PremiumAttack(
                                                    VARIABLE.village.id.ToString(),
                                                    StaticVariables.Templates.ElementAt(0), target);
                                        if (s2.Contains("error"))
                                        {
                                            break;
                                        }
                                    }
                                    var delay = Convert.ToInt32(StaticVariables.AttackPremiumDelay);
                                    if (StaticVariables.RandomDelayPremiumFarming)
                                    {
                                        Random rand = new Random();
                                        delay += rand.Next(0, 200);
                                    }
                                    StaticVariables.Lootassistantattackssent++;
                                    await Task.Delay(delay);
                                }
                            }
                        }
                        //else if (StaticVariables.Template == 2)
                        //{
                        //    StaticVariables.LogsList.Add(DateTime.Now + " Selected method HttpClient and template C");
                        //    foreach (var VARIABLE in StaticVariables.MyVillages)
                        //    {
                        //        var targets = new List<string>();
                        //        var sq =
                        //            await
                        //                SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                        //                    VARIABLE.village.id.ToString());
                        //        targets = SilverBot.PremiumFarming.GetTargets.Targets(sq, targets);
                        //        foreach (var target in targets)
                        //        {
                        //            StaticVariables.LogsList.Add(DateTime.Now + " Sending attack from " + VARIABLE.village.id.ToString() + " on target " + target);
                        //            var s1 =
                        //                await
                        //                    SilverBot.PremiumFarming.SendAttack.PremiumAttack(
                        //                        VARIABLE.village.id.ToString(), StaticVariables.Templates.ElementAt(2),
                        //                        target);
                        //            var delay = Convert.ToInt32(StaticVariables.AttackPremiumDelay);
                        //            if (StaticVariables.RandomDelayPremiumFarming)
                        //            {
                        //                Random rand = new Random();
                        //                delay += rand.Next(0, 200);
                        //            }
                        //            StaticVariables.Lootassistantattackssent++;
                        //            await Task.Delay(delay);
                        //        }
                        //    }
                        //}
                    }
                    else
                    {
                        if (!Browser.Source.AbsoluteUri.Contains("&screen=am_farm"))
                        {
                            Browser.Visibility = Visibility.Hidden;
                            await
                                this.ShowMessageAsync("Error",
                                    "Your selected method in loot assistant is Javascript so your browser must be on loot assistant page");
                            Browser.Visibility = Visibility.Visible;
                            return;

                        }
                        if (StaticVariables.Template == 0)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Selected method JavaScript and template A");
                            foreach (var VARIABLE in StaticVariables.MyVillages)
                            {
                                var targets = new List<string>();
                                var sq =
                                    await
                                        SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                                            VARIABLE.village.id.ToString());
                                targets = SilverBot.PremiumFarming.GetTargets.Targets(sq, targets);
                                foreach (var target in targets)
                                {
                                    //var s1 = await SilverBot.PremiumFarming.SendAttack.PremiumAttack(VARIABLE.village.id.ToString(), StaticVariables.Templates.ElementAt(2), target);
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending attack from " +
                                                                 VARIABLE.village.id.ToString() + " on target " + target);
                                    var jsCode = "Accountmanager.farm.sendUnits(" + VARIABLE.village.id.ToString() +
                                                 ", " + target + ", " + StaticVariables.Templates.ElementAt(0) + ")";
                                    Browser.InvokeScript("execScript", new Object[] {jsCode, "JavaScript"});
                                    var delay = Convert.ToInt32(StaticVariables.AttackPremiumDelay);
                                    if (StaticVariables.RandomDelayPremiumFarming)
                                    {
                                        Random rand = new Random();
                                        delay += rand.Next(0, 200);
                                    }
                                    StaticVariables.Lootassistantattackssent++;
                                    await Task.Delay(delay);
                                }
                            }
                        }
                        else if (StaticVariables.Template == 1)
                        {
                            StaticVariables.LogsList.Add(DateTime.Now + " Selected method JavaScript and template B");
                            foreach (var VARIABLE in StaticVariables.MyVillages)
                            {
                                var targets = new List<string>();
                                var sq =
                                    await
                                        SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                                            VARIABLE.village.id.ToString());
                                targets = SilverBot.PremiumFarming.GetTargets.Targets(sq, targets);
                                foreach (var target in targets)
                                {
                                    //var s1 = await SilverBot.PremiumFarming.SendAttack.PremiumAttack(VARIABLE.village.id.ToString(), StaticVariables.Templates.ElementAt(2), target);
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending attack from " +
                                                                 VARIABLE.village.id.ToString() + " on target " + target);
                                    var jsCode = "Accountmanager.farm.sendUnits(this, " + VARIABLE.village.id.ToString() +
                                                 ", " + StaticVariables.Templates.ElementAt(1) + ")";
                                    Browser.InvokeScript("execScript", new Object[] {jsCode, "JavaScript"});
                                    var delay = Convert.ToInt32(StaticVariables.AttackPremiumDelay);
                                    if (StaticVariables.RandomDelayPremiumFarming)
                                    {
                                        Random rand = new Random();
                                        delay += rand.Next(0, 200);
                                    }
                                    StaticVariables.Lootassistantattackssent++;
                                    await Task.Delay(delay);
                                }
                            }
                        }
                        //else if (StaticVariables.Template == 2)
                        //{
                        //    foreach (var VARIABLE in StaticVariables.MyVillages)
                        //    {
                        //        var targets = new List<string>();
                        //        var sq =
                        //            await
                        //                SilverBot.PremiumFarming.EnterToLootAssistant.StandardEnter(
                        //                    VARIABLE.village.id.ToString());
                        //        targets = SilverBot.PremiumFarming.GetTargets.Targets(sq, targets);
                        //        foreach (var target in targets)
                        //        {
                        //            //var s1 = await SilverBot.PremiumFarming.SendAttack.PremiumAttack(VARIABLE.village.id.ToString(), StaticVariables.Templates.ElementAt(2), target);
                        //            var jsCode = "Accountmanager.farm.sendUnits(this, " + VARIABLE.village.id.ToString() +
                        //                         ", " + StaticVariables.Templates.ElementAt(2) + ")";
                        //            Browser.InvokeScript("execScript", new Object[] {jsCode, "JavaScript"});
                        //            var delay = Convert.ToInt32(StaticVariables.AttackPremiumDelay);
                        //            if (StaticVariables.RandomDelayPremiumFarming)
                        //            {
                        //                Random rand = new Random();
                        //                delay += rand.Next(0, 200);
                        //            }
                        //            StaticVariables.Lootassistantattackssent++;
                        //            await Task.Delay(delay);
                        //        }
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        void wbMain_Navigated(object sender, NavigationEventArgs e)
        {
            SetSilent(Browser, true); // make it silent
        }

        public async void SetSilent(WebBrowser browser, bool silent)
        {
            try
            {
                if (browser == null)
                    throw new ArgumentNullException("browser");

                // get an IWebBrowser2 from the document
                IOleServiceProvider sp = browser.Document as IOleServiceProvider;
                if (sp != null)
                {
                    Guid IID_IWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");
                    Guid IID_IWebBrowser2 = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");

                    object webBrowser;
                    sp.QueryService(ref IID_IWebBrowserApp, ref IID_IWebBrowser2, out webBrowser);
                    if (webBrowser != null)
                    {
                        webBrowser.GetType()
                            .InvokeMember("Silent",
                                BindingFlags.Instance | BindingFlags.Public | BindingFlags.PutDispProperty, null,
                                webBrowser, new object[] {silent});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }


        [ComImport, Guid("6D5140C1-7436-11CE-8034-00AA006009FA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IOleServiceProvider
        {
            [PreserveSig]
            int QueryService([In] ref Guid guidService, [In] ref Guid riid,
                [MarshalAs(UnmanagedType.IDispatch)] out object ppvObject);
        }

        private async void BuildTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.BuildEnabled)
                {
                    foreach (var VARIABLE in StaticVariables.MyVillagesBuild.ToList())
                    {
                        foreach (var variable2 in VARIABLE.ToList())
                        {
                            if (VARIABLE.Any(x => x.isupgrading == true))
                            {

                            }
                            else
                            {
                                var mywill =
                                    StaticVariables.MyVillages.Find(id => id.village.id.ToString() == variable2.id);
                                if (mywill.village == null)
                                {
                                    return;
                                }
                                var x = BuildQueue.Core.Calc(mywill, variable2.name);
                                if (x)
                                {
                                    if (mywill.village.buildqueue <= StaticVariables.maxBuildQueue)
                                    {
                                        StaticVariables.LogsList.Add(DateTime.Now + " Sending build request in " +
                                                                     variable2.id + " structure " + variable2.name);
                                        var result = await BuildQueue.BuildRequest.BuildRequestUp(
                                            variable2.name,
                                            variable2.id);
                                        if (result.Contains("success"))
                                        {
                                            var time = TimeFinder.finder(result);
                                            var id = TimeFinder.idfinder(result);
                                            variable2.isupgrading = true;
                                            variable2.lefttime = time;
                                            variable2.maxtime = time;
                                            variable2.idtoskip = id;
                                        }

                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (variable2.isupgrading)
                            {
                                variable2.lefttime -= 3;
                                //if (variable2.lefttime <= 179)
                                //{
                                //    StaticVariables.LogsList.Add(DateTime.Now + " Sending skip request in " + variable2.id + " structure " + variable2.name);
                                //    BuildQueue.BuildRequest.SkipRequest(variable2.id, variable2.idtoskip);
                                //    VARIABLE.Remove(variable2);
                                //    if (VARIABLE.Count == 0)
                                //    {
                                //        StaticVariables.MyVillagesBuild.Remove(VARIABLE);
                                //    }
                                //}
                                if (variable2.lefttime <= 0)
                                {
                                    VARIABLE.Remove(variable2);
                                    if (VARIABLE.Count == 0)
                                    {
                                        StaticVariables.MyVillagesBuild.Remove(VARIABLE);
                                    }
                                }
                            }


                            //var mywill = StaticVariables.MyVillages.Find(id => id.village.id.ToString() == variable2.id);
                            //if (mywill == null) return;
                            //var mywillindex =
                            //    StaticVariables.MyVillages.FindIndex(id => id.village.id.ToString() == variable2.id);
                            //if (mywill.village.id.ToString() == variable2.id)
                            //{
                            //    var x = BuildQueue.Core.Calc(mywill, variable2.name);
                            //    if (x)
                            //    {
                            //        if (mywill.village.buildqueue <= StaticVariables.maxBuildQueue)
                            //        {
                            //            if (variable2.upgrade == true)
                            //            {
                            //                StaticVariables.LogsList.Add(DateTime.Now + " Sending build request in " + variable2.id + " structure " + variable2.name);
                            //                var result = await BuildQueue.BuildRequest.BuildRequestUp(
                            //                    variable2.name,
                            //                    variable2.id);
                            //                if (result.Contains("success"))
                            //                {
                            //                    StaticVariables.BuildRequestSent++;
                            //                    StaticVariables.MyVillages.ElementAt(mywillindex).village.buildqueue++;
                            //                    VARIABLE.Remove(variable2);
                            //                    if (VARIABLE.Count == 0)
                            //                    {
                            //                        StaticVariables.MyVillagesBuild.Remove(VARIABLE);
                            //                    }
                            //                    break;
                            //                }
                            //            }
                            //            else if (variable2.upgrade == false)
                            //            {
                            //                StaticVariables.LogsList.Add(DateTime.Now + " Sending destroy request in " + variable2.id + " structure " + variable2.name);
                            //                var result = await BuildQueue.BuildRequest.BuildRequestDestroy(
                            //                    variable2.name,
                            //                    variable2.id);
                            //                if (result.Contains("success"))
                            //                {
                            //                    StaticVariables.BuildRequestSent++;
                            //                    StaticVariables.MyVillages.ElementAt(mywillindex).village.buildqueue++;
                            //                    VARIABLE.Remove(variable2);
                            //                    if (VARIABLE.Count == 0)
                            //                    {
                            //                        StaticVariables.MyVillagesBuild.Remove(VARIABLE);
                            //                    }
                            //                    break;
                            //                }
                            //            }
                            //        }
                            //    }
                            //    else
                            //    {
                            //        break;
                            //    }
                            //}

                        }
                    }
                    if (StaticVariables.AutoStorage)
                    {
                        foreach (var VARIABLE in StaticVariables.MyVillages)
                        {
                            if (VARIABLE.village.wood == VARIABLE.village.storage_max &&
                                VARIABLE.village.stone == VARIABLE.village.storage_max &&
                                VARIABLE.village.iron == VARIABLE.village.storage_max)
                            {
                                if (VARIABLE.village.buildqueue == 0)
                                {
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending auto storage request");
                                    var result =
                                        await
                                            BuildQueue.BuildRequest.BuildRequestUp("storage",
                                                VARIABLE.village.id.ToString());
                                    if (result.Contains("success"))
                                    {
                                        StaticVariables.BuildRequestSent++;
                                        VARIABLE.village.buildqueue++;
                                    }
                                }
                            }
                        }
                    }
                    if (StaticVariables.AutoFarm)
                    {
                        foreach (var VARIABLE in StaticVariables.MyVillages)
                        {
                            var maxspace = VARIABLE.village.pop_max;
                            var currentpop = VARIABLE.village.pop;
                            var result = currentpop/maxspace*100;
                            var r1 = 100;
                            var r2 = r1 - result;
                            if (r2 < StaticVariables.AutoFarmLeftSpace)
                            {
                                var x = BuildQueue.Core.Calc(VARIABLE, "Farm");
                                if (x)
                                {
                                    if (VARIABLE.village.buildqueue == 0)
                                    {
                                        StaticVariables.LogsList.Add(DateTime.Now + " Sending auto farm request");
                                        var end =
                                            await
                                                BuildQueue.BuildRequest.BuildRequestUp("farm",
                                                    VARIABLE.village.id.ToString());
                                        if (end.Contains("success"))
                                        {
                                            StaticVariables.BuildRequestSent++;
                                            VARIABLE.village.buildqueue++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (StaticVariables.DynamicStorage)
                    {
                        foreach (var VARIABLE in StaticVariables.MyVillagesBuild)
                        {
                            foreach (var VARIABLE2 in VARIABLE)
                            {
                                var name = VARIABLE2.name;
                                var id = VARIABLE2.id;
                                var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == id);
                                if (village == null)
                                {
                                    return;
                                }
                                var result = SilverBot.BuildQueue.CoreStorage.Calc(village, name);
                                if (result)
                                {
                                    var x = BuildQueue.Core.Calc(village, "Storage");
                                    if (x)
                                    {
                                        if (village.village.buildqueue == 0)
                                        {
                                            StaticVariables.LogsList.Add(DateTime.Now +
                                                                         " Sending dynamic storage request");
                                            var result2 = await BuildQueue.BuildRequest.BuildRequestUp("storage", id);
                                            if (result2.Contains("success"))
                                            {
                                                StaticVariables.BuildRequestSent++;
                                                StaticVariables.MyVillages.Find(d => d.village.id.ToString() == id)
                                                    .village.buildqueue++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private async void WorldTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (StaticVariables.WorldSync && StaticVariables.Sync)
                {
                    WorldSync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");

            }

        }

        private async void WorldSync()
        {
            try
            {
                StaticVariables.WorldNotParsed = string.Empty;
                StaticVariables.WorldVillages.Clear();
                await Task.Delay(200);
                StatusBarInfo.Content = "Downloading map...";
                await DownloadMapAndETC();
                StatusBarInfo.Content = "Last sync: " + DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private async void MyVillagesTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                MyVillagesTimer.Interval = new TimeSpan(0, Convert.ToInt32(StaticVariables.MyVillageSyncSlider), 0);
                if (StaticVariables.MyVillageSync && StaticVariables.Sync)
                {
                    await Task.Run(MyVillSync);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private async Task MyVillSync()
        {
            try
            {
                await this.Dispatcher.Invoke(async () =>
                {

                    MyvillOnlyID.Clear();
                    StatusBarInfo.Content = "Downloading your villages...";
                    await GetVillageList();
                    await DownloadVillage();
                    StatusBarInfo.Content = "Last sync: " + DateTime.Now.ToString();
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private async void SyncButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                GlobalSync();
            }
            catch (Exception)
            {
                
            }
        }

        public async void GlobalSync()
        {
            try
            {
                if (StaticVariables.Server == string.Empty || StaticVariables.World == string.Empty)
                {
                    Browser.Visibility = Visibility.Hidden;
                    await
                        this.ShowMessageAsync("Error",
                            "Please go to settings and select server and world in what we will play!");
                    Browser.Visibility = Visibility.Visible;
                }
                else
                {
                    if (!Browser.Source.AbsoluteUri.Contains("game.php?"))
                    {
                        Browser.Visibility = Visibility.Hidden;
                        await this.ShowMessageAsync("Error", "Please enter to game!");
                        Browser.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        StaticVariables.WorldNotParsed = string.Empty;
                        StaticVariables.WorldVillages.Clear();
                        StaticVariables.MyVillages.Clear();
                        StaticVariables.MyVillagesBuildings.Clear();
                        MyvillOnlyID.Clear();
                        SyncButton.IsEnabled = false;
                        StatusBarInfo.Content = "Downloading world settings...";
                        var watch = new Stopwatch();
                        watch.Start();
                        await DownloadMapAndETC();
                        await GetVillageList();
                        await DownloadVillage();
                        if (StaticVariables.MyVillages.FirstOrDefault().majorVersion.ToString() != StaticVariables.gameversion)
                        {
                            Browser.Visibility = Visibility.Hidden;
                            await
                                this.ShowMessageAsync("Game version",
                                    "Version of the game is different than the one in bot. Wait for update");
                            Environment.Exit(0);
                        }
                        StaticVariables.Token = StaticVariables.MyVillages.FirstOrDefault().csrf;
                        TimePingEtc.GetPing.Sync(StaticVariables.MyVillages.FirstOrDefault().village.id.ToString());
                        StatusBarInfo.Content = "Last sync: " + DateTime.Now.ToString();
                        watch.Stop();
                        MessageBox.Show("Downloaded all files in: " + watch.ElapsedMilliseconds + "ms", "Done!"
                        );
                        //////////var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);

                        //////////// Fill in the text elements
                        //////////var stringElements = toastXml.GetElementsByTagName("text");
                        //////////stringElements[0].AppendChild(toastXml.CreateTextNode("Title"));
                        //////////stringElements[1].AppendChild(toastXml.CreateTextNode("Content"));
                        StaticVariables.Sync = true;
                        SyncButton.IsEnabled = true;
                        MainMenu.IsEnabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public static void ThrowEx()
        {

        }

        public async Task DownloadMapAndETC()
        {
            try
            {
                StaticVariables.LogsList.Add(DateTime.Now + " Downloading world settings");
                await Task.Run(World.DownloadWorldSettings.World);
                StaticVariables.LogsList.Add(DateTime.Now + " Downloading map");
                await Task.Run(World.DownloadMap.Map);
                await Task.Run(World.WorldParser.Parser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        public async Task GetVillageList()
        {
            try
            {
                StaticVariables.LogsList.Add(DateTime.Now + " Downloading village list");
                var Result = await Task.Run(UserVillages.DownloadVillage.Download);
                var utc = Attack.FindServerUTC.utc(Result);
                StaticVariables.serverUTC = double.Parse(utc, CultureInfo.InvariantCulture);
                UserVillages.FindVillages.find(Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        public async Task DownloadVillage()
        {
            try
            {
                StaticVariables.LogsList.Add(DateTime.Now + " Downloading your villages");
                var temp = new List<UserVillages.VillageStructure.Example>();
                var temp2 = new List<UserVillages.VillageStructure.RootObject>();
                for (int i = 0; i < MyvillOnlyID.Count; i++)
                {
                    var x = await UserVillages.DownloadSpecifyVillage.Download(MyvillOnlyID.ElementAt(i));
                    var json = UserVillages.JsonFinder.Jsonfind(x);
                    var json2 = UserVillages.JsonFinder.FindJsonBuildings(x);
                    var response = await UserVillages.VillageParser.Parser(json);
                    var response2 = await UserVillages.VillageParser.ParserBuild(json2);
                    temp.Add(response);
                    temp2.Add(response2);
                    temp.ElementAt(i).village.buildings.buildingsReq =
                        temp2.ElementAt(0);
                    temp.ElementAt(i).village.buildqueue =
                        UserVillages.FindBuildqueue.findqueue(x);
                    var y = await UserVillages.ArmyRequest.Download(MyvillOnlyID.ElementAt(i));
                    temp.ElementAt(i).village.spear = UserVillages.FindArmy.GetDetailsSpear(y);
                    temp.ElementAt(i).village.sword = UserVillages.FindArmy.GetDetailsSword(y);
                    temp.ElementAt(i).village.axe = UserVillages.FindArmy.GetDetailsAxe(y);
                    temp.ElementAt(i).village.archer = UserVillages.FindArmy.GetDetailsArcher(y);
                    temp.ElementAt(i).village.spy = UserVillages.FindArmy.GetDetailsSpy(y);
                    temp.ElementAt(i).village.light = UserVillages.FindArmy.GetDetailsLight(y);
                    temp.ElementAt(i).village.marcher = UserVillages.FindArmy.GetDetailsMarcher(y);
                    temp.ElementAt(i).village.heavy = UserVillages.FindArmy.GetDetailsHeavy(y);
                    temp.ElementAt(i).village.ram = UserVillages.FindArmy.GetDetailsRam(y);
                    temp.ElementAt(i).village.catapult = UserVillages.FindArmy.GetDetailsCatapult(y);
                    temp.ElementAt(i).village.knight = UserVillages.FindArmy.GetDetailsKnight(y);
                    temp.ElementAt(i).village.snob = UserVillages.FindArmy.GetDetailsSnob(y);
                    temp.ElementAt(i).village.militia = UserVillages.FindArmy.GetDetailsMilitia(y);
                    StatusBarInfo.Content = "Downloading your villages... (" + (i + 1) + "/" + MyvillOnlyID.Count + ")";
                }
                StaticVariables.MyVillages = temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            var settingsWindows = new Windows.Settings();
            settingsWindows.Show();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void WorldItem_OnClick(object sender, RoutedEventArgs e)
        {
            var worldWindow = new Windows.World();
            worldWindow.Show();
        }

        private void BuildingsMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var buildingsWindow = new Windows.BuildingsWindow();
            buildingsWindow.Show();
        }

        private void QuickMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var homeWindows = new HomeBuildings();
            homeWindows.Show();
        }

        private void BuildQueueMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var buildqueueWindows = new Windows.BuildQueueNew();
            buildqueueWindows.Show();
        }

        private void ArmyMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var ArmyWindows = new Windows.ArmyWindow();
            ArmyWindows.Show();
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {

        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {

        }

        private void SendNowItem_OnClick(object sender, RoutedEventArgs e)
        {
            var SendnowWindows = new Windows.SendNow();
            SendnowWindows.Show();
        }

        private void FarmingItem_OnClick(object sender, RoutedEventArgs e)
        {
            var FarmingWindows = new Windows.Farming();
            FarmingWindows.Show();
        }

        private void FarmingTemplateItem_OnClick(object sender, RoutedEventArgs e)
        {
            var FarmingTemplateWindows = new Windows.FarmingTemplate();
            FarmingTemplateWindows.Show();
        }

        private void Browser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            if (StaticVariables.AutoResizeMap)
            {
                if (e.Uri.AbsoluteUri.Contains("&screen=map"))
                {
                    try
                    {
                        var jsCode = "TWMap.resize(" + StaticVariables.Size + ",false);";
                        Browser.InvokeScript("execScript", new Object[] { jsCode, "JavaScript" });
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void RecruitItem_OnClick(object sender, RoutedEventArgs e)
        {
            var RecruitWindows = new Windows.Recruit();
            RecruitWindows.Show();
        }

        private void AttackListItem_OnClick(object sender, RoutedEventArgs e)
        {
            var attacklistwindow =  new Windows.AttackListWindow();
            attacklistwindow.Show();
        }

    }
}

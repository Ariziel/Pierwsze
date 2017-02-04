using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : MetroWindow
    {
        System.Windows.Threading.DispatcherTimer DebugTimer = new System.Windows.Threading.DispatcherTimer();

        public Settings()
        {
            InitializeComponent();
            DebugTimer.Tick += DebugTimer_Tick;
            DebugTimer.Interval = new TimeSpan(0, 0, 1);
            DebugTimer.Start();
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes/1024f)/1024f;
        }

        private void DebugTimer_Tick(object sender, EventArgs e)
        {
            var Threads = Process.GetCurrentProcess().Threads;
            var Handle = Process.GetCurrentProcess().HandleCount;
            var Memory = Process.GetCurrentProcess().PagedMemorySize64;
            var StartTime = Process.GetCurrentProcess().StartTime;
            DebugThreadsTextBlock.Text = "Threads: " + Threads.Count;
            DebugHandleTextBlock.Text = "Handle count: " + Handle;
            DebugMemoryTextBlock.Text = "Memory: " + Memory + " (" + Math.Ceiling(ConvertBytesToMegabytes(Memory)) +
                                        "MB)";
            DebugStartTimeTextBlock.Text = "Start time: " + StartTime.ToString();
            PremiumAttackSent.Text = "Loot assistant attacks sent: " + StaticVariables.Lootassistantattackssent;
            BuildRequessent.Text = "Build request sent: " + StaticVariables.BuildRequestSent.ToString();
        }

        private void CustomWorldCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            CustomWorld.Visibility = Visibility.Visible;
            StaticVariables.CustomWorldCheckBox = true;
        }

        private void CustomWorldCheckBox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            CustomWorld.Visibility = Visibility.Hidden;
            StaticVariables.CustomWorldCheckBox = false;
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            StaticVariables.Server = ServerList.Text;
            StaticVariables.ServerShort = SilverBot.World.ServerSelector.Server(ServerList.Text);
            if (CustomWorldCheckBox.IsChecked == true)
            {
                StaticVariables.World = CustomWorld.Text;
            }
            else
            {
                StaticVariables.World = WorldNumeric.Value.ToString();
            }
            if (AutoStorageCheckBox.IsChecked == true)
            {
                StaticVariables.AutoStorage = true;
            }
            else
            {
                StaticVariables.AutoStorage = false;
            }
            if (AutoBuildCheckBox.IsChecked == true)
            {
                StaticVariables.BuildEnabled = true;
            }
            else
            {
                StaticVariables.BuildEnabled = false;
            }
            if (MyvillagesSync.IsChecked == true)
            {
                StaticVariables.MyVillageSync = true;
            }
            else
            {
                StaticVariables.MyVillageSync = false;
            }
            StaticVariables.MyVillageSyncSlider = MyvillagesSyncSlider.Value;
            if (WorldSync.IsChecked == true)
            {
                StaticVariables.WorldSync = true;
            }
            else
            {
                StaticVariables.WorldSync = false;
            }
            //loot assistant

            if (TemplateA.IsChecked == true)
            {
                StaticVariables.Template = 0;
            }
            else if (TemplateB.IsChecked == true)
            {
                StaticVariables.Template = 1;
            }
            else if (TemplateC.IsChecked == true)
            {
                StaticVariables.Template = 2;
            }

            if (EnablePremiumFarming.IsChecked == true)
            {
                StaticVariables.LootAssistantEnabled = true;
            }
            else
            {
                StaticVariables.LootAssistantEnabled = false;
            }

            if (JavascriptMethodRadio.IsChecked == true)
            {
                StaticVariables.Method = false;
            }
            else
            {
                StaticVariables.Method = true;
            }

            StaticVariables.LootAssistantDelay = FarmPremiumDelay.Value;

            if (FarmingPremiumOption1.IsChecked == true)
            {
                StaticVariables.LootAssistantOption1 = true;
            }
            else
            {
                StaticVariables.LootAssistantOption1 = false;
            }

            if (FarmingPremiumOption2.IsChecked == true)
            {
                StaticVariables.LootAssistantOption2 = true;
            }
            else
            {
                StaticVariables.LootAssistantOption2 = false;
            }

            if (FarmingPremiumOption3.IsChecked == true)
            {
                StaticVariables.LootAssistantOption3 = true;
            }
            else
            {
                StaticVariables.LootAssistantOption3 = false;
            }

            if (FarmingPremiumOption4.IsChecked == true)
            {
                StaticVariables.LootAssistantOption4 = true;
            }
            else
            {
                StaticVariables.LootAssistantOption4 = false;
            }

            if (FarmingPremiumOption5.IsChecked == true)
            {
                StaticVariables.LootAssistantOption5 = true;
            }
            else
            {
                StaticVariables.LootAssistantOption5 = false;
            }

            StaticVariables.AttackCountFarmPremium = AttackCountFarmPremium.Value;
            StaticVariables.AttackPremiumDelay = AttackPremiumDelay.Value;


            if (RandomDelayPremiumFarming.IsChecked == true)
            {
                StaticVariables.RandomDelayPremiumFarming = true;
            }
            else
            {
                StaticVariables.RandomDelayPremiumFarming = false;
            }

            if (AutoFarmCheckBox.IsChecked == true)
            {
                StaticVariables.AutoFarm = true;
            }
            else
            {
                StaticVariables.AutoFarm = false;
            }
            StaticVariables.AutoFarmLeftSpace = LeftSpaceSlider.Value;
            if (DynamicStorage.IsChecked == true)
            {
                StaticVariables.DynamicStorage = true;
            }
            else
            {
                StaticVariables.DynamicStorage = false;
            }
            if (PremiumExchange.IsChecked == true)
            {
                StaticVariables.PremiumExchange = true;
            }
            else
            {
                StaticVariables.PremiumExchange = false;
            }
            if (DynamicTemaplate.IsChecked == true)
            {
                StaticVariables.DynamicTemaplate = true;
            }
            else
            {
                StaticVariables.DynamicTemaplate = false;
            }
            StaticVariables.RefreshSlider = RefreshSlider.Value;
            if (NormalFarming.IsChecked == true)
            {
                StaticVariables.NormalFarming = true;
            }
            else
            {
                StaticVariables.NormalFarming = false;
            }
            StaticVariables.FarmingInterval = FarmingIterval.Value;
            if (AutoResizeMapCheckBox.IsChecked == true)
            {
                StaticVariables.AutoResizeMap = true;
            }
            else
            {
                StaticVariables.AutoResizeMap = false;
            }
            StaticVariables.Size = SizeSlider.Value;
            StaticVariables.CatapultTargetFarming = CatapultTargetFarming.Text;

            //recruit
            if (EnableRecruitCheckBox.IsChecked == true)
            {
                StaticVariables.EnableRecruit = true;
            }
            else
            {
                StaticVariables.EnableRecruit = false;
            }
            StaticVariables.MinimumInfantryPackage = InfantryPackage.Value.Value;
            StaticVariables.MinimumCavalaryPackage = CavalaryPackage.Value.Value;
            StaticVariables.MinimumOthersPackage = OthersPackage.Value.Value;
            StaticVariables.RecruitDelay = RecruitDelay.Value;

            //attack
            if (EnableAttackCheckBox.IsChecked == true)
            {
                StaticVariables.EnableAttack = true;
            }
            else
            {
                StaticVariables.EnableAttack = false;
            }
            StaticVariables.TimeFix = TimeFixSlider.Value;

            //attack detector
            if (AttackDetector.IsChecked == true)
            {
                StaticVariables.AttackDetector = true;
            }
            else
            {
                StaticVariables.AttackDetector = false;
            }
            StaticVariables.AttackDetectorInterval = AttackDetectorInterval.Value;
            StaticVariables.AttackDetectorOption = AttackDetectorOption.Text;
            this.Close();
        }

        private void Settings_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DebugList.ItemsSource = StaticVariables.LogsList;
            }
            catch (Exception)
            {

            }          
            ServerList.Text = StaticVariables.Server;
            if (StaticVariables.CustomWorldCheckBox)
            {
                CustomWorld.Visibility = Visibility.Visible;
                CustomWorldCheckBox.IsChecked = true;
                CustomWorld.Text = StaticVariables.World;
            }
            else
            {
                if (StaticVariables.World != string.Empty)
                {
                    WorldNumeric.Value = int.Parse(StaticVariables.World, CultureInfo.InvariantCulture);
                }
            }
            MyvillagesSyncSlider.Value = StaticVariables.MyVillageSyncSlider;
            if (StaticVariables.MyVillageSync)
            {
                MyvillagesSync.IsChecked = true;
                YourVillagesTextBlock.Text = "Your villages";
            }
            else
            {
                MyvillagesSync.IsChecked = false;
                YourVillagesTextBlock.Text =
    "Your villages - WARNING! if you disable this option, farming, building, attacking and other functions will not work";
            }
            if (StaticVariables.WorldSync)
            {
                WorldSync.IsChecked = true;
            }
            else
            {
                WorldSync.IsChecked = false;
            }
            if (StaticVariables.BuildEnabled)
            {
                AutoBuildCheckBox.IsChecked = true;
            }
            else
            {
                AutoBuildCheckBox.IsChecked = false;
            }

            if (StaticVariables.AutoStorage == true)
            {
                AutoStorageCheckBox.IsChecked = true;
            }
            else
            {
                AutoStorageCheckBox.IsChecked = false;
            }

            //Loot Assistant
            if (StaticVariables.LootAssistantEnabled == true)
            {
                EnablePremiumFarming.IsChecked = true;
            }
            else
            {
                EnablePremiumFarming.IsChecked = false;
            }

            if (StaticVariables.Method == true)
            {
                HttpMethodRadio.IsChecked = true;
            }
            else
            {
                JavascriptMethodRadio.IsChecked = true;
            }

            if (StaticVariables.Template == 0)
            {
                TemplateA.IsChecked = true;
            }
            else if (StaticVariables.Template == 1)
            {
                TemplateB.IsChecked = true;
            }
            else if (StaticVariables.Template == 2)
            {
                TemplateC.IsChecked = true;
            }

            FarmPremiumDelay.Value = StaticVariables.LootAssistantDelay;

            if (StaticVariables.LootAssistantOption1 == true)
            {
                FarmingPremiumOption1.IsChecked = true;
            }
            else
            {
                FarmingPremiumOption1.IsChecked = false;
            }


            if (StaticVariables.LootAssistantOption2 == true)
            {
                FarmingPremiumOption2.IsChecked = true;
            }
            else
            {
                FarmingPremiumOption2.IsChecked = false;
            }

            if (StaticVariables.LootAssistantOption3 == true)
            {
                FarmingPremiumOption3.IsChecked = true;
            }
            else
            {
                FarmingPremiumOption3.IsChecked = false;
            }

            if (StaticVariables.LootAssistantOption4 == true)
            {
                FarmingPremiumOption4.IsChecked = true;
            }
            else
            {
                FarmingPremiumOption4.IsChecked = false;
            }


            if (StaticVariables.LootAssistantOption5 == true)
            {
                FarmingPremiumOption5.IsChecked = true;
            }
            else
            {
                FarmingPremiumOption5.IsChecked = false;
            }

            AttackCountFarmPremium.Value = StaticVariables.AttackCountFarmPremium;
            AttackPremiumDelay.Value = StaticVariables.AttackPremiumDelay;

            if (StaticVariables.RandomDelayPremiumFarming == true)
            {
                RandomDelayPremiumFarming.IsChecked = true;
            }
            else
            {
                RandomDelayPremiumFarming.IsChecked = false;
            }

            if (StaticVariables.AutoFarm)
            {
                AutoFarmCheckBox.IsChecked = true;
            }
            else
            {
                AutoFarmCheckBox.IsChecked = false;
            }
            LeftSpaceSlider.Value = StaticVariables.AutoFarmLeftSpace;
            if (StaticVariables.DynamicStorage)
            {
                DynamicStorage.IsChecked = true;
            }
            else
            {
                DynamicStorage.IsChecked = false;
            }
            if (StaticVariables.DynamicTemaplate)
            {
                DynamicTemaplate.IsChecked = true;
            }
            else
            {
                DynamicTemaplate.IsChecked = false;
            }
            if (StaticVariables.PremiumExchange)
            {
                PremiumExchange.IsChecked = true;
            }
            else
            {
                PremiumExchange.IsChecked = false;
            }
            RefreshSlider.Value = StaticVariables.RefreshSlider;
            if (StaticVariables.NormalFarming)
            {
                NormalFarming.IsChecked = true;                
            }
            else
            {
                NormalFarming.IsChecked = false;
            }
            if (StaticVariables.AutoResizeMap)
            {
                AutoResizeMapCheckBox.IsChecked = true;
            }
            else
            {
                AutoResizeMapCheckBox.IsChecked = false;
            }
            SizeSlider.Value = StaticVariables.Size;            
            CatapultTargetFarming.Text = StaticVariables.CatapultTargetFarming;
            FarmingIterval.Value = StaticVariables.FarmingInterval;
            //recruit
            if (StaticVariables.EnableRecruit)
            {
                EnableRecruitCheckBox.IsChecked = true;
            }
            else
            {
                EnableRecruitCheckBox.IsChecked = false;
            }
            InfantryPackage.Value = StaticVariables.MinimumInfantryPackage;
            CavalaryPackage.Value = StaticVariables.MinimumCavalaryPackage;
            OthersPackage.Value = StaticVariables.MinimumOthersPackage;
            RecruitDelay.Value = StaticVariables.RecruitDelay;

            //attack
            if (StaticVariables.EnableAttack)
            {
                EnableAttackCheckBox.IsChecked = true;
            }
            else
            {
                EnableAttackCheckBox.IsChecked = false;
            }
            TimeFixSlider.Value = StaticVariables.TimeFix;
            
            //attack detector
            if (StaticVariables.AttackDetector)
            {
                AttackDetector.IsChecked = true;
            }
            else
            {
                AttackDetector.IsChecked = false;
            }
            AttackDetectorInterval.Value = StaticVariables.AttackDetectorInterval;
            AttackDetectorOption.Text = StaticVariables.AttackDetectorOption;
        }

        public static string Md5(string blank, string salt)
        {
            byte[] buffer2 = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(blank + salt));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer2.Length; i++)
            {
                builder.Append(buffer2[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}

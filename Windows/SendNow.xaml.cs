using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using SilverBot.Attack;
using SilverBot.World;

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for SendNow.xaml
    /// </summary>
    public partial class SendNow : MetroWindow
    {
        public DispatcherTimer TDispatcherTimer = new DispatcherTimer();
        public SendNow()
        {
            InitializeComponent();
            TDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            TDispatcherTimer.Tick += TDispatcherTimer_Tick;
            TDispatcherTimer.Start();

        }

        private void TDispatcherTimer_Tick(object sender, EventArgs e)
        {
            DateHours.SetValue(TextBoxHelper.WatermarkProperty, DateTime.Now.ToString("hh:mm:ss.fff"));
        }

        private void SendNow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var items = from p in StaticVariables.WorldVillages
                select p;
            TargetDataGrid.ItemsSource = items;
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                FromComboBox.Items.Add(VARIABLE.village.name);
            }
        }

        private void Targets_TextChanged(object sender, TextChangedEventArgs e)
        {
            var items = from p in StaticVariables.WorldVillages
                where p.Name.Contains(Targets.Text)
                select p;
            TargetDataGrid.ItemsSource = items;
        }

        private async void SendAttack_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var FromVillage = StaticVariables.MyVillages.Find(x => x.village.name == FromComboBox.Text);
                var FromID = FromVillage.village.id.ToString();
                var type = false;
                var typeTXT = "";
                var InTime = TimeCheckBox.IsChecked.Value;

                var spearUse = false;
                spearUse = SpearCountTextBox.Text != "";

                var swordUse = false;
                swordUse = SwordCountTextBox.Text != "";

                var axeUse = false;
                axeUse = AxeCountTextBox.Text != "";

                var archerUse = false;
                archerUse = ArcherCountTextBox.Text != "";

                var spyUse = false;
                spyUse = SpyCountTextBox.Text != "";

                var lightUse = false;
                lightUse = LightCountTextBox.Text != "";

                var marcherUse = false;
                marcherUse = MarcherCountTextBox.Text != "";

                var heavyUse = false;
                heavyUse = HeavyCountTextBox.Text != "";

                var ramUse = false;
                ramUse = RamCountTextBox.Text != "";

                var catapultUse = false;
                catapultUse = CatapultCountTextBox.Text != "";

                var knightUse = false;
                knightUse = KnightCountTextBox.Text != "";

                var snobUse = false;
                snobUse = SnobCountTextBox.Text != "";

                if (AttackRadio.IsChecked == true)
                {
                    type = true;
                    typeTXT = "Attack";
                }
                else if (SupportRadio.IsChecked == true)
                {
                    type = false;
                    typeTXT = "Support";
                }
                var AttackCount = AttackCountNumeric.Value;
                var exploit = false;
                if (ExploitCheckBox.IsChecked == true)
                {
                    exploit = true;
                }
                else
                {
                    exploit = false;
                }
                var targetId = TargetDataGrid.SelectedItem as WorldVillagesStructure;
                Console.WriteLine(FromID);
                Console.WriteLine(type);
                Console.WriteLine(AttackCount);
                Console.WriteLine(exploit);
                Console.WriteLine(targetId.ID);
                TimeSpan CastTime = new TimeSpan();
                DateTime LandTimeDay = new DateTime();
                DateTime Time = new DateTime();
                if (InTime)
                {
                    var roadtime = Attack.RoadTime.Road(spearUse, swordUse, axeUse, archerUse, spyUse, lightUse, marcherUse, heavyUse, ramUse, catapultUse, knightUse, snobUse, int.Parse(FromVillage.village.x.ToString(), CultureInfo.InvariantCulture), int.Parse(FromVillage.village.y.ToString(), CultureInfo.InvariantCulture), int.Parse(targetId.X, CultureInfo.InvariantCulture), int.Parse(targetId.Y, CultureInfo.InvariantCulture));
                    LandTimeDay = (DateTime)DatePickerHours.SelectedDate;
                    var HoursMinuteSecMilisec = DateTime.Parse(DateHours.Text, CultureInfo.InvariantCulture);
                    TimeSpan ts = new TimeSpan(0, HoursMinuteSecMilisec.Hour, HoursMinuteSecMilisec.Minute, HoursMinuteSecMilisec.Second, HoursMinuteSecMilisec.Millisecond);
                    LandTimeDay = LandTimeDay.Date + ts;
                    CastTime = LandTimeDay - roadtime;
                    var test = CastTime.TotalMilliseconds;
                    var posixTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
                    Time = posixTime.AddMilliseconds(test);
                    Time = Time.AddSeconds(StaticVariables.serverUTC);
                }
              
                //var data2 = roadtime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

                //var data4 = data1 - data2;
                //var posixTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
                //var CastTime = posixTime.AddMilliseconds(data4);
                //CastTime = CastTime.AddMilliseconds(StaticVariables.TimeDiff);
                //var ping = StaticVariables.Ping * (-1);
                //CastTime = CastTime.AddMilliseconds(ping);
                //CastTime = CastTime.AddMilliseconds(ping);
                //CastTime = CastTime.AddMilliseconds(TimeFixSlider.Value);
                //Console.WriteLine(CastTime);
                if (InTime)
                {
                    StaticVariables.AttackList.Add(new Attack.Structure
                    {
                        id = FromVillage.village.id.ToString(),
                        type = typeTXT,
                        from = FromVillage.village.name,
                        to = targetId.Name,
                        x = targetId.X,
                        y = targetId.Y,
                        count = AttackCount.ToString(),
                        casttime = Time.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                        landtime = LandTimeDay.ToString(),
                        catapulttarget = CatapultTargetCombobBox.Text,
                        spear = SpearCountTextBox.Text,
                        sword = SwordCountTextBox.Text,
                        axe = AxeCountTextBox.Text,
                        archer = ArcherCountTextBox.Text,
                        spy = SpyCountTextBox.Text,
                        light = LightCountTextBox.Text,
                        marcher = MarcherCountTextBox.Text,
                        heavy = HeavyCountTextBox.Text,
                        ram = RamCountTextBox.Text,
                        catapult = CatapultCountTextBox.Text,
                        knight = KnightCountTextBox.Text,
                        snob = SnobCountTextBox.Text
                    });
                    StaticVariables.AttackID++;
                }
                else
                {
                    if (exploit)
                    {
                        if (type)
                        {
                            for (int i = 0; i < AttackCountNumeric.Value; i++)
                            {
                                Attack.SendAttack.FirstRequest(FromID, SpearCountTextBox.Text, SwordCountTextBox.Text,
                                    AxeCountTextBox.Text, ArcherCountTextBox.Text, SpyCountTextBox.Text,
                                    LightCountTextBox.Text,
                                    MarcherCountTextBox.Text, HeavyCountTextBox.Text, RamCountTextBox.Text,
                                    CatapultCountTextBox.Text, KnightCountTextBox.Text, SnobCountTextBox.Text, targetId.X,
                                    targetId.Y, CatapultTargetCombobBox.Text);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < AttackCountNumeric.Value; i++)
                            {

                                Attack.SendAttack.FirstRequestSupport(FromID, SpearCountTextBox.Text, SwordCountTextBox.Text,
                                    AxeCountTextBox.Text, ArcherCountTextBox.Text, SpyCountTextBox.Text,
                                    LightCountTextBox.Text,
                                    MarcherCountTextBox.Text, HeavyCountTextBox.Text, RamCountTextBox.Text,
                                    CatapultCountTextBox.Text, KnightCountTextBox.Text, SnobCountTextBox.Text, targetId.X,
                                    targetId.Y, CatapultTargetCombobBox.Text);
                            }
                        }
                    }
                    else
                    {
                        if (type)
                        {
                            for (int i = 0; i < AttackCountNumeric.Value; i++)
                            {
                                var result =
                                    await
                                        Attack.SendAttack.FirstRequest(FromID, SpearCountTextBox.Text,
                                            SwordCountTextBox.Text,
                                            AxeCountTextBox.Text, ArcherCountTextBox.Text, SpyCountTextBox.Text,
                                            LightCountTextBox.Text,
                                            MarcherCountTextBox.Text, HeavyCountTextBox.Text, RamCountTextBox.Text,
                                            CatapultCountTextBox.Text, KnightCountTextBox.Text, SnobCountTextBox.Text,
                                            targetId.X,
                                            targetId.Y, CatapultTargetCombobBox.Text);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < AttackCountNumeric.Value; i++)
                            {
                                var result =
                                    await
                                        Attack.SendAttack.FirstRequestSupport(FromID, SpearCountTextBox.Text,
                                            SwordCountTextBox.Text,
                                            AxeCountTextBox.Text, ArcherCountTextBox.Text, SpyCountTextBox.Text,
                                            LightCountTextBox.Text,
                                            MarcherCountTextBox.Text, HeavyCountTextBox.Text, RamCountTextBox.Text,
                                            CatapultCountTextBox.Text, KnightCountTextBox.Text, SnobCountTextBox.Text,
                                            targetId.X,
                                            targetId.Y, CatapultTargetCombobBox.Text);
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

            }
            await this.ShowMessageAsync("Attack request", "Done");

        }

        private void FromComboBox_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                var MySelectedVillages = StaticVariables.MyVillages.Find(x => x.village.name == FromComboBox.Text);
                SpearCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.spear);
                SwordCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.sword);
                AxeCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.axe);
                ArcherCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.archer);
                SpyCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.spy);
                LightCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.light);
                MarcherCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.marcher);
                HeavyCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.heavy);
                RamCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.ram);
                CatapultCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.catapult);
                KnightCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.knight);
                SnobCountTextBox.SetValue(TextBoxHelper.WatermarkProperty, MySelectedVillages.village.snob);
            }
            catch (Exception)
            {
                    

            }

        }

        private void XSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (YSearch.Text != "")
            {
                var items = from p in StaticVariables.WorldVillages
                            where p.X.Contains(XSearch.Text) && p.Y.Contains(YSearch.Text)
                            select p;
                TargetDataGrid.ItemsSource = items;

            }
            else
            {
                var items = from p in StaticVariables.WorldVillages
                            where p.X.Contains(XSearch.Text)
                            select p;
                TargetDataGrid.ItemsSource = items;

            }

        }

        private void YSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (XSearch.Text != "")
            {
                var items = from p in StaticVariables.WorldVillages
                            where p.Y.Contains(YSearch.Text) && p.X.Contains(XSearch.Text)
                            select p;
                TargetDataGrid.ItemsSource = items;
            }
            else
            {
                var items = from p in StaticVariables.WorldVillages
                            where p.Y.Contains(YSearch.Text)
                            select p;
                TargetDataGrid.ItemsSource = items;
            }

        }
    }
}

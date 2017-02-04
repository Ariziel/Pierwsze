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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using SilverBot.Farming;

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for FarmingTemplate.xaml
    /// </summary>
    public partial class FarmingTemplate : MetroWindow
    {
        public FarmingTemplate()
        {
            InitializeComponent();
        }

        private async void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            var SelectedTemp = StaticVariables.CustomTemplates.Find(x => x.Name == TemplateListComboBox.Text);
            var SelectedVillage = StaticVariables.MyVillages.Find(z => z.village.name == VillageListComboBox.Text);
            if (SelectedTemp.Barbarian)
            {
                var villagestoattack = from villages in StaticVariables.WorldVillages
                                       where int.Parse(villages.IDPlayer, CultureInfo.InvariantCulture) == 0
                                       where
                                       double.Parse(villages.Points, CultureInfo.InvariantCulture) > SelectedTemp.PointsMin &&
                                       double.Parse(villages.Points, CultureInfo.InvariantCulture) < SelectedTemp.PointsMax
                                       where
                                       Math.Pow(double.Parse(villages.X, CultureInfo.InvariantCulture) - SelectedVillage.village.x, 2) +
                                       Math.Pow(double.Parse(villages.Y, CultureInfo.InvariantCulture) - SelectedVillage.village.y, 2) < Math.Pow(SelectedTemp.Radius, 2)
                                       select villages;
                StaticVariables.VillagesTemplate.Add(new SilverBot.Farming.VillagesTemplateStucture
                {
                    IDVillage = SelectedVillage.village.id.ToString(),
                    TemplateName = SelectedTemp.Name,
                    Villages = villagestoattack.ToList(),
                    Spear = SelectedTemp.Spear,
                    Sword = SelectedTemp.Sword,
                    Axe = SelectedTemp.Axe,
                    Archer = SelectedTemp.Archer,
                    Spy = SelectedTemp.Spy,
                    Light = SelectedTemp.Light,
                    Marcher = SelectedTemp.Marcher,
                    Heavy = SelectedTemp.Heavy,
                    Ram = SelectedTemp.Ram,
                    Catapult = SelectedTemp.Catapult,
                    Knight = SelectedTemp.Knight,
                    Snob = SelectedTemp.Snob,
                    BreakPoint = 0,
                });
                var distinctItems = StaticVariables.VillagesTemplate.GroupBy(x => x.IDVillage).Select(y => y.Last());
                StaticVariables.VillagesTemplate = distinctItems.ToList();
                await this.ShowMessageAsync("Saved", "Generated villages: " + villagestoattack.Count());
            }
            else
            {
                var villagestoattack = from villages in StaticVariables.WorldVillages
                                       where
                                       double.Parse(villages.Points, CultureInfo.InvariantCulture) > SelectedTemp.PointsMin &&
                                       double.Parse(villages.Points, CultureInfo.InvariantCulture) < SelectedTemp.PointsMax
                                       where
                                       Math.Pow(double.Parse(villages.X, CultureInfo.InvariantCulture) - SelectedVillage.village.x, 2) +
                                       Math.Pow(double.Parse(villages.Y, CultureInfo.InvariantCulture) - SelectedVillage.village.y, 2) < Math.Pow(SelectedTemp.Radius, 2)
                                       select villages;
                StaticVariables.VillagesTemplate.Add(new SilverBot.Farming.VillagesTemplateStucture
                {
                    IDVillage = SelectedVillage.village.id.ToString(),
                    TemplateName = SelectedTemp.Name,
                    Villages = villagestoattack.ToList(),
                    Spear = SelectedTemp.Spear,
                    Sword = SelectedTemp.Sword,
                    Axe = SelectedTemp.Axe,
                    Archer = SelectedTemp.Archer,
                    Spy = SelectedTemp.Spy,
                    Light = SelectedTemp.Light,
                    Marcher = SelectedTemp.Marcher,
                    Heavy = SelectedTemp.Heavy,
                    Ram = SelectedTemp.Ram,
                    Catapult = SelectedTemp.Catapult,
                    Knight = SelectedTemp.Knight,
                    Snob = SelectedTemp.Snob,
                    BreakPoint = 0,
                });
                var distinctItems = StaticVariables.VillagesTemplate.GroupBy(x => x.IDVillage).Select(y => y.Last());
                StaticVariables.VillagesTemplate = distinctItems.ToList();
                await this.ShowMessageAsync("Saved", "Generated villages: " + villagestoattack.Count());
            }

            VillTempDatagrid.ItemsSource = StaticVariables.VillagesTemplate;
            //VillTempDatagrid.Items.Clear();

            //foreach (var commandBinding in StaticVariables.VillagesTemplate)
            //{
            //    VillTempDatagrid.Items.Add(new VillagesTemplateStucture()
            //    {
            //        IDVillage =
            //            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == commandBinding.IDVillage)
            //                .village.name,
            //        TemplateName = commandBinding.TemplateName,
            //    });
            //}
        }

        private void FarmingTemplate_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var villages in StaticVariables.MyVillages)
            {
                VillageListComboBox.Items.Add(villages.village.name);
            }
            foreach (var templates in StaticVariables.CustomTemplates)
            {
                TemplateListComboBox.Items.Add(templates.Name);
            }
            VillTempDatagrid.ItemsSource = StaticVariables.VillagesTemplate;
            //foreach (var commandBinding in StaticVariables.VillagesTemplate)
            //{
            //    VillTempDatagrid.Items.Add(new VillagesTemplateStucture()
            //    {
            //        IDVillage =
            //            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == commandBinding.IDVillage)
            //                .village.name,
            //        TemplateName = commandBinding.TemplateName,
            //    });
            //}
        }
    }
}

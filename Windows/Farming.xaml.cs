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
    /// Interaction logic for Farming.xaml
    /// </summary>
    public partial class Farming : MetroWindow
    {
        public Farming()
        {
            InitializeComponent();
        }

        private async void SaveTemplate_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StaticVariables.CustomTemplates.Any(x => x.Name.Contains(TemplateName.Text)))
                {
                    await this.ShowMessageAsync("Error", "That name already exists");
                    return;
                }
                StaticVariables.CustomTemplates.Add(new FarmingTemplateStructure
                {
                    Name = TemplateName.Text,
                    Barbarian = OnlyBarbCheckBox.IsChecked.Value,
                    PointsMin = PointsRange.LowerValue,
                    PointsMax = PointsRange.UpperValue,
                    Radius = RadiusUpDown.Value.Value,
                    Spear = int.Parse(SpearCountTextBox.Text, CultureInfo.InvariantCulture),
                    Sword = int.Parse(SwordCountTextBox.Text, CultureInfo.InvariantCulture),
                    Axe = int.Parse(AxeCountTextBox.Text, CultureInfo.InvariantCulture),
                    Archer = int.Parse(ArcherCountTextBox.Text, CultureInfo.InvariantCulture),
                    Spy = int.Parse(SpyCountTextBox.Text, CultureInfo.InvariantCulture),
                    Light = int.Parse(LightCountTextBox.Text, CultureInfo.InvariantCulture),
                    Marcher = int.Parse(MarcherCountTextBox.Text, CultureInfo.InvariantCulture),
                    Heavy = int.Parse(HeavyCountTextBox.Text, CultureInfo.InvariantCulture),
                    Ram = int.Parse(RamCountTextBox.Text, CultureInfo.InvariantCulture),
                    Catapult = int.Parse(CatapultCountTextBox.Text, CultureInfo.InvariantCulture),
                    Knight = int.Parse(KnightCountTextBox.Text, CultureInfo.InvariantCulture),
                    Snob = int.Parse(SnobCountTextBox.Text, CultureInfo.InvariantCulture)
                });
                await this.ShowMessageAsync("", "Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            TemplatesListComboBox.Items.Clear();
            foreach (var commandBinding in StaticVariables.CustomTemplates)
            {
                TemplatesListComboBox.Items.Add(commandBinding.Name);
            }
        }

        private void SpearCountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RemoveTempButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                StaticVariables.CustomTemplates.RemoveAt(TemplatesListComboBox.SelectedIndex);
                TemplatesListComboBox.Items.Clear();
                foreach (var commandBinding in StaticVariables.CustomTemplates)
                {
                    TemplatesListComboBox.Items.Add(commandBinding.Name);
                }
            }
            catch (Exception)
            {

            }

        }

        private void Farming_OnLoaded(object sender, RoutedEventArgs e)
        {
            TemplatesListComboBox.Items.Clear();
            
            foreach (var VARIABLE in StaticVariables.CustomTemplates)
            {
                TemplatesListComboBox.Items.Add(VARIABLE.Name);
            }
        }
    }
}

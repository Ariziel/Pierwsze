using System;
using System.Collections.Generic;
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
using SilverBot.Structure.User.Recruit;

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for Recruit.xaml
    /// </summary>
    public partial class Recruit : MetroWindow
    {
        public Recruit()
        {
            InitializeComponent();
        }

        private void Recruit_OnLoaded(object sender, RoutedEventArgs e)
        {
            YourVillage.Items.Clear();
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                YourVillage.Items.Add(VARIABLE.village.name);
            }
        }

        private void YourVillage_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                var Id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
                var army = StaticVariables.RecruitList.Find(x => x.id == Id.ToString());
                if (army != null)
                {
                    SpearCountTextBox.Text = army.spear;
                    SwordCountTextBox.Text = army.sword;
                    AxeCountTextBox.Text = army.axe;
                    ArcherCountTextBox.Text = army.archer;
                    SpyCountTextBox.Text = army.spy;
                    LightCountTextBox.Text = army.light;
                    MarcherCountTextBox.Text = army.marcher;
                    HeavyCountTextBox.Text = army.heavy;
                    RamCountTextBox.Text = army.ram;
                    CatapultCountTextBox.Text = army.catapult;
                }

            }
            catch (Exception)
            {

            }
 
        }

        private async void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            var Id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            var army = new Structure.User.Recruit.RecruitStructure();
            var con = StaticVariables.RecruitList.Find(z => z.id == Id.ToString());
            var conindex = StaticVariables.RecruitList.FindIndex(z => z.id == Id.ToString());
            army.id = Id.ToString();
            army.spear = SpearCountTextBox.Text;
            army.sword = SwordCountTextBox.Text;
            army.axe = AxeCountTextBox.Text;
            army.archer = ArcherCountTextBox.Text;
            army.spy = SpyCountTextBox.Text;
            army.light = LightCountTextBox.Text;
            army.marcher = MarcherCountTextBox.Text;
            army.heavy = HeavyCountTextBox.Text;
            army.ram = RamCountTextBox.Text;
            army.catapult = CatapultCountTextBox.Text;
            if (conindex != -1)
            {
                StaticVariables.RecruitList.ElementAt(conindex).id = army.id;
                StaticVariables.RecruitList.ElementAt(conindex).spear = army.spear;
                StaticVariables.RecruitList.ElementAt(conindex).sword = army.sword;
                StaticVariables.RecruitList.ElementAt(conindex).axe = army.axe;
                StaticVariables.RecruitList.ElementAt(conindex).archer = army.archer;
                StaticVariables.RecruitList.ElementAt(conindex).spy = army.spy;
                StaticVariables.RecruitList.ElementAt(conindex).light = army.light;
                StaticVariables.RecruitList.ElementAt(conindex).marcher = army.marcher;
                StaticVariables.RecruitList.ElementAt(conindex).heavy = army.heavy;
                StaticVariables.RecruitList.ElementAt(conindex).ram = army.ram;
                StaticVariables.RecruitList.ElementAt(conindex).catapult = army.catapult;
            }
            else
            {
                StaticVariables.RecruitList.Add(army);
            }
            await this.ShowMessageAsync("Done", "Recruit updated");
        }
    }
}

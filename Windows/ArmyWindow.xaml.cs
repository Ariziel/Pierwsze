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

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for ArmyWindow.xaml
    /// </summary>
    public partial class ArmyWindow : MetroWindow
    {
        public ArmyWindow()
        {
            InitializeComponent();
        }

        private void ArmyWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            int index = 0;
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                index++;
                ArmyDataGrid.Items.Add(new ArmyStruct
                {
                    id = index.ToString(),
                    name = VARIABLE.village.name,
                    spear = VARIABLE.village.spear,
                    sword = VARIABLE.village.sword,
                    axe = VARIABLE.village.axe,
                    archer = VARIABLE.village.archer,
                    spy = VARIABLE.village.spy,
                    light = VARIABLE.village.light,
                    marcher = VARIABLE.village.marcher,
                    heavy = VARIABLE.village.heavy,
                    ram = VARIABLE.village.ram,
                    catapult = VARIABLE.village.catapult,
                    knight = VARIABLE.village.knight,
                    snob = VARIABLE.village.snob,
                    militia = VARIABLE.village.militia
                });
            }
        }
    }

    public class ArmyStruct
    {
        public string id { get; set; }
        public string name { get; set; }
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
    }
}

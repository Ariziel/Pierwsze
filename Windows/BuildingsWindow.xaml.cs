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
    /// Interaction logic for BuildingsWindow.xaml
    /// </summary>
    public partial class BuildingsWindow : MetroWindow
    {
        public BuildingsWindow()
        {
            InitializeComponent();
        }

        private int _index = 0;

        private void BuildingsWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                _index++;
                BuildingsDatagrid.Items.Add(new BuildingsStructure
                {
                    id = _index.ToString(),
                    name = VARIABLE.village.name,
                    main = VARIABLE.village.buildings.main.ToString(),
                    barracks = VARIABLE.village.buildings.barracks.ToString(),
                    stable = VARIABLE.village.buildings.stable.ToString(),
                    workshop = VARIABLE.village.buildings.garage.ToString(),
                    church = VARIABLE.village.buildings.church.ToString(),
                    church_f = VARIABLE.village.buildings.church_f.ToString(),
                    academy = VARIABLE.village.buildings.snob.ToString(),
                    smithy = VARIABLE.village.buildings.smith.ToString(),
                    rally_point = VARIABLE.village.buildings.place.ToString(),
                    statue = VARIABLE.village.buildings.statue.ToString(),
                    market = VARIABLE.village.buildings.market.ToString(),
                    timber_camp = VARIABLE.village.buildings.wood.ToString(),
                    clay_pit = VARIABLE.village.buildings.stone.ToString(),
                    iron_mine = VARIABLE.village.buildings.iron.ToString(),
                    farm = VARIABLE.village.buildings.farm.ToString(),
                    warehouse = VARIABLE.village.buildings.storage.ToString(),
                    hiding_place = VARIABLE.village.buildings.hide.ToString(),
                    wall = VARIABLE.village.buildings.wall.ToString(),
                    watchtower = VARIABLE.village.buildings.watchtower.ToString(),
                });
            }
        }
    }

    public class BuildingsStructure
    {
        public string id { get; internal set; }
        public string name { get; internal set; }
        public string main { get; internal set; }
        public string barracks { get; internal set; }
        public string stable { get; internal set; }
        public string workshop { get; internal set; }
        public string church { get; internal set; }
        public string church_f { get; internal set; }
        public string academy { get; internal set; }
        public string smithy { get; internal set; }
        public string rally_point { get; internal set; }
        public string statue { get; internal set; }
        public string market { get; internal set; }
        public string timber_camp { get; internal set; }
        public string clay_pit { get; internal set; }
        public string iron_mine { get; internal set; }
        public string farm { get; internal set; }
        public string warehouse { get; internal set; }
        public string hiding_place { get; internal set; }
        public string wall { get; internal set; }
        public string watchtower { get; internal set; }
    }
}

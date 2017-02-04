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

namespace SilverBot
{
    /// <summary>
    /// Interaction logic for HomeBuildings.xaml
    /// </summary>
    public partial class HomeBuildings : MetroWindow
    {
        public HomeBuildings()
        {
            InitializeComponent();
        }

        private int _index = 0;
        private void HomeBuildings_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                _index++;
                MyBuildingsDataGrid.Items.Add(new MyVillagesStructure()
                {
                    id = _index.ToString(),
                    name = VARIABLE.village.name,
                    x = VARIABLE.village.x.ToString(),
                    y = VARIABLE.village.y.ToString(),
                    wood = VARIABLE.village.wood.ToString() + "/" + VARIABLE.village.storage_max,
                    stone = VARIABLE.village.stone.ToString() + "/" + VARIABLE.village.storage_max,
                    iron = VARIABLE.village.iron.ToString() + "/" + VARIABLE.village.storage_max,
                    population = VARIABLE.village.pop.ToString() + "/" + VARIABLE.village.pop_max.ToString(),
                    buildqueue = VARIABLE.village.buildqueue + "/" + StaticVariables.maxBuildQueue.ToString(),
                });
            }
            
        }

        private void AddNewBuildQueue_OnClick(object sender, RoutedEventArgs e)
        {
            object item = MyBuildingsDataGrid.SelectedItem;
            var textBlock = MyBuildingsDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock;
            if (textBlock != null)
            {
                string ID = textBlock.Text;
                var buildqueueWindows = new Windows.Buildqueue();
                buildqueueWindows.Show();
            }
        }
    }

    class MyVillagesStructure
    {
        public string id { get; internal set; }
        public string name { get; internal set; }
        public string x { get; internal set; }
        public string y { get; internal set; }
        public string wood { get; internal set; }
        public string stone { get; internal set; }
        public string iron { get; internal set; }
        public string population { get; internal set; }
        public string buildqueue { get; internal set; }
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
        public string spear { get; internal set; }
        public string sword { get; internal set; }
        public string axe { get; internal set; }
        public string archer { get; internal set; }
        public string spy { get; internal set; }
        public string light { get; internal set; }
        public string marcher { get; internal set; }
        public string heavy { get; internal set; }
        public string ram { get; internal set; }
        public string catapult { get; internal set; }
        public string knight { get; internal set; }
        public string snob { get; internal set; }
        public string militia { get; internal set; }
    }
}

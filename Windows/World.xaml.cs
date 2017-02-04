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
    /// Interaction logic for World.xaml
    /// </summary>
    public partial class World : MetroWindow
    {
        public World()
        {
            InitializeComponent();
        }

        private void World_OnLoaded(object sender, RoutedEventArgs e)
        {
           
            foreach (var VARIABLE in StaticVariables.WorldVillages)
            {
                WorldDataGrid.Items.Add(new GridStructure
                {
                    id = VARIABLE.ID,
                    name = VARIABLE.Name,
                    x = VARIABLE.X,
                    y = VARIABLE.Y,
                    playerid = VARIABLE.IDPlayer,
                    points = VARIABLE.Points
                });
            }
        }
    }

    class GridStructure
    {
        public string id { get; set; }
        public string name { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string playerid { get; set; }
        public string points { get; set; }
    }
}

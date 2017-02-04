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
using MahApps.Metro.Controls.Dialogs;
using SilverBot.World;

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for BuildQueueNew.xaml
    /// </summary>
    public partial class BuildQueueNew
    {
        private List<UserVillages.BuildStructure> tempqueue = new List<UserVillages.BuildStructure>();

        public BuildQueueNew()
        {
            InitializeComponent();
        }

        private void MainButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Main",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Main");
        }

        private void UpdateList()
        {
            try
            {
                ProgressBarMain.Visibility = Visibility.Hidden;
                ProgressBarBarracks.Visibility = Visibility.Hidden;
                ProgressBarStable.Visibility = Visibility.Hidden;
                ProgressBarGarage.Visibility = Visibility.Hidden;
                ProgressBarSmith.Visibility = Visibility.Hidden;
                ProgressBarPlace.Visibility = Visibility.Hidden;
                ProgressBarMarket.Visibility = Visibility.Hidden;
                ProgressBarWood.Visibility = Visibility.Hidden;
                ProgressBarStone.Visibility = Visibility.Hidden;
                ProgressBarIron.Visibility = Visibility.Hidden;
                ProgressBarFarm.Visibility = Visibility.Hidden;
                ProgressBarStorage.Visibility = Visibility.Hidden;
                ProgressBarHide.Visibility = Visibility.Hidden;
                ProgressBarWall.Visibility = Visibility.Hidden;
                ProgressBarSnob.Visibility = Visibility.Hidden;
                ProgressBarStatue.Visibility = Visibility.Hidden;
                ListViewBuildQueueFlyout.Items.Clear();
                foreach (var commandBinding in StaticVariables.MyVillagesBuild)
                {
                    var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
                    foreach (var buildStructure in commandBinding)
                    {
                        if (buildStructure.id == id.ToString())
                        {
                            ListViewBuildQueueFlyout.Items.Add(buildStructure.name);
                            if (buildStructure.isupgrading)
                            {
                                switch (buildStructure.name)
                                {
                                    case "Main":
                                    {
                                        ProgressBarMain.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarMain.Value = (100 - x);
                                        break;
                                    }
                                    case "Barracks":
                                    {
                                        ProgressBarBarracks.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarBarracks.Value = (100 - x);
                                        break;
                                    }
                                    case "Stable":
                                    {
                                        ProgressBarStable.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarStable.Value = (100 - x);
                                        break;
                                    }
                                    case "Garage":
                                    {
                                        ProgressBarGarage.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarGarage.Value = (100 - x);
                                        break;
                                    }
                                    case "Smith":
                                    {
                                        ProgressBarSmith.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarSmith.Value = (100 - x);
                                        break;
                                    }
                                    case "Place":
                                    {
                                        ProgressBarPlace.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarPlace.Value = (100 - x);
                                        break;
                                    }
                                    case "Market":
                                    {
                                        ProgressBarMarket.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarMarket.Value = (100 - x);
                                        break;
                                    }
                                    case "Wood":
                                    {
                                        ProgressBarWood.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarWood.Value = (100 - x);
                                        break;
                                    }
                                    case "Stone":
                                    {
                                        ProgressBarStone.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarStone.Value = (100 - x);
                                        break;
                                    }
                                    case "Iron":
                                    {
                                        ProgressBarIron.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarIron.Value = (100 - x);
                                        break;
                                    }
                                    case "Farm":
                                    {
                                        ProgressBarFarm.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarFarm.Value = (100 - x);
                                        break;
                                    }
                                    case "Storage":
                                    {
                                        ProgressBarStorage.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarStorage.Value = (100 - x);
                                        break;
                                    }
                                    case "Hide":
                                    {
                                        ProgressBarHide.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarHide.Value = (100 - x);
                                        break;
                                    }
                                    case "Wall":
                                    {
                                        ProgressBarWall.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarWall.Value = (100 - x);
                                        break;
                                    }
                                    case "Snob":
                                    {
                                        ProgressBarSnob.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarSnob.Value = (100 - x);
                                        break;
                                    }
                                    case "Statue":
                                    {
                                        ProgressBarStatue.Visibility = Visibility.Visible;
                                        var x = (buildStructure.lefttime/buildStructure.maxtime)*100;
                                        ProgressBarStatue.Value = (100 - x);
                                        break;
                                    }
                                    default:
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {


            }


        }

        private async void Savequeuebutton_Click(object sender, RoutedEventArgs e)
        {
            if (tempqueue.Count >= 1)
            {
                if (StaticVariables.MyVillagesBuild.Count == 0)
                {
                    StaticVariables.MyVillagesBuild.Add(tempqueue);
                }
                else
                {
                    foreach (var VARIABLE in StaticVariables.MyVillagesBuild.ToList())
                    {
                        foreach (var VARIABLE2 in VARIABLE.ToList())
                        {
                            if (VARIABLE2.id == tempqueue.FirstOrDefault().id)
                            {
                                foreach (var VARIABLE3 in tempqueue.ToList())
                                {
                                    VARIABLE.Add(VARIABLE3);
                                }
                                break;
                            }
                            else
                            {
                                StaticVariables.MyVillagesBuild.Add(tempqueue);
                                break;
                            }
                        }
                    }
                }
            }
            await this.ShowMessageAsync("Done", "Saved!");
        }

        private void YourVillage_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                MainButton.IsEnabled = false;
                BarracksButton.IsEnabled = false;
                StableButton.IsEnabled = false;
                Garage.IsEnabled = false;
                SmithButton.IsEnabled = false;
                PlaceButton.IsEnabled = false;
                MarketButton.IsEnabled = false;
                WoodButton.IsEnabled = false;
                StoneButton.IsEnabled = false;
                IronButton.IsEnabled = false;
                FarmButton.IsEnabled = false;
                StorageButton.IsEnabled = false;
                HideButton.IsEnabled = false;
                WallButton.IsEnabled = false;
                SnobButton.IsEnabled = false;
                StatueButton.IsEnabled = false;
                UpdateList();
                var willage = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text);
                MainLVL.Text = "Level: " + willage.village.buildings.main.ToString();
                BarracksLVL.Text = "Level: " + willage.village.buildings.barracks.ToString();
                StableLVL.Text = "Level: " + willage.village.buildings.stable.ToString();
                GarageLVL.Text = "Level: " + willage.village.buildings.garage.ToString();
                SmithLVL.Text = "Level: " + willage.village.buildings.smith.ToString();
                PlaceLVL.Text = "Level: " + willage.village.buildings.place.ToString();
                MarketLVL.Text = "Level: " + willage.village.buildings.market.ToString();
                WoodLVL.Text = "Level: " + willage.village.buildings.wood.ToString();
                StoneLVL.Text = "Level: " + willage.village.buildings.stone.ToString();
                IronLVL.Text = "Level: " + willage.village.buildings.iron.ToString();
                FarmLVL.Text = "Level: " + willage.village.buildings.farm.ToString();
                StorageLVL.Text = "Level: " + willage.village.buildings.storage.ToString();
                HideLVL.Text = "Level: " + willage.village.buildings.hide.ToString();
                WallLVL.Text = "Level: " + willage.village.buildings.wall.ToString();
                SnobLVL.Text = "Level: " + willage.village.buildings.snob.ToString();
                StatueLVL.Text = "Level: " + willage.village.buildings.statue.ToString();
                MainButton.IsEnabled = true;
                if (willage.village.buildings.main >= 3)
                {
                    BarracksButton.IsEnabled = true;
                }
                if (willage.village.buildings.main >= 10 && willage.village.buildings.barracks >= 5 && willage.village.buildings.smith >= 5)
                {
                    StableButton.IsEnabled = true;
                }
                if (willage.village.buildings.main >= 10 && willage.village.buildings.smith >= 10)
                {
                    Garage.IsEnabled = true;
                }
                if (willage.village.buildings.main >= 5 && willage.village.buildings.barracks >= 1)
                {
                    SmithButton.IsEnabled = true;
                }
                PlaceButton.IsEnabled = true;
                if (willage.village.buildings.main >= 3 && willage.village.buildings.storage >= 2)
                {
                    MarketButton.IsEnabled = true;
                }
                WoodButton.IsEnabled = true;
                StoneButton.IsEnabled = true;
                IronButton.IsEnabled = true;
                FarmButton.IsEnabled = true;
                StorageButton.IsEnabled = true;
                HideButton.IsEnabled = true;
                if (willage.village.buildings.barracks >= 1)
                {
                    WallButton.IsEnabled = true;
                }
                if (willage.village.buildings.main >= 20 && willage.village.buildings.smith >= 20 && willage.village.buildings.market >= 10)
                {
                    SnobButton.IsEnabled = true;
                }
                StatueButton.IsEnabled = true;
            }
            catch (Exception)
            {
                

            }
           
        }

        private void BarracksButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Barracks",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Barracks");
        }

        private void StableButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Stable",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Stable");
        }

        private void Garage_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Garage",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Garage");
        }

        private void SmithButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Smith",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Smith");
        }

        private void PlaceButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Place",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Place");
        }

        private void MarketButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Market",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Market");
        }

        private void WoodButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Wood",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Wood");
        }

        private void StoneButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Stone",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Stone");
        }

        private void IronButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Iron",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Iron");
        }

        private void FarmButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Farm",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Farm");
        }

        private void StorageButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Storage",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Storage");
        }

        private void HideButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Hide",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Hide");
        }

        private void WallButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Wall",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Wall");
        }

        private void SnobButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Snob",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Snob");
        }

        private void StatueButton_OnClick(object sender, RoutedEventArgs e)
        {
            var id = StaticVariables.MyVillages.Find(y => y.village.name == YourVillage.Text).village.id;
            tempqueue.Add(new UserVillages.BuildStructure
            {
                id = id.ToString(),
                name = "Statue",
                upgrade = true,
            });
            ListViewBuildQueueFlyout.Items.Add("Statue");
        }

        private void BuildQueueNew_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var vill in StaticVariables.MyVillages)
            {
                YourVillage.Items.Add(vill.village.name);
            }
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = ListViewBuildQueueFlyout.SelectedItem;
                var index = ListViewBuildQueueFlyout.SelectedIndex;
                if (item.ToString() != null)
                {
                    string ID = item.ToString();
                    foreach (var VARIABLE in StaticVariables.MyVillagesBuild.ToList())
                    {
                        VARIABLE.RemoveAt(index);
                    }
                    ListViewBuildQueueFlyout.Items.RemoveAt(index);
                    tempqueue.RemoveAt(index);
                }
            }
            catch (Exception)
            {

            }

        }
    }
}

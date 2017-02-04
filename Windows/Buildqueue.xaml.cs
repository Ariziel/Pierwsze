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
using SilverBot.World;

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for Buildqueue.xaml
    /// </summary>
    public partial class Buildqueue : MetroWindow
    {
        private List<UserVillages.BuildStructure> TempQueue = new List<UserVillages.BuildStructure>();
        private UserVillages.VillageStructure.Example SelectedVillage;

        public Buildqueue()
        {
            InitializeComponent();
        }

        private void Buildqueue_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                VillageComboBox.Items.Add(VARIABLE.village.name);
            }
        }

        private void VillageComboBox_DropDownClosed(object sender, EventArgs e)
        {
            BuildQueueDataGrid.Items.Clear();
            foreach (var VARIABLE in StaticVariables.MyVillages)
            {
                if (VARIABLE.village.name == VillageComboBox.Text)
                {
                    SelectedVillage = VARIABLE;
                }
            }
            foreach (var VARIABLE in StaticVariables.MyVillagesBuild)
            {
                foreach (var VARIABLE2 in VARIABLE)
                {
                    if (VARIABLE2.id == SelectedVillage.village.id.ToString())
                    {
                        foreach (var VARIABLE3 in VARIABLE)
                        {
                            BuildQueueDataGrid.Items.Add(new BuildStructure()
                            {
                                id = VARIABLE3.id,
                                name = VARIABLE3.name,
                                upgrade = VARIABLE3.upgrade,
                            });
                        }
                    }
                    break;
                }
            }
            Structure.IsEnabled = true;
        }

        private void Structure_DropDownClosed(object sender, EventArgs e)
        {
            var upordown = true;
            if (UpGradeRadio.IsChecked == true)
            {
                upordown = true;
            }
            else if (UpGradeRadio.IsChecked == false)
            {
                upordown = false;
            }
            var item = Structure.Text;
            switch (item)
            {
                case "Main":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Main",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Main",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Farm":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Farm",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Farm",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Storage":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Storage",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Storage",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Place":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Place",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Place",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Barracks":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Barracks",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Barracks",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Church":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Church",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Church",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Church First":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Church First",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Church First",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Smith":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Smith",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Smith",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Wood":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Wood",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Wood",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Stone":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Stone",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Stone",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Iron":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Iron",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Iron",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Market":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Market",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Market",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Stable":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Stable",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Stable",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Wall":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Wall",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Wall",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Garage":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Garage",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Garage",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Hide":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Hide",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Hide",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Snob":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Snob",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Snob",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Statue":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Statue",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Statue",
                        upgrade = upordown,
                    });
                    break;
                }
                case "Watchtower":
                {
                    BuildQueueDataGrid.Items.Add(new BuildStructure()
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Watchtower",
                        upgrade = upordown,

                    });
                    TempQueue.Add(new UserVillages.BuildStructure
                    {
                        id = SelectedVillage.village.id.ToString(),
                        name = "Watchtower",
                        upgrade = upordown,
                    });
                    break;
                }
            }

        }

        private async void SaveQueue_OnClick(object sender, RoutedEventArgs e)
        {
            //StaticVariables.MyVillagesBuild.Remove(TempQueue);
            if (TempQueue.Count >= 1)
            {
                if (StaticVariables.MyVillagesBuild.Count == 0)
                {
                    StaticVariables.MyVillagesBuild.Add(TempQueue);
                }
                else
                {
                    foreach (var VARIABLE in StaticVariables.MyVillagesBuild.ToList())
                    {
                        foreach (var VARIABLE2 in VARIABLE.ToList())
                        {
                            if (VARIABLE2.id == TempQueue.FirstOrDefault().id)
                            {
                                foreach (var VARIABLE3 in TempQueue.ToList())
                                {
                                    VARIABLE.Add(VARIABLE3);
                                }
                                break;
                            }
                            else
                            {
                                StaticVariables.MyVillagesBuild.Add(TempQueue);
                                break;
                            }
                        }
                    }
                }
            }
            await this.ShowMessageAsync("Done", "Saved!");
        }

        private void RemoveFromQueue_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = BuildQueueDataGrid.SelectedItem;
                var index = BuildQueueDataGrid.SelectedIndex;
                var textBlock = BuildQueueDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock;
                if (textBlock != null)
                {
                    string ID = textBlock.Text;
                    foreach (var VARIABLE in StaticVariables.MyVillagesBuild.ToList())
                    {
                        VARIABLE.RemoveAt(index);
                    }
                    BuildQueueDataGrid.Items.RemoveAt(index);
                    TempQueue.RemoveAt(index);
                }
            }
            catch (Exception)
            {
                
            }

        }
    }

    public class BuildStructure
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool upgrade { get; set; }
    }
}

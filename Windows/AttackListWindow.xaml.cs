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

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for AttackListWindow.xaml
    /// </summary>
    public partial class AttackListWindow
    {
        public AttackListWindow()
        {
            InitializeComponent();
        }

        private void AttackListWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            AttackDatagrid.ItemsSource = StaticVariables.AttackList;
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                StaticVariables.AttackList.RemoveAt(AttackDatagrid.SelectedIndex);
                AttackDatagrid.ItemsSource = null;
                AttackDatagrid.ItemsSource = StaticVariables.AttackList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

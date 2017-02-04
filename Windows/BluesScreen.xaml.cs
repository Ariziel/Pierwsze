using System;
using System.Collections.Generic;
using System.IO;
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

namespace SilverBot.Windows
{
    /// <summary>
    /// Interaction logic for BluesScreen.xaml
    /// </summary>
    public partial class BluesScreen : MetroWindow
    {
        public BluesScreen()
        {
            InitializeComponent();
        }

        private void BluesScreen_OnClosed(object sender, EventArgs e)
        {
            var gx = StaticVariables.ErrorMessage;
            string n = string.Format("text-{0:yyyy-MM-dd_hh-mm-ss-tt}.txt", DateTime.Now);
            File.WriteAllText(n, gx);
            Environment.Exit(0);
        }
    }
}

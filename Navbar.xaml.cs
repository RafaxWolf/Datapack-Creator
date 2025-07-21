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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWindow
{
    /// <summary>
    /// Lógica de interacción para Navbar.xaml
    /// </summary>
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
        }

        private void Opt_Click(object sender, RoutedEventArgs e)
        {
            // Handle the click event for the options button
            MessageBox.Show("Options clicked!");
        }

        private void OpenConfigs_Click(object sender, RoutedEventArgs e)
        {
            // Handle the click event for the open configurations button
            MessageBox.Show("Open Configurations clicked!");
        }

        private void OpenHelp_Click(object sender, RoutedEventArgs e)
        {
            // Handle the click event for the open help button
            MessageBox.Show("Open Help clicked!");
        }

    }
}

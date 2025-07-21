using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double Spacing { get; set; }

        private void Create_Project(object sender, RoutedEventArgs e)
        {
            var window = new CreateProjectWindow();
            window.Owner = this;
            window.ShowDialog();
        }

        private void Open_Project(object sender, RoutedEventArgs e)
        {
            // Opens and existing Project
            // W.I.P Just show a message
            MessageBox.Show("Opening a Project...");
        }

    }

}
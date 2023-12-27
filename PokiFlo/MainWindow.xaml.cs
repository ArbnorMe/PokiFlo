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

namespace PokiFlo
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

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Main_Mainmenue_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Hauptmenue();
        }

        private void Button_Main_Fightarena_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Fightarena();
        }

        private void Button_Main_Inventory_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Inventory();
        }

        private void Button_Main_Statistic_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Statistic();
        }

        private void Button_Main_Settings_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Settings();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;

namespace WPF_Forms.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new UserInfo());
           
        }

        private void Tacnical_inventorization(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new UserInfo());
            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new Page1());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new Page1());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //_mainFrame.Navigate(new Instructions());

            Instructions lol = new Instructions();
            //this.NavigationService.Navigate(lol);
            lol.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Prejskurant lol = new Prejskurant();
            //this.NavigationService.Navigate(lol);
            lol.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            List_of_Works WorksList = new List_of_Works();
            //this.NavigationService.Navigate(lol);
            WorksList.Show();
            Close();
        }
    }
}

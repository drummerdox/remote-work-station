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

namespace WPF_Forms.Views
{
    /// <summary>
    /// Interaction logic for UserInfo.xaml
    /// </summary>
   
    public partial class UserInfo : Page
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorksAdding lol = new WorksAdding();
            this.NavigationService.Navigate(lol);
            //_mainFrame.Navigate(new WorksAdding());
        }

        private void close(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }

        private void DatePicker_SelectedDateChanged(object sender,
         SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for WorksAdding.xaml
    /// </summary>
    public partial class WorksAdding : Page
    {
        public WorksAdding()
        {
            InitializeComponent();

            lstMachineFunctions.ItemsSource = MachineFunctions = new ObservableCollection<MachineFunction>();
        }

        private void OnDeleteMachineFunction(object sender, RoutedEventArgs e)
        {
            MachineFunctions.Remove((sender as FrameworkElement).DataContext as MachineFunction);
        }

        private void OnAddMachineFunction(object sender, RoutedEventArgs e)
        {
            MachineFunctions.Add(new MachineFunction());
        }

        private void OnAddScaleUnit(object sender, RoutedEventArgs e)
        {
            var mf = (sender as FrameworkElement).DataContext as MachineFunction;

            mf.ScaleUnits.Add(new ScaleUnit(mf.ScaleUnits.Count));
        }

        private void OnDeleteScaleUnit(object sender, RoutedEventArgs e)
        {
            var delScaleUnit = (sender as FrameworkElement).DataContext as ScaleUnit;

            var mf = MachineFunctions.FirstOrDefault(_ => _.ScaleUnits.Contains(delScaleUnit));

            if (mf != null)
            {
                mf.ScaleUnits.Remove(delScaleUnit);

                foreach (var scaleUnit in mf.ScaleUnits)
                {
                    scaleUnit.Index = mf.ScaleUnits.IndexOf(scaleUnit);
                }
            }
        }

        public ObservableCollection<MachineFunction> MachineFunctions { get; set; }
    }
}


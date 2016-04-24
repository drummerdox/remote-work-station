using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Forms.Views
{
    public class MachineFunction
    {
        public string Name { get; set; }
        public int Machines { get; set; }

        public ObservableCollection<ScaleUnit> ScaleUnits { get; set; }

        public MachineFunction()
        {
            ScaleUnits = new ObservableCollection<ScaleUnit>();
        }
    }

    public class ScaleUnit
    {
        public string Name { get; set; }
        public int Index { get; set; }

        public ScaleUnit(int index)
        {
            this.Index = index;
        }
    }
}

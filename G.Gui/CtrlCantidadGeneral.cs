using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Core.Data;

namespace G.Gui
{
    public partial class CtrlCantidadGeneral : UserControl
    {
        public CtrlCantidadGeneral()
        {
            InitializeComponent();
        }

        public object DataSouce {

            set {
                List<Bovino> bovinos = value as List<Bovino>;
                this.label1.Text ="Cantidad: " + bovinos.Count.ToString();            
            }
        }
    }
}

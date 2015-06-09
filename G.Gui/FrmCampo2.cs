using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Core.Data;

namespace G.Gui
{
    public partial class FrmCampo2 : Form
    {
        public FrmCampo2()
        {
            InitializeComponent();
        }

        private Campo campo;

        public Campo Campo {
            get {
                return campo;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            campo = new Campo();
            campo.Nombre = Nombre_txt.Text;
            campo.Cuil = "sd";
            campo.Razon = "sD";
            campo.Renspa = Renspa_txt.Text;
            campo.RenspaGanadera = "SD";
        }
    }
}

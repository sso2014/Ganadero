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
    public partial class FrmCampo : Form
    {
        public FrmCampo()
        {
            InitializeComponent();
        }

        private Campo campo=null;
        private Establecimiento establecimiento=null;

        public Campo Campo {
            get {
                return campo;
            }
        }

        public Establecimiento Establecimiento {
            
            get {
                 return establecimiento;
            }
        }
        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCampo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            campo = new Campo();
            campo.Nombre = Campo_nombre_text.Text;
            campo.Cuil = cuil_text.Text;
            campo.Razon = razon_text.Text;
            campo.Renspa = renspa_text.Text;
            campo.RenspaGanadera = renspa_ganadero_text.Text;   
        }
    }
}

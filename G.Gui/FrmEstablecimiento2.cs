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
    public partial class FrmEstablecimiento2 : Form
    {
        public FrmEstablecimiento2()
        {
            InitializeComponent();
        }

        private Campo campo;
        private Establecimiento establecimiento;

        public Campo Campo {
            set {

                if (value != null)
                {
                    campo = value as Campo;
                    Campo_lbl.Text = campo.Nombre;
                    Renspa_lbl.Text = campo.Renspa;
                }
            }
        }

        public Establecimiento Establecimiento {
            get { return establecimiento;  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (campo != null)
            {
                Campo_lbl.Text = campo.Nombre;
                Renspa_lbl.Text = campo.Renspa;
                establecimiento = new Establecimiento();
                establecimiento.Nombre = Nombre_text.Text;
                establecimiento.Localidad = "S/D";
                establecimiento.Partido = "S/D";
                establecimiento.Provincia = "S/D";
                establecimiento.Campo_id = campo.id;
                  
            }
        }
    }
}

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
    public partial class FrmBovinoGeneral : Form
    {
        public FrmBovinoGeneral()
        {
            InitializeComponent();
        }
        private Bovino bovino = null;
        private Establecimiento establecimiento = null;
        public Establecimiento Establecimiento
        {
            set {

                establecimiento = value as Establecimiento;
                this.Establecimiento_text.Text = establecimiento.Nombre;        
            }
        }
        public Bovino Bovino
        {
            get
            {
                return bovino;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bovino = new Bovino();
            bovino.Categoria = new Categoria();
            bovino.Categoria.id = 1;
            bovino.EstablecimientoID = establecimiento.Id;
            if (rp_text != null)
                bovino.Rp = rp_text.Text;
            else
                bovino.Rp = "S/D";    
            //bovino.Categoria = Categoria_text.Text;       
        }        
    }
}

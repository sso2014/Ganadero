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
    public partial class FrmBovino_Ingresos : Form
    {
        public FrmBovino_Ingresos()
        {
            InitializeComponent();
        }

        public Establecimiento Establecimiento
        {
            set
            {
                establecimiento = value;
                Establecimiento_lbl.Text = establecimiento.Nombre;
                Renspa_lbl.Text = "Renspa: " ;
            }
            get
            {
                return establecimiento;
            }
        }
        public List<Bovino> Bovinos
        {
            get {
                return bovinos;
            }
        }

        private static Establecimiento establecimiento = null;
        private static List<Bovino> bovinos = null;

        private void button3_Click(object sender, EventArgs e)
        {
            if (Establecimiento != null)
            {
                bovinos = new List<Bovino>();
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    bovinos.Add(new Bovino()
                    {
                        EstablecimientoID = establecimiento.Id,
                        Rp = txtRenspa.Text,
                        Categoria = comboBox1.SelectedItem as Categoria
                    });
                }
            }
        }
    }
}
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
    public partial class FrmBovino2 : Form
    {
        public FrmBovino2()
        {
            InitializeComponent();
        }

        public Establecimiento Establecimiento { set; private get; }
        public Bovino Bovino
        {
            get
            {
                return bovino;
            }
        }
        private Bovino bovino = null;

        private void button1_Click(object sender, EventArgs e)
        {
            bovino = new Bovino();
            bovino.Rp = Rp_textBox.Text;
            bovino.Apodo = Apodo_textBox.Text;
            //bovino.Categoria = Categoria_comboBox.Text;
            bovino.Color = Color_comboBox.Text;
            bovino.Raza = Raza_comboBox.Text;
            bovino.Sexo = Sexo_comboBox4.Text;
            bovino.Edad = (int)Edad_numeric.Value;
            bovino.Peso = (int)Peso_numeric.Value;
        }
    }
}

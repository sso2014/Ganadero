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
    public partial class FrmEstablecimiento : Form
    {
        public FrmEstablecimiento()
        {
            InitializeComponent();
        }

        private Establecimiento establecimiento;

        public Establecimiento Establecimiento {
            get {
                return establecimiento;
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Campo campo =(Campo)comboBox1.SelectedItem;
            establecimiento = new Establecimiento();
            establecimiento.Localidad = localidad_txt.Text;
            establecimiento.Nombre = nombre_txt.Text;
            establecimiento.Partido = partido_txt.Text;
            establecimiento.Provincia = provincia_txt.Text;
            establecimiento.Campo_id = campo.id;
        }
    }
}
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
    public partial class FrmTransferencia : Form
    {
        public FrmTransferencia()
        {
            InitializeComponent();
        }

        public Transferencia Transferencia
        {
            get{
                return transferencia;
            }
        }

        public List<Bovino> Bovinos
        {
            set
            {
                bovinos = value;
            }
        }


        private List<Bovino> bovinos;
      
        private static Transferencia transferencia = null;

        private void button1_Click(object sender, EventArgs e)
        {
            transferencia = new Transferencia();
            transferencia.DesdeEstablecimiento = (DesdeEstablecimineto_comboBox.SelectedItem as Establecimiento).Id;
            transferencia.HastaEstablecimiento = (HastaEstablecimiento_comboBox.SelectedItem as Establecimiento).Id;
            transferencia.Descripcion = textBox1.Text;            
        }

        private void DesdeEstablecimineto_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void DesdeEstablecimineto_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesdeEstablecimineto_comboBox.SelectedItem != null && bovinos != null)
                dataGridView1.DataSource = bovinos.FindAll(b => b.EstablecimientoID == (DesdeEstablecimineto_comboBox.SelectedItem as Establecimiento).Id);
        }

        private void HastaEstablecimiento_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

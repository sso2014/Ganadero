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
using G.Data;

namespace G.Gui
{
    public partial class Menu : Form, IBovinoView
    {
        public Menu()
        {
            InitializeComponent();
        }

        public event Action BovinoSelect;

        public void SelectAllBovino(List<Bovino> bovinos)
        {
            dataGridView1.DataSource = bovinos;
        }

        public Bovino SelectBovino
        {
            get { throw new NotImplementedException(); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmBovino frm = new FrmBovino();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmActaDeVacunacion frmVac = new FrmActaDeVacunacion();
            frmVac.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmCampo frmCam = new FrmCampo();
            frmCam.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
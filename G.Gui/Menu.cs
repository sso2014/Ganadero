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
    public partial class Menu : Form, IGanaderoView
    {
        public Menu()
        {
            InitializeComponent();
            BindControls();
        }

        public event Action BovinoSelected;
        public event Action CampoSelect;
        public event Action CreateEstablecimiento;
        public event Action CampoLoad;
        public event Action CreateCampo;
        public event Action SelectCampo;
        public event Action CreatedBovino;
        public event Action EstablecimientoSelected;

        private Form1 f1 = new Form1();
        private FrmCampo2 frmCam = new FrmCampo2();
        private FrmIngreso frmIngr = new FrmIngreso();
        private FrmEstablecimiento2 frmest= new FrmEstablecimiento2();
        //private FrmBovino frmBovino = new FrmBovino();
        private FrmRodeoGeneral frmRodeoGeneral = new FrmRodeoGeneral();
        private FrmBovino2 frmBovino = new FrmBovino2();
        private FrmBovinoGeneral frmBovinoGeneral = new FrmBovinoGeneral();
        private FrmBovino_Ingresos frmBovino_Ingresos = new FrmBovino_Ingresos();

        private void BindControls()
        {
            frmCam.button1.Click += OnCreateCampo;
            frmest.button1.Click += OnCreateEstablecimiento;
            frmBovino.button1.Click += OnCreateBovino;
            //campoListView1.NodeMouseClick += OnSelectEstablecimiento;
            //frmBovinoGeneral.button1.Click += OnCreateBovino;
            frmBovino_Ingresos.button3.Click += OnCreateBovino;
        }

        private void OnSelectEstablecimiento(object sender, EventArgs e)
        {
            if (EstablecimientoSelected != null)
            {
                EstablecimientoSelected();
            }
        }

        private void OnCreateCampo(object sender, EventArgs e)
        {
            if (CreateCampo != null)
            {
                this.CreateCampo();
            }
        }

        public void OnCreateEstablecimiento(object sender, EventArgs e)
        {
            if (CreateEstablecimiento != null)
            {
                this.CreateEstablecimiento();
            }
        }

        public void LoadBovinos(List<Bovino> bovinos)
        {
            if (bovinos != null)
            {
                dataGridView1.DataSource = bovinos;
                ctrlCantidadGeneral1.DataSouce = bovinos;
            }
            else
            {
                dataGridView1.Refresh();
            }
        }

        public Bovino SelectBovino
        {
            get { return frmBovinoGeneral.Bovino; }
        }

        public List<Bovino> SelectBovinos {
            get {
                return frmBovino_Ingresos.Bovinos;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //FrmBovino frm = new FrmBovino();
            //frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmActaDeVacunacion frmVac = new FrmActaDeVacunacion();
            frmVac.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmCam.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (CampoLoad != null)
            {
                CampoLoad();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        public void SelectAllCampos(List<Campo> campos)
        {
            campoListView1.DataSouce = campos;
            //frmest.comboBox1.DataSource = campos;
      
        }

        public void OnCreateBovino(object sender, EventArgs e)
        {

            if (CreatedBovino != null)
            {
                CreatedBovino();
            }
        }

        public void LoadEstablecimientos(List<Establecimiento> establecimientos)
        {
           
        }

        Campo IGanaderoView.SelectCampo
        {
            get { return frmCam.Campo; }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //frmIngr.ShowDialog();
            f1.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmest.ShowDialog();
        }

        public void SelectedCampo(Campo campo)
        {
            
        }

      

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmBovino.ShowDialog();
        }

        Establecimiento IGanaderoView.SelectEstablecimiento
        {
            get { return campoListView1.Establecimiento; }
        }


        public void LoadEstablecimiento(Establecimiento establecimiento)
        {
            if (establecimiento != null)
            {
                frmBovino_Ingresos.Establecimiento = establecimiento;
                frmBovino.Establecimiento = establecimiento;
                frmBovino_Ingresos.Establecimiento = establecimiento;
            }             
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }
        
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            frmBovinoGeneral.ShowDialog();
        }

        public void LoadCategorias(List<Categoria> categorias)
        {
            frmBovinoGeneral.Categoria_text.DataSource = categorias;
            frmBovino_Ingresos.comboBox1.DataSource = categorias;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            frmBovino_Ingresos.ShowDialog();
        }

        private void campoListView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            

        }
    }
}
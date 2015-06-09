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
using G.Core.DataUser;

namespace G.Gui
{
    public partial class FrmManu2 : Form, IView
    {
        public FrmManu2()
        {
            InitializeComponent();
            BindControls();
        }

        public event Action CampoSelected;
        public event Action CampoCreated;
        public event Action EstablecimientoCreated;
        public event Action BovinoCreated;
        public event Action BovinosSelected;
        public event Action EstablecimientoSelected;
        public event Action EstablecimientoSelectedIndex;
        public event Action Loading;
        public event Action TransferenciaCreated;
        
        private FrmCampo2 frmCampo = new FrmCampo2();
        private FrmEstablecimiento2 frmEst = new FrmEstablecimiento2();
        private FrmBovino_Ingresos frmIngresos = new FrmBovino_Ingresos();
        private FrmTransferencia frmTransferencia = new FrmTransferencia();
        private FrmActa frmActa = new FrmActa();

        private void BindControls()
        {
            campoTreeView1.NodeMouseClick += OnSelectedCampo;
            campoTreeView1.NodeMouseClick += OnSelectedEstablecimiento;
            frmCampo.button1.MouseClick += OnCreatedCampo;
            frmEst.button1.MouseClick += OnCreatedEstablecimiento;
            frmIngresos.button3.Click += OnCreateBovino;
            frmTransferencia.button1.Click += OnCreatedTransferencia;
            this.Load += OnLoading;
        }

        private void OnCreatedTransferencia(object sender, EventArgs e)
        {
            if (TransferenciaCreated != null)
            {
                TransferenciaCreated();
            }
        }

        private void OnLoading(object sender, EventArgs e)
        {
            if (Loading != null)
            {
                Loading();
            }               
        }  

        private void OnCreateBovino(object sender, EventArgs e)
        {
            if (BovinoCreated != null)
            {
                BovinoCreated();
            }
        }

        private void OnCreatedEstablecimiento(object sender, EventArgs e)
        {
            if (EstablecimientoCreated != null)
            {
                EstablecimientoCreated();
            }
        }

        private void OnSelectedEstablecimiento(object sender, EventArgs e)
        {
            if (EstablecimientoSelected != null)
            {
                EstablecimientoSelected();
            }
        }
                
        private void OnCreatedCampo(object sender, EventArgs e)
        {
            if (CampoCreated != null)
            {
                CampoCreated();
            }
        }

        private void OnSelectedCampo(object sender, EventArgs e)
        {
            if (CampoSelected != null)
            {
                CampoSelected();
            }
        }

        public void LoadAllCampo(List<Core.Data.Campo> campos)
        {
           campoTreeView1.DataSouce = campos;
        }

        public void LoadCampo(Core.Data.Campo campo)
        {
            if (campo != null)
            {
                frmEst.Campo = campo;
            }            
        }

        public Core.Data.Campo SelectedCampo
        {
            get { throw new NotImplementedException(); }
        }

        public Core.Data.Establecimiento SelectedEstablecimiento
        {
            get { throw new NotImplementedException(); }
        }

        public Core.Data.Bovino SelectedBovino
        {
            get { throw new NotImplementedException(); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCampo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmEst.ShowDialog();
        }


        public Campo CreatedCampo
        {
            get { return frmCampo.Campo; }
        }       

        public Establecimiento CreatedEstablecimiento
        {
            get { return frmEst.Establecimiento; }
        }
        
        public void SelectedCategorias(List<Categoria> categorias)
        {
            frmIngresos.comboBox1.DataSource = categorias;
            ctrlCampo1.DataSeries = categorias;
            frmTransferencia.Categoria_comboBox.DataSource = categorias;
            frmActa.DataCategoria = categorias;
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmIngresos.ShowDialog();
        }

        public void Loadestablecimiento(Establecimiento establecimiento)
        {
            if (establecimiento != null)
            frmIngresos.Establecimiento = establecimiento;
        }               

        public int SelectedEstablecimientoIndex
        {
            get { return 
                campoTreeView1.SelectedIndexEstablecimiento; }
        }
        
        public List<Bovino> CreatedBovinos
        {
            get { return frmIngresos.Bovinos; }
        }
        
        public void LoadBovinos(List<Bovino> bovinos)
        {

            dataGridView1.Refresh();
            dataGridView1.DataSource = bovinos;
            ctrlCampo1.DataSouce = bovinos;
            frmTransferencia.Bovinos = bovinos;
            frmActa.DataBovino = bovinos;

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        
        public int SelectedCampoIndex
        {
            get { return campoTreeView1.SelectedIndexCampo; }
        }

        public void LoadEstablecimientos(List<Establecimiento> establecimientos)
        {
            frmTransferencia.DesdeEstablecimineto_comboBox.DataSource = establecimientos;
            frmTransferencia.HastaEstablecimiento_comboBox.DataSource = establecimientos;
            campoTreeView1.DataEstablecimiento = establecimientos;
            fr.DataEstablecimiento = establecimientos;
          
        }

        public void LoadAllUserEvent(List<Evento> eventos)
        {
            UserEvent_DataGridView.DataSource = null;
            UserEvent_DataGridView.DataSource = eventos;
        }

        public void LoadTransferencias(List<Transferencia> transferencias)
        {
            Transferencia_dataGridView.DataSource = transferencias;
        }        

        public Transferencia CreatedTransferencia
        {
            get { return frmTransferencia.Transferencia; }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmTransferencia.ShowDialog();
        }
        
        public List<Bovino> SelectedBovinos
        {
            get { throw new NotImplementedException(); }
        }

        FrmTransferencia2 fr = new FrmTransferencia2();

        private void toolStripButton5_Click(object sender, EventArgs e)
        {           
            fr.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmActa.ShowDialog();
        }
    }
}
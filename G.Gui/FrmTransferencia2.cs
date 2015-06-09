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
    public partial class FrmTransferencia2 : Form
    {
        public FrmTransferencia2()
        {
            InitializeComponent();
        }

        public List<Bovino> DataBovino
        {
            set
            {
                this.bovinos = value;
            }
        }

        public List<Categoria> DataCategoria
        {
            set
            {
                categorias = value;
            }
        }

        List<Bovino> bovinos;
        List<Categoria> categorias;

        public object DataEstablecimiento
        {
            set{
                this.comboBox3.DataSource = value;
                this.comboBox2.DataSource = value;
            }
        }       
               
        List<CtrlTranferencia> ctrs = new List<CtrlTranferencia>();
              
        int count = 0;
        //int x = 0;
        int y = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ctrs.Add(new CtrlTranferencia(){
            Location = new Point(0,y)
            });
            ctrs[count].comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            panel1.Controls.Add(ctrs[count]);            
            y += ctrs[count].Size.Height + 5;
            count++;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtrlTranferencia crl = sender as CtrlTranferencia;
            
           crl.numericUpDown1.Value = (int) this.bovinos.FindAll(b => b.Categoria.id == (comboBox3.SelectedItem as Categoria).id).Count;
        }
    }
}

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
    public partial class FrmActa : Form
    {
        public FrmActa()
        {
            InitializeComponent();
        }

        public List<Categoria> DataCategoria
        {
            set{
                   categorias = value; 
            }
        }
        public List<Bovino> DataBovino
        {
            set
            {
                bovinos = value;
            }
        }

        private List<Categoria> categorias;
        private List<Bovino> bovinos;
        private List<CtrlActa> cantidades = new List<CtrlActa>();
        int y = 0;
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            cantidades.Add(new CtrlActa()
            {
                Location = new Point(0, y)
            });
            cantidades[count].comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            cantidades[count].comboBox1.DataSource = categorias;
            panel1.Controls.Add(cantidades[count]);          
            y += cantidades[count].Size.Height + 5;
            count++;
        }

        void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CtrlActa ctrlActa = sender as CtrlActa; 

            if (ctrlActa != null)
            {
                if (bovinos != null)
                {                
                    Categoria categ = ctrlActa.comboBox1.SelectedItem as Categoria;
                    var bo = bovinos.FindAll(b => b.Categoria.id == categ.id);                
                }
            }
        }

        //public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CtrlActa ctrlActa = sender as CtrlActa;
        //    if (ctrlActa != null)
        //    {
        //        if (bovinos != null)
        //        {
        //            if (ctrlActa.comboBox1 != null)
        //            {
        //                Categoria categ = ctrlActa.comboBox1.SelectedItem as Categoria;
        //                var bo = bovinos.FindAll(b => b.Categoria.id == categ.id);
        //            }
        //        }
        //    }
        //}
    }
}

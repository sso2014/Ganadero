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
    public partial class FrmTransferencia3 : Form
    {
        public FrmTransferencia3()
        {
            InitializeComponent();
        }

        private List<Bovino> bovinos;
        private List<Categoria> categorias;
        
        public object DataBovino
        {
            set { 
                
                bovinos = value as List<Bovino>;
                            
            }       
        
        }

        public object DataCatgoria
        {
            set
            {
                categorias = value as List<Categoria>;
            }
        }

    }
}

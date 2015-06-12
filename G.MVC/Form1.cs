using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G.MVC
{
    public partial class Form1 : Form, IBovinoView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintBovinoDetails(Core.Data.Bovino bovino)
        {
            throw new NotImplementedException();
        }
    }
}

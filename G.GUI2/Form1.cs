using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G.GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          G.Data2.DAO.BovinoDao bovinoDao =  G.Data2.DAO.daoFactory.readBovinoDao();
          dataGridView1.DataSource = bovinoDao.getAllBovinos();
        }
    }
}

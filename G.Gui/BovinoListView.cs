using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Core.Data;

namespace G.Gui
{
    class BovinoListView:ListView
    {
       

        public object DataSouce
        {

            set
            {
                List<Bovino>bovinos  = (List<Bovino>) value;

                this.Items.Clear();

                if (bovinos != null)
                {

                    foreach (Bovino b in bovinos)
                    {
                        this.Items.Add(new ListViewItem(new string[]
                    { 
                           b.Rp.ToString(), 
                           b.Apodo, 
                           b.Sexo,
                           b.Color,
                           b.Peso.ToString(),
                           b.Edad.ToString(), 
                           b.Raza
                    }, 0));
                    }
                }

            }
        }

        private void InitializeComponent()
        {
           

        }
    }
}

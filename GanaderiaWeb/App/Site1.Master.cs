using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using G.Data;
using G.Core.Data;

namespace GanaderiaWeb.App
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GanaderoRepository repository = new GanaderoRepository();
            bovinos = repository.getAllBovinos();
            TableRow tempRow = new TableRow();

            foreach (Bovino b in bovinos)
            {
                TableCell tempCell = new TableCell();
                tempCell.Text =
                    String.Format(b.Apodo, b.Categoria);
                tempRow.Cells.Add(tempCell);

                Table1.Rows.Add(tempRow);
            }
        }

        private List<Bovino> bovinos;



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Data.Dao;
using G.Data;
using G.Data.Context;

namespace G.GUI2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var view = new FrmMain();
            var repository = 

            Application.Run(new FrmMain());
        }
    }
}

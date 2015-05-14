using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Gui;
using G.Data;


namespace Ganadero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            
            var repository = new BovinoRepository();
            var view = new G.Gui.Menu();
            var presenter = new Presenter(view, repository);
            Application.Run(view);
        }
    }
}

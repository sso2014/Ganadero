using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Gui;
using G.Data;

namespace Ganadero
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main(string [] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            var repository = new GanaderoRepository2();
            var view = new G.Gui.FrmManu2();
            var presenter = new Presenter(view, repository);

            //Application.Run(view);

            Application.Run(new G.GUI2.FrmMain2());
        }
    }
}

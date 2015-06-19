using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.Data
{
    public class Campo
    {
        private List<Campo> campos;

        public Campo()
        {
            campos = new List<Campo>();
        }
     
        public int id { get; set; }

        public string Nombre { get; set; }

        public string Renspa { get; set; }

        public string Razon { get; set; }

        public string Cuil { get; set; }

        public string RenspaGanadera { get; set; }

        public List<Establecimiento> Establecimientos { get; set; }
    
        public void add(Campo campo)
        {
            campos.Add(campo);
        }

        public void remove(Campo campo)
        {
            campos.Remove(campo);
        }

        public List<Campo>getCampos()
        {
            return campos;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

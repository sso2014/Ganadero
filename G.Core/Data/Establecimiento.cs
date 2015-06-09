using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.Data
{
    public class Establecimiento
    {
        public int Id { get; set; }

        public int Campo_id { get; set; }

        public string Nombre { get; set; }

        public string Localidad { get; set; }

        public string Partido { get; set; }

        public string Provincia { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}

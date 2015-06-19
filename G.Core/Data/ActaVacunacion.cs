using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.Data
{
    public class ActaVacunacion
    {
        public int Id { get; set; }
        
        public string Numero { get; set; }

        public int EstablecimientoID { get; set; }

        public string Bovino { get; set; }

        public int Cantidad { get; set; }
    }
}

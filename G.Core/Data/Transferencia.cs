using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.Data
{
    public class Transferencia
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public int DesdeEstablecimiento { get; set; }
                
        public int HastaEstablecimiento { get; set; }

        public List<int> Bovino_id { get; set; }

        public string Descripcion { get; set; }
       
    }                 
}

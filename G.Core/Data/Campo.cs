using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.Data
{
    public class Campo
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Raspa { get; set; }
        public List<Establecimiento> Establecimientos { get; set; }
    }
}

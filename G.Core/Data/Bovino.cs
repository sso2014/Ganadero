using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.Data
{
    public class Bovino:BaseBovino
    {     
        public string Apodo { get; set; }
        public int Sexo { get; set; }
        public int Color { get;set;}
        public float Peso { get; set; }
        public int Edad { get; set; }
        public int Raza { get;set; }
    }
}

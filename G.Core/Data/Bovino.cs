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
        public string Sexo { get; set; }
        public string Color { get;set;}
        public float Peso { get; set; }
        public int Edad { get; set; }
        public string Raza { get;set; }
        public string Categoria { get; set; }
    }
}

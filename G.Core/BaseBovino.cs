using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core
{
    public class BaseBovino
    {
        public int id { get; set; }
        public string Rp { get; set; }
              
        public override string ToString()
        {
            return "Id: " + id.ToString() + "Rp: " + Rp.ToString();
        }
    }
}

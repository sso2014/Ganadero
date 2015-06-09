using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Core.DataUser
{
    public class Evento
    {
        public int Id { get; set; }

        public int User_id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}

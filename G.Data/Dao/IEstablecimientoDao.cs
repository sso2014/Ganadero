using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    interface IEstablecimientoDao
    {
        List<Establecimiento> getAllEstablecimiento();
        Establecimiento getEstablecimiento(int id);
        void updateEstablecimiento(Establecimiento establecimento);
        void deleteEstablecimiento(Establecimiento establecimiento);
    }
}

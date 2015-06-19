using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    interface IActaVacunacion
    {
        List<ActaVacunacion> getAllActaVacunacion();
        ActaVacunacion getActaVacunacion(int id);
        void updateActaVacunacion(ActaVacunacion actaVacunacion);
        void deleteActaVacunacion(ActaVacunacion actaVacunacion);
                
    }
}

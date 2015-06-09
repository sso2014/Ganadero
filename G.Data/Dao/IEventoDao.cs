using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.DataUser;

namespace G.Data.Dao
{
    interface IEventoDao
    {
        List<Evento> getAllEvento();
        Evento getEvento(int id);
        void UpdateEvento(Evento evento);
        void DeleteEvento(Evento evento);
    
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.DataUser;
using System.Data;

namespace G.Data.Dao
{
    public class EventoDaoImp:IEventoDao,IUnitOfWork
    {
        public EventoDaoImp(userDao dao)
        {
            this.dao = dao;
            eventos = new List<Evento>();

            foreach (DataRow dr in dao.selectedAllEvento().Rows)
            {
                eventos.Add(new Evento(){
                    Id = Convert.ToInt32(dr["Evento_id"]),
                    User_id = Convert.ToInt32(dr["User_id"]),
                    Fecha = Convert.ToDateTime(dr["Fecha"]),
                    Descripcion = dr["Descripcion"].ToString()
                });
            }

            EventCount = eventos.Count;
        }

        private userDao dao;
        private static List<Evento> eventos;
        private int EventCount = 0;

        public List<Evento> getAllEvento()
        {
            return eventos;
        }

        public Evento getEvento(int id)
        {
            return eventos.Find(e => e.Id == id);
        }

        public void UpdateEvento(Evento evento)
        {
           //...
        }

        public void DeleteEvento(Evento evento)
        {
            //...
        }

        public void Commint()
        {
            if (EventCount < eventos.Count)
            {
                int count = eventos.Max(e => e.Id) + 1;

                foreach (Evento e in eventos)
                {
                    if (e.Id == 0)
                    {
                        e.Id = count;
                        e.Fecha = DateTime.Now;
                        dao.insertIntoEvento(e.User_id, e.Descripcion);
                        count++;
                    }
                }

                EventCount = eventos.Count;
            }
        }
    }
}

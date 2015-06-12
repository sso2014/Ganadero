using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Data;
using G.Core.Data;
using System.Data;

namespace G.Data.Dao
{
    class EstablecimientoDaoImp:IEstablecimientoDao, IUnitOfWork
    {
        private userDao dao;
        private static List<Establecimiento> establecimientos;

        public EstablecimientoDaoImp(userDao dao)
        {

            this.dao = dao;
            
            establecimientos = new List<Establecimiento>();
            
            foreach (DataRow dr in dao.selectAllEstablecimientos().Rows)
            {
                establecimientos.Add(new Establecimiento()
                {
                    Id = Convert.ToInt32(dr["Establecimiento_id"]),
                    Campo_id = Convert.ToInt32(dr["campo_id"]),
                    Nombre = dr["nombre"].ToString(),
                    Localidad = dr["localidad"].ToString(),
                    Partido = dr["partido"].ToString(),
                    Provincia = dr["provincia"].ToString()
                });
            }
        }

        public EstablecimientoDaoImp(){

         this.dao = new userDao();
            
            establecimientos = new List<Establecimiento>();
            
            foreach (DataRow dr in dao.selectAllEstablecimientos().Rows)
            {
                establecimientos.Add(new Establecimiento()
                {
                    Id = Convert.ToInt32(dr["Establecimiento_id"]),
                    Campo_id = Convert.ToInt32(dr["campo_id"]),
                    Nombre = dr["nombre"].ToString(),
                    Localidad = dr["localidad"].ToString(),
                    Partido = dr["partido"].ToString(),
                    Provincia = dr["provincia"].ToString()
                });
            }
        }
        
        public List<Core.Data.Establecimiento> getAllEstablecimiento()
        {
            return establecimientos;
        }

        public Core.Data.Establecimiento getEstablecimiento(int id)
        {
            return establecimientos.Find(e => e.Id == id);
        }

        public void updateEstablecimiento(Core.Data.Establecimiento establecimento)
        {
            Establecimiento est = establecimientos.Find(e => e.Id == establecimento.Id);
            est.Localidad = establecimento.Localidad;
            est.Nombre = establecimento.Nombre;
            est.Partido = establecimento.Partido;
            est.Provincia = establecimento.Provincia;
            est.Campo_id = establecimento.Campo_id;            
        }

        public void deleteEstablecimiento(Core.Data.Establecimiento establecimiento)
        {
            establecimientos.Remove(establecimiento);
        }

        public void Commint()
        {
           
        }
    }
}

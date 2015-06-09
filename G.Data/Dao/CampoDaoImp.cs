using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;
using System.Data; 

namespace G.Data.Dao
{
    public class CampoDaoImp:ICampoDao,IUnitOfWork
    {
        public CampoDaoImp(userDao dao)
        {
            this.dao = dao;
            campos = new List<Campo>();
        
            foreach (DataRow dr in dao.selectAllCampos().Rows)
            {
                campos.Add(new Campo()
                {
                    id = Convert.ToInt32(dr["Campo_id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Renspa = dr["Renspa"].ToString(),
                    Razon = dr["Razon"].ToString(),
                    Cuil = dr["Cuil"].ToString(),
                    RenspaGanadera = dr["Renspa_Ganadero"].ToString(),
                });
            };
        }

        private userDao dao;
        private static List<Campo> campos;

        public List<Core.Data.Campo> getAllCampos()
        {
            return campos;
        }

        public Core.Data.Campo getCampo(int id)
        {
            return campos.Find(c => c.id == id);
        }

        public void UpdateCampo(Core.Data.Campo campo)
        {
            Campo cam = campos.Find(c => c.id == campo.id);
            cam.Nombre = campo.Nombre;
            cam.Cuil = campo.Cuil;
            cam.Establecimientos = cam.Establecimientos;
            cam.Razon = campo.Razon;
            cam.Renspa = campo.Renspa;
            cam.RenspaGanadera = campo.RenspaGanadera;
        }

        public void DeleteCampo(Core.Data.Campo campo)
        {
            campos.Remove(campo);
        }

        public void Commint()
        {
           
        }
    }
}

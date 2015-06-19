using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Data2.DAO;
using G.Core.Data;
using System.Data;

namespace G.Data2.DAO
{
    public class CampoDao:UserDao
    {

     
        private List<Campo> campos;

        public CampoDao(DataSouce dataSouce)
        {

            this.dataSouce = dataSouce;

            campos = new List<Campo>();

            foreach (DataRow dr in dataSouce.executeSelectQuery("SELECT_ALL_CAMPOS", null).Rows)
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

        public List<Campo> getAllCampos()
        {
            return campos;
        }

        public Campo getCampo(int id)
        {
            return campos.Find(c => c.id == id);
        }

        public void UpdateCampo(Campo campo)
        {
            Campo cam = campos.Find(c => c.id == campo.id);
            cam.Nombre = campo.Nombre;
            cam.Cuil = campo.Cuil;
            cam.Establecimientos = cam.Establecimientos;
            cam.Razon = campo.Razon;
            cam.Renspa = campo.Renspa;
            cam.RenspaGanadera = campo.RenspaGanadera;
        }

        public void DeleteCampo(Campo campo)
        {
            campos.Remove(campo);
        }
    }
}
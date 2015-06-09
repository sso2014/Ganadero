using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using G.Data.Dao;
using G.Core.Data;

namespace G.Data.Bus
{
    class userBus
    {
        public userBus()
        {
            dao = new userDao();
        }

        private userDao dao;

        public List<Categoria> GetAllCategorias(){
            
            List<Categoria>categorias = new List<Categoria>();
            
                         foreach(DataRow dr in dao.selectAllCategoria().Rows){
                categorias.Add(new Categoria(){
                        id = Convert.ToInt32(dr["Categoria_id"]),
                        Descripcion = dr["Descripcion"].ToString()                               
                });
              }

            return categorias;           
        }
        
        public List<Bovino> GetAllBovinos()
        {
            List<Bovino> bovinos = new List<Bovino>();

            try
            {
                foreach (DataRow dr in dao.selectAllBovinos().Rows)
                {
                    bovinos.Add(new Bovino()
                    {
                        id = Convert.ToInt32(dr["Bovino_id"]),
                        Rp = dr["Rp"].ToString(),
                        EstablecimientoID = Convert.ToInt32(dr["Establecimiento_id"]),
                        Categoria = new Categoria() {
                            id = Convert.ToInt32(dr["Categoria_id"]),
                            Descripcion = dr["Descripcion"].ToString()
                        } 
                    });
                }
            }
            catch (System.InvalidCastException e)
            {
                string st = e.Message;  
            }
            return bovinos;
        }

        public void InsertBovino(Bovino bovino)
        {
            if(bovino != null)
            dao.insertIntoBovino(bovino.Rp,
                bovino.Categoria.id, 
                bovino.EstablecimientoID);         
        }

        public int SelectUltimoBovino()
        {
            int intUltimoBovino = 0;

            foreach (DataRow dr in dao.selectUltimoBovino().Rows)
            {
                intUltimoBovino = Convert.ToInt32(dr[0]);
            }
            return intUltimoBovino;
        }             

        public int InsertarEstablecimiento(Establecimiento establecimiento) {

            return dao.insertIntEstablecimiento(
                establecimiento.Campo_id,
                establecimiento.Nombre,
                establecimiento.Localidad,
                establecimiento.Partido,
                establecimiento.Provincia);                        
        }
        
        public int InsertCampo(Campo campo) {

           return dao.insertIntoCampo(campo.Nombre, 
               campo.Renspa, 
               campo.Razon, 
               campo.Cuil,
               campo.RenspaGanadera,
               "0", "0", "0", "0");
        }

        public List<Campo> GetAllCampos()
        {
            List<Campo> campos = new List<Campo>();

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

            return campos;
        }

        public List<Establecimiento> GetAllEstablecimientos ()
        {
            List<Establecimiento> establecimientos = new List<Establecimiento>();

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

            return establecimientos;
        }

        public int SetSexoBovino(string sexo)
        {
            return dao.insertIntoSexoBovino(sexo);
        }

        public List<string> GetAllSexos()
        {
            List<string> sexos = new List<string>();

            foreach (DataRow dr in dao.selectAllSexos().Rows)
            {
                sexos.Add(dr["Descripcion"].ToString());
            }
            return sexos;
        }
    }
}

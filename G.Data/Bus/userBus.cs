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
                        Rp = Convert.ToInt32(dr["Rp"]),
                        Apodo = Convert.ToString(dr["Apodo"]),
                        Sexo = dr["Sexo"].ToString(),
                        Color = dr["Color"].ToString(),
                        Peso = (float)Convert.ToDouble(dr["Peso_Actual"]),
                        Edad = Convert.ToInt32(dr["Edad"]),
                        Raza = dr["Raza"].ToString(),
                        Categoria = dr["Categoria"].ToString()                        
                    });
                }
            }
            catch (System.InvalidCastException e)
            {
                string st = e.Message;
            }
            return bovinos;
        }

        public List<Campo> GetAllCampos(){

            List<Campo> campos = new List<Campo>();
            foreach (DataRow dr in dao.selectAllCampos().Rows)
            {
                campos.Add(new Campo()
                {
                    id = Convert.ToInt32(dr["Campo_id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Raspa = dr["Raspa"].ToString()
                });
            };
            return campos;

        }
       
        public int SetSexoBovino(string sexo)
        {
            return dao.insertIntoSexoBovino(sexo);

        }

        public List<string> GetAllSexos()
        {
            List<string>sexos = new List<string>();

            foreach(DataRow dr in dao.selectAllSexos().Rows){
                sexos.Add(dr["Descripcion"].ToString());
            }
            return sexos;
        }
                
        //public int SetBovino(Bovino bovino)
        //{
        //  return dao.insertIntoBovino(bovino.Rp,
        //      bovino.Apodo,
        //      //bovino.Fecha_Nacimiento,
        //      bovino.Sexo, 
        //      bovino.Color, 
        //      bovino.Peso,
        //      bovino.Edad,
        //      //bovino.Madre,
        //      //bovino.Padre, 
        //      bovino.Raza);
        //}
    }
}

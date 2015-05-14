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
                        //Fecha_Nacimiento = Convert.ToDateTime(dr["Fecha_Nacimiento"]),
                        Sexo = Convert.ToInt32(dr["Sexo"]),
                        Color = Convert.ToInt32(dr["Color"]),
                        Peso = (float)Convert.ToDouble(dr["Peso"]),
                        Edad = Convert.ToInt32(dr["Edad"]),
                        //Madre = Convert.ToInt32(dr["Madre"]),
                        //Padre = Convert.ToInt32(dr["Padre"]),
                        Raza = Convert.ToInt32(dr["Raza_id"])
                    });
                }
            }
            catch (System.InvalidCastException e)
            {
                string st = e.Message;
            }
            return bovinos;
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

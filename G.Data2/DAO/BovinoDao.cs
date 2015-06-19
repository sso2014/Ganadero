using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using G.Core.Data;


namespace G.Data2.DAO
{
    public class BovinoDao:UserDao
    {      
        private List<Bovino> bovinos = null;
        
        public BovinoDao(DataSouce dataSouce)
        {
            this.dataSouce = dataSouce;

            bovinos = new List<Bovino>();

            foreach (DataRow dr in this.dataSouce.executeSelectQuery("SELECT_ALL_BOVINOS", null).Rows)
            {           
                bovinos.Add(new Bovino()
                {
                    id = Convert.ToInt32(dr["Bovino_id"]),
                    Rp = dr["Rp"].ToString(),
                    EstablecimientoID = Convert.ToInt32(dr["Establecimiento_id"]),
                    Categoria = new Categoria()
                    {
                        id = Convert.ToInt32(dr["Categoria_id"]),
                        Descripcion = dr["Descripcion"].ToString()
                    }
                });
            }
        }
      
        public List<Bovino> getAllBovinos()
        {
            return bovinos;
        }

        public Bovino getBovino(int id)
        {
            return bovinos.Find(b => b.id == id);
        }

        public void updateBovino(Bovino bovino)
        {
            Bovino bo = bovinos.Find(b => b.id == bovino.id);
            bo.Renspa = bovino.Renspa;
            bo.Apodo = bovino.Apodo;
            bo.Categoria = bovino.Categoria;
            bo.Color = bovino.Color;
            bo.Edad = bovino.Edad;
            bo.EstablecimientoID = bovino.EstablecimientoID;
            bo.Peso = bovino.Peso;
            bo.Raza = bovino.Raza;
            bo.Rp = bovino.Rp;
            bo.Sexo = bo.Sexo;
        }

        public void deleteBoivno(Bovino bovino)
        {
            bovinos.Remove(bovino);
        }
 
    }
}
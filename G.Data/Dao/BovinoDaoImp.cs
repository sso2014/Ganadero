using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;
using G.Data;
using System.Data;

namespace G.Data.Dao
{
    public class BovinoDaoImp : IBovinoDao, IUnitOfWork
    {
        private int maxBovino;
        private userDao dao;
        private static List<Bovino> bovinos;
        
        public BovinoDaoImp(userDao dao)
        {
            this.dao = dao;
            bovinos = new List<Bovino>();


            foreach (DataRow dr in dao.selectAllBovinos().Rows)
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

            maxBovino = bovinos.Count;

        }

        public BovinoDaoImp()
        {
            this.dao = new userDao();
            bovinos = new List<Bovino>();

            foreach (DataRow dr in dao.selectAllBovinos().Rows)
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

            maxBovino = bovinos.Count;

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

        public void Commint()
        {

            if (maxBovino < bovinos.Count)
            {
                int count = bovinos.Max(b => b.id) + 1;

                foreach (Bovino b in bovinos)
                {
                    if (b.id == 0)
                    {
                        b.id = count;
                        dao.insertIntoBovino(b.Rp, b.Categoria.id, b.EstablecimientoID);
                        count++;
                    }
                }
                maxBovino = bovinos.Count;
            }
        }
    }
}
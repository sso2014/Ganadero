using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;
using G.Data.Context;

namespace G.Data.Dao
{
    public class BovinoRepository : IContainer, IStrategy
    {
        public static List<Bovino> bovinos;
        private BovinoDaoImp bovinosDao;

        public BovinoRepository()
        {
            bovinosDao = new BovinoDaoImp(new userDao());
            bovinos = bovinosDao.getAllBovinos();
        }

        public ITerator getIterator()
        { 
            return new BovinoIterator();
        }
        
        private class BovinoIterator : ITerator
        {
            int index;

            public bool hasNext()
            {
                if (index < bovinos.Count)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return bovinos[index++];
                }
                return null;
            }
        }

        public void Create(object obj)
        {
            bovinos.Add(obj as Bovino);
        }

        public object Read()
        {
            return bovinos;
        }

        public void Update(object obj)
        {
            Bovino bovino = obj as Bovino;
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

        public void Delete(object obj)
        {
            Bovino bovino = obj as Bovino;
            bovinos.Remove(bovino);
        }
    }
}
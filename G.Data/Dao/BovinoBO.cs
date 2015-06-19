using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    class BovinoBO
    {
        public BovinoBO()
        {
            bovinos = new List<Bovino>();
        }

        private List<Bovino> bovinos = null;

        public List<Bovino> getAllBovinos()
        {
            return bovinos;
        }

        public void addBovino(Bovino bovino)
        {
            bovinos.Add(bovino);
        }

        public void updateBovino(Bovino bovino)
        {
            Bovino bo = bovinos.Find(b => b.id == bovino.id);
            bo.Apodo = bovino.Apodo;
            bo.Categoria = bovino.Categoria;
            bo.Color = bovino.Color;
            bo.Edad = bovino.Edad;
            bo.id = bovino.id;
            bo.Peso = bovino.Peso;
            bo.Raza = bovino.Raza;
            bo.Rp = bovino.Rp;
            bo.Sexo = bovino.Sexo;
        }

        public void deleteBovino(Bovino bovino)
        {
            bovinos.Remove(bovino);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data
{
    public class BovinoRepository:IBovinoRepository
    {
        public BovinoRepository()
        {
            bus = new Bus.userBus();
            bovinos = bus.GetAllBovinos();
        }

        Bus.userBus bus;
        private List<Bovino>bovinos;
     
        public List<Bovino> getAllBovinos()
        {
            return bovinos;
        }

        public void addBovino(Bovino bovino)
        {
            bovinos.Add(bovino);
            //bus.SetBovino(bovinos.Max());
        }

        public void UpdateBovino(Bovino bovino)
        {
           
        }

        public void DeleteBovino(Bovino bovino)
        {
            bovinos.Remove(bovino);
        }
    }
}

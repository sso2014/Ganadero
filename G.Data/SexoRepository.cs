using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Data
{
    class SexoRepository
    {
        public SexoRepository(Bus.userBus bus)
        {
            this.bus = bus;
        }
        private Bus.userBus bus;
        
        public List<string> getAllSexos() {
            return bus.GetAllSexos();      
        }
        
        //public void addBovino(Bovino bovino) { 
        //}   

        //public void UpdateBovino(Bovino bovino) { 
        //}
        
        //void DeleteBovino(Bovino bovino) {
        //}
    }
}

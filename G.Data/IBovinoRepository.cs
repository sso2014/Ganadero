using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data
{
    interface IBovinoRepository
    {
        List<Bovino> getAllBovinos();


        void addBovino(Bovino bovino);


        void UpdateBovino(Bovino bovino);


        void DeleteBovino(Bovino bovino);
      
    }
}

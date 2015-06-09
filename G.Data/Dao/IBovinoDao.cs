using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    public interface IBovinoDao
    {
        List<Bovino> getAllBovinos();
        Bovino getBovino(int id);
        void updateBovino(Bovino bovino);
        void deleteBoivno(Bovino bovino);
    }
}

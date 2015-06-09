using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Data.Dao
{
    public interface IUnitOfWork
    {
        void Commint();
    }
}

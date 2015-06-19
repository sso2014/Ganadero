using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Data.Context
{
   public interface IStrategy
   {
        void Create(object obj);
        
        object Read();
        
        void Update(object obj);

        void Delete(object obj);
    }
}

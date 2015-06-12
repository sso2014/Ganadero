using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Data
{
    public interface ITerator
    {
        bool hasNext();
        object next();
    }
}

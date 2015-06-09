using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    public interface ITransferenciaDao
    {
        List<Transferencia> getAllTransferencia();
        Transferencia getTransferencia(int id);
        void updateTransferencia(Transferencia transferencia);
        void deleteTransferencia(Transferencia transferencia);
    }
}

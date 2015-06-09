using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    public interface ICampoDao
    {
        List<Campo> getAllCampos();
        Campo getCampo(int id);
        void UpdateCampo(Campo campo);
        void DeleteCampo(Campo campo);

    }
}

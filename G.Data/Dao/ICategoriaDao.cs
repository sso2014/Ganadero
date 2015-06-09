using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data.Dao
{
    public interface ICategoriaDao
    {
        List<Categoria> getAllCategoria();
        Categoria getCategoria(int id);
        void updateCategoria(Categoria categoria);
        void deleteCategoria(Categoria categoria);
    }
}

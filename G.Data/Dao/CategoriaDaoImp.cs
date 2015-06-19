using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Data;
using G.Core.Data;
using System.Data;

namespace G.Data.Dao
{
    class CategoriaDaoImp:ICategoriaDao, IUnitOfWork
    {
        private userDao dao;
        private static List<Categoria> categorias;

        public CategoriaDaoImp(userDao dao)
        {

            this.dao = dao;

            categorias = new List<Categoria>();

            foreach (DataRow dr in dao.selectAllCategoria().Rows)
            {
                categorias.Add(new Categoria()
                {
                    id = Convert.ToInt32(dr["Categoria_id"]),
                    Descripcion = dr["Descripcion"].ToString()
                });
            }
        }

        public CategoriaDaoImp()
        {
            this.dao = new userDao();

            categorias = new List<Categoria>();

            foreach (DataRow dr in dao.selectAllCategoria().Rows)
            {
                categorias.Add(new Categoria()
                {
                    id = Convert.ToInt32(dr["Categoria_id"]),
                    Descripcion = dr["Descripcion"].ToString()
                });
            }
        }
              
        public List<Core.Data.Categoria> getAllCategoria()
        {
            return categorias;
        }

        public Core.Data.Categoria getCategoria(int id)
        {
            return categorias.Find(c => c.id == id);
        }

        public void updateCategoria(Core.Data.Categoria categoria)
        {
            Categoria cate = categorias.Find(c => c.id == categoria.id);
            categoria.Descripcion = categoria.Descripcion;
        }

        public void deleteCategoria(Core.Data.Categoria categoria)
        {
            categorias.Remove(categoria);
        }

        public void Commint()
        {

        }
    }
}

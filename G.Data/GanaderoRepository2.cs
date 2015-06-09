using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Data;
using G.Core.Data;
using G.Data.Dao;
using System.Threading;
using G.Core.DataUser;

namespace G.Data
{
    public class GanaderoRepository2
    {
        public GanaderoRepository2()
        {
            Thread th = new Thread(new ThreadStart(UpdateBD));
            dao = new userDao();
            campoDao = new CampoDaoImp(dao);
            establecimientoDao = new EstablecimientoDaoImp(dao);
            bovinoDao = new BovinoDaoImp(dao);
            categoriaDao = new CategoriaDaoImp(dao);
            eventoDao = new EventoDaoImp(dao);
            transferenciDao = new TransferenciaDaoImp(dao);
            uowList = new List<IUnitOfWork>();
            //<list commint>
            uowList.Add((IUnitOfWork)campoDao);
            uowList.Add((IUnitOfWork)establecimientoDao);
            uowList.Add((IUnitOfWork)bovinoDao);
            uowList.Add((IUnitOfWork)categoriaDao);
            uowList.Add((IUnitOfWork)eventoDao);
            uowList.Add((IUnitOfWork)transferenciDao);
            //</List commint>
            th.Start();
        }

        private static userDao dao;
        private static CampoDaoImp campoDao;
        private static EstablecimientoDaoImp establecimientoDao;
        private static BovinoDaoImp bovinoDao;
        private static CategoriaDaoImp categoriaDao;
        private static EventoDaoImp eventoDao;
        private static TransferenciaDaoImp transferenciDao;
        private static List<IUnitOfWork> uowList;
        
        public List<Evento> GetAllUserEvent()
        {
            return eventoDao.getAllEvento();
        }

        private void UpdateBD() { 
              while(true){
                  foreach (IUnitOfWork w in uowList)
                  {
                     w.Commint();
                  }
              }      
        }

        public List<Campo> GetAllCampo()
        {
            return campoDao.getAllCampos();        
        }

        public List<Establecimiento> GetAllEstablecimiento()
        {
            return establecimientoDao.getAllEstablecimiento();
        }

        public List<Bovino> GetAllBovino()
        {
            return bovinoDao.getAllBovinos();
        }

        public List<Categoria> GetAllCategoria()
        {
            return categoriaDao.getAllCategoria();
        }

        public List<Transferencia> GetAllTransferencias()
        {
            return transferenciDao.getAllTransferencia();
        }

        public Campo GetCampo(int id)
        {
            return campoDao.getCampo(id);
        }

        public Establecimiento GetEstablecimiento(int id)
        {
            return establecimientoDao.getEstablecimiento(id);
        }
        public Bovino GetBovino(int id)
        {
            return bovinoDao.getBovino(id);
        }

        public Categoria GetCategoria(int id)
        {
            return categoriaDao.getCategoria(id);
        }

        public void DeleteCampo(Campo campo)
        {
            campoDao.DeleteCampo(campo);
        }

        public void DeleteEstablecimiento(Establecimiento establecimiento)
        {
            establecimientoDao.deleteEstablecimiento(establecimiento);
        }

        public void DeleteBovino(Bovino bovino)
        {
            bovinoDao.deleteBoivno(bovino);
        }

        public void DeleteCategoria(Categoria categoria)
        {
            categoriaDao.deleteCategoria(categoria);
        }

        public void UpdateCampo(Campo campo)
        {
            campoDao.UpdateCampo(campo);
        }

        public void UpdateEstablecimiento(Establecimiento establecimiento)
        {
            establecimientoDao.updateEstablecimiento(establecimiento);
        }

        public void UpdateBovino(Bovino bovino)
        {
            bovinoDao.updateBovino(bovino);
        }

        public void UpdateCategoria(Categoria categoria)
        {
            categoriaDao.updateCategoria(categoria);
        }
    }
}
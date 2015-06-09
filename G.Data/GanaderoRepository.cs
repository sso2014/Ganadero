using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;


namespace G.Data
{
    public class GanaderoRepository
    {
        public GanaderoRepository()
        {
            CreateList();          
        }

        private void CreateList() {

            db = new Bus.userBus();
            establecimientos = db.GetAllEstablecimientos();
            campos = db.GetAllCampos();
            bovinos = db.GetAllBovinos();
            categorias = db.GetAllCategorias();
        }
        
        private Bus.userBus db;        
        private List<Bovino> bovinos;
        private List<Establecimiento> establecimientos;
        private List<Campo> campos;
        private List<Categoria> categorias;
    

        public Campo GetByCampo(int index)
        {
            return campos.Find(c => c.id == index);
        }


        public List<Categoria> getAllCategorias() {
            if (categorias == null)
                CreateList();
            return categorias;
        }
        
        public List<Establecimiento> getAllEstablecimientos() {
            if (establecimientos == null)
                CreateList();
            return establecimientos;
        }

        public void AddEstablecimiento(Establecimiento establecimiento)
        {
            if (establecimiento != null)
            {
                establecimientos.Add(establecimiento);
                db.InsertarEstablecimiento(establecimiento);
            }
        }

        public Establecimiento GetByEstablecimiento(int index)
        {
            return establecimientos.Find(e => e.Id == index);
        }

        public void AddCampo(Campo campo) {

            if (campo != null)
            {
                campos.Add(campo);
                db.InsertCampo(campo);
            }
        }

        public List<Campo> getAllCampos()
        {
            if (campos == null)
                CreateList();
            return campos;
        }

        #region bovinos
        public List<Bovino> getAllBovinos()
        {
            return bovinos;
        }
        public void addBovino(Bovino bovino)
        {
            db.InsertBovino(bovino);
            //bus.SetBovino(bovinos.Max());
        }
        public void UpdateBovino(Bovino bovino)
        {

        }
        public void DeleteBovino(Bovino bovino)
        {
            bovinos.Remove(bovino);
        }
        #endregion
    }
}
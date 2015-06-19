using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Gui;
using G.Data;
using G.Core.Data;
using G.Core.DataUser;

namespace Ganadero
{
    class Presenter {

       public Presenter(IView view, GanaderoRepository2 repository)
       {
           this.repository = repository;
           this.view = view;
           this.view.CampoSelected += SelectedCampo;
           this.view.CampoCreated += CreatedCampo;
           this.view.EstablecimientoCreated += CreatedEstablecimiento;
           this.view.EstablecimientoSelected += SelectedEstablecimiento;
           this.view.BovinoCreated += CreatedBovino;
           this.view.TransferenciaCreated += CreateTransferencia;
           this.view.Loading += Loading;
       }
        
       private GanaderoRepository2 repository; 
       private IView view;

       private void Refresh()
       {
           Loading();
       }

       private void Loading()
       {
           #region
           //foreach (Campo camp in repository.GetAllCampo())
           //{
           //    foreach (Establecimiento est in repository.GetAllEstablecimiento())
           //    {
           //        if (camp.id == est.Campo_id)
           //        {
           //            if (camp.Establecimientos == null)
           //                camp.Establecimientos = new List<Establecimiento>();
           //            camp.Establecimientos.Add(est);
           //        }
           //    }
           //}     
           #endregion
           view.LoadEstablecimientos(repository.GetAllEstablecimiento());
           view.LoadAllCampo(repository.GetAllCampo());
           view.LoadBovinos(repository.GetAllBovino());
           view.SelectedCategorias(repository.GetAllCategoria());
           view.LoadAllUserEvent(repository.GetAllUserEvent());
           view.LoadTransferencias(repository.GetAllTransferencias());

           //foreach (Campo campo in repository.GetAllCampo()) {
           //    campo.Establecimientos = repository.GetAllEstablecimiento().FindAll(e => e.Campo_id == campo.id);
           //}

           //foreach(Establecimiento establecimiento in repository.GetAllEstablecimiento()) {
           //}
       }

       private void CreateTransferencia()
       {
           repository.GetAllTransferencias().Add(view.CreatedTransferencia);
           view.LoadTransferencias(repository.GetAllTransferencias());
       }
        
       private void CreatedBovino()
       {        
               repository.GetAllBovino().AddRange(view.CreatedBovinos);
               repository.GetAllUserEvent().Add(new Evento()
               {
                   Descripcion = "Se ingresaron : " + view.CreatedBovinos.Count + "Bovinos",
                   User_id = 1,
               });
               view.LoadBovinos(repository.GetAllBovino());
               view.LoadAllUserEvent(repository.GetAllUserEvent());      
       }                   
       
       void CreatedCampo()
       {          
           repository.GetAllCampo().Add(view.CreatedCampo);
       }

       private void SelectedEstablecimiento() {

           Establecimiento est = repository.GetEstablecimiento(view.SelectedEstablecimientoIndex);

           if (est != null)
           {
               view.Loadestablecimiento(est);
               view.LoadBovinos(repository.GetAllBovino().FindAll(b => b.EstablecimientoID == est.Id));
           }           
       }

       private void CreatedEstablecimiento()
       {           
           repository.GetAllEstablecimiento().Add(view.CreatedEstablecimiento);
       }

       void SelectedCampo()
       {
           view.LoadCampo(repository.GetCampo(view.SelectedCampoIndex));
       }
    }
}
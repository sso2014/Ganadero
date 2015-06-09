using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;
using G.Core.DataUser;

namespace G.Gui
{
    public interface IView
    {
        event Action CampoSelected;

        event Action CampoCreated;

        event Action EstablecimientoCreated;

        event Action BovinoCreated;

        event Action BovinosSelected;

        event Action EstablecimientoSelected;

        event Action EstablecimientoSelectedIndex;

        event Action TransferenciaCreated;
        
        event Action Loading;                   
        
        void LoadBovinos(List<Bovino> bovinos);

        void LoadTransferencias(List<Transferencia> transferencias);

        Campo CreatedCampo { get; }

        void LoadAllCampo(List<Campo> campos);

        void LoadCampo(Campo campo);

        void LoadAllUserEvent(List<Evento> eventos);
        
        int SelectedCampoIndex { get; }
                
        Campo SelectedCampo{get;}

        List<Bovino> SelectedBovinos { get; }

        Transferencia CreatedTransferencia { get; } 
        
        Establecimiento SelectedEstablecimiento{get;}

        void Loadestablecimiento(Establecimiento establecimiento);

        void LoadEstablecimientos(List<Establecimiento> establecimientos);

        int SelectedEstablecimientoIndex { get; }

        Establecimiento CreatedEstablecimiento { get; }
                
        Bovino SelectedBovino { get; }

        void SelectedCategorias(List<Categoria> categorias);

        List<Bovino> CreatedBovinos { get; }    
       
    }
}

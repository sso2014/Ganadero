using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Gui
{
    public interface IGanaderoView
    {
        event Action CampoSelect;
        event Action CreateEstablecimiento;
        event Action BovinoSelected;
        event Action CampoLoad;
        event Action CreateCampo;
        event Action CreatedBovino;
        event Action EstablecimientoSelected;
       

        Campo SelectCampo { get; }

        void SelectAllCampos(List<Campo> campos);

        void LoadCategorias(List<Categoria> categorias);
        
        void LoadBovinos(List<Bovino> bovino);

        void LoadEstablecimiento(Establecimiento establecimiento);

        void SelectedCampo(Campo campo);

        void LoadEstablecimientos(List<Establecimiento> establecimientos);

        Bovino SelectBovino { get; }

        List<Bovino> SelectBovinos { get; }

        Establecimiento SelectEstablecimiento { get; }       
       
    }
}

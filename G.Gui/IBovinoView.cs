using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Gui
{
    public interface IBovinoView
    {
        event Action BovinoSelect;        
        void SelectAllBovino(List<Bovino> bovino);
        Bovino SelectBovino { get; }
        
    }
}

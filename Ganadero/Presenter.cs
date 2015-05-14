using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Gui;
using G.Data;


namespace Ganadero
{
    class Presenter
    {
        public Presenter(IBovinoView view, BovinoRepository repository)
        {
            this.repository = repository;
            this.view = view;
            view.SelectAllBovino(repository.getAllBovinos());
        }

        private BovinoRepository repository;
        private IBovinoView view;
    }
}

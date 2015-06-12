using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Data;
using G.Data.Dao;
using G.Data.Context;


namespace G.GUI2
{
    class Presenter
    {
        public Presenter(IView view, IStrategy repository)
        {
            this.view = view;
            this.repository = repository;
        }

        private IView view;
        private IStrategy repository;

        
    }
}

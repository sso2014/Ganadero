using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;

namespace G.Data
{
    public class CampoRepository
    {
        public CampoRepository()
        {
            bovinos = new GanaderoRepository();            
           
        }
        List<Campo> campos;
        GanaderoRepository bovinos;
       
        //public List<Campo> getAllCampos()
        //{
           
        //}

        public void addCampo(Campo campo)
        {

        }

        public void UpdateCampo(Campo campo)
        {

        }

        public void DeleteCampo(Campo campo)
        {

        }
    }
}


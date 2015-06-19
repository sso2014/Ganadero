using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Data2.DAO
{
    public class daoFactory
    {    
        private static DataSouce db = new DataSouce();

        public static BovinoDao readBovinoDao()
        {
            return new BovinoDao(db);
        }

        public static CampoDao readCampoDao()
        {
            return new CampoDao(db);
        }

        //public static EstablecimientoDao readEstablecimientoDao()
        //{
        //    return new EstablecimientoDao(db);
        //}
    }
}
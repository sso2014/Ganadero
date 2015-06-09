using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;
using G.Data.Bus;
using G.Data.Dao;
using System.Data;

namespace G.Data
{
    public class BovinoCollection
    {
        public BovinoCollection(Dao.userDao dao)
        {
            this.dao = dao;

            foreach (DataRow dr in dao.selectAllBovinos().Rows)
            {
                bovinos.Add(Convert.ToInt32(dr["Bovino_id"].ToString()),
                    new Bovino()
                    {
                        Rp = dr["RP"].ToString(),
                        EstablecimientoID = Convert.ToInt32(dr["establecimiento_id"])
                    });
            }
        }

        private userDao dao;
    
        private static Dictionary<int, Bovino> bovinos =
            new Dictionary<int, Bovino>();
        
        public Bovino this [int index]
        {
            get {
                if (!bovinos.ContainsKey(index))
                {
                    return bovinos[index] = new Bovino();                    
                }
                else
                {
                    return
                        bovinos[index];
                }

            }

        }
        
    }
}

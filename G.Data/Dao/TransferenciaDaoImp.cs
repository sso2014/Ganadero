using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Core.Data;
using System.Data;


namespace G.Data.Dao
{
    public class TransferenciaDaoImp:ITransferenciaDao, IUnitOfWork
    {
        public TransferenciaDaoImp(userDao dao)
        {
            this.dao = dao;
            transferencias = new List<Transferencia>();

            foreach (DataRow dr in dao.selectAllTransferencias().Rows)
            {
                transferencias.Add(new Transferencia()
                {
                    Id = Convert.ToInt32(dr["Transferencia_id"]),
                    Fecha = Convert.ToDateTime( dr["Fecha"]),
                    DesdeEstablecimiento = Convert.ToInt32(dr["Desde_Establecimiento_id"]),
                    HastaEstablecimiento = Convert.ToInt32(dr["Hasta_Establecimiento_id"]),
                    Descripcion = dr["Descripcion"].ToString(),
                    Bovino_id = new List<int>()
                });
            }

            countTransferencia = transferencias.Count;
        }

        private static List<Transferencia> transferencias;
        private static int countTransferencia;
        private userDao dao;

        public List<Transferencia> getAllTransferencia()
        {
            return transferencias;
        }

        public Transferencia getTransferencia(int id)
        {
            return transferencias.Find(t => t.Id == id);
        }

        public void updateTransferencia(Transferencia transferencia)
        {
            Transferencia trans = transferencias.Find(t => t.Id == transferencia.Id);
            trans.Fecha = transferencia.Fecha;
            trans.DesdeEstablecimiento = transferencia.DesdeEstablecimiento;
            trans.HastaEstablecimiento = transferencia.HastaEstablecimiento;
            trans.Descripcion = transferencia.Descripcion;
        }

        public void deleteTransferencia(Core.Data.Transferencia transferencia)
        {
            transferencias.Remove(transferencia);
        }

        public void Commint()
        {
            if (countTransferencia < transferencias.Count)
            {
                int count = transferencias.Max(t => t.Id) + 1;

                foreach (Transferencia t in transferencias)
                {
                    if (t.Id == 0)
                    {
                        t.Id = count;
                        t.Fecha = DateTime.Now;
                        dao.insertIntoTransferencia(
                            t.Fecha,
                            t.DesdeEstablecimiento,
                            t.HastaEstablecimiento,
                            t.Descripcion);
                            
                        count++;

                        

                    }
                }
            }
        }
    }
}

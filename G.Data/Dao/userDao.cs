using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace G.Data.Dao
{
    public class userDao
    {
        public userDao()
        {
            conn = new dbConnection();
        }
        private dbConnection conn = null;
        public DataTable selectAllBovinos()
        {
            string query =
            string.Format("SELECT_ALL_BOVINOS");
            return conn.executeSelectQuery(query, null);
        }
        public int insertIntoBovino(int rp, string apodo, DateTime fecha_Nacimiento, int sexo, int color, float peso, int edad, int madre, int padre, int raza)
        {
            string query =
                string.Format("INSERT_BOVINO");
            SqlParameter[] parameter = new SqlParameter[10];
            parameter[0] = new SqlParameter("@rp", SqlDbType.Int);
            parameter[0].Value = rp;
            parameter[1] = new SqlParameter("@apodo", SqlDbType.NChar);
            parameter[1].Value = apodo;
            parameter[2] = new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime);
            parameter[2].Value = fecha_Nacimiento;
            parameter[3] = new SqlParameter("@sexo", SqlDbType.Int);
            parameter[3].Value = sexo;
            parameter[4] = new SqlParameter("@color", SqlDbType.Int);
            parameter[4].Value = color;
            parameter[5] = new SqlParameter("@peso", SqlDbType.Float);
            parameter[5].Value = peso;
            parameter[6] = new SqlParameter("@edad", SqlDbType.Int);
            parameter[6].Value = edad;
            parameter[7] = new SqlParameter("@madre", SqlDbType.Int);
            parameter[7].Value = madre;
            parameter[8] = new SqlParameter("@padre", SqlDbType.Int);
            parameter[8].Value = padre;
            parameter[9] = new SqlParameter("@raza", SqlDbType.Int);
            parameter[9].Value = apodo;
            return conn.executeInsertQuery(query, parameter);
        }
        public int insertIntoSexoBovino(string sexo)
        {
            string query =
                string.Format("INSERT_SEXO");
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@sexo", SqlDbType.NChar);
            parameter[0].Value = sexo;
            return conn.executeInsertQuery(query, parameter);
        }
        public int updateBovino(int id, int rp, string apodo, DateTime fecha_Nacimiento, int sexo, int color, float peso, int edad, int madre, int padre, int raza)
        {
            string query =
              string.Format("UPDATE_BOVINO");
            SqlParameter[] parameter = new SqlParameter[11];
            parameter[0] = new SqlParameter("@rp", SqlDbType.Int);
            parameter[0].Value = rp;
            parameter[1] = new SqlParameter("@apodo", SqlDbType.NChar);
            parameter[1].Value = apodo;
            parameter[2] = new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime);
            parameter[2].Value = fecha_Nacimiento;
            parameter[3] = new SqlParameter("@sexo", SqlDbType.Int);
            parameter[3].Value = sexo;
            parameter[4] = new SqlParameter("@color", SqlDbType.Int);
            parameter[4].Value = color;
            parameter[5] = new SqlParameter("@peso", SqlDbType.Float);
            parameter[5].Value = peso;
            parameter[6] = new SqlParameter("@edad", SqlDbType.Int);
            parameter[6].Value = edad;
            parameter[7] = new SqlParameter("@madre", SqlDbType.Int);
            parameter[7].Value = madre;
            parameter[8] = new SqlParameter("@padre", SqlDbType.Int);
            parameter[8].Value = padre;
            parameter[9] = new SqlParameter("@raza", SqlDbType.Int);
            parameter[9].Value = apodo;
            parameter[10] = new SqlParameter("@id", SqlDbType.Int);
            parameter[10].Value = id;
            return conn.executeInsertQuery(query, parameter);
        }
        public int deleteBovino(int id)
        {
            string query =
                string.Format("DELETE_BOVINO");
            SqlParameter[] paramater = new SqlParameter[1];
            paramater[0] = new SqlParameter("@id", SqlDbType.Int);
            paramater[0].Value = id;
            return conn.executeDeleteQuery(query, paramater);
        }
        public DataTable selectAllSexos()
        {
            string query =
                string.Format("SELECT_ALL_SEXOS");
            return conn.executeSelectQuery(query, null);
        }
    }
}
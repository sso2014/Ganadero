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

        public DataTable selectAllTransferencias()
        {
            string query =
                string.Format("SELECT_ALL_TRANSFERENCIAS");
            return conn.executeSelectQuery(query, null);
        }
        
        public void insertIntoTransferencia(DateTime fecha, int Desde_establecimiento_id, int Hasta_establecimiento2_id, string Descripcion)
        {
            string query =
                string.Format("INSERT_TRANSFERENCIA");
            SqlParameter [] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@Fecha", SqlDbType.DateTime);
            parameters[0].Value = fecha;
            parameters[1] = new SqlParameter("@Desde_Establecimiento_id", SqlDbType.Int);
            parameters[1].Value = Desde_establecimiento_id;
            parameters[2] = new SqlParameter("@Hasta_Establecimiento_id", SqlDbType.Int);
            parameters[2].Value = Desde_establecimiento_id;
            parameters[3] = new SqlParameter("@Descripcion", SqlDbType.NChar);
            parameters[3].Value = Descripcion;
            conn.executeInsertQuery(query, parameters);
        }

        public void insertTransferenciaEvent(int transferenciaId, DateTime fecha,  int BoivinoId, int categoriaId)
        {
            string query =
                string.Format("INSERT_TRANSFERENCIA_EVENT");
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Transferencia_id", SqlDbType.Int);
            parameters[0].Value = transferenciaId;
            parameters[1] = new SqlParameter("@Fecha", SqlDbType.DateTime);
            parameters[1].Value = fecha;
            parameters[2] = new SqlParameter("@Bovino_id", SqlDbType.Int);
            parameters[2].Value = fecha;
            parameters[3] = new SqlParameter("@Categoria_id", SqlDbType.Int);
            parameters[3].Value = categoriaId;
            conn.executeInsertQuery(query, parameters);
        }

        public DataTable selectAllBovinos()
        {
            string query =
                string.Format("SELECT_ALL_BOVINOS");
            return conn.executeSelectQuery(query, null);
        }

        public DataTable selectedAllEvento()
        {
            string query = 
                string.Format("SELECT_ALL_EVENTOS");
           return conn.executeSelectQuery(query, null);
        }

        public int insertIntoEvento(int user, string descripcion)
        {
            string query =
                string.Format("INSERT_EVENTO");
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@User_id", SqlDbType.Int);
            parameter[0].Value = user;
            parameter[1] = new SqlParameter("@Fecha", SqlDbType.DateTime);
            parameter[1].Value = DateTime.Now;
            parameter[2] = new SqlParameter("@Descripcion", SqlDbType.NChar);
            parameter[2].Value =descripcion;
            return conn.executeInsertQuery(query, parameter);
        }

        public DataTable selectAllCategoria() {
            string query =
                string.Format("SELECT_ALL_CATEGORIA");
            return conn.executeSelectQuery(query, null);
        }

        public int insertIntoBovino(string rp, int categoria, int establecimiento_id){ 
            string query =
                 string.Format("INSERT_BOVINO");
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@categoria_id", SqlDbType.Int);
            parameter[0].Value = categoria;
            parameter[1] = new SqlParameter("@rp", SqlDbType.NVarChar);
            parameter[1].Value = rp;
            parameter[2] = new SqlParameter("@establecimiento_id", SqlDbType.Int);
            parameter[2].Value = establecimiento_id;
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

        public int deleteCampo(int campo_id)
        {
            string query =
                string.Format("DELETE_CAMPO");
            SqlParameter [] parameter = new SqlParameter[1];
            parameter[0]= new SqlParameter("@campo_id",SqlDbType.Int);
            parameter[0].Value = campo_id;
            return conn.executeDeleteQuery(query, parameter);
        }

        public int updateCampo(int campo_id, string nombre, string renspa, string razon, string cuil, string renspa_ganadero, string direccion, string localidad, string partido, string provincia)
        {
            string query =
                string.Format("UPDATE_CAMPO");
            SqlParameter [] parameter = new SqlParameter[10];
            parameter[9] = new SqlParameter("@campo_id", SqlDbType.Int);
            parameter[9].Value = campo_id;
            parameter[0] = new SqlParameter("@nombre",SqlDbType.NChar);
            parameter[0].Value = nombre;
            parameter[1] = new SqlParameter("@renspa",SqlDbType.NChar);
            parameter[1].Value = renspa;
            parameter[2] = new SqlParameter("@razon",SqlDbType.NChar);
            parameter[2].Value = razon;
            parameter[3] = new SqlParameter("@cuil",SqlDbType.NChar);
            parameter[3].Value = cuil;
            parameter[4] = new SqlParameter("@renspa_ganadero",SqlDbType.NChar);
            parameter[4].Value = renspa_ganadero;
            parameter[5] = new SqlParameter("@direccion",SqlDbType.NChar);
            parameter[5].Value = direccion;
            parameter[6] = new SqlParameter("@localidad",SqlDbType.NChar);
            parameter[6].Value = localidad;
            parameter[7] = new SqlParameter("@partido",SqlDbType.NChar);
            parameter[7].Value = partido;
            parameter[8] = new SqlParameter("@provincia",SqlDbType.NChar);
            parameter[8].Value = provincia;
            return conn.executeUpdateQuery(query, parameter);
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

        public DataTable selectUltimoBovino()
        {
            string query =
                string.Format("SELECT_ULTIMO_BOVINO");
            return conn.executeSelectQuery(query, null);
        }

        public DataTable selectAllEstablecimientos()
        {
            string query =
                string.Format("SELECT_ALL_ESTABLECIMIENTOS");
            return conn.executeSelectQuery(query, null);
        }

        public int deleteEstablecimiento(int id)
        {
            string query =
                string.Format("DELETE_ESTABLECIMIENTO");
            SqlParameter [] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@establecimiento_id", SqlDbType.Int);
            parameter[0].Value = id;
           return conn.executeDeleteQuery(query, parameter);
        }

        public int updateEstablecimiento(int id, int campo_id, string nombre, string localidad, string partido, string provincia) {
            string query =
                string.Format("UPDATE_ESTABLECIMIENTO");
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@id", SqlDbType.Int);
            parameter[0].Value = id;
            parameter[1] = new SqlParameter("@campo_id", SqlDbType.Int);
            parameter[1].Value = campo_id;
            parameter[2] = new SqlParameter("@localidad", SqlDbType.NChar);
            parameter[2].Value = localidad;
            parameter[3] = new SqlParameter("@partido", SqlDbType.NChar);
            parameter[3].Value = campo_id;
            parameter[4] = new SqlParameter("@provincia", SqlDbType.NChar);
            parameter[4].Value = provincia;
            return conn.executeUpdateQuery(query, parameter);

        }       
       
        public int insertIntEstablecimiento(int campo_id,  string nombre, string localidad, string partido, string provincia)
        {
            string query =
                string.Format("INSERT_ESTABLECIMIENTO");
            SqlParameter [] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@campo_id", SqlDbType.Int);
            parameter[0].Value = campo_id;
            parameter[1] = new SqlParameter("@nombre", SqlDbType.NChar);
            parameter[1].Value = nombre;
            parameter[2] = new SqlParameter("@localidad", SqlDbType.NChar);
            parameter[2].Value = localidad;
            parameter[3] = new SqlParameter("@partido", SqlDbType.NChar);
            parameter[3].Value = partido;
            parameter[4] = new SqlParameter("@provincia", SqlDbType.NChar);
            parameter[4].Value = provincia;
            return conn.executeDeleteQuery(query, parameter);
        }

        public int insertIntoCampo(string nombre, string renspa, string razon, string cuil, string renspa_ganadero, string direccion, string localidad, string partido, string provincia)
        {
            string query =
                string.Format("INSERT_CAMPO");
            SqlParameter [] parameter = new SqlParameter[9];
            parameter[0] = new SqlParameter("@nombre", SqlDbType.NChar);
            parameter[0].Value = nombre;
            parameter[1] = new SqlParameter("@renspa", SqlDbType.NChar);
            parameter[1].Value = renspa;
            parameter[2] = new SqlParameter("@razon", SqlDbType.NChar);
            parameter[2].Value = razon;
            parameter[3] = new SqlParameter("@cuil", SqlDbType.NChar);
            parameter[3].Value = cuil;
            parameter[4] = new SqlParameter("@renspa_ganadero", SqlDbType.NChar);
            parameter[4].Value = renspa_ganadero;
            parameter[5] = new SqlParameter("@direccion", SqlDbType.NChar);
            parameter[5].Value = direccion;
            parameter[6] = new SqlParameter("@localidad", SqlDbType.NChar);
            parameter[6].Value = localidad;
            parameter[7] = new SqlParameter("@partido", SqlDbType.NChar);
            parameter[7].Value = partido;
            parameter[8] = new SqlParameter("@provincia", SqlDbType.NChar);
            parameter[8].Value = provincia;
            return conn.executeInsertQuery(query, parameter);
        }

        public DataTable selectAllCampos()
        {
            string query =
                string.Format("SELECT_ALL_CAMPOS");
            return conn.executeSelectQuery(query, null);
        }

        public DataTable selectAllSexos()
        {
            string query =
                string.Format("SELECT_ALL_SEXOS");
            return conn.executeSelectQuery(query, null);
        }
    }
}
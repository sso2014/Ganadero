using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace G.Data2.DAO
{
        public class DataSouce : IDisposable
        {
            public DataSouce()
            {
                myAdapter = new SqlDataAdapter();
                conn = new SqlConnection(StringConnection);
            }

            private SqlDataAdapter myAdapter;
            private SqlConnection conn;
            private string StringConnection =
                @"Data Source=TELEMETRIA-PC\SSOFT;Initial Catalog=Ganaderia;Integrated Security=True";

            //@"Data Source=TELEMETRIA-PC\RIEGO;Initial Catalog=GANADERIA;Integrated Security=True";
            //@"Data Source=UAGRRES00012\RIEGO;Initial Catalog=GANADERIA;Integrated Security=True";
            //@"Data Source=TELEMETRIA-PC\SSOFT;Initial Catalog=GANADERIA;Integrated Security=True";//;Ganaderia;User ID=admin;Password=SSOsso123";
            //@"Data Source=TELEMETRIA-PC\SSOFT;Initial Catalog=Ganaderia;User ID=admin;Password=SSOsso123";
            private SqlConnection openConnection()
            {
                try
                {
                    if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    {
                        conn.Open();
                    }
                    return conn;
                }
                catch (Exception exp)
                {
                    return null;
                }
            }
            
            public int executeUpdateQuery(string query, SqlParameter[] parameters)
            {
                SqlCommand myCommand = new SqlCommand();

                try
                {
                    myCommand.CommandText = query;
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Connection = openConnection();
                    myCommand.Parameters.AddRange(parameters);
                    int num = myCommand.ExecuteNonQuery();
                    return num;
                }
                catch (SqlException exp)
                {
                    return 0;
                }
                finally
                {
                    myCommand.Connection.Close();
                }
            }
            public DataTable executeSelectQuery(string query, SqlParameter[] sqlParameter)
            {
                SqlCommand myCommand = new SqlCommand();
                DataTable datatable = new DataTable();
                DataSet ds = new DataSet();
                myCommand.CommandType = CommandType.StoredProcedure;

                try
                {
                    myCommand.Connection = openConnection();
                    myCommand.CommandText = query;
                    if (sqlParameter != null)
                        myCommand.Parameters.AddRange(sqlParameter);
                    myCommand.ExecuteNonQuery();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(ds);
                    datatable = ds.Tables[0];
                }
                catch (SqlException Exp)
                {
                    string m = Exp.Message;
                }
                finally
                {
                }
                return datatable;
            }
            public int executeInsertQuery(string query, SqlParameter[] sqlParameter)
            {
                SqlCommand myCommand = new SqlCommand();
                try
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Connection = openConnection();
                    myCommand.CommandText = query;
                    myCommand.Parameters.AddRange(sqlParameter);
                    int num = myCommand.ExecuteNonQuery();
                    return num;
                }
                catch (SqlException exp)
                {

                    string msg = exp.Message;
                    return 0;
                }
                finally
                {
                    myCommand.Connection.Close();
                }          
            }
            public int executeDeleteQuery(string query, SqlParameter[] sqlParameter)
            {
                SqlCommand myCommand = new SqlCommand();
                try
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Connection = openConnection();
                    myCommand.CommandText = query;
                    myCommand.Parameters.AddRange(sqlParameter);
                    int num = myCommand.ExecuteNonQuery();
                    return num;
                }
                catch (SqlException exp)
                {
                    return 0;
                }
                finally
                {
                    myCommand.Connection.Close();
                }
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }

using System;
using Microsoft.Data.SqlClient;

namespace ABP_Dal.DataBase
{
    public class DataBaseRepository
    {
        SqlConnection sqlConnection = new SqlConnection("Server = LAPTOP-MFD4FGN1\\SQLEXPRESS07; Initial Catalog = IlCats_db; Integrated Security = True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}

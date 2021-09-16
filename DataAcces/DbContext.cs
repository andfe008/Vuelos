using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAcces
{
    public class Connection
    {
        private SqlConnection ConnectionString = new SqlConnection("server=DESKTOP-PJ8H6RC;database=Vuelos;integrated security = true");


        public SqlConnection GetConnection()
        {
            //if (ConnectionString.State == ConnectionState.Closed)
                //ConnectionString.Open();
            return ConnectionString;
        }

        public SqlConnection CerrarConexion()
        {
            if (ConnectionString.State == ConnectionState.Open)
                ConnectionString.Close();
            return ConnectionString;
        }
    }
}

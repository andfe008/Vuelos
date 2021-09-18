using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Usuario
    {
        DataAcces.Connection connection = new DataAcces.Connection();

        public List<DataAcces.Models.Usuario> Select()
        {
            string query = "SELECT * FROM Usuario";

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Usuario>(query).ToList();
            }
        }
       
    }
}

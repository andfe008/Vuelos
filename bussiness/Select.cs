﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Select
    {
        DataAcces.Connection connection = new DataAcces.Connection();

        public List<DataAcces.Models.Select> City()
        {
            string query = "SELECT id as Keys, Nombre as Vals FROM Ciudad";

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Select>(query).ToList();
            }
        }
        
        public List<DataAcces.Models.Select> Airline()
        {
            string query = "SELECT id as Keys, Nombre as Vals FROM Aerolineas";

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Select>(query).ToList();
            }
        }

        public List<DataAcces.Models.Select> Filter(int id)
        {
            string query = "select id_Aerolinea as keys, Aviones.Nombre as Vals from Aviones inner join Aerolineas on Aviones.id_Aerolinea= Aerolineas.id where Aerolineas.id = @id ";

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Select>(query, new { id = id }).ToList();
            }
        }
        public List<DataAcces.Models.Select> Flys()
        {
            string query = "SELECT id as Keys, Nombre as Vals FROM Aviones";

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Select>(query).ToList();
            }
        }


    }
}

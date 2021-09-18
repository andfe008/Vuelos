using Dapper;
using DataAcces.DTOModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Vuelo
    {
        DataAcces.Connection connection = new DataAcces.Connection();


        public List<DataAcces.Models.Vwvuelos> List()
        {
            string query = "SELECT * FROM vw_ObtenerVuelos";

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Vwvuelos>(query).ToList();
            }
        }

        public DataAcces.Models.Response New(DTONuevoVuelo model)
        {

            using (var conn = connection.GetConnection())
            {
                return conn.Query<DataAcces.Models.Response>("sp_NuevoVuelo",
                    new
                    {
                        idASalida = model.idASalida,
                        FechaSalida = model.FechaSalida,
                        HoraSalida = model.HoraSalida,
                        idLlegada = model.idLlegada,
                        FechaLlegada = model.FechaLlegada,
                        HoraLlegada = model.HoraLlegada,
                        IdAvion =    "1" //model.IdAvion,
                    },
                        commandType: CommandType.StoredProcedure).First();
            }
        }
    }
}

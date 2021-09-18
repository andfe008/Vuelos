using Dapper;
using DataAcces.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business
{

    public class Login
    {
        private DataAcces.Connection connection = new DataAcces.Connection();
        public DataAcces.Models.Response login(DataAcces.DTOModels.Login model)
        {
            Response response = new Response();
            string query = "select Nick,IdRol,IdPersona from Usuario where Nick = @Nick and Clave = @Clave ";
            try
            {
                using (var conn = connection.GetConnection())
                {
                    var usert = conn.Query<DataAcces.Models.Usuario>(query, new { Nick = model.Nick, Clave = model.Clave }).FirstOrDefault();
                    //valido si el "usert" es diferente de nulo es porque encontro el usuario
                    if (usert != null)
                    {
                        response.Status = 1;
                        response.Mensaje = "Usuario encontrado";
                        response.Data = JsonSerializer.Serialize(usert);
                        //context.Session("User") = usert;
                    }
                    else
                    {
                        response.Status = 1;
                        response.Mensaje = "Usuario no encontrado";
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Status = 0;
                response.Mensaje = ex.Message;
                return response;
            }
        }
    }
}

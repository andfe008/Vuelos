using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class Response
    {
        public int id { get; set; }
        public int Status { get; set; }
        public string Mensaje { get; set; }
        public string Data { get; set; }
    }
}

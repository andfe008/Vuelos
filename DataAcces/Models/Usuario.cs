using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public bool Estado { get; set; }
        public int IdRol { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}

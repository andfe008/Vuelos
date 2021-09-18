using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DTOModels
{
    public class DTONuevoVuelo
    {
        public int idASalida { get; set; }
        public string FechaSalida { get; set; }
        public string HoraSalida { get; set; }
        public int idLlegada { get; set; }
        public string FechaLlegada { get; set; }
        public string HoraLlegada { get; set; }
        public int IdAvion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class Vwvuelos
    {
        public int Numero_Vuelo { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime FEcha_Llegada { get; set; }
        public string Aerolinea { get; set; }
        public string Nombre { get; set; }
        public string origen { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public string Destino { get; set; }
        public int Estado { get; set; }
    }
}
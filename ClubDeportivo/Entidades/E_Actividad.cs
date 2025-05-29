using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Actividad
    {
        public int idActividad { get; set; }
        public string nombre { get; set; }
        public int cupoActual  { get; set; }
        public int cupoMax { get; set; }
        public decimal valor { get; set; }
    }
}

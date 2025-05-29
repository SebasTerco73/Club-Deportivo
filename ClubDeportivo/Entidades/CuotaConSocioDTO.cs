using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class CuotaConSocioDTO
    {
        public int CodSocio { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string NombreCompleto { get; set; }
        public string Documento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Socio
    {
        public int Documento { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool FichaMedica { get; set; }
        public bool AptoMedico { get; set; }
    }
}

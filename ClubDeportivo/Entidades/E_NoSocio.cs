using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_NoSocio : E_Persona
    {
        public E_NoSocio(string documento, string nombreCompleto, DateTime fechaNacimiento, string telefono,
           DateTime fechaInscripcion, bool fichaMedica,  bool aptoMedico) 
            : base(documento, nombreCompleto, fechaNacimiento, telefono)
        {
            this.fechaInscripcion = fechaInscripcion;
            this.fichaMedica = fichaMedica;
            this.aptoMedico = aptoMedico;
        }

        public int idNoSocio { get; set; }
        public DateTime fechaInscripcion { get; }
        public bool fichaMedica { get; }
        public bool aptoMedico { get; }

    }
}

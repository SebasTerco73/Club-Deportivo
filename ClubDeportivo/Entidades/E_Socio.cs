using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Socio : E_Persona
    {
        public int idSocio { get; }
        public DateTime fechaInscripcion { get; }
        public bool fichaMedica { get; }
        public bool aptoMedico { get; }
        public bool activo { get; }
        public bool carnet { get; }

        public E_Socio(string documento, string nombreCompleto, DateTime fechaNacimiento,
            string telefono, DateTime fechaInscripcion,
            bool fichaMedica, bool aptoMedico) :
            base(documento, nombreCompleto, fechaNacimiento, telefono)
        {
            this.fechaInscripcion = fechaInscripcion;
            this.fichaMedica = fichaMedica;
            this.aptoMedico = aptoMedico;
            this.activo = true;
        }

        public E_Socio(string documento, string nombreCompleto, DateTime fechaNacimiento,
            string telefono, int idSocio, DateTime fechaInscripcion,
            bool fichaMedica, bool aptoMedico, 
            bool carnet) : base(documento, nombreCompleto, fechaNacimiento, telefono)
            {
                this.idSocio = idSocio;
                this.fechaInscripcion = fechaInscripcion;
                this.fichaMedica = fichaMedica;
                this.aptoMedico = aptoMedico;
                this.activo = true;
                this.carnet = carnet;
            }
    }
}

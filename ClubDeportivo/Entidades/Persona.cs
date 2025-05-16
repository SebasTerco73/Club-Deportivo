using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class Persona
    {
       
        public string documento { get; }
        public string nombreCompleto { get; }
        public DateTime fechaNacimiento { get; }
        public string telefono { get; }

        public Persona(string documento, string nombreCompleto, DateTime fechaNacimiento, string telefono)
        {
            this.documento = documento;
            this.nombreCompleto = nombreCompleto;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
        }

    }
}

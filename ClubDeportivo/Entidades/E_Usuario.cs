using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Usuario
    {
        private string nombreUsuario;
        private string passUsuario;
        private int rol;
        private bool activo;

        public E_Usuario(string nombreUsuario, string passUsuario, int rol, bool activo)
        {
            this.nombreUsuario = nombreUsuario;
            this.passUsuario = passUsuario;
            this.rol = rol;
            this.activo = activo;
        }
    }
}

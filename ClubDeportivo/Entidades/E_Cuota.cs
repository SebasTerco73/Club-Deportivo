using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Cuota
    {
        
        public int CodSocio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public bool EstadoPago { get; set; }
        public string MedioPago { get; set; }
        public int cantCuotas { get; set; }

        public E_Cuota(int CodSocio,DateTime fechaPago, string medioPago, int cantCuotas)
        {
            this.CodSocio = CodSocio;
            this.FechaPago = fechaPago;
            this.FechaVencimiento = fechaPago.AddMonths(1);
            this.Monto = 5000;
            this.EstadoPago = true;
            this.MedioPago = medioPago;
            this.cantCuotas = cantCuotas;
        }

    }
}

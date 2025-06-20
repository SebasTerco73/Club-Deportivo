using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Cuota
    {
        public int? idCuota { get; set; }
        
        public int CodSocio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public bool EstadoPago { get; set; }
        public string MedioPago { get; set; }
        public int cantCuotas { get; set; }

        public int ultimoPago { get; set; } // Indica si es la última cuota del mes, 0 si no es la última

        public E_Cuota(int CodSocio,DateTime fechaPago, string medioPago, int cantCuotas)
        {
            this.CodSocio = CodSocio;
            this.FechaPago = fechaPago;
            this.FechaVencimiento = fechaPago.AddMonths(1);
            this.Monto = (medioPago.Equals("Tarjeta") && (cantCuotas == 3 || cantCuotas == 6)) ? 5000m * 0.90m : 5000m;
            this.EstadoPago = true;
            this.MedioPago = medioPago;
            this.cantCuotas = cantCuotas;
            this.ultimoPago = 1; // Por defecto, es el ultimo pago
        }

        public E_Cuota(int CodSocio, DateTime fechaPago, DateTime vencimiento, string medioPago, int cantCuotas)
        {
            this.CodSocio = CodSocio;
            this.FechaPago = fechaPago;
            this.FechaVencimiento = vencimiento;
            this.Monto = (medioPago.Equals("Tarjeta") && (cantCuotas == 3 || cantCuotas == 6)) ? 5000m*0.90m:5000m;
            this.EstadoPago = true;
            this.MedioPago = medioPago;
            this.cantCuotas = cantCuotas;
            this.ultimoPago = 1; // Por defecto, es el ultimo pago
        }

    }
}

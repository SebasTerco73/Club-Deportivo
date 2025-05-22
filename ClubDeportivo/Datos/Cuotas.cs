using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class Cuotas
    {
        public int RegistrarCuota(E_Cuota cuota)
        {
            int idGenerado = -1;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql = @"INSERT INTO cuota
                       (codSocio, fechaVencimiento, fechaPago, monto, estadoPago, medioPago) 
                       VALUES (@codSocio, @fechaVencimiento, @fechaPago, @monto, @estadoPago, @medioPago);";

                MySqlCommand comando = new MySqlCommand(sql, sqlCon);

                comando.Parameters.Add("@codSocio", MySqlDbType.Int32).Value = cuota.CodSocio;
                comando.Parameters.Add("@fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                comando.Parameters.Add("@fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                comando.Parameters.Add("@monto", MySqlDbType.Decimal).Value = cuota.Monto;
                comando.Parameters.Add("@estadoPago", MySqlDbType.Int16).Value = cuota.EstadoPago;
                comando.Parameters.Add("@medioPago", MySqlDbType.VarChar).Value = cuota.MedioPago;

                sqlCon.Open();
                comando.ExecuteNonQuery();

                idGenerado = (int)comando.LastInsertedId; // Obtengo el id autogenerado
            }
            catch (Exception ex)
            {
                // Log o manejo de error aquí
                idGenerado = -1;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return idGenerado;
        }
    }
}

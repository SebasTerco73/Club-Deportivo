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
                       (codSocio, fechaVencimiento, fechaPago, monto, estadoPago, medioPago,cantCuota) 
                       VALUES (@codSocio, @fechaVencimiento, @fechaPago, @monto, @estadoPago, @medioPago, @cantCuotas);";

                MySqlCommand comando = new MySqlCommand(sql, sqlCon);

                comando.Parameters.Add("@codSocio", MySqlDbType.Int32).Value = cuota.CodSocio;
                comando.Parameters.Add("@fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                comando.Parameters.Add("@fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                comando.Parameters.Add("@monto", MySqlDbType.Decimal).Value = cuota.Monto;
                comando.Parameters.Add("@estadoPago", MySqlDbType.Int16).Value = cuota.EstadoPago;
                comando.Parameters.Add("@medioPago", MySqlDbType.VarChar).Value = cuota.MedioPago;
                comando.Parameters.Add("@cantCuotas", MySqlDbType.Int32).Value = cuota.cantCuotas;

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

        public List<CuotaConSocioDTO> ObtenerCuotasPorVencimiento(string filtro)
        {
            List<CuotaConSocioDTO> lista = new List<CuotaConSocioDTO>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string queryBase = @"SELECT c.CodSocio, c.fechaPago, c.fechaVencimiento, s.NombreCompleto, s.Documento
                             FROM cuota c
                             INNER JOIN socios s ON c.codSocio = s.CodSocio
                             WHERE c.fechaPago IS NOT NULL ";

                switch (filtro)
                {
                    case "Dia":
                        queryBase += "AND DATE(c.fechaVencimiento) = CURDATE() ";
                        break;
                    case "Semana":
                        queryBase += "AND c.fechaVencimiento BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 6 DAY) ";
                        break;
                    case "Mes":
                        queryBase += "AND c.fechaVencimiento BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 1 MONTH) ";
                        break;
                    case "Todos":
                    default:
                        // Sin filtro adicional
                        break;
                }

                queryBase += "ORDER BY c.fechaVencimiento ASC";

                using (MySqlCommand comando = new MySqlCommand(queryBase, sqlCon))
                {
                    sqlCon.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CuotaConSocioDTO dto = new CuotaConSocioDTO
                            {
                                CodSocio = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                FechaPago = reader.IsDBNull(1) ? DateTime.MinValue : reader.GetDateTime(1),
                                FechaVencimiento = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                                NombreCompleto = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                Documento = reader.IsDBNull(4) ? "" : reader.GetString(4)
                            };
                            lista.Add(dto);
                        }
                    }
                }
            }

            return lista;
        }
    }
}

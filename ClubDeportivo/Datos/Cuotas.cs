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
            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    sqlCon.Open();

                    using (MySqlTransaction transaccion = sqlCon.BeginTransaction())
                    {
                        try
                        {
                            // Paso 1: Poner en 0 el campo ultimoPago para las cuotas anteriores del mismo socio
                            string updateSql = @"UPDATE cuota 
                                         SET ultimoPago = 0 
                                         WHERE codSocio = @codSocio";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateSql, sqlCon, transaccion))
                            {
                                updateCmd.Parameters.Add("@codSocio", MySqlDbType.Int32).Value = cuota.CodSocio;
                                updateCmd.ExecuteNonQuery();
                            }

                            // Paso 2: Insertar la nueva cuota como la última (ultimoPago = 1)
                            string insertSql = @"INSERT INTO cuota
                        (codSocio, fechaVencimiento, fechaPago, monto, estadoPago, medioPago, cantCuota, ultimoPago) 
                        VALUES (@codSocio, @fechaVencimiento, @fechaPago, @monto, @estadoPago, @medioPago, @cantCuotas, @ultimoPago)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertSql, sqlCon, transaccion))
                            {
                                insertCmd.Parameters.Add("@codSocio", MySqlDbType.Int32).Value = cuota.CodSocio;
                                insertCmd.Parameters.Add("@fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                                insertCmd.Parameters.Add("@fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                                insertCmd.Parameters.Add("@monto", MySqlDbType.Decimal).Value = cuota.Monto;
                                insertCmd.Parameters.Add("@estadoPago", MySqlDbType.Int16).Value = cuota.EstadoPago ? 1 : 0;
                                insertCmd.Parameters.Add("@medioPago", MySqlDbType.VarChar).Value = cuota.MedioPago;
                                insertCmd.Parameters.Add("@cantCuotas", MySqlDbType.Int32).Value = cuota.cantCuotas;
                                insertCmd.Parameters.Add("@ultimoPago", MySqlDbType.Int16).Value = 1;
                                insertCmd.ExecuteNonQuery();
                                idGenerado = (int)insertCmd.LastInsertedId;
                            }
                            transaccion.Commit(); // Éxito: se guarda todo
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback(); // Falla: se deshace todo
                            MessageBox.Show("Error al registrar cuota (transacción): " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cuota: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                             WHERE c.fechaPago IS NOT NULL AND c.ultimoPago = 1 ";

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

        public DateTime? ObtenerUltimoVencimiento(int codSocio)
        {
            using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
            {
                string sql = "SELECT MAX(fechaVencimiento) FROM cuota WHERE codSocio = @codSocio AND ultimoPago = 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codSocio", codSocio);
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToDateTime(result);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}

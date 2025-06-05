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
    internal class Clientes
    {
        public int RegistrarCliente(E_Persona cliente)
        {
            int salida;
            {
                if (cliente is E_Socio socio)
                {
                    salida = registrarSocio(socio);
                    return salida;
                }
                else if (cliente is E_NoSocio noSocio)
                {
                    salida = registrarNoSocio(noSocio);
                    return salida;
                }
                else
                {
                    throw new ArgumentException("Tipo de cliente no reconocido.");
                }
            }
        }

        private int registrarSocio(E_Socio socio)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("s_Documento", MySqlDbType.VarChar).Value = socio.documento;
                comando.Parameters.Add("s_NombreCompleto", MySqlDbType.VarChar).Value = socio.nombreCompleto;
                comando.Parameters.Add("s_FechaNac", MySqlDbType.Date).Value = socio.fechaNacimiento;
                comando.Parameters.Add("s_Telefono", MySqlDbType.VarChar).Value = socio.telefono;
                comando.Parameters.Add("s_FechaInscripcion", MySqlDbType.Date).Value = socio.fechaInscripcion;
                comando.Parameters.Add("s_FichaMedica", MySqlDbType.Bit).Value = socio.fichaMedica;
                comando.Parameters.Add("s_AptoMedico", MySqlDbType.Bit).Value = socio.aptoMedico;

                MySqlParameter rta = new MySqlParameter("rta", MySqlDbType.Int32);
                rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Si en null se le asigna -1
                return (rta.Value != DBNull.Value) ? Convert.ToInt32(rta.Value) : -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private int registrarNoSocio(E_NoSocio noSocio)
        {
            int salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("s_Documento", MySqlDbType.VarChar).Value = noSocio.documento;
                comando.Parameters.Add("s_NombreCompleto", MySqlDbType.VarChar).Value = noSocio.nombreCompleto;
                comando.Parameters.Add("s_FechaNac", MySqlDbType.Date).Value = noSocio.fechaNacimiento;
                comando.Parameters.Add("s_Telefono", MySqlDbType.VarChar).Value = noSocio.telefono;
                comando.Parameters.Add("s_FechaInscripcion", MySqlDbType.Date).Value = noSocio.fechaInscripcion;
                comando.Parameters.Add("s_FichaMedica", MySqlDbType.Bit).Value = noSocio.fichaMedica;
                comando.Parameters.Add("s_AptoMedico", MySqlDbType.Bit).Value = noSocio.aptoMedico;

                MySqlParameter rta = new MySqlParameter("rta", MySqlDbType.Int32);
                rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Si en null se le asigna -1
                salida = (rta.Value != DBNull.Value) ? Convert.ToInt32(rta.Value) : -1;
            }
            catch (Exception)
            {
                salida = -1;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return salida;
        }
    }
}

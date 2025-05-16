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
    internal class Socios
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_Documento", MySqlDbType.Int32).Value = socio.Documento;
                comando.Parameters.Add("p_NombreCompleto", MySqlDbType.VarChar).Value = socio.NombreCompleto;
                comando.Parameters.Add("p_FechaNac", MySqlDbType.Date).Value = socio.FechaNacimiento;
                comando.Parameters.Add("p_Telefono", MySqlDbType.Int32).Value = socio.Telefono;
                comando.Parameters.Add("p_FechaInscripcion", MySqlDbType.Date).Value = socio.FechaInscripcion;
                comando.Parameters.Add("p_FichaMedica", MySqlDbType.Bit).Value = socio.FichaMedica;
                comando.Parameters.Add("p_AptoMedico", MySqlDbType.Bit).Value = socio.AptoMedico;

                MySqlParameter rta = new MySqlParameter("rta", MySqlDbType.Int32);
                rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                salida = Convert.ToString(rta.Value);
            }
            catch (Exception ex)
            {
                salida = "Error: " + ex.Message;
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

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
        public string RegistrarSocio(E_Socio socio)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_Documento", MySqlDbType.VarChar).Value = socio.documento;
                comando.Parameters.Add("p_NombreCompleto", MySqlDbType.VarChar).Value = socio.nombreCompleto;
                comando.Parameters.Add("p_FechaNac", MySqlDbType.Date).Value = socio.fechaNacimiento;
                comando.Parameters.Add("p_Telefono", MySqlDbType.VarChar).Value = socio.telefono;
                comando.Parameters.Add("p_FechaInscripcion", MySqlDbType.Date).Value = socio.fechaInscripcion;
                comando.Parameters.Add("p_FichaMedica", MySqlDbType.Bit).Value = socio.fichaMedica;
                comando.Parameters.Add("p_AptoMedico", MySqlDbType.Bit).Value = socio.aptoMedico;

                MySqlParameter rta = new MySqlParameter("rta", MySqlDbType.Int32);
                rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Si en null se le asigna -1
                salida = Convert.ToString(rta.Value) ?? "-1";
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

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Entidades;  

namespace ClubDeportivo.Datos
{
    internal class NoSocios_Actividades
    {
        public bool RegistrarNoSocio_Actividad(int codNoSocio, int idActividad, DateTime? registro = null)
        
        {
            bool exito = false;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarNoSocioActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para el Stored Procedure
                DateTime fechaRegistro = registro ?? DateTime.Now;

                comando.Parameters.Add("p_idNoSocio", MySqlDbType.Int32).Value = codNoSocio;
                comando.Parameters.Add("p_idActividad", MySqlDbType.Int32).Value = idActividad;
                comando.Parameters.Add("p_fechaRegistro", MySqlDbType.DateTime).Value = fechaRegistro;

                // Parámetro de salida
                MySqlParameter rta = new MySqlParameter("rta", MySqlDbType.Int32);
                rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                exito = true;
            }
            catch (Exception)
            {
                exito = false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return exito;
        }
    }
}

        

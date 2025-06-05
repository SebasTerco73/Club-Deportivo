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
        public int RegistrarNoSocio_Actividad(int codNoSocio, int idActividad)
        {
            int idGenerado = -1;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarNoSocioActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para el Stored Procedure
                comando.Parameters.Add("p_idNoSocio", MySqlDbType.Int32).Value = codNoSocio;
                comando.Parameters.Add("p_idActividad", MySqlDbType.Int32).Value = idActividad;

                // Parámetro de salida
                MySqlParameter rta = new MySqlParameter("rta", MySqlDbType.Int32);
                rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(rta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Si en null se le asigna -1
                idGenerado = (rta.Value != DBNull.Value) ? Convert.ToInt32(rta.Value) : -1;
            }
            catch (Exception)
            {
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

        

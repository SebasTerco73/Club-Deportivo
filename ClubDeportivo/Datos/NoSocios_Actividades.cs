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
        public int RegistrarNoSocio_Actividad(int codNoSocio, int actividad)
        {
            int idGenerado = -1;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql = @"INSERT INTO noSocio_actividad
                       (idNoSocio, idActividad)
                       VALUES (@codNoSocio, @actividad);";

                MySqlCommand comando = new MySqlCommand(sql, sqlCon);

                comando.Parameters.Add("@idNoSocio", MySqlDbType.Int32).Value = codNoSocio;
                comando.Parameters.Add("@idActividad", MySqlDbType.Int32).Value = actividad;

                sqlCon.Open();
                comando.ExecuteNonQuery();

                idGenerado = (int)comando.LastInsertedId; // Obtengo el id autogenerado
            }
            catch (Exception)
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

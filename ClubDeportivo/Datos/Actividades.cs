using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClubDeportivo.Entidades;

namespace ClubDeportivo.Datos
{
    internal class Actividades
    {
        public List<E_Actividad> ListarActividades()
        {
            List<E_Actividad> salida = new List<E_Actividad>();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT * FROM Actividad"; // ACÁ VA EL SELECT ALL
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Actividad actividad = new E_Actividad
                    {
                        idActividad = reader.GetInt32("idActividad"),
                        nombre = reader.GetString("nombre"),
                        cupoMax = reader.GetInt32("cupoMax"),
                        cupoActual = reader.GetInt32("cupoActual"),
                        valor = Convert.ToDecimal(reader["valor"])
                    };
                    salida.Add(actividad);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar actividades: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
            return salida;
        }
    }
}

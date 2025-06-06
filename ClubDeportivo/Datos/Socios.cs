using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Socios
    {
        public bool BuscarSocioPorDni(string dni)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT 1 FROM socios WHERE Documento = @dni LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
                {
                    comando.Parameters.AddWithValue("@dni", dni);
                    sqlCon.Open();
                    object result = comando.ExecuteScalar();
                    return result != null;
                }
            }
        }
        public string BuscarSocioPorId(int id)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT NombreCompleto FROM socios WHERE codSocio = @id LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    object result = comando.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }
    }
}


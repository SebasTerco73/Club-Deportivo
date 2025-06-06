using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class NoSocios
    {
        public bool BuscarNoSocioPorDni(string dni)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT 1 FROM nosocios WHERE Documento = @dni LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
                {
                    comando.Parameters.AddWithValue("@id", dni);
                    sqlCon.Open();
                    object result = comando.ExecuteScalar();
                    return result != null;
                }
            }
        }

        public bool BuscarNoSocioPorId(int id)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT 1 FROM nosocios WHERE codNoSocio = @id LIMIT 1";

                using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    object result = comando.ExecuteScalar();
                    return result != null;
                }
            }

        }
    }
}

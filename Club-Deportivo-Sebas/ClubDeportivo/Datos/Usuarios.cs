using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { 
                    sqlCon.Close(); 
                }
            }
        }


        // FALTA IMPLEMENTAR
        //public DataTable Reg_Usu(string L_Usu, string P_Usu)
        //{
        //    MySqlDataReader resultado; // variable de tipo datareader
        //    DataTable tabla = new DataTable();
        //    MySqlConnection sqlCon = new MySqlConnection();
        //    try
        //    {
        //        sqlCon = Conexion.getInstancia().CrearConexion();
        //        MySqlCommand comando = new MySqlCommand("RegistrarUser", sqlCon);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
        //        comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value =
        //        P_Usu;
        //        sqlCon.Open();
        //        resultado = comando.ExecuteReader();
        //        tabla.Load(resultado);
        //        return tabla;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //        { 
        //            sqlCon.Close();
        //        }
        //    }
        //}
    }
}

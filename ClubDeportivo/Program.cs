using login;
using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            bool conectado = false;

            while (!conectado)
            {
                try
                {
                    var conexion = Conexion.getInstancia();
                    using (var cn = conexion.CrearConexion())
                    {
                        cn.Open();
                        cn.Close();
                    }
                    conectado = true;
                }
                catch (Exception ex)
                {
                    var resultado = MessageBox.Show("No se pudo conectar a la base de datos" + "\n¿Desea intentar nuevamente?",
                                                    "Error de conexión", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // Reiniciamos la instancia para que vuelva a pedir datos
                        Conexion.Reset();
                    }
                }
            }
            Application.Run(new Login());
        }
    }
}
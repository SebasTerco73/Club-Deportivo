using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class Conexion
    {
        private string baseDatos, servidor, puerto, usuario, clave;
        private static Conexion? con = null;

        private Conexion()
        {
            bool correcto = false;
            int mensaje;

            
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (correcto != true)
            { 
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = InputBoxPassword("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");

                mensaje = (int)MessageBox.Show("su ingreso:\nSERVIDOR = " + T_servidor + "\nPUERTO= " + T_puerto + "\nUSUARIO: " + T_usuario + "\nCLAVE: " + new string('*', T_clave.Length), "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (mensaje != 6) // el valor 6 corresponde al SI
                { 
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false; 
                } else 
                { 
                    correcto = true;
                } 
            }

            this.baseDatos = "clubdeportivo";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave; // ""; 
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor + ";port=" + this.puerto +
                    ";username=" + this.usuario + ";password=" + this.clave + ";Database=" + this.baseDatos;

                // Probar si se puede abrir la conexión
                cadena.Open();
                cadena.Close(); // Cerrarla enseguida si se abrió bien
            }
            catch (Exception ex)
            {
                // Podés loguearlo si querés, o lanzar para manejarlo afuera
                throw new Exception("Error al verificar la conexión a la base: " + ex.Message, ex);
            }

            return cadena; // Devuelve la conexión lista para usar
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

        public static void Reset()
        {
            con = null;
        }

        public static string InputBoxPassword(string prompt, string title)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;
            textBox.UseSystemPasswordChar = true;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 50, 372, 20);
            buttonOk.SetBounds(228, 80, 75, 23);
            buttonCancel.SetBounds(309, 80, 75, 23);

            label.AutoSize = true;
            form.ClientSize = new Size(396, 120);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult == DialogResult.OK ? textBox.Text : "";
        }
    }
}
    

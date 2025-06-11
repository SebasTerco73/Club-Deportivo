using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Colores basados en el logo (los mismos que en Form1)
            Color azulOscuro = Color.FromArgb(10, 45, 74);
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            // Color de fondo del formulario
            this.BackColor = grisClaro;

            if (labelTitulo != null)
            {
                labelTitulo.ForeColor = azulOscuro;
            }

            // Aplicar color al Label de "Usuario:"
            if (labelUser != null)
            {
                labelUser.ForeColor = azulOscuro;
            }

            // Aplicar color al Label de "Contraseña:"
            // ¡Reemplaza "labelContrasena" con el nombre real del Label de "Contraseña:" en tu Form2!
            if (labelContrasena != null)
            {
                labelContrasena.ForeColor = azulOscuro;
            }

            // Estilo visual para el botón "Ingresar"
            // ¡Reemplaza "botonIngresar" con el nombre real del botón en tu Form2!
            if (botonIngresar != null && botonIngresar is Button)
            {
                botonIngresar.BackColor = azulOscuro;
                botonIngresar.ForeColor = blanco;
                botonIngresar.FlatStyle = FlatStyle.Flat;
                botonIngresar.FlatAppearance.BorderSize = 0;
                botonIngresar.Cursor = Cursors.Hand;

                // Hover effect para el botón "Ingresar"
                botonIngresar.MouseEnter += (s, e) =>
                {
                    botonIngresar.BackColor = blanco;
                    botonIngresar.ForeColor = azulOscuro;
                };
                botonIngresar.MouseLeave += (s, e) =>
                {
                    botonIngresar.BackColor = azulOscuro;
                    botonIngresar.ForeColor = blanco;
                };
            }
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            // es la que recibe los datos desde el formulario
            DataTable tablaLogin = new DataTable();
            // variable que contiene todas las caracteristicas de la clase
            ClubDeportivo.Datos.Usuarios dato = new ClubDeportivo.Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUser.Text, txtPass.Text);
            if (tablaLogin != null && tablaLogin.Rows.Count > 0)
            {
                // Login exitoso
                lblMensajeError.Visible = false;
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.usuario = txtUser.Text;
                menuPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                menuPrincipal.Show();
                this.Hide();
                txtPass.Text = "";
                txtUser.Text = "";
            }
            else
            {
                lblMensajeError.Visible = true;
            }
        } 
        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
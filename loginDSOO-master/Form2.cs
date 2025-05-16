using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void label1_Click(object sender, EventArgs e)
        {
            // ... (tu código existente para label1_Click) ...
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // ... (tu código existente para pictureBox1_Click) ...
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // ... (tu código existente para label3_Click) ...
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
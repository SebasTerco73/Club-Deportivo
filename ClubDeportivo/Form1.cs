using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            // Color de fondo del formulario
            this.BackColor = grisClaro;

            // Color del título
            label1.ForeColor = azulOscuro;

            // Establecer el cursor como mano para cada botón
            inicioSesionSocios.Cursor = Cursors.Hand;
            registroUsuario.Cursor = Cursors.Hand;
            inicioNoSocios.Cursor = Cursors.Hand;

            // Estilo visual para los botones
            Button[] botones = { inicioSesionSocios, registroUsuario, inicioNoSocios };
            foreach (Button btn in botones)
            {
                btn.BackColor = azulOscuro;
                btn.ForeColor = blanco;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // Hover: cambia a blanco con texto azul oscuro
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = blanco;
                    btn.ForeColor = azulOscuro;
                };
                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = azulOscuro;
                    btn.ForeColor = blanco;
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Acción para botón "Inicio sesión socios"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Acción para botón "Registro"
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Acción para botón "Inicio sesión no socios"
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código al cargar el formulario (opcional)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento click del label (opcional)
        }
    }
}

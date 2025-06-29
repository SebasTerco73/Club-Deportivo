﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Gui;

namespace ClubDeportivo
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            // Color de fondo del formulario
            this.BackColor = grisClaro;

            // Color del título
            lblIngreso.ForeColor = azulOscuro;

            // Estilo visual para los botones
            Button[] botones = { inicioSesionSocios, registroUsuario, btnListado, btnSalir };
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

        internal string? rol;
        internal string? usuario;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "Bienvenido: " + usuario + " (" + rol + ")";
            lblIngreso.Left = (this.ClientSize.Width - lblIngreso.Width) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form? login = Application.OpenForms["Login"];
            if (login != null)
            {
                login.Show();
            }
            this.Close();
        }

        private void inicioSesionSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroCliente registro = new RegistroCliente();
            registro.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoVencimientos listado = new ListadoVencimientos();
            listado.Show();
        }

        private void registroUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cobros cobros = new Cobros();
            cobros.Show();
        }
    }
}

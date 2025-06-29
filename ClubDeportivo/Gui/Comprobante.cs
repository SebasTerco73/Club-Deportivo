﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Gui
{
    public partial class Comprobante : Form
    {
        public string? nombre_c;
        public string? forma_c;
        public float monto_c;
        public int identificador_c;
        public DateTime fechaPago_c;
        public DateTime fechaInscripcion_c;
        public int cuotas_c;
        public Comprobante(string nombre, float monto, DateTime fechaInscripcion, DateTime fechaPago, string forma, int identificador, string cuotas)
        {
            InitializeComponent();
            nombre_c = nombre;
            monto_c = monto;
            fechaInscripcion_c = fechaInscripcion;
            fechaPago_c = fechaPago;
            forma_c = forma;
            identificador_c = identificador;
            cuotas_c = int.Parse(cuotas);
            this.Load += Comprobante_Load;

            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            // Color de fondo del formulario
            this.BackColor = grisClaro;

            // Estilo visual para los botones
            Button[] botones = { btbImprimir };
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

        private void btbImprimir_Click(object sender, EventArgs e)
        {
            btbImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            btbImprimir.Visible = true;
            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form? menuPrincipal = Application.OpenForms["MenuPrincipal"];
            if (menuPrincipal != null)
            {
                menuPrincipal.Show();
            }
            this.Close();
        }
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
        private void Comprobante_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre_c ?? "N/A"; // Usa un valor por defecto si es null
            lblMonto.Text = monto_c.ToString("N2");
            lblFechaIns.Text = fechaInscripcion_c.ToShortDateString();
            lblFechaP.Text = fechaPago_c.ToShortDateString();
            lblFPago.Text = forma_c ?? "N/A";
            lblId.Text = identificador_c.ToString();
            lblCuotas.Text = cuotas_c.ToString();
        }

        private void Comprobante_Load_1(object sender, EventArgs e)
        {

        }
    }
}

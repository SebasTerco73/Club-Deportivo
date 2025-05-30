using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Gui
{
    public partial class ListadoVencimientos : Form
    {
        public ListadoVencimientos()
        {
            InitializeComponent();

            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            // Color de fondo del formulario
            this.BackColor = grisClaro;

            // Estilo visual para los botones
            Button[] botones = { btnAtras };
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

        private void ListadoVencimientos_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }
        public void CargaGrilla()
        {
            string filtro = "";
            if (rbtDia.Checked)
                filtro = "Dia";
            else if (rbtSemana.Checked)
                filtro = "Semana";
            else if (rbtMes.Checked)
                filtro = "Mes";
            else if (rbtTodo.Checked)
                filtro = "Todos";
            Cuotas cuotas = new Cuotas();
            List<CuotaConSocioDTO> listado = cuotas.ObtenerCuotasPorVencimiento(filtro);

            dvgListSocio.Rows.Clear();

            foreach (var cuota in listado)
            {
                int renglon = dvgListSocio.Rows.Add();

                dvgListSocio.Rows[renglon].Cells[0].Value = cuota.CodSocio.ToString();
                dvgListSocio.Rows[renglon].Cells[1].Value = cuota.NombreCompleto;
                dvgListSocio.Rows[renglon].Cells[2].Value = cuota.Documento;
                dvgListSocio.Rows[renglon].Cells[3].Value = cuota.FechaPago.ToString("yyyy-MM-dd");
                dvgListSocio.Rows[renglon].Cells[4].Value = cuota.FechaVencimiento.ToString("yyyy-MM-dd");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form? menuPrincipal = Application.OpenForms["MenuPrincipal"];
            if (menuPrincipal != null)
            {
                menuPrincipal.Show();
            }
        }

        private void rbtTodo_CheckedChanged(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void rbtMes_CheckedChanged(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void rbtSemana_CheckedChanged(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void rbtDia_CheckedChanged(object sender, EventArgs e)
        {
            CargaGrilla();
        }
    }

}

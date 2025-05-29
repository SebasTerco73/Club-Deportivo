using ClubDeportivo.Datos;
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
            Button[] botones = { btnAtras};
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
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Trae Nro. Socio, Documento, Fecha de Pago y Fecha de Vencimiento
                query = "SELECT s.CodSocio,NombreCompleto, s.Documento, c.fechaPago, c.fechaVencimiento " + "FROM socios s " +
                    "INNER JOIN cuota c ON s.CodSocio = c.codSocio " + "WHERE c.fechaPago IS NOT NULL " + "ORDER BY c.fechaVencimiento ASC;";


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dvgListSocio.Rows.Add();

                        // Nro. Socio
                        dvgListSocio.Rows[renglon].Cells[0].Value = reader.IsDBNull(0) ? "" : reader.GetInt32(0).ToString();

                        //Socio
                        dvgListSocio.Rows[renglon].Cells[1].Value = reader.IsDBNull(1) ? "" : reader.GetString(1);

                        // Documento
                        dvgListSocio.Rows[renglon].Cells[2].Value = reader.IsDBNull(2) ? "" : reader.GetString(2);

                        // Fecha de Pago
                        dvgListSocio.Rows[renglon].Cells[3].Value = reader.IsDBNull(3) ? "" : reader.GetDateTime(3).ToString("yyyy-MM-dd");

                        // Fecha de Vencimiento
                        dvgListSocio.Rows[renglon].Cells[4].Value = reader.IsDBNull(4) ? "" : reader.GetDateTime(4).ToString("yyyy-MM-dd");
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
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
    }

}

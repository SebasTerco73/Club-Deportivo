using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;

namespace ClubDeportivo.Gui
{
    public partial class RegistroSocio : Form
    {
        public RegistroSocio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void LimpiarCampos()
        {
            txtDocumento.Clear();
            txtNombreCompleto.Clear();
            dtpFechaNac.Value = DateTime.Today;
            txtTelefono.Clear();
            dtpFechaInscripcion.Value = DateTime.Today;
            cboFichaMedica.SelectedIndex = -1;
            cboAptoMedico.SelectedIndex = -1;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Socio socio = new E_Socio()
                {
                    Documento = int.Parse(txtDocumento.Text),
                    NombreCompleto = txtNombreCompleto.Text,
                    FechaNacimiento = dtpFechaNac.Value,
                    Telefono = int.Parse(txtTelefono.Text),
                    FechaInscripcion = dtpFechaInscripcion.Value,
                    FichaMedica = cboFichaMedica.Text == "SI" ? true : false,
                    AptoMedico = cboAptoMedico.Text == "SI" ? true : false
                };

                string resultado = new Socios().Nuevo_Socio(socio);

                if (int.TryParse(resultado, out _))
                {
                    MessageBox.Show("Socio registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar socio: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

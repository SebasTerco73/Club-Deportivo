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
            Form? menuPrincipal = Application.OpenForms["MenuPrincipal"];
            if (menuPrincipal != null)
            {
                menuPrincipal.Show();
            }
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
                string documento = txtDocumento.Text;
                string nombre = txtNombreCompleto.Text;
                DateTime fechaNac = dtpFechaNac.Value;
                string tel = txtTelefono.Text;
                DateTime fechaInscri = dtpFechaInscripcion.Value;
                bool FichaMedica = cboFichaMedica.Text.Equals("SI") ? true : false;
                bool aptoMedico = cboAptoMedico.Text.Equals("SI") ? true : false;

                E_Socio socio = new(documento, nombre, fechaNac, tel,
                    fechaInscri, FichaMedica, aptoMedico);

                string resultado = new Socios().RegistrarSocio(socio);

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

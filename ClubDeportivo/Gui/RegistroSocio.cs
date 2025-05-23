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
            pnlActividad.Hide();
            cboCuotas.SelectedIndex = 0;
            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            // Color de fondo del formulario
            this.BackColor = grisClaro;

            // Estilo visual para los botones
            Button[] botones = {btnRegistrar,btnVolver,btnLimpiar};
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
            // TextBox
            txtDocumento.Clear();
            txtNombreCompleto.Clear();
            txtTelefono.Clear();

            // DateTimePicker
            dtpFechaNac.Value = DateTime.Today;
            dtpFechaInscripcion.Value = DateTime.Today;

            // CheckBox
            ckbFicha.Checked = false;
            ckbApto.Checked = false;

            // RadioButtons: Marca efectivo como default
            rbtEfectivo.Checked = true;

            // ComboBox
            cboCuotas.SelectedIndex = 0; // Asumiendo que el primer ítem es "1"
            cboCuotas.Enabled = false;

            // Panel de cuotas
            pnlCuota.Visible = true;
            pnlActividad.Visible = false;
            txtDocumento.Focus();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool esSocio = pnlCuota.Visible;

            try
            {
                string documento = txtDocumento.Text;
                string nombre = txtNombreCompleto.Text;
                DateTime fechaNac = dtpFechaNac.Value;
                string tel = txtTelefono.Text;
                DateTime fechaInscri = dtpFechaInscripcion.Value;
                bool FichaMedica = ckbFicha.Checked;
                bool aptoMedico = ckbApto.Checked;

                if (string.IsNullOrWhiteSpace(txtDocumento.Text))
                {
                    MessageBox.Show("El campo Documento es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
                {
                    MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El campo Teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                E_Socio socio = new(documento, nombre, fechaNac, tel,
                    fechaInscri, FichaMedica, aptoMedico);

                if (esSocio)
                {
                    string medioPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta";

                    int resultadoSocio = new Socios().RegistrarSocio(socio);

                    if (resultadoSocio == -1)
                    {
                        MessageBox.Show($"El socio con dni: {documento}, ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int cuotas = int.Parse(cboCuotas.Text);
                        E_Cuota cuota = new E_Cuota(resultadoSocio, fechaInscri, medioPago, cuotas);
                        int resultadoCuota = new Cuotas().RegistrarCuota(cuota);
                        if (resultadoCuota != -1)
                        {
                            MessageBox.Show($"Socio registrado correctamente y se abono la cuota con id {resultadoCuota}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            if (pnlActividad.Visible)
            {
                pnlActividad.Hide();
                pnlCuota.Show();
            }
        }

        private void btnNoSocio_Click(object sender, EventArgs e)
        {
            if (pnlCuota.Visible)
            {
                pnlCuota.Hide();
                pnlActividad.Show();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
            }
            else
            {
                cboCuotas.Enabled = false;
            }
            
        }

        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEfectivo.Checked)
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = true;
            }

                
        }
    }
}

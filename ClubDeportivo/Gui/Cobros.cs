using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Gui
{
    public partial class Cobros : Form
    {
        private E_Cuota ultimaCuotaRegistrada;

        public Cobros()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            pnlActividad.Hide();
            cboCuotas.SelectedIndex = 0;
            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            btnPagar.Enabled = false;

            Panel panelSombra = new Panel();
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(pnlCuota.Width, pnlCuota.Height);
            panelSombra.Location = new Point(pnlCuota.Left + 8, pnlCuota.Top + 8);
            panelSombra.BackColor = Color.DarkGray;
            panelSombra.BringToFront(); // Para verlo por encima
            botonActivo = btnSocio;
            botonActivo.BackColor = Color.FromArgb(173, 216, 230);
            botonActivo.Size = new Size(65, 61);


            this.Controls.Add(panelSombra); // agrega al formulario
            this.Controls.SetChildIndex(pnlCuota, 0); // Panel principal arriba

            // Color de fondo del formulario
            this.BackColor = grisClaro;
            pnlCuota.BackColor = Color.LightGray;
            pnlCuota.BorderStyle = BorderStyle.FixedSingle;
            pnlActividad.BackColor = Color.LightGray;
            pnlActividad.BorderStyle = BorderStyle.FixedSingle;
            panelSombra.Location = new Point(pnlCuota.Left + 3, pnlCuota.Top + 3);
            panelSombra.BackColor = Color.DarkGray;


            // Estilo visual para los botones
            Button[] botones = { btnPagar, btnVolver, btnLimpiar, btnBuscar };
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
                btnSocio.Click += Boton_Click;
                btnNoSocio.Click += Boton_Click;
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
            btnPagar.Enabled = false;
            pbCheckSocio.Visible = false;
            pbCheckNoSocio.Visible = false;

            // TextBox
            txtNoSocio.Clear();
            txtNoSocio.Enabled = true;
            txtSocio.Clear();
            txtSocio.Enabled = true;    

            // DateTimePicker
            dtpFechaInscripcion.Value = DateTime.Today;

            // RadioButtons: Marca efectivo como default
            rbtEfectivo.Checked = true;

            // ComboBox
            cboCuotas.SelectedIndex = 0; // Asumiendo que el primer ítem es "1"
            cboCuotas.Enabled = false;

            // Panel de cuotas
            pnlCuota.Visible = true;
            pnlActividad.Visible = false;
            btnLimpiar.Focus();

            botonActivo = btnSocio;
            botonActivo.BackColor = Color.FromArgb(173, 216, 230);
            botonActivo.Size = new Size(65, 61);
            btnNoSocio.BackColor = Color.Transparent;
            btnNoSocio.Size = new Size(57, 53);

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

        private void btnSocio_MouseEnter(object sender, EventArgs e)
        {
            if (botonActivo != btnSocio) // sólo si no está marcado
            {
                btnSocio.Size = new Size(65, 61);
                btnSocio.BackColor = Color.LightBlue;
            }
        }

        private void btnSocio_MouseLeave(object sender, EventArgs e)
        {
            if (botonActivo != btnSocio) // sólo si no está marcado
            {
                btnSocio.Size = new Size(57, 53);
                btnSocio.BackColor = Color.Transparent; // o el color base
            }
        }
        Point posicionOriginalBtnSocio;
        private void btnSocio_MouseDown(object sender, MouseEventArgs e)
        {
            posicionOriginalBtnSocio = btnSocio.Location;
            btnSocio.Location = new Point(posicionOriginalBtnSocio.X + 1, posicionOriginalBtnSocio.Y + 1);
        }

        private void btnSocio_MouseUp(object sender, MouseEventArgs e)
        {
            btnSocio.Location = posicionOriginalBtnSocio;
        }

        Button botonActivo = null;
        private void Boton_Click(object sender, EventArgs e)
        {

            Button botonClickeado = sender as Button;

            if (botonActivo == botonClickeado)
            {
                return;
            }
            else
            {
                // Desmarcamos el botón anterior (si había uno)
                if (botonActivo != null)
                    botonActivo.BackColor = Color.Transparent;
                    botonActivo.Size = new Size(57, 53);

                // Marcamos el nuevo
                    botonClickeado.BackColor = Color.FromArgb(173, 216, 230); // o el color que prefieras
                    botonActivo = botonClickeado;
            }
        }

        Point posicionOriginalBtnNoSocio;
        private void btnNoSocio_MouseDown(object sender, MouseEventArgs e)
        {
            posicionOriginalBtnNoSocio = btnNoSocio.Location;
            btnNoSocio.Location = new Point(posicionOriginalBtnNoSocio.X + 1, posicionOriginalBtnNoSocio.Y + 1);
        }

        private void btnNoSocio_MouseEnter(object sender, EventArgs e)
        {
            if (botonActivo != btnNoSocio)
            {
                btnNoSocio.Size = new Size(65, 61);
                btnNoSocio.BackColor = Color.LightBlue;
            }
        }

        private void btnNoSocio_MouseLeave(object sender, EventArgs e)
        {
            if (botonActivo != btnNoSocio)
            {
                btnNoSocio.Size = new Size(57, 53);
                btnNoSocio.BackColor = Color.Transparent;
            }
        }

        private void btnNoSocio_MouseUp(object sender, MouseEventArgs e)
        {
                btnNoSocio.Location = posicionOriginalBtnNoSocio;
        }

        private void txtSocio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSocio.Text))
            {
                // Simula click en btnSocio
                btnSocio.PerformClick();

                // Bloquea el otro campo y botón
                txtNoSocio.Enabled = false;
                btnNoSocio.Enabled = false;
            }
            else
            {
                // Desbloquea si se borra
                txtNoSocio.Enabled = true;
                btnNoSocio.Enabled = true;
            }
        }

        private void txtNoSocio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNoSocio.Text))
            {
                btnNoSocio.PerformClick();
                txtSocio.Enabled = false;
                btnSocio.Enabled = false;
            }
            else
            {
                txtSocio.Enabled = true;
                btnSocio.Enabled = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (botonActivo == btnSocio)
            {

                if (!int.TryParse(txtSocio.Text, out int idSocio))
                {
                    MessageBox.Show("El ID de socio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Obtener datos del socio para mostrar en el comprobante
                DateTime? ultimoVencimiento = new Cuotas().ObtenerUltimoVencimiento(idSocio);
                DateTime fechaPago = dtpFechaInscripcion.Value;
                DateTime fechaVencimiento = (ultimoVencimiento.HasValue && fechaPago < ultimoVencimiento.Value)
                ? ultimoVencimiento.Value.AddMonths(1)
                : fechaPago.AddMonths(1);

                string medioPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta";
                int cantCuotas = cboCuotas.SelectedIndex + 1; // El índice comienza en 0, así que sumamos 1 para obtener la cantidad real de cuotas
                E_Cuota cuota = new E_Cuota(idSocio, fechaPago, fechaVencimiento, medioPago, cantCuotas);
                bool cuotaRegistrada = new Cuotas().RegistrarCuota(cuota) > 0;

                if (!cuotaRegistrada)
                {
                    MessageBox.Show("No se pudo registrar la cuota para el socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nombre = new Socios().BuscarSocioPorId(idSocio);
                if (nombre == null)
                {
                    MessageBox.Show("No se encontró un socio con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal montoAPagar = cuota.Monto; // Monto base de la cuota
                if (medioPago == "Tarjeta" && (cantCuotas == 3 || cantCuotas == 6))
                {
                    montoAPagar *= 0.90m; // Aplica un descuento del 10% si es pago con tarjeta en 3 o 6 cuotas
                }

                // Crear comprobante con los datos
                Comprobante comprobante = new Comprobante(
                    nombre,
                    (float)montoAPagar,
                    fechaPago,
                    fechaVencimiento,
                    medioPago,
                    idSocio,
                    cantCuotas.ToString()
                );
                this.Hide(); // Oculta el formulario actual
                comprobante.Show(); // Muestra el comprobante
            }
              
            else if (botonActivo == btnNoSocio)
            {
                if (!int.TryParse(txtNoSocio.Text, out int idNoSocio))
                {
                    MessageBox.Show("El ID de No Socio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Obtener datos del no socio para mostrar en el comprobante
                if (cbxActividades.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                E_Actividad actividadSeleccionada = (E_Actividad)cbxActividades.SelectedItem;
                decimal montoAPagar = actividadSeleccionada.valor;
                NoSocios_Actividades noSocios_Actividades = new NoSocios_Actividades();
                DateTime fechaPago = dtpFechaInscripcion.Value;
                DateTime fechaVencimiento = fechaPago.AddDays(1);
                string nombre = new NoSocios().BuscarNoSocioPorId(idNoSocio);

                bool salida = noSocios_Actividades.RegistrarNoSocio_Actividad(idNoSocio, actividadSeleccionada.idActividad, fechaPago);
                if (!salida)
                {
                    MessageBox.Show("Hubo un error al registrar la actividad del no socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Se efectuo el pago del No Socio {nombre} con id {idNoSocio} a {actividadSeleccionada.nombre}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Comprobante comprobanteNoSocio = new Comprobante(
                        nombre,
                        (float)montoAPagar,
                        fechaPago,
                        fechaVencimiento,
                        "Efectivo",
                        idNoSocio,
                        "1"
                );
                this.Hide(); // Oculta el formulario actual
                comprobanteNoSocio.Show(); // Muestra el comprobante
            }
                LimpiarCampos();
        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            List<E_Actividad> actividades = new Actividades().ListarActividades();

            cbxActividades.DataSource = actividades;
            cbxActividades.DisplayMember = "nombre";     // Lo que se ve
            cbxActividades.ValueMember = "idActividad";  // El valor real

            // Opcional: para evitar que se seleccione algo por defecto
            cbxActividades.SelectedIndex = 0;
            E_Actividad actividadSeleccionada = (E_Actividad)cbxActividades.SelectedItem;
            txtCupo.Text = actividadSeleccionada.cupoActual.ToString();
            txtPrecio.Text = actividadSeleccionada.valor.ToString("C", CultureInfo.CurrentCulture); // Formatea el precio como moneda local
        }

        private void cbxActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            E_Actividad actividadSeleccionada = (E_Actividad)cbxActividades.SelectedItem;
            txtCupo.Text = actividadSeleccionada.cupoActual.ToString();
            txtPrecio.Text = actividadSeleccionada.valor.ToString("C", CultureInfo.CurrentCulture);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda;

            if (string.IsNullOrWhiteSpace(txtSocio.Text) && string.IsNullOrWhiteSpace(txtNoSocio.Text)){
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (botonActivo == btnSocio)
            {
                int idSocio = int.Parse(txtSocio.Text);
                busqueda = new Socios().BuscarSocioPorId(idSocio);
                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    MessageBox.Show($"No existe socio con id {idSocio} registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSocio.Clear();
                }
                else
                {
                    MessageBox.Show($"Socio {busqueda} con id {idSocio} encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbCheckSocio.Visible = true;
                    txtSocio.Enabled = false;
                    txtNoSocio.Enabled = false;
                    btnPagar.Enabled = true;
                }
            }
            else if (botonActivo == btnNoSocio)
            {
                int idNoSocio = int.Parse(txtNoSocio.Text);
                busqueda = new NoSocios().BuscarNoSocioPorId(idNoSocio);
                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    MessageBox.Show($"No Socio con id {idNoSocio} no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNoSocio.Clear();
                }
                else
                {
                    MessageBox.Show($"No Socio {busqueda} con id {idNoSocio} encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbCheckNoSocio.Visible = true;
                    txtSocio.Enabled = false;
                    txtNoSocio.Enabled = false;
                    btnPagar.Enabled = true;
                }
            }
        }   
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Asn1.Crmf;

namespace ClubDeportivo.Gui
{
    public partial class RegistroSocio : Form
    {
        private E_Cuota ultimaCuotaRegistrada;
        public RegistroSocio()
        {
            InitializeComponent();
            pnlActividad.Hide();
            cboCuotas.SelectedIndex = 0;
            // Colores basados en el logo
            Color azulOscuro = Color.FromArgb(10, 45, 74);   // Azul del título y botón
            Color blanco = Color.White;
            Color grisClaro = Color.FromArgb(240, 240, 240); // Color de fondo del formulario

            Panel panelSombra = new Panel();
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(pnlCuota.Width, pnlCuota.Height);
            panelSombra.Location = new Point(pnlCuota.Left + 8, pnlCuota.Top + 8);
            panelSombra.BackColor = Color.DarkGray;
            panelSombra.BringToFront(); // Por si querés verlo encima (opcional)
            botonActivo = btnSocio;
            botonActivo.BackColor = Color.FromArgb(173, 216, 230);
            botonActivo.Size = new Size(65, 61);


            this.Controls.Add(panelSombra); // Agregalo al formulario
            this.Controls.SetChildIndex(pnlCuota, 0); // Asegurá que el panel principal esté arriba

            // Color de fondo del formulario
            this.BackColor = grisClaro;
            pnlCuota.BackColor = Color.LightGray;
            pnlCuota.BorderStyle = BorderStyle.FixedSingle;
            pnlActividad.BackColor = Color.LightGray;
            pnlActividad.BorderStyle = BorderStyle.FixedSingle;
            panelSombra.Location = new Point(pnlCuota.Left + 3, pnlCuota.Top + 3);
            panelSombra.BackColor = Color.DarkGray;


            // Estilo visual para los botones
            Button[] botones = { btnRegistrar, btnVolver, btnLimpiar };
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

            botonActivo = btnSocio;
            botonActivo.BackColor = Color.FromArgb(173, 216, 230);
            botonActivo.Size = new Size(65, 61);
            btnNoSocio.BackColor = Color.FromArgb(240, 240, 240);
            btnNoSocio.Size = new Size(57, 53);

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
                        cuota.idCuota = resultadoCuota;
                        
                        if (resultadoCuota != -1)
                        {
                            MessageBox.Show($"Socio registrado correctamente y se abono la cuota con id {resultadoCuota}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ultimaCuotaRegistrada = cuota;
                            generarCuotaPdf();
                            generarPdf();
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

        private void btnSocio_MouseDown(object sender, MouseEventArgs e)
        {
            btnSocio.Location = new Point(btnSocio.Location.X + 1, btnSocio.Location.Y + 1); // se mueve 1 px
        }

        private void btnSocio_MouseUp(object sender, MouseEventArgs e)
        {
            if (!btnSocio.Enabled)
            {
                btnSocio.Location = new Point(btnSocio.Location.X - 1, btnSocio.Location.Y - 1); // vuelve
            }
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

        private void btnNoSocio_MouseDown(object sender, MouseEventArgs e)
        {
            btnNoSocio.Location = new Point(btnNoSocio.Location.X + 1, btnNoSocio.Location.Y + 1); // se mueve 1 px
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
            if (!btnNoSocio.Enabled)
            {
                btnNoSocio.Location = new Point(btnNoSocio.Location.X - 1, btnNoSocio.Location.Y - 1); // vuelve
            }
        }

        private void generarPdf()
        {
            PrintDocument pd = new PrintDocument();  // Crea el documento que se va a imprimir
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);  // Asociamos el documento al metodo imprimir form
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();  // Cuadro de dialogo vista previa
            previewDialog.Document = pd;  // Se le asigna el documento a la vista previa
            previewDialog.ShowDialog(); // Muestra la vista previa
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            // ancho y alto: el tamaño del formulario(this) en pantalla.
            int ancho = this.Width;
            int alto = this.Height;
            // Crea un rectángulo del tamaño del formulario para usar como referencia de captura.
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            // Crea una imagen en memoria (Bitmap) donde se va a "dibujar" el formulario.
            Bitmap img = new Bitmap(ancho, alto);
            // Dibuja visualmente el formulario completo dentro del Bitmap.
            // Es como sacar una "captura de pantalla" del formulario(incluidos sus controles visibles).
            this.DrawToBitmap(img, bounds);

            Rectangle rectRecorte = new Rectangle(0, 0, ancho / 2, alto);
            Bitmap imgRecortado = img.Clone(rectRecorte, img.PixelFormat);
            //Dibuja la imagen generada en el objeto Graphics del documento para impresión.
            //e.Graphics es el "lienzo" donde se está dibujando lo que irá impreso.
            //En este caso, se coloca en el punto(100, 100) respecto al borde de la página.
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(imgRecortado, p);
            img.Dispose();
            imgRecortado.Dispose();
        }
        private void generarCuotaPdf()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += ImprimirCuota;
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog(); // Esto muestra vista previa, podés reemplazarlo por pd.Print() para imprimir directo
        }

        private void ImprimirCuota(object sender, PrintPageEventArgs e)
        {
            if (ultimaCuotaRegistrada == null)
            {
                e.Cancel = true;
                return;
            }

            string estado = ultimaCuotaRegistrada.EstadoPago ? "Pagado" : "Sin pagar";
            decimal monto = ultimaCuotaRegistrada.Monto;

            Font fuente = new Font("Arial", 12);
            float x = 100, y = 100;

            e.Graphics.DrawString("Comprobante de Cuota", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
            y += 40;
            e.Graphics.DrawString($"ID Cuota: {ultimaCuotaRegistrada.idCuota}", fuente, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Codigo del Socio: {ultimaCuotaRegistrada.CodSocio}", fuente, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Fecha de pago: {ultimaCuotaRegistrada.FechaPago.ToShortDateString()}", fuente, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Medio de Pago: {ultimaCuotaRegistrada.MedioPago}", fuente, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Cantidad de cuotas: {ultimaCuotaRegistrada.cantCuotas}", fuente, Brushes.Black, x, y);
            y += 25;
            if(ultimaCuotaRegistrada.MedioPago.Equals("Tarjeta") && (ultimaCuotaRegistrada.cantCuotas == 3 || ultimaCuotaRegistrada.cantCuotas == 6)){
                e.Graphics.DrawString($"Por pagar con tarjeta en 3 o 6 cuotas tiene un descuento del 10% {ultimaCuotaRegistrada.Monto} - {ultimaCuotaRegistrada.Monto * 0.1m}", fuente, Brushes.Black, x, y);
                y += 25;
                monto = monto * 0.90m; // para multiplicar un decimal con un double tengo que agregarle la m al double
            }
            e.Graphics.DrawString($"Monto del pago: ${monto}", fuente, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Estado del pago: {estado}", fuente, Brushes.Black, x, y);
            y += 25;
        }
    }
}

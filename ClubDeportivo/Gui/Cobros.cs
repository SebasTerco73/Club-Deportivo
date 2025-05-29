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
        private const decimal MONTO_MENSUAL_BASE = 5000.0m; // Ejemplo: 5000.00

        public Cobros()
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
            Button[] botones = { btnPagar, btnVolver, btnLimpiar };
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
            txtNoSocio.Clear();
            txtSocio.Clear();

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
            btnNoSocio.BackColor = Color.FromArgb(240, 240, 240);
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

        /* SE LO DEJO A UN EXPERTO
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
            if (ultimaCuotaRegistrada.MedioPago.Equals("Tarjeta") && (ultimaCuotaRegistrada.cantCuotas == 3 || ultimaCuotaRegistrada.cantCuotas == 6))
            {
                e.Graphics.DrawString($"Por pagar con tarjeta en 3 o 6 cuotas tiene un descuento del 10% {ultimaCuotaRegistrada.Monto} - {ultimaCuotaRegistrada.Monto * 0.1m}", fuente, Brushes.Black, x, y);
                y += 25;
                monto = monto * 0.90m; // para multiplicar un decimal con un double tengo que agregarle la m al double
            }
            e.Graphics.DrawString($"Monto del pago: ${monto}", fuente, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Estado del pago: {estado}", fuente, Brushes.Black, x, y);
            y += 25;
        } */

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
            MySqlConnection sqlCon = null;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando;
                MySqlDataReader reader;

                if (pnlCuota.Visible)
                {
                    if (string.IsNullOrWhiteSpace(txtSocio.Text))
                    {
                        MessageBox.Show("Por favor, ingrese el Número de Socio.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int codSocio;
                    if (!int.TryParse(txtSocio.Text, out codSocio))
                    {
                        MessageBox.Show("Número de Socio inválido. Debe ser un número entero.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string querySocio = "SELECT NombreCompleto, FechaInscripcion FROM socios WHERE CodSocio = @CodSocio";
                    comando = new MySqlCommand(querySocio, sqlCon);
                    comando.Parameters.AddWithValue("@CodSocio", codSocio);
                    reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        decimal montoAPagar = MONTO_MENSUAL_BASE;
                        string formaPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta";
                        if (rbtTarjeta.Checked && (cboCuotas.Equals("3") || cboCuotas.Equals("6")))
                        {
                            montoAPagar *= 0.90m;
                        }

                        // Crear una nueva instancia de Comprobante con los datos
                        Comprobante comprobante = new Comprobante(reader.GetString("NombreCompleto"),
                    (float)montoAPagar,
                    reader.GetDateTime("FechaInscripcion"),
                    DateTime.Now,
                    formaPago,
                    codSocio,
                    cboCuotas.SelectedItem.ToString());
                      
                        reader.Close();

                        // Insertar la cuota en la base de datos
                        string insertCuotaQuery = @"
                    INSERT INTO cuota
                        (codSocio, fechaVencimiento, fechaPago, monto, estadoPago, medioPago, cantCuota)
                    VALUES
                        (@codSocio, @fechaVenc, @fechaPago, @monto, @estado, @medio, @cant)";
                        MySqlCommand insertCmd = new MySqlCommand(insertCuotaQuery, sqlCon);
                        insertCmd.Parameters.AddWithValue("@codSocio", codSocio);
                        insertCmd.Parameters.AddWithValue("@fechaVenc", DateTime.Now.AddMonths(1));
                        insertCmd.Parameters.AddWithValue("@fechaPago", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@monto", montoAPagar);
                        insertCmd.Parameters.AddWithValue("@estado", 1);
                        insertCmd.Parameters.AddWithValue("@medio", formaPago);
                        int cantCuotas = 1;
                        if (formaPago == "Tarjeta" && cboCuotas.Enabled && cboCuotas.SelectedItem != null)
                        {
                            int.TryParse(cboCuotas.SelectedItem.ToString(), out cantCuotas);
                            if (cantCuotas <= 0) cantCuotas = 1;
                        }
                        insertCmd.Parameters.AddWithValue("@cant", cantCuotas);
                        insertCmd.ExecuteNonQuery();

                        this.Hide();
                        comprobante.Show();
                    }
                    else
                    {
                        MessageBox.Show("Número de Socio Inexistente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (reader != null && !reader.IsClosed) reader.Close();
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show("Error de base de datos: " + mysqlEx.Message, "ERROR MYSQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "ERROR GENERAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
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
    }
}


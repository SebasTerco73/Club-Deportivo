using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Gui
{
    public partial class Carnet : Form
    {

        internal string? CarnetNombre;
        internal string? CarnetDni;
        internal DateTime? CarnetInscri;
        internal int? CarnetNumero;

        public Carnet()
        {
            InitializeComponent();
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

            //Rectangle rectRecorte = new Rectangle(0, 0, ancho / 2, alto);
            //Bitmap imgRecortado = img.Clone(rectRecorte, img.PixelFormat);
            //Dibuja la imagen generada en el objeto Graphics del documento para impresión.
            //e.Graphics es el "lienzo" donde se está dibujando lo que irá impreso.
            //En este caso, se coloca en el punto(100, 100) respecto al borde de la página.
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
            img.Dispose();
        }

        private void btbImprimir_Click(object sender, EventArgs e)
        {
            btbImprimir.Hide();
            lblBienvenida.Visible = true;
            generarPdf();
            Form? registroSocio = Application.OpenForms["RegistroCliente"];
            if (registroSocio != null)
            {
                registroSocio.Show();
            }
            this.Close();
        }

        private void Carnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = CarnetNombre ?? "Nombre no disponible";
            lblNumero.Text = CarnetNumero?.ToString() ?? "Número no disponible";
            lblInscri.Text = CarnetInscri?.ToString("dd/MM/yyyy") ?? "Fecha de inscripción no disponible";
            lblDni.Text = CarnetDni ?? "DNI no disponible";
        }
    }
}

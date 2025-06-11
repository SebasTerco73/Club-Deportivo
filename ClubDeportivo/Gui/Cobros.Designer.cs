namespace ClubDeportivo.Gui
{
    partial class Cobros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobros));
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnSocio = new Button();
            btnNoSocio = new Button();
            ttSocio = new ToolTip(components);
            ttNoSocio = new ToolTip(components);
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            label9 = new Label();
            cboCuotas = new ComboBox();
            pnlCuota = new Panel();
            btnPagar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSocio = new TextBox();
            txtNoSocio = new TextBox();
            dtpFechaInscripcion = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            cbxActividades = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtCupo = new TextBox();
            txtPrecio = new TextBox();
            pnlActividad = new Panel();
            btnBuscar = new Button();
            pbCheckNoSocio = new PictureBox();
            pbCheckSocio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            pnlCuota.SuspendLayout();
            pnlActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCheckNoSocio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCheckSocio).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(216, 320);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 26);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(359, 320);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 26);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSocio
            // 
            btnSocio.BackColor = Color.Transparent;
            btnSocio.BackgroundImage = Properties.Resources.socios;
            btnSocio.BackgroundImageLayout = ImageLayout.Zoom;
            btnSocio.Cursor = Cursors.Hand;
            btnSocio.FlatAppearance.BorderColor = Color.Red;
            btnSocio.FlatAppearance.BorderSize = 0;
            btnSocio.FlatStyle = FlatStyle.Flat;
            btnSocio.ForeColor = Color.Transparent;
            btnSocio.Location = new Point(438, 112);
            btnSocio.Name = "btnSocio";
            btnSocio.Size = new Size(57, 53);
            btnSocio.TabIndex = 12;
            ttSocio.SetToolTip(btnSocio, "Socios");
            btnSocio.UseVisualStyleBackColor = false;
            btnSocio.Click += btnSocio_Click;
            btnSocio.MouseDown += btnSocio_MouseDown;
            btnSocio.MouseEnter += btnSocio_MouseEnter;
            btnSocio.MouseLeave += btnSocio_MouseLeave;
            btnSocio.MouseUp += btnSocio_MouseUp;
            // 
            // btnNoSocio
            // 
            btnNoSocio.BackColor = Color.Transparent;
            btnNoSocio.BackgroundImage = Properties.Resources.noSocio;
            btnNoSocio.BackgroundImageLayout = ImageLayout.Stretch;
            btnNoSocio.FlatAppearance.BorderColor = Color.Black;
            btnNoSocio.FlatAppearance.BorderSize = 0;
            btnNoSocio.FlatStyle = FlatStyle.Flat;
            btnNoSocio.ForeColor = Color.Black;
            btnNoSocio.Location = new Point(438, 217);
            btnNoSocio.Name = "btnNoSocio";
            btnNoSocio.Size = new Size(57, 41);
            btnNoSocio.TabIndex = 13;
            ttNoSocio.SetToolTip(btnNoSocio, "No Socios");
            btnNoSocio.UseVisualStyleBackColor = false;
            btnNoSocio.Click += btnNoSocio_Click;
            btnNoSocio.MouseDown += btnNoSocio_MouseDown;
            btnNoSocio.MouseEnter += btnNoSocio_MouseEnter;
            btnNoSocio.MouseLeave += btnNoSocio_MouseLeave;
            btnNoSocio.MouseUp += btnNoSocio_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label8.Location = new Point(54, 37);
            label8.Name = "label8";
            label8.Size = new Size(149, 15);
            label8.TabIndex = 0;
            label8.Text = "Pago cuota mensual | Socio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtTarjeta);
            groupBox1.Controls.Add(rbtEfectivo);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medio de pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(30, 63);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(117, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.Text = "Tarjeta de credito";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Checked = true;
            rbtEfectivo.Location = new Point(30, 28);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(66, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            rbtEfectivo.CheckedChanged += rbtEfectivo_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label9.Location = new Point(18, 249);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 2;
            label9.Text = "Cantidad de cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Enabled = false;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cboCuotas.Location = new Point(133, 241);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(62, 23);
            cboCuotas.TabIndex = 3;
            // 
            // pnlCuota
            // 
            pnlCuota.Controls.Add(cboCuotas);
            pnlCuota.Controls.Add(label9);
            pnlCuota.Controls.Add(groupBox1);
            pnlCuota.Controls.Add(label8);
            pnlCuota.Location = new Point(525, 26);
            pnlCuota.Name = "pnlCuota";
            pnlCuota.Size = new Size(254, 348);
            pnlCuota.TabIndex = 11;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(76, 320);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(88, 26);
            btnPagar.TabIndex = 18;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(76, 112);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 7;
            label1.Text = "Numero de Socio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(67, 156);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 19;
            label2.Text = "Numero de No Socio";
            // 
            // txtSocio
            // 
            txtSocio.Location = new Point(216, 109);
            txtSocio.Name = "txtSocio";
            txtSocio.Size = new Size(122, 23);
            txtSocio.TabIndex = 20;
            txtSocio.TextChanged += txtSocio_TextChanged;
            // 
            // txtNoSocio
            // 
            txtNoSocio.Location = new Point(216, 156);
            txtNoSocio.Name = "txtNoSocio";
            txtNoSocio.Size = new Size(122, 23);
            txtNoSocio.TabIndex = 21;
            txtNoSocio.TextChanged += txtNoSocio_TextChanged;
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.CalendarMonthBackground = Color.Transparent;
            dtpFechaInscripcion.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold);
            dtpFechaInscripcion.Location = new Point(145, 251);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(229, 24);
            dtpFechaInscripcion.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label11.Location = new Point(54, 37);
            label11.Name = "label11";
            label11.Size = new Size(154, 15);
            label11.TabIndex = 0;
            label11.Text = "Pago por actividad | No socio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label10.Location = new Point(70, 117);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 1;
            label10.Text = "Lista de Actividades";
            // 
            // cbxActividades
            // 
            cbxActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxActividades.FormattingEnabled = true;
            cbxActividades.Location = new Point(66, 171);
            cbxActividades.Name = "cbxActividades";
            cbxActividades.Size = new Size(121, 23);
            cbxActividades.TabIndex = 2;
            cbxActividades.SelectedIndexChanged += cbxActividades_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label12.Location = new Point(36, 234);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 3;
            label12.Text = "Cupo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label13.Location = new Point(36, 277);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 4;
            label13.Text = "Precio";
            // 
            // txtCupo
            // 
            txtCupo.Enabled = false;
            txtCupo.Location = new Point(95, 231);
            txtCupo.Name = "txtCupo";
            txtCupo.ReadOnly = true;
            txtCupo.Size = new Size(74, 23);
            txtCupo.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(95, 274);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(74, 23);
            txtPrecio.TabIndex = 6;
            // 
            // pnlActividad
            // 
            pnlActividad.Controls.Add(txtPrecio);
            pnlActividad.Controls.Add(txtCupo);
            pnlActividad.Controls.Add(label13);
            pnlActividad.Controls.Add(label12);
            pnlActividad.Controls.Add(cbxActividades);
            pnlActividad.Controls.Add(label10);
            pnlActividad.Controls.Add(label11);
            pnlActividad.Location = new Point(525, 26);
            pnlActividad.Name = "pnlActividad";
            pnlActividad.Size = new Size(254, 348);
            pnlActividad.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(216, 194);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(122, 23);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "BUSCAR ID";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pbCheckNoSocio
            // 
            pbCheckNoSocio.BackColor = Color.Transparent;
            pbCheckNoSocio.Image = (Image)resources.GetObject("pbCheckNoSocio.Image");
            pbCheckNoSocio.Location = new Point(344, 156);
            pbCheckNoSocio.Name = "pbCheckNoSocio";
            pbCheckNoSocio.Size = new Size(30, 23);
            pbCheckNoSocio.SizeMode = PictureBoxSizeMode.Zoom;
            pbCheckNoSocio.TabIndex = 24;
            pbCheckNoSocio.TabStop = false;
            pbCheckNoSocio.Visible = false;
            // 
            // pbCheckSocio
            // 
            pbCheckSocio.BackColor = Color.Transparent;
            pbCheckSocio.Image = (Image)resources.GetObject("pbCheckSocio.Image");
            pbCheckSocio.Location = new Point(344, 109);
            pbCheckSocio.Name = "pbCheckSocio";
            pbCheckSocio.Size = new Size(30, 23);
            pbCheckSocio.SizeMode = PictureBoxSizeMode.Zoom;
            pbCheckSocio.TabIndex = 25;
            pbCheckSocio.TabStop = false;
            pbCheckSocio.Visible = false;
            // 
            // Cobros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 406);
            ControlBox = false;
            Controls.Add(pbCheckSocio);
            Controls.Add(pbCheckNoSocio);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFechaInscripcion);
            Controls.Add(txtNoSocio);
            Controls.Add(txtSocio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPagar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNoSocio);
            Controls.Add(btnSocio);
            Controls.Add(pnlActividad);
            Controls.Add(pnlCuota);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cobros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COBROS";
            Load += Cobros_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlCuota.ResumeLayout(false);
            pnlCuota.PerformLayout();
            pnlActividad.ResumeLayout(false);
            pnlActividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCheckNoSocio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCheckSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnNoSocio;
        private Button btnSocio;
        private ToolTip ttSocio;
        private ToolTip ttNoSocio;
        private PictureBox pictureBox1;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Label label9;
        private ComboBox cboCuotas;
        private Panel pnlCuota;
        private Button btnPagar;
        private Label label1;
        private Label label2;
        private TextBox txtSocio;
        private TextBox txtNoSocio;
        private DateTimePicker dtpFechaInscripcion;
        private Label label11;
        private Label label10;
        private ComboBox cbxActividades;
        private Label label12;
        private Label label13;
        private TextBox txtCupo;
        private TextBox txtPrecio;
        private Panel pnlActividad;
        private Button btnBuscar;
        private PictureBox pbCheckNoSocio;
        private PictureBox pbCheckSocio;
    }
}
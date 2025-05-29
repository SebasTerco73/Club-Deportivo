namespace ClubDeportivo.Gui
{
    partial class RegistroSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroSocio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpFechaNac = new DateTimePicker();
            dtpFechaInscripcion = new DateTimePicker();
            txtDocumento = new TextBox();
            txtNombreCompleto = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnSocio = new Button();
            btnNoSocio = new Button();
            pnlActividad = new Panel();
            txbPrecio = new TextBox();
            txbCupo = new TextBox();
            label13 = new Label();
            label12 = new Label();
            cboActividades = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            ckbFicha = new CheckBox();
            ckbApto = new CheckBox();
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
            pnlActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            pnlCuota.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(78, 70);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(34, 99);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(152, 19);
            label3.TabIndex = 0;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(97, 161);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 0;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(36, 190);
            label5.Name = "label5";
            label5.Size = new Size(130, 19);
            label5.TabIndex = 0;
            label5.Text = "Fecha inscripcion";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold);
            dtpFechaNac.Location = new Point(170, 133);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(229, 24);
            dtpFechaNac.TabIndex = 1;
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold);
            dtpFechaInscripcion.Location = new Point(172, 190);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(229, 24);
            dtpFechaInscripcion.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(170, 70);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(229, 23);
            txtDocumento.TabIndex = 3;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(170, 99);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(229, 23);
            txtNombreCompleto.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(172, 161);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(57, 320);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(88, 26);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(209, 320);
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
            // pnlActividad
            // 
            pnlActividad.Controls.Add(txbPrecio);
            pnlActividad.Controls.Add(txbCupo);
            pnlActividad.Controls.Add(label13);
            pnlActividad.Controls.Add(label12);
            pnlActividad.Controls.Add(cboActividades);
            pnlActividad.Controls.Add(label10);
            pnlActividad.Controls.Add(label11);
            pnlActividad.Location = new Point(525, 26);
            pnlActividad.Name = "pnlActividad";
            pnlActividad.Size = new Size(254, 348);
            pnlActividad.TabIndex = 14;
            // 
            // txbPrecio
            // 
            txbPrecio.Enabled = false;
            txbPrecio.Location = new Point(95, 274);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.ReadOnly = true;
            txbPrecio.Size = new Size(74, 23);
            txbPrecio.TabIndex = 6;
            // 
            // txbCupo
            // 
            txbCupo.Enabled = false;
            txbCupo.Location = new Point(95, 231);
            txbCupo.Name = "txbCupo";
            txbCupo.ReadOnly = true;
            txbCupo.Size = new Size(74, 23);
            txbCupo.TabIndex = 5;
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
            // cboActividades
            // 
            cboActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividades.FormattingEnabled = true;
            cboActividades.Location = new Point(66, 171);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new Size(121, 23);
            cboActividades.TabIndex = 2;
            cboActividades.SelectedIndexChanged += cboActividades_SelectedIndexChanged;
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
            // ckbFicha
            // 
            ckbFicha.AutoSize = true;
            ckbFicha.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            ckbFicha.Location = new Point(97, 262);
            ckbFicha.Name = "ckbFicha";
            ckbFicha.Size = new Size(119, 23);
            ckbFicha.TabIndex = 15;
            ckbFicha.Text = "Ficha medica";
            ckbFicha.UseVisualStyleBackColor = true;
            // 
            // ckbApto
            // 
            ckbApto.AutoSize = true;
            ckbApto.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            ckbApto.Location = new Point(258, 262);
            ckbApto.Name = "ckbApto";
            ckbApto.Size = new Size(100, 23);
            ckbApto.TabIndex = 16;
            ckbApto.Text = "Apto fisico";
            ckbApto.UseVisualStyleBackColor = true;
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
            // RegistroSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 406);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btnNoSocio);
            Controls.Add(btnSocio);
            Controls.Add(ckbApto);
            Controls.Add(pnlActividad);
            Controls.Add(ckbFicha);
            Controls.Add(pnlCuota);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDocumento);
            Controls.Add(dtpFechaInscripcion);
            Controls.Add(dtpFechaNac);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RegistroSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Socio";
            Load += RegistroSocio_Load;
            pnlActividad.ResumeLayout(false);
            pnlActividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlCuota.ResumeLayout(false);
            pnlCuota.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFechaNac;
        private DateTimePicker dtpFechaInscripcion;
        private TextBox txtDocumento;
        private TextBox txtNombreCompleto;
        private TextBox txtTelefono;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnNoSocio;
        private Button btnSocio;
        private Panel pnlActividad;
        private Label label12;
        private ComboBox cboActividades;
        private Label label10;
        private Label label11;
        private Label label13;
        private TextBox txbPrecio;
        private TextBox txbCupo;
        private CheckBox ckbFicha;
        private CheckBox ckbApto;
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
    }
}
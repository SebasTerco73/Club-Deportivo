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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpFechaNac = new DateTimePicker();
            dtpFechaInscripcion = new DateTimePicker();
            txtDocumento = new TextBox();
            txtNombreCompleto = new TextBox();
            txtTelefono = new TextBox();
            cboFichaMedica = new ComboBox();
            cboAptoMedico = new ComboBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 65);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 96);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 127);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 191);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 0;
            label5.Text = "Fecha inscripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 227);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 0;
            label6.Text = "Ficha medica";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 258);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 0;
            label7.Text = "Apto medico";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(359, 127);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(229, 23);
            dtpFechaNac.TabIndex = 1;
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Location = new Point(359, 185);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(229, 23);
            dtpFechaInscripcion.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(359, 62);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(229, 23);
            txtDocumento.TabIndex = 3;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(359, 91);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(229, 23);
            txtNombreCompleto.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(359, 156);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 23);
            txtTelefono.TabIndex = 5;
            // 
            // cboFichaMedica
            // 
            cboFichaMedica.FormattingEnabled = true;
            cboFichaMedica.Items.AddRange(new object[] { "SI", "NO" });
            cboFichaMedica.Location = new Point(359, 227);
            cboFichaMedica.Name = "cboFichaMedica";
            cboFichaMedica.Size = new Size(37, 23);
            cboFichaMedica.TabIndex = 6;
            // 
            // cboAptoMedico
            // 
            cboAptoMedico.FormattingEnabled = true;
            cboAptoMedico.Items.AddRange(new object[] { "SI", "NO" });
            cboAptoMedico.Location = new Point(359, 256);
            cboAptoMedico.Name = "cboAptoMedico";
            cboAptoMedico.Size = new Size(37, 23);
            cboAptoMedico.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(137, 345);
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
            btnLimpiar.Location = new Point(378, 345);
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
            btnVolver.Location = new Point(609, 345);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 26);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // RegistroSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(cboAptoMedico);
            Controls.Add(cboFichaMedica);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDocumento);
            Controls.Add(dtpFechaInscripcion);
            Controls.Add(dtpFechaNac);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFechaNac;
        private DateTimePicker dtpFechaInscripcion;
        private TextBox txtDocumento;
        private TextBox txtNombreCompleto;
        private TextBox txtTelefono;
        private ComboBox cboFichaMedica;
        private ComboBox cboAptoMedico;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}
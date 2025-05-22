namespace login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelUser = new Label();
            labelContrasena = new Label();
            txtUser = new TextBox();
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            txtPass = new TextBox();
            botonIngresar = new Button();
            chkMostrarPass = new CheckBox();
            lblMensajeError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelUser.Location = new Point(357, 146);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(77, 22);
            labelUser.TabIndex = 0;
            labelUser.Text = "Usuario:";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelContrasena.Location = new Point(336, 178);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(106, 22);
            labelContrasena.TabIndex = 0;
            labelContrasena.Text = "Contraseña:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(466, 146);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(214, 23);
            txtUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 60);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft YaHei", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(164, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(390, 46);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "INICIO SESION | UDS";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(466, 181);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(214, 23);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // botonIngresar
            // 
            botonIngresar.Location = new Point(444, 273);
            botonIngresar.Margin = new Padding(3, 2, 3, 2);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(88, 26);
            botonIngresar.TabIndex = 7;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            botonIngresar.Click += botonIngresar_Click;
            // 
            // chkMostrarPass
            // 
            chkMostrarPass.AutoSize = true;
            chkMostrarPass.Location = new Point(552, 209);
            chkMostrarPass.Name = "chkMostrarPass";
            chkMostrarPass.Size = new Size(128, 19);
            chkMostrarPass.TabIndex = 4;
            chkMostrarPass.Text = "Mostrar contraseña";
            chkMostrarPass.UseVisualStyleBackColor = true;
            chkMostrarPass.CheckedChanged += chkMostrarPass_CheckedChanged;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Firebrick;
            lblMensajeError.Location = new Point(398, 244);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(189, 15);
            lblMensajeError.TabIndex = 8;
            lblMensajeError.Text = " Usuario y/o contraseña incorrecto";
            lblMensajeError.Visible = false;
            // 
            // Login
            // 
            AcceptButton = botonIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblMensajeError);
            Controls.Add(chkMostrarPass);
            Controls.Add(botonIngresar);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(labelContrasena);
            Controls.Add(labelUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label labelContrasena;
        private TextBox txtUser;
        private PictureBox pictureBox1;
        private Label labelTitulo;
        private TextBox txtPass;
        private Button botonIngresar;
        private CheckBox chkMostrarPass;
        private Label lblMensajeError;
    }
}

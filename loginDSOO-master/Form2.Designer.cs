namespace login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelUser = new Label();
            labelContrasena = new Label();
            textBoxUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            labelTitulo = new Label();
            textBoxContrasena = new TextBox();
            botonIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelUser.Location = new Point(408, 194);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(96, 27);
            labelUser.TabIndex = 0;
            labelUser.Text = "Usuario:";
            labelUser.Click += label1_Click;
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelContrasena.Location = new Point(384, 238);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(132, 27);
            labelContrasena.TabIndex = 1;
            labelContrasena.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(532, 194);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(244, 27);
            textBoxUsuario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft YaHei", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(227, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(561, 58);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "INICIO SESION | SOCIOS";
            labelTitulo.Click += label3_Click;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(532, 241);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.Size = new Size(244, 27);
            textBoxContrasena.TabIndex = 3;
            // 
            // botonIngresar
            // 
            botonIngresar.Location = new Point(676, 284);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(100, 35);
            botonIngresar.TabIndex = 6;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonIngresar);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelContrasena);
            Controls.Add(labelUser);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label labelContrasena;
        private TextBox textBoxUsuario;
        private PictureBox pictureBox1;
        private Label labelTitulo;
        private TextBox textBoxContrasena;
        private Button botonIngresar;
    }
}

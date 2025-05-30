namespace ClubDeportivo.Gui
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            btbImprimir = new Button();
            panel2 = new Panel();
            lblDni = new Label();
            label3 = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            lblInscri = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            lblBienvenida = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btbImprimir
            // 
            btbImprimir.Location = new Point(217, 266);
            btbImprimir.Name = "btbImprimir";
            btbImprimir.Size = new Size(75, 23);
            btbImprimir.TabIndex = 26;
            btbImprimir.Text = "Imprimir";
            btbImprimir.UseVisualStyleBackColor = true;
            btbImprimir.Click += btbImprimir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDni);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblNumero);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(lblInscri);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(24, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 179);
            panel2.TabIndex = 23;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(95, 54);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(0, 15);
            lblDni.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label3.Location = new Point(3, 52);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 11;
            label3.Text = "Documento";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(138, 86);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(0, 15);
            lblNumero.TabIndex = 10;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(70, 17);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 9;
            // 
            // lblInscri
            // 
            lblInscri.AutoSize = true;
            lblInscri.Location = new Point(105, 153);
            lblInscri.Name = "lblInscri";
            lblInscri.Size = new Size(0, 15);
            lblInscri.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(119, 17);
            label5.TabIndex = 7;
            label5.Text = "Numero de socio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.Location = new Point(66, 127);
            label2.Name = "label2";
            label2.Size = new Size(166, 17);
            label2.TabIndex = 2;
            label2.Text = "FECHA INSCRIPCION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 52);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(240, 27);
            label1.TabIndex = 0;
            label1.Text = "C A R N E T   D E   S O C I O";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Showcard Gothic", 15.75F);
            lblBienvenida.Location = new Point(110, 266);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(313, 27);
            lblBienvenida.TabIndex = 27;
            lblBienvenida.Text = "Bienvenido a nuestro club!";
            lblBienvenida.Visible = false;
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 301);
            ControlBox = false;
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox1);
            Controls.Add(btbImprimir);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Carnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet";
            Load += Carnet_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbImprimir;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label lblNumero;
        private Label lblNombre;
        private Label lblInscri;
        private Label lblDni;
        private Label label3;
        private Label lblBienvenida;
    }
}
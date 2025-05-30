namespace ClubDeportivo.Gui
{
    partial class Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblId = new Label();
            label5 = new Label();
            label4 = new Label();
            lblNombre = new Label();
            lblFechaIns = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lbl10 = new Label();
            lblCuotas = new Label();
            lblMonto = new Label();
            label10 = new Label();
            lblFechaP = new Label();
            lblFPago = new Label();
            label7 = new Label();
            label6 = new Label();
            btbImprimir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 15);
            label1.Name = "label1";
            label1.Size = new Size(257, 27);
            label1.TabIndex = 0;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(31, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 101);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblId);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(lblFechaIns);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(297, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 101);
            panel3.TabIndex = 19;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblId.Location = new Point(95, 74);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 17);
            lblId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label5.Location = new Point(14, 74);
            label5.Name = "label5";
            label5.Size = new Size(25, 17);
            label5.TabIndex = 6;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label4.Location = new Point(14, 46);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 5;
            label4.Text = "Nombre";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(95, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 17);
            lblNombre.TabIndex = 4;
            // 
            // lblFechaIns
            // 
            lblFechaIns.AutoSize = true;
            lblFechaIns.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblFechaIns.Location = new Point(175, 12);
            lblFechaIns.Name = "lblFechaIns";
            lblFechaIns.Size = new Size(0, 17);
            lblFechaIns.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 17);
            label2.TabIndex = 1;
            label2.Text = "FECHA INSCRIPCION";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl10);
            panel4.Controls.Add(lblCuotas);
            panel4.Controls.Add(lblMonto);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblFechaP);
            panel4.Controls.Add(lblFPago);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(31, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 114);
            panel4.TabIndex = 20;
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl10.Location = new Point(316, 71);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(70, 17);
            lbl10.TabIndex = 10;
            lbl10.Text = "CUOTAS";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(403, 73);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(0, 15);
            lblCuotas.TabIndex = 9;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblMonto.Location = new Point(411, 24);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(0, 17);
            lblMonto.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label10.Location = new Point(316, 24);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 7;
            label10.Text = "MONTO";
            // 
            // lblFechaP
            // 
            lblFechaP.AutoSize = true;
            lblFechaP.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblFechaP.Location = new Point(223, 24);
            lblFechaP.Name = "lblFechaP";
            lblFechaP.Size = new Size(0, 17);
            lblFechaP.TabIndex = 6;
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblFPago.Location = new Point(223, 71);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(0, 17);
            lblFPago.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label7.Location = new Point(73, 71);
            label7.Name = "label7";
            label7.Size = new Size(136, 17);
            label7.TabIndex = 1;
            label7.Text = "FORMA DE PAGO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label6.Location = new Point(73, 24);
            label6.Name = "label6";
            label6.Size = new Size(140, 17);
            label6.TabIndex = 0;
            label6.Text = "FECHA DEL PAGO";
            // 
            // btbImprimir
            // 
            btbImprimir.Location = new Point(511, 315);
            btbImprimir.Name = "btbImprimir";
            btbImprimir.Size = new Size(75, 23);
            btbImprimir.TabIndex = 21;
            btbImprimir.Text = "Imprimir";
            btbImprimir.UseVisualStyleBackColor = true;
            btbImprimir.Click += btbImprimir_Click;
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 350);
            ControlBox = false;
            Controls.Add(btbImprimir);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "Comprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            Load += Comprobante_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label lblNombre;
        private Label lblFechaIns;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Label label6;
        private Label lblMonto;
        private Label label10;
        private Label lblFechaP;
        private Label lblFPago;
        private Label label7;
        private Button btbImprimir;
        private Label lblId;
        private Label label5;
        private Label label4;
        private Label lbl10;
        private Label lblCuotas;
    }
}
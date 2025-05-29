namespace ClubDeportivo.Gui
{
    partial class ListadoVencimientos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dvgListSocio = new DataGridView();
            NroSocio = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            FechaPago = new DataGridViewTextBoxColumn();
            FechaVenc = new DataGridViewTextBoxColumn();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgListSocio).BeginInit();
            SuspendLayout();
            // 
            // dvgListSocio
            // 
            dvgListSocio.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgListSocio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgListSocio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListSocio.Columns.AddRange(new DataGridViewColumn[] { NroSocio, Socio, Documento, FechaPago, FechaVenc });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dvgListSocio.DefaultCellStyle = dataGridViewCellStyle4;
            dvgListSocio.Location = new Point(12, 29);
            dvgListSocio.Name = "dvgListSocio";
            dvgListSocio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dvgListSocio.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dvgListSocio.Size = new Size(610, 395);
            dvgListSocio.TabIndex = 0;
            // 
            // NroSocio
            // 
            NroSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = Color.White;
            NroSocio.DefaultCellStyle = dataGridViewCellStyle2;
            NroSocio.Frozen = true;
            NroSocio.HeaderText = "Nro.Socio";
            NroSocio.Name = "NroSocio";
            NroSocio.ReadOnly = true;
            NroSocio.Resizable = DataGridViewTriState.False;
            NroSocio.Width = 97;
            // 
            // Socio
            // 
            Socio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Socio.Frozen = true;
            Socio.HeaderText = "Socio";
            Socio.Name = "Socio";
            Socio.ReadOnly = true;
            Socio.Resizable = DataGridViewTriState.False;
            Socio.Width = 70;
            // 
            // Documento
            // 
            Documento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Documento.Frozen = true;
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Resizable = DataGridViewTriState.False;
            Documento.Width = 107;
            // 
            // FechaPago
            // 
            FechaPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FechaPago.Frozen = true;
            FechaPago.HeaderText = "Fecha de Pago";
            FechaPago.Name = "FechaPago";
            FechaPago.ReadOnly = true;
            FechaPago.Resizable = DataGridViewTriState.False;
            FechaPago.Width = 89;
            // 
            // FechaVenc
            // 
            FechaVenc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 128);
            FechaVenc.DefaultCellStyle = dataGridViewCellStyle3;
            FechaVenc.HeaderText = "Fecha Vencimiento";
            FechaVenc.Name = "FechaVenc";
            FechaVenc.ReadOnly = true;
            FechaVenc.Resizable = DataGridViewTriState.False;
            FechaVenc.Width = 144;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(628, 80);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(56, 290);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "ATRAS";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // ListadoVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            ControlBox = false;
            Controls.Add(btnAtras);
            Controls.Add(dvgListSocio);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ListadoVencimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Vencimientos";
            Load += ListadoVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dvgListSocio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgListSocio;
        private Button btnAtras;
        private DataGridViewTextBoxColumn NroSocio;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn FechaPago;
        private DataGridViewTextBoxColumn FechaVenc;
    }
}
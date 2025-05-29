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
            groupBox1 = new GroupBox();
            rbtTodo = new RadioButton();
            rbtMes = new RadioButton();
            rbtSemana = new RadioButton();
            rbtDia = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dvgListSocio).BeginInit();
            groupBox1.SuspendLayout();
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
            dvgListSocio.Location = new Point(12, 80);
            dvgListSocio.Name = "dvgListSocio";
            dvgListSocio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dvgListSocio.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dvgListSocio.Size = new Size(610, 344);
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
            btnAtras.Location = new Point(628, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(56, 412);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "ATRAS";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtTodo);
            groupBox1.Controls.Add(rbtMes);
            groupBox1.Controls.Add(rbtSemana);
            groupBox1.Controls.Add(rbtDia);
            groupBox1.Location = new Point(20, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 62);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodos";
            // 
            // rbtTodo
            // 
            rbtTodo.AutoSize = true;
            rbtTodo.Checked = true;
            rbtTodo.Location = new Point(446, 28);
            rbtTodo.Name = "rbtTodo";
            rbtTodo.Size = new Size(56, 19);
            rbtTodo.TabIndex = 3;
            rbtTodo.TabStop = true;
            rbtTodo.Text = "Todos";
            rbtTodo.UseVisualStyleBackColor = true;
            rbtTodo.CheckedChanged += rbtTodo_CheckedChanged;
            // 
            // rbtMes
            // 
            rbtMes.AutoSize = true;
            rbtMes.Location = new Point(328, 28);
            rbtMes.Name = "rbtMes";
            rbtMes.Size = new Size(47, 19);
            rbtMes.TabIndex = 2;
            rbtMes.Text = "Mes";
            rbtMes.UseVisualStyleBackColor = true;
            rbtMes.CheckedChanged += rbtMes_CheckedChanged;
            // 
            // rbtSemana
            // 
            rbtSemana.AutoSize = true;
            rbtSemana.Location = new Point(195, 28);
            rbtSemana.Name = "rbtSemana";
            rbtSemana.Size = new Size(67, 19);
            rbtSemana.TabIndex = 1;
            rbtSemana.Text = "Semana";
            rbtSemana.UseVisualStyleBackColor = true;
            rbtSemana.CheckedChanged += rbtSemana_CheckedChanged;
            // 
            // rbtDia
            // 
            rbtDia.AutoSize = true;
            rbtDia.Location = new Point(79, 28);
            rbtDia.Name = "rbtDia";
            rbtDia.Size = new Size(42, 19);
            rbtDia.TabIndex = 0;
            rbtDia.Text = "Día";
            rbtDia.UseVisualStyleBackColor = true;
            rbtDia.CheckedChanged += rbtDia_CheckedChanged;
            // 
            // ListadoVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(btnAtras);
            Controls.Add(dvgListSocio);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ListadoVencimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Vencimientos";
            Load += ListadoVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dvgListSocio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton rbtTodo;
        private RadioButton rbtMes;
        private RadioButton rbtSemana;
        private RadioButton rbtDia;
    }
}
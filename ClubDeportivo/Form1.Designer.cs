namespace ClubDeportivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.inicioSesionSocios = new System.Windows.Forms.Button();
            this.registroUsuario = new System.Windows.Forms.Button();
            this.inicioNoSocios = new System.Windows.Forms.Button();
            this.logouds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logouds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inicioSesionSocios
            // 
            resources.ApplyResources(this.inicioSesionSocios, "inicioSesionSocios");
            this.inicioSesionSocios.BackColor = System.Drawing.SystemColors.Control;
            this.inicioSesionSocios.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.inicioSesionSocios.Name = "inicioSesionSocios";
            this.inicioSesionSocios.UseCompatibleTextRendering = true;
            this.inicioSesionSocios.UseVisualStyleBackColor = false;
            this.inicioSesionSocios.UseWaitCursor = true;
            this.inicioSesionSocios.Click += new System.EventHandler(this.button1_Click);
            // 
            // registroUsuario
            // 
            resources.ApplyResources(this.registroUsuario, "registroUsuario");
            this.registroUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.registroUsuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.registroUsuario.Name = "registroUsuario";
            this.registroUsuario.UseCompatibleTextRendering = true;
            this.registroUsuario.UseVisualStyleBackColor = false;
            this.registroUsuario.UseWaitCursor = true;
            this.registroUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // inicioNoSocios
            // 
            resources.ApplyResources(this.inicioNoSocios, "inicioNoSocios");
            this.inicioNoSocios.BackColor = System.Drawing.SystemColors.Control;
            this.inicioNoSocios.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.inicioNoSocios.Name = "inicioNoSocios";
            this.inicioNoSocios.UseCompatibleTextRendering = true;
            this.inicioNoSocios.UseVisualStyleBackColor = false;
            this.inicioNoSocios.UseWaitCursor = true;
            this.inicioNoSocios.Click += new System.EventHandler(this.button3_Click);
            // 
            // logouds
            // 
            resources.ApplyResources(this.logouds, "logouds");
            this.logouds.Name = "logouds";
            this.logouds.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logouds);
            this.Controls.Add(this.inicioNoSocios);
            this.Controls.Add(this.registroUsuario);
            this.Controls.Add(this.inicioSesionSocios);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logouds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logouds;
        internal System.Windows.Forms.Button inicioSesionSocios;
        internal System.Windows.Forms.Button registroUsuario;
        internal System.Windows.Forms.Button inicioNoSocios;
    }
}


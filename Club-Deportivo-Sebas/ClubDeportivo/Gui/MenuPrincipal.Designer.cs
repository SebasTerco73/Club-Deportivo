namespace ClubDeportivo
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            lblIngreso = new Label();
            inicioSesionSocios = new Button();
            registroUsuario = new Button();
            inicioNoSocios = new Button();
            logouds = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logouds).BeginInit();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            resources.ApplyResources(lblIngreso, "lblIngreso");
            lblIngreso.ForeColor = SystemColors.WindowFrame;
            lblIngreso.Name = "lblIngreso";
            // 
            // inicioSesionSocios
            // 
            resources.ApplyResources(inicioSesionSocios, "inicioSesionSocios");
            inicioSesionSocios.BackColor = SystemColors.ControlDark;
            inicioSesionSocios.Cursor = Cursors.Hand;
            inicioSesionSocios.ForeColor = SystemColors.MenuBar;
            inicioSesionSocios.Name = "inicioSesionSocios";
            inicioSesionSocios.UseCompatibleTextRendering = true;
            inicioSesionSocios.UseVisualStyleBackColor = false;
            // 
            // registroUsuario
            // 
            resources.ApplyResources(registroUsuario, "registroUsuario");
            registroUsuario.BackColor = SystemColors.Control;
            registroUsuario.Cursor = Cursors.Hand;
            registroUsuario.ForeColor = SystemColors.MenuBar;
            registroUsuario.Name = "registroUsuario";
            registroUsuario.UseCompatibleTextRendering = true;
            registroUsuario.UseVisualStyleBackColor = false;
            // 
            // inicioNoSocios
            // 
            resources.ApplyResources(inicioNoSocios, "inicioNoSocios");
            inicioNoSocios.BackColor = SystemColors.Control;
            inicioNoSocios.Cursor = Cursors.Hand;
            inicioNoSocios.ForeColor = SystemColors.MenuBar;
            inicioNoSocios.Name = "inicioNoSocios";
            inicioNoSocios.UseCompatibleTextRendering = true;
            inicioNoSocios.UseVisualStyleBackColor = false;
            // 
            // logouds
            // 
            resources.ApplyResources(logouds, "logouds");
            logouds.Name = "logouds";
            logouds.TabStop = false;
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logouds);
            Controls.Add(inicioNoSocios);
            Controls.Add(registroUsuario);
            Controls.Add(inicioSesionSocios);
            Controls.Add(lblIngreso);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            TransparencyKey = SystemColors.ControlDarkDark;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logouds).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.PictureBox logouds;
        internal System.Windows.Forms.Button inicioSesionSocios;
        internal System.Windows.Forms.Button registroUsuario;
        internal System.Windows.Forms.Button inicioNoSocios;
    }
}


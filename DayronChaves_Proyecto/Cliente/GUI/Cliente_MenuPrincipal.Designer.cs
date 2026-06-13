
namespace Cliente.GUI
{
    partial class Cliente_MenuPrincipal
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
            this.BTN_RegistrarVacuna = new System.Windows.Forms.Button();
            this.BTN_ConsultarVacuna = new System.Windows.Forms.Button();
            this.BTN_RegistrarTratamiento = new System.Windows.Forms.Button();
            this.BTN_ConsultarTratamiento = new System.Windows.Forms.Button();
            this.BTN_CerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_RegistrarVacuna
            // 
            this.BTN_RegistrarVacuna.Location = new System.Drawing.Point(12, 25);
            this.BTN_RegistrarVacuna.Name = "BTN_RegistrarVacuna";
            this.BTN_RegistrarVacuna.Size = new System.Drawing.Size(160, 23);
            this.BTN_RegistrarVacuna.TabIndex = 1;
            this.BTN_RegistrarVacuna.Text = "Registrar Vacunamiento";
            this.BTN_RegistrarVacuna.UseVisualStyleBackColor = true;
            this.BTN_RegistrarVacuna.Click += new System.EventHandler(this.BTN_RegistrarVacuna_Click);
            // 
            // BTN_ConsultarVacuna
            // 
            this.BTN_ConsultarVacuna.Location = new System.Drawing.Point(12, 54);
            this.BTN_ConsultarVacuna.Name = "BTN_ConsultarVacuna";
            this.BTN_ConsultarVacuna.Size = new System.Drawing.Size(160, 23);
            this.BTN_ConsultarVacuna.TabIndex = 2;
            this.BTN_ConsultarVacuna.Text = "Consultar Vacunamiento";
            this.BTN_ConsultarVacuna.UseVisualStyleBackColor = true;
            this.BTN_ConsultarVacuna.Click += new System.EventHandler(this.BTN_ConsultarVacuna_Click);
            // 
            // BTN_RegistrarTratamiento
            // 
            this.BTN_RegistrarTratamiento.Location = new System.Drawing.Point(12, 83);
            this.BTN_RegistrarTratamiento.Name = "BTN_RegistrarTratamiento";
            this.BTN_RegistrarTratamiento.Size = new System.Drawing.Size(160, 23);
            this.BTN_RegistrarTratamiento.TabIndex = 3;
            this.BTN_RegistrarTratamiento.Text = "Registrar Tratamiento";
            this.BTN_RegistrarTratamiento.UseVisualStyleBackColor = true;
            this.BTN_RegistrarTratamiento.Click += new System.EventHandler(this.BTN_RegistrarTratamiento_Click);
            // 
            // BTN_ConsultarTratamiento
            // 
            this.BTN_ConsultarTratamiento.Location = new System.Drawing.Point(12, 112);
            this.BTN_ConsultarTratamiento.Name = "BTN_ConsultarTratamiento";
            this.BTN_ConsultarTratamiento.Size = new System.Drawing.Size(160, 23);
            this.BTN_ConsultarTratamiento.TabIndex = 4;
            this.BTN_ConsultarTratamiento.Text = "Consultar Tratamiento";
            this.BTN_ConsultarTratamiento.UseVisualStyleBackColor = true;
            this.BTN_ConsultarTratamiento.Click += new System.EventHandler(this.BTN_ConsultarTratamiento_Click);
            // 
            // BTN_CerrarSesion
            // 
            this.BTN_CerrarSesion.Location = new System.Drawing.Point(11, 141);
            this.BTN_CerrarSesion.Name = "BTN_CerrarSesion";
            this.BTN_CerrarSesion.Size = new System.Drawing.Size(161, 23);
            this.BTN_CerrarSesion.TabIndex = 5;
            this.BTN_CerrarSesion.Text = "Cerrar Sesion";
            this.BTN_CerrarSesion.UseVisualStyleBackColor = true;
            this.BTN_CerrarSesion.Click += new System.EventHandler(this.BTN_CerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Bienvenido!:";
            // 
            // TXT_NombreUsuario
            // 
            this.TXT_NombreUsuario.AutoSize = true;
            this.TXT_NombreUsuario.Location = new System.Drawing.Point(80, 9);
            this.TXT_NombreUsuario.Name = "TXT_NombreUsuario";
            this.TXT_NombreUsuario.Size = new System.Drawing.Size(92, 13);
            this.TXT_NombreUsuario.TabIndex = 7;
            this.TXT_NombreUsuario.Text = "[NOMBRE_AQUI]";
            this.TXT_NombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cliente_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 170);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_NombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_CerrarSesion);
            this.Controls.Add(this.BTN_ConsultarTratamiento);
            this.Controls.Add(this.BTN_RegistrarTratamiento);
            this.Controls.Add(this.BTN_ConsultarVacuna);
            this.Controls.Add(this.BTN_RegistrarVacuna);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Empleado";
            this.Load += new System.EventHandler(this.Cliente_MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_RegistrarVacuna;
        private System.Windows.Forms.Button BTN_ConsultarVacuna;
        private System.Windows.Forms.Button BTN_RegistrarTratamiento;
        private System.Windows.Forms.Button BTN_ConsultarTratamiento;
        private System.Windows.Forms.Button BTN_CerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXT_NombreUsuario;
    }
}
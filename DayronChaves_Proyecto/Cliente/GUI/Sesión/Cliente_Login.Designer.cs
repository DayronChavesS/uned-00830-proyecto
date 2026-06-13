
namespace Cliente.GUI.Sesión
{
    partial class Cliente_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.MSK_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MSK_Contraseña = new System.Windows.Forms.MaskedTextBox();
            this.BTN_IniciarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su usuario:";
            // 
            // MSK_Usuario
            // 
            this.MSK_Usuario.Location = new System.Drawing.Point(16, 29);
            this.MSK_Usuario.Name = "MSK_Usuario";
            this.MSK_Usuario.Size = new System.Drawing.Size(227, 20);
            this.MSK_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su contraseña:";
            // 
            // MSK_Contraseña
            // 
            this.MSK_Contraseña.Location = new System.Drawing.Point(16, 73);
            this.MSK_Contraseña.Name = "MSK_Contraseña";
            this.MSK_Contraseña.Size = new System.Drawing.Size(227, 20);
            this.MSK_Contraseña.TabIndex = 3;
            // 
            // BTN_IniciarSesion
            // 
            this.BTN_IniciarSesion.Location = new System.Drawing.Point(16, 100);
            this.BTN_IniciarSesion.Name = "BTN_IniciarSesion";
            this.BTN_IniciarSesion.Size = new System.Drawing.Size(227, 23);
            this.BTN_IniciarSesion.TabIndex = 4;
            this.BTN_IniciarSesion.Text = "Iniciar Sesion";
            this.BTN_IniciarSesion.UseVisualStyleBackColor = true;
            this.BTN_IniciarSesion.Click += new System.EventHandler(this.BTN_IniciarSesion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿No tiene un usuario?";
            // 
            // BTN_Registrarse
            // 
            this.BTN_Registrarse.Location = new System.Drawing.Point(19, 158);
            this.BTN_Registrarse.Name = "BTN_Registrarse";
            this.BTN_Registrarse.Size = new System.Drawing.Size(224, 23);
            this.BTN_Registrarse.TabIndex = 6;
            this.BTN_Registrarse.Text = "Registrarse";
            this.BTN_Registrarse.UseVisualStyleBackColor = true;
            this.BTN_Registrarse.Click += new System.EventHandler(this.BTN_Registrarse_Click);
            // 
            // Cliente_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 198);
            this.Controls.Add(this.BTN_Registrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_IniciarSesion);
            this.Controls.Add(this.MSK_Contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSK_Usuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MSK_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MSK_Contraseña;
        private System.Windows.Forms.Button BTN_IniciarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Registrarse;
    }
}



namespace Principal
{
    partial class Principal_MenuPrincipal
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
            this.BTN_CrearServidor = new System.Windows.Forms.Button();
            this.BTN_CrearCliente = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CrearServidor
            // 
            this.BTN_CrearServidor.Location = new System.Drawing.Point(12, 12);
            this.BTN_CrearServidor.Name = "BTN_CrearServidor";
            this.BTN_CrearServidor.Size = new System.Drawing.Size(143, 23);
            this.BTN_CrearServidor.TabIndex = 0;
            this.BTN_CrearServidor.Text = "Crear Nuevo Servidor";
            this.BTN_CrearServidor.UseVisualStyleBackColor = true;
            this.BTN_CrearServidor.Click += new System.EventHandler(this.BTN_CrearServidor_Click);
            // 
            // BTN_CrearCliente
            // 
            this.BTN_CrearCliente.Location = new System.Drawing.Point(12, 41);
            this.BTN_CrearCliente.Name = "BTN_CrearCliente";
            this.BTN_CrearCliente.Size = new System.Drawing.Size(143, 23);
            this.BTN_CrearCliente.TabIndex = 1;
            this.BTN_CrearCliente.Text = "Crear Nuevo Cliente";
            this.BTN_CrearCliente.UseVisualStyleBackColor = true;
            this.BTN_CrearCliente.Click += new System.EventHandler(this.BTN_CrearCliente_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Location = new System.Drawing.Point(13, 71);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(142, 23);
            this.BTN_Salir.TabIndex = 2;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // Principal_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 106);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_CrearCliente);
            this.Controls.Add(this.BTN_CrearServidor);
            this.Name = "Principal_MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Informatico Mi Finca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CrearServidor;
        private System.Windows.Forms.Button BTN_CrearCliente;
        private System.Windows.Forms.Button BTN_Salir;
    }
}


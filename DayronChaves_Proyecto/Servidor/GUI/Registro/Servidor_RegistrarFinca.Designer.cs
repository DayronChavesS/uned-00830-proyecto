
namespace Servidor.GUI.Registro
{
    partial class Servidor_RegistrarFinca
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
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.MSK_FincaTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TXT_FincaTelefono = new System.Windows.Forms.Label();
            this.MSK_FincaDireccion = new System.Windows.Forms.MaskedTextBox();
            this.TXT_FincaDireccion = new System.Windows.Forms.Label();
            this.MSK_FincaTamaño = new System.Windows.Forms.MaskedTextBox();
            this.TXT_FincaTamaño = new System.Windows.Forms.Label();
            this.MSK_FincaNombre = new System.Windows.Forms.MaskedTextBox();
            this.TXT_FincaNombre = new System.Windows.Forms.Label();
            this.MSK_FincaNumero = new System.Windows.Forms.MaskedTextBox();
            this.TXT_FincaNumero = new System.Windows.Forms.Label();
            this.TXT_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(151, 244);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(64, 26);
            this.BTN_Registrar.TabIndex = 24;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // MSK_FincaTelefono
            // 
            this.MSK_FincaTelefono.Location = new System.Drawing.Point(11, 207);
            this.MSK_FincaTelefono.Name = "MSK_FincaTelefono";
            this.MSK_FincaTelefono.Size = new System.Drawing.Size(205, 20);
            this.MSK_FincaTelefono.TabIndex = 23;
            // 
            // TXT_FincaTelefono
            // 
            this.TXT_FincaTelefono.AutoSize = true;
            this.TXT_FincaTelefono.Location = new System.Drawing.Point(8, 191);
            this.TXT_FincaTelefono.Name = "TXT_FincaTelefono";
            this.TXT_FincaTelefono.Size = new System.Drawing.Size(52, 13);
            this.TXT_FincaTelefono.TabIndex = 22;
            this.TXT_FincaTelefono.Text = "Telefono:";
            // 
            // MSK_FincaDireccion
            // 
            this.MSK_FincaDireccion.Location = new System.Drawing.Point(11, 169);
            this.MSK_FincaDireccion.Name = "MSK_FincaDireccion";
            this.MSK_FincaDireccion.Size = new System.Drawing.Size(205, 20);
            this.MSK_FincaDireccion.TabIndex = 21;
            // 
            // TXT_FincaDireccion
            // 
            this.TXT_FincaDireccion.AutoSize = true;
            this.TXT_FincaDireccion.Location = new System.Drawing.Point(8, 153);
            this.TXT_FincaDireccion.Name = "TXT_FincaDireccion";
            this.TXT_FincaDireccion.Size = new System.Drawing.Size(107, 13);
            this.TXT_FincaDireccion.TabIndex = 20;
            this.TXT_FincaDireccion.Text = "Direccion de la finca:";
            // 
            // MSK_FincaTamaño
            // 
            this.MSK_FincaTamaño.Location = new System.Drawing.Point(12, 131);
            this.MSK_FincaTamaño.Name = "MSK_FincaTamaño";
            this.MSK_FincaTamaño.Size = new System.Drawing.Size(204, 20);
            this.MSK_FincaTamaño.TabIndex = 19;
            // 
            // TXT_FincaTamaño
            // 
            this.TXT_FincaTamaño.AutoSize = true;
            this.TXT_FincaTamaño.Location = new System.Drawing.Point(8, 115);
            this.TXT_FincaTamaño.Name = "TXT_FincaTamaño";
            this.TXT_FincaTamaño.Size = new System.Drawing.Size(217, 13);
            this.TXT_FincaTamaño.TabIndex = 18;
            this.TXT_FincaTamaño.Text = "Tamaño de la Finca (Numero de Hectareas):";
            // 
            // MSK_FincaNombre
            // 
            this.MSK_FincaNombre.Location = new System.Drawing.Point(11, 92);
            this.MSK_FincaNombre.Name = "MSK_FincaNombre";
            this.MSK_FincaNombre.Size = new System.Drawing.Size(205, 20);
            this.MSK_FincaNombre.TabIndex = 17;
            // 
            // TXT_FincaNombre
            // 
            this.TXT_FincaNombre.AutoSize = true;
            this.TXT_FincaNombre.Location = new System.Drawing.Point(8, 77);
            this.TXT_FincaNombre.Name = "TXT_FincaNombre";
            this.TXT_FincaNombre.Size = new System.Drawing.Size(102, 13);
            this.TXT_FincaNombre.TabIndex = 16;
            this.TXT_FincaNombre.Text = "Nombre de la Finca:";
            // 
            // MSK_FincaNumero
            // 
            this.MSK_FincaNumero.Location = new System.Drawing.Point(12, 54);
            this.MSK_FincaNumero.Name = "MSK_FincaNumero";
            this.MSK_FincaNumero.Size = new System.Drawing.Size(204, 20);
            this.MSK_FincaNumero.TabIndex = 15;
            // 
            // TXT_FincaNumero
            // 
            this.TXT_FincaNumero.AutoSize = true;
            this.TXT_FincaNumero.Location = new System.Drawing.Point(8, 38);
            this.TXT_FincaNumero.Name = "TXT_FincaNumero";
            this.TXT_FincaNumero.Size = new System.Drawing.Size(91, 13);
            this.TXT_FincaNumero.TabIndex = 14;
            this.TXT_FincaNumero.Text = "Numero de Finca:";
            // 
            // TXT_Info
            // 
            this.TXT_Info.AutoSize = true;
            this.TXT_Info.Location = new System.Drawing.Point(12, 9);
            this.TXT_Info.Name = "TXT_Info";
            this.TXT_Info.Size = new System.Drawing.Size(203, 13);
            this.TXT_Info.TabIndex = 13;
            this.TXT_Info.Text = "Por favor ingrese la siguiente informacion.";
            // 
            // Servidor_RegistrarFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 282);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.MSK_FincaTelefono);
            this.Controls.Add(this.TXT_FincaTelefono);
            this.Controls.Add(this.MSK_FincaDireccion);
            this.Controls.Add(this.TXT_FincaDireccion);
            this.Controls.Add(this.MSK_FincaTamaño);
            this.Controls.Add(this.TXT_FincaTamaño);
            this.Controls.Add(this.MSK_FincaNombre);
            this.Controls.Add(this.TXT_FincaNombre);
            this.Controls.Add(this.MSK_FincaNumero);
            this.Controls.Add(this.TXT_FincaNumero);
            this.Controls.Add(this.TXT_Info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_RegistrarFinca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Finca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.MaskedTextBox MSK_FincaTelefono;
        private System.Windows.Forms.Label TXT_FincaTelefono;
        private System.Windows.Forms.MaskedTextBox MSK_FincaDireccion;
        private System.Windows.Forms.Label TXT_FincaDireccion;
        private System.Windows.Forms.MaskedTextBox MSK_FincaTamaño;
        private System.Windows.Forms.Label TXT_FincaTamaño;
        private System.Windows.Forms.MaskedTextBox MSK_FincaNombre;
        private System.Windows.Forms.Label TXT_FincaNombre;
        private System.Windows.Forms.MaskedTextBox MSK_FincaNumero;
        private System.Windows.Forms.Label TXT_FincaNumero;
        private System.Windows.Forms.Label TXT_Info;
    }
}
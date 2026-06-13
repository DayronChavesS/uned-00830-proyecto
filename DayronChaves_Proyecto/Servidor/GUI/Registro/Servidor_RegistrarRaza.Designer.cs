
namespace Servidor.GUI.Registro
{
    partial class Servidor_RegistrarRaza
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
            this.MSK_DescripcionRaza = new System.Windows.Forms.MaskedTextBox();
            this.TXT_RazaDescripcion = new System.Windows.Forms.Label();
            this.MSK_CodigoRaza = new System.Windows.Forms.MaskedTextBox();
            this.TXT_RazaCodigo = new System.Windows.Forms.Label();
            this.TXT_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(145, 118);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(64, 29);
            this.BTN_Registrar.TabIndex = 12;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // MSK_DescripcionRaza
            // 
            this.MSK_DescripcionRaza.Location = new System.Drawing.Point(12, 92);
            this.MSK_DescripcionRaza.Name = "MSK_DescripcionRaza";
            this.MSK_DescripcionRaza.Size = new System.Drawing.Size(198, 20);
            this.MSK_DescripcionRaza.TabIndex = 11;
            // 
            // TXT_RazaDescripcion
            // 
            this.TXT_RazaDescripcion.AutoSize = true;
            this.TXT_RazaDescripcion.Location = new System.Drawing.Point(12, 76);
            this.TXT_RazaDescripcion.Name = "TXT_RazaDescripcion";
            this.TXT_RazaDescripcion.Size = new System.Drawing.Size(120, 13);
            this.TXT_RazaDescripcion.TabIndex = 10;
            this.TXT_RazaDescripcion.Text = "Descripcion de la Raza:";
            // 
            // MSK_CodigoRaza
            // 
            this.MSK_CodigoRaza.Location = new System.Drawing.Point(12, 50);
            this.MSK_CodigoRaza.Name = "MSK_CodigoRaza";
            this.MSK_CodigoRaza.Size = new System.Drawing.Size(198, 20);
            this.MSK_CodigoRaza.TabIndex = 9;
            // 
            // TXT_RazaCodigo
            // 
            this.TXT_RazaCodigo.AutoSize = true;
            this.TXT_RazaCodigo.Location = new System.Drawing.Point(11, 34);
            this.TXT_RazaCodigo.Name = "TXT_RazaCodigo";
            this.TXT_RazaCodigo.Size = new System.Drawing.Size(86, 13);
            this.TXT_RazaCodigo.TabIndex = 8;
            this.TXT_RazaCodigo.Text = "Codigo de Raza:";
            // 
            // TXT_Info
            // 
            this.TXT_Info.AutoSize = true;
            this.TXT_Info.Location = new System.Drawing.Point(12, 9);
            this.TXT_Info.Name = "TXT_Info";
            this.TXT_Info.Size = new System.Drawing.Size(203, 13);
            this.TXT_Info.TabIndex = 7;
            this.TXT_Info.Text = "Por favor ingrese la siguiente informacion.";
            // 
            // Servidor_RegistrarRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 159);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.MSK_DescripcionRaza);
            this.Controls.Add(this.TXT_RazaDescripcion);
            this.Controls.Add(this.MSK_CodigoRaza);
            this.Controls.Add(this.TXT_RazaCodigo);
            this.Controls.Add(this.TXT_Info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_RegistrarRaza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Raza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.MaskedTextBox MSK_DescripcionRaza;
        private System.Windows.Forms.Label TXT_RazaDescripcion;
        private System.Windows.Forms.MaskedTextBox MSK_CodigoRaza;
        private System.Windows.Forms.Label TXT_RazaCodigo;
        private System.Windows.Forms.Label TXT_Info;
    }
}
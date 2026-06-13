
namespace Servidor.GUI.Otros
{
    partial class Servidor_EmpleadosPendientes
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
            this.TXT_Info = new System.Windows.Forms.Label();
            this.COMBO_EmpleadosPendientes = new System.Windows.Forms.ComboBox();
            this.BTN_Activar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_Info
            // 
            this.TXT_Info.AutoSize = true;
            this.TXT_Info.Location = new System.Drawing.Point(13, 13);
            this.TXT_Info.Name = "TXT_Info";
            this.TXT_Info.Size = new System.Drawing.Size(210, 13);
            this.TXT_Info.TabIndex = 0;
            this.TXT_Info.Text = "Seleccione el empleado que desea validar:";
            // 
            // COMBO_EmpleadosPendientes
            // 
            this.COMBO_EmpleadosPendientes.FormattingEnabled = true;
            this.COMBO_EmpleadosPendientes.Location = new System.Drawing.Point(16, 29);
            this.COMBO_EmpleadosPendientes.Name = "COMBO_EmpleadosPendientes";
            this.COMBO_EmpleadosPendientes.Size = new System.Drawing.Size(207, 21);
            this.COMBO_EmpleadosPendientes.TabIndex = 1;
            // 
            // BTN_Activar
            // 
            this.BTN_Activar.Location = new System.Drawing.Point(147, 57);
            this.BTN_Activar.Name = "BTN_Activar";
            this.BTN_Activar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Activar.TabIndex = 2;
            this.BTN_Activar.Text = "Activar";
            this.BTN_Activar.UseVisualStyleBackColor = true;
            this.BTN_Activar.Click += new System.EventHandler(this.BTN_Activar_Click);
            // 
            // Servidor_EmpleadosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 92);
            this.Controls.Add(this.BTN_Activar);
            this.Controls.Add(this.COMBO_EmpleadosPendientes);
            this.Controls.Add(this.TXT_Info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_EmpleadosPendientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados Pendientes";
            this.Load += new System.EventHandler(this.Servidor_EmpleadosPendientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TXT_Info;
        private System.Windows.Forms.ComboBox COMBO_EmpleadosPendientes;
        private System.Windows.Forms.Button BTN_Activar;
    }
}
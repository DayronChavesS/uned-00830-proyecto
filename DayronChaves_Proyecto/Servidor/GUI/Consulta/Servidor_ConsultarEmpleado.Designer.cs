
namespace Servidor.GUI.Consulta
{
    partial class Servidor_ConsultarEmpleado
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
            this.DGV_Empleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Empleado
            // 
            this.DGV_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Empleado.Location = new System.Drawing.Point(12, 12);
            this.DGV_Empleado.Name = "DGV_Empleado";
            this.DGV_Empleado.Size = new System.Drawing.Size(1060, 300);
            this.DGV_Empleado.TabIndex = 2;
            // 
            // Servidor_ConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 320);
            this.Controls.Add(this.DGV_Empleado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_ConsultarEmpleado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Empleados";
            this.Load += new System.EventHandler(this.Servidor_ConsultarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Empleado;
    }
}
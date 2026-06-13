
namespace Cliente.GUI.Consulta
{
    partial class Cliente_ConsultarTratamiento
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
            this.DGV_Tratamientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Tratamientos
            // 
            this.DGV_Tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tratamientos.Location = new System.Drawing.Point(12, 12);
            this.DGV_Tratamientos.Name = "DGV_Tratamientos";
            this.DGV_Tratamientos.Size = new System.Drawing.Size(500, 300);
            this.DGV_Tratamientos.TabIndex = 1;
            // 
            // Cliente_ConsultarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 324);
            this.Controls.Add(this.DGV_Tratamientos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_ConsultarTratamiento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tratamiento";
            this.Load += new System.EventHandler(this.Cliente_ConsultarTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tratamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Tratamientos;
    }
}
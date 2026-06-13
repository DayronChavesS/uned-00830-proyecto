
namespace Servidor.GUI.Consulta
{
    partial class Servidor_ConsultarRaza
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
            this.DGV_Razas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Razas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Razas
            // 
            this.DGV_Razas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Razas.Location = new System.Drawing.Point(12, 12);
            this.DGV_Razas.Name = "DGV_Razas";
            this.DGV_Razas.Size = new System.Drawing.Size(250, 300);
            this.DGV_Razas.TabIndex = 2;
            // 
            // Servidor_ConsultarRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 330);
            this.Controls.Add(this.DGV_Razas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_ConsultarRaza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Razas";
            this.Load += new System.EventHandler(this.Servidor_ConsultarRaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Razas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Razas;
    }
}
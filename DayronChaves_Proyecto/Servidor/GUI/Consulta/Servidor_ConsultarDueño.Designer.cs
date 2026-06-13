
namespace Servidor.GUI.Consulta
{
    partial class Servidor_ConsultarDueño
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
            this.DGV_Dueño = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dueño)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Dueño
            // 
            this.DGV_Dueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Dueño.Location = new System.Drawing.Point(12, 12);
            this.DGV_Dueño.Name = "DGV_Dueño";
            this.DGV_Dueño.Size = new System.Drawing.Size(860, 300);
            this.DGV_Dueño.TabIndex = 2;
            // 
            // Servidor_ConsultarDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 322);
            this.Controls.Add(this.DGV_Dueño);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_ConsultarDueño";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Dueño";
            this.Load += new System.EventHandler(this.Servidor_ConsultarDueño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dueño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Dueño;
    }
}
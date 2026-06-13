
namespace Servidor.GUI.Otros
{
    partial class Servidor_EventosRecientes
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
            this.DGV_Eventos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Eventos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Eventos
            // 
            this.DGV_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Eventos.Location = new System.Drawing.Point(12, 12);
            this.DGV_Eventos.Name = "DGV_Eventos";
            this.DGV_Eventos.Size = new System.Drawing.Size(210, 300);
            this.DGV_Eventos.TabIndex = 3;
            // 
            // Servidor_EventosRecientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 323);
            this.Controls.Add(this.DGV_Eventos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_EventosRecientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos Recientes";
            this.Load += new System.EventHandler(this.Servidor_EventosRecientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Eventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Eventos;
    }
}
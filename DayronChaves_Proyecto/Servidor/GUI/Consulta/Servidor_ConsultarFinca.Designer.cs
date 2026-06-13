
namespace Servidor.GUI.Consulta
{
    partial class Servidor_ConsultarFinca
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
            this.DGV_Finca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Finca)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Finca
            // 
            this.DGV_Finca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Finca.Location = new System.Drawing.Point(12, 12);
            this.DGV_Finca.Name = "DGV_Finca";
            this.DGV_Finca.Size = new System.Drawing.Size(545, 300);
            this.DGV_Finca.TabIndex = 2;
            // 
            // Servidor_ConsultarFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 324);
            this.Controls.Add(this.DGV_Finca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_ConsultarFinca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fincas";
            this.Load += new System.EventHandler(this.Servidor_ConsultarFinca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Finca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Finca;
    }
}
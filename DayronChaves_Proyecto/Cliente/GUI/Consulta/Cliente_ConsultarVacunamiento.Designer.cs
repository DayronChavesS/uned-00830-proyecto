
namespace Cliente.GUI.Consulta
{
    partial class Cliente_ConsultarVacunamiento
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
            this.DGV_Vacunamientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vacunamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Vacunamientos
            // 
            this.DGV_Vacunamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Vacunamientos.Location = new System.Drawing.Point(13, 13);
            this.DGV_Vacunamientos.Name = "DGV_Vacunamientos";
            this.DGV_Vacunamientos.Size = new System.Drawing.Size(500, 300);
            this.DGV_Vacunamientos.TabIndex = 0;
            // 
            // Cliente_ConsultarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 324);
            this.Controls.Add(this.DGV_Vacunamientos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_ConsultarVacuna";
            this.ShowIcon = false;
            this.Text = "Consultar Vacunas";
            this.Load += new System.EventHandler(this.Cliente_ConsultarVacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vacunamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Vacunamientos;
    }
}
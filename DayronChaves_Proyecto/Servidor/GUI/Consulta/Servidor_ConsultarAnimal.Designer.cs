
namespace Servidor.GUI.Consulta
{
    partial class Servidor_ConsultarAnimal
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
            this.DGV_Animal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Animal)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Animal
            // 
            this.DGV_Animal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Animal.Location = new System.Drawing.Point(12, 12);
            this.DGV_Animal.Name = "DGV_Animal";
            this.DGV_Animal.Size = new System.Drawing.Size(860, 300);
            this.DGV_Animal.TabIndex = 2;
            // 
            // Servidor_ConsultarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 324);
            this.Controls.Add(this.DGV_Animal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_ConsultarAnimal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Animales";
            this.Load += new System.EventHandler(this.Servidor_ConsultarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Animal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Animal;
    }
}
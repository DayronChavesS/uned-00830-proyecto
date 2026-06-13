
namespace Cliente.GUI.Registro
{
    partial class Cliente_RegistrarVacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COMBO_Finca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COMBO_Animal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MSK_Enfermedad = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MSK_Observaciones = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.COMBO_Vacuna = new System.Windows.Forms.ComboBox();
            this.DATEPICK_FechaAplicacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor ingrese la siguiente informacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificador de Finca:";
            // 
            // COMBO_Finca
            // 
            this.COMBO_Finca.FormattingEnabled = true;
            this.COMBO_Finca.Location = new System.Drawing.Point(16, 53);
            this.COMBO_Finca.Name = "COMBO_Finca";
            this.COMBO_Finca.Size = new System.Drawing.Size(200, 21);
            this.COMBO_Finca.TabIndex = 2;
            this.COMBO_Finca.SelectedIndexChanged += new System.EventHandler(this.COMBO_Finca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificador de Animal:";
            // 
            // COMBO_Animal
            // 
            this.COMBO_Animal.FormattingEnabled = true;
            this.COMBO_Animal.Location = new System.Drawing.Point(16, 97);
            this.COMBO_Animal.Name = "COMBO_Animal";
            this.COMBO_Animal.Size = new System.Drawing.Size(200, 21);
            this.COMBO_Animal.TabIndex = 4;
            this.COMBO_Animal.SelectedIndexChanged += new System.EventHandler(this.COMBO_Animal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Identificador de la Vacuna:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Aplicacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enfermedad:";
            // 
            // MSK_Enfermedad
            // 
            this.MSK_Enfermedad.Location = new System.Drawing.Point(16, 230);
            this.MSK_Enfermedad.Name = "MSK_Enfermedad";
            this.MSK_Enfermedad.Size = new System.Drawing.Size(200, 20);
            this.MSK_Enfermedad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Observaciones:";
            // 
            // MSK_Observaciones
            // 
            this.MSK_Observaciones.Location = new System.Drawing.Point(16, 274);
            this.MSK_Observaciones.Name = "MSK_Observaciones";
            this.MSK_Observaciones.Size = new System.Drawing.Size(200, 20);
            this.MSK_Observaciones.TabIndex = 12;
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(140, 301);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Registrar.TabIndex = 13;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // COMBO_Vacuna
            // 
            this.COMBO_Vacuna.FormattingEnabled = true;
            this.COMBO_Vacuna.Location = new System.Drawing.Point(16, 142);
            this.COMBO_Vacuna.Name = "COMBO_Vacuna";
            this.COMBO_Vacuna.Size = new System.Drawing.Size(199, 21);
            this.COMBO_Vacuna.TabIndex = 14;
            this.COMBO_Vacuna.SelectedIndexChanged += new System.EventHandler(this.COMBO_Vacuna_SelectedIndexChanged);
            // 
            // DATEPICK_FechaAplicacion
            // 
            this.DATEPICK_FechaAplicacion.Location = new System.Drawing.Point(16, 186);
            this.DATEPICK_FechaAplicacion.Name = "DATEPICK_FechaAplicacion";
            this.DATEPICK_FechaAplicacion.Size = new System.Drawing.Size(200, 20);
            this.DATEPICK_FechaAplicacion.TabIndex = 15;
            // 
            // Cliente_RegistrarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 337);
            this.Controls.Add(this.DATEPICK_FechaAplicacion);
            this.Controls.Add(this.COMBO_Vacuna);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.MSK_Observaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MSK_Enfermedad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COMBO_Animal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COMBO_Finca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_RegistrarVacuna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Vacuna";
            this.Load += new System.EventHandler(this.Cliente_RegistrarVacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMBO_Finca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox COMBO_Animal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MSK_Enfermedad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MSK_Observaciones;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.ComboBox COMBO_Vacuna;
        private System.Windows.Forms.DateTimePicker DATEPICK_FechaAplicacion;
    }
}
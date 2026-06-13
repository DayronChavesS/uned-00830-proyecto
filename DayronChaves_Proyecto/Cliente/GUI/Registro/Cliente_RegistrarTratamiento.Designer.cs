
namespace Cliente.GUI.Registro
{
    partial class Cliente_RegistrarTratamiento
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
            this.COMBO_Animal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COMBO_Finca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSK_Diagnostico = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MSK_MedicamentoAplicado = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MSK_DiaTratamiento = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MSK_Observaciones = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.DATEPICK_FechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // COMBO_Animal
            // 
            this.COMBO_Animal.FormattingEnabled = true;
            this.COMBO_Animal.Location = new System.Drawing.Point(15, 93);
            this.COMBO_Animal.Name = "COMBO_Animal";
            this.COMBO_Animal.Size = new System.Drawing.Size(200, 21);
            this.COMBO_Animal.TabIndex = 9;
            this.COMBO_Animal.SelectedIndexChanged += new System.EventHandler(this.COMBO_Animal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identificador de Animal:";
            // 
            // COMBO_Finca
            // 
            this.COMBO_Finca.FormattingEnabled = true;
            this.COMBO_Finca.Location = new System.Drawing.Point(15, 49);
            this.COMBO_Finca.Name = "COMBO_Finca";
            this.COMBO_Finca.Size = new System.Drawing.Size(200, 21);
            this.COMBO_Finca.TabIndex = 7;
            this.COMBO_Finca.SelectedIndexChanged += new System.EventHandler(this.COMBO_Finca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificador de Finca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Por favor ingrese la siguiente informacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de Tratamiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diagnostico:";
            // 
            // MSK_Diagnostico
            // 
            this.MSK_Diagnostico.Location = new System.Drawing.Point(15, 182);
            this.MSK_Diagnostico.Name = "MSK_Diagnostico";
            this.MSK_Diagnostico.Size = new System.Drawing.Size(200, 20);
            this.MSK_Diagnostico.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Medicamento Aplicado:";
            // 
            // MSK_MedicamentoAplicado
            // 
            this.MSK_MedicamentoAplicado.Location = new System.Drawing.Point(15, 226);
            this.MSK_MedicamentoAplicado.Name = "MSK_MedicamentoAplicado";
            this.MSK_MedicamentoAplicado.Size = new System.Drawing.Size(200, 20);
            this.MSK_MedicamentoAplicado.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dias de Tratamiento:";
            // 
            // MSK_DiaTratamiento
            // 
            this.MSK_DiaTratamiento.Location = new System.Drawing.Point(15, 270);
            this.MSK_DiaTratamiento.Name = "MSK_DiaTratamiento";
            this.MSK_DiaTratamiento.Size = new System.Drawing.Size(200, 20);
            this.MSK_DiaTratamiento.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Observaciones:";
            // 
            // MSK_Observaciones
            // 
            this.MSK_Observaciones.Location = new System.Drawing.Point(15, 314);
            this.MSK_Observaciones.Name = "MSK_Observaciones";
            this.MSK_Observaciones.Size = new System.Drawing.Size(200, 20);
            this.MSK_Observaciones.TabIndex = 19;
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(140, 340);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Registrar.TabIndex = 20;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // DATEPICK_FechaTratamiento
            // 
            this.DATEPICK_FechaTratamiento.Location = new System.Drawing.Point(15, 138);
            this.DATEPICK_FechaTratamiento.Name = "DATEPICK_FechaTratamiento";
            this.DATEPICK_FechaTratamiento.Size = new System.Drawing.Size(200, 20);
            this.DATEPICK_FechaTratamiento.TabIndex = 22;
            // 
            // Cliente_RegistrarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 374);
            this.Controls.Add(this.DATEPICK_FechaTratamiento);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.MSK_Observaciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MSK_DiaTratamiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MSK_MedicamentoAplicado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MSK_Diagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COMBO_Animal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COMBO_Finca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_RegistrarTratamiento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tratamiento";
            this.Load += new System.EventHandler(this.Cliente_RegistrarTratamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COMBO_Animal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox COMBO_Finca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MSK_Diagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MSK_MedicamentoAplicado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MSK_DiaTratamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MSK_Observaciones;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.DateTimePicker DATEPICK_FechaTratamiento;
    }
}
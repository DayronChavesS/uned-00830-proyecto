
namespace Servidor.GUI.Registro
{
    partial class Servidor_RegistrarAnimal
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
            this.RADIOGROUP_AnimalSexo = new System.Windows.Forms.GroupBox();
            this.RADIOBTN_AnimalSexoMacho = new System.Windows.Forms.RadioButton();
            this.RADIOBTN_AnimalSexoHembra = new System.Windows.Forms.RadioButton();
            this.TXT_AnimalSexo = new System.Windows.Forms.Label();
            this.BTN_Registrar = new System.Windows.Forms.Button();
            this.TXT_AnimalPadre = new System.Windows.Forms.Label();
            this.TXT_AnimalMadre = new System.Windows.Forms.Label();
            this.TXT_AnimalNacimiento = new System.Windows.Forms.Label();
            this.COMBO_AnimalRaza = new System.Windows.Forms.ComboBox();
            this.TXT_AnimalRaza = new System.Windows.Forms.Label();
            this.COMBO_AnimalFinca = new System.Windows.Forms.ComboBox();
            this.TXT_AnimalFinca = new System.Windows.Forms.Label();
            this.MSK_AnimalNombre = new System.Windows.Forms.MaskedTextBox();
            this.TXT_AnimalNombre = new System.Windows.Forms.Label();
            this.MSK_AnimalIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.TXT_AnimalIdentificacion = new System.Windows.Forms.Label();
            this.TXT_Info = new System.Windows.Forms.Label();
            this.COMBO_AnimalMadre = new System.Windows.Forms.ComboBox();
            this.COMBO_AnimalPadre = new System.Windows.Forms.ComboBox();
            this.DATEPICK_AnimalNacimiento = new System.Windows.Forms.DateTimePicker();
            this.RADIOGROUP_AnimalSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // RADIOGROUP_AnimalSexo
            // 
            this.RADIOGROUP_AnimalSexo.Controls.Add(this.RADIOBTN_AnimalSexoMacho);
            this.RADIOGROUP_AnimalSexo.Controls.Add(this.RADIOBTN_AnimalSexoHembra);
            this.RADIOGROUP_AnimalSexo.Controls.Add(this.TXT_AnimalSexo);
            this.RADIOGROUP_AnimalSexo.Location = new System.Drawing.Point(12, 245);
            this.RADIOGROUP_AnimalSexo.Name = "RADIOGROUP_AnimalSexo";
            this.RADIOGROUP_AnimalSexo.Size = new System.Drawing.Size(197, 53);
            this.RADIOGROUP_AnimalSexo.TabIndex = 38;
            this.RADIOGROUP_AnimalSexo.TabStop = false;
            // 
            // RADIOBTN_AnimalSexoMacho
            // 
            this.RADIOBTN_AnimalSexoMacho.AutoSize = true;
            this.RADIOBTN_AnimalSexoMacho.Location = new System.Drawing.Point(64, 31);
            this.RADIOBTN_AnimalSexoMacho.Name = "RADIOBTN_AnimalSexoMacho";
            this.RADIOBTN_AnimalSexoMacho.Size = new System.Drawing.Size(58, 17);
            this.RADIOBTN_AnimalSexoMacho.TabIndex = 13;
            this.RADIOBTN_AnimalSexoMacho.TabStop = true;
            this.RADIOBTN_AnimalSexoMacho.Text = "Macho";
            this.RADIOBTN_AnimalSexoMacho.UseVisualStyleBackColor = true;
            // 
            // RADIOBTN_AnimalSexoHembra
            // 
            this.RADIOBTN_AnimalSexoHembra.AutoSize = true;
            this.RADIOBTN_AnimalSexoHembra.Location = new System.Drawing.Point(5, 31);
            this.RADIOBTN_AnimalSexoHembra.Name = "RADIOBTN_AnimalSexoHembra";
            this.RADIOBTN_AnimalSexoHembra.Size = new System.Drawing.Size(62, 17);
            this.RADIOBTN_AnimalSexoHembra.TabIndex = 12;
            this.RADIOBTN_AnimalSexoHembra.TabStop = true;
            this.RADIOBTN_AnimalSexoHembra.Text = "Hembra";
            this.RADIOBTN_AnimalSexoHembra.UseVisualStyleBackColor = true;
            // 
            // TXT_AnimalSexo
            // 
            this.TXT_AnimalSexo.AutoSize = true;
            this.TXT_AnimalSexo.Location = new System.Drawing.Point(5, 16);
            this.TXT_AnimalSexo.Name = "TXT_AnimalSexo";
            this.TXT_AnimalSexo.Size = new System.Drawing.Size(34, 13);
            this.TXT_AnimalSexo.TabIndex = 11;
            this.TXT_AnimalSexo.Text = "Sexo:";
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.Location = new System.Drawing.Point(147, 396);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(64, 20);
            this.BTN_Registrar.TabIndex = 36;
            this.BTN_Registrar.Text = "Registrar";
            this.BTN_Registrar.UseVisualStyleBackColor = true;
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // TXT_AnimalPadre
            // 
            this.TXT_AnimalPadre.AutoSize = true;
            this.TXT_AnimalPadre.Location = new System.Drawing.Point(12, 343);
            this.TXT_AnimalPadre.Name = "TXT_AnimalPadre";
            this.TXT_AnimalPadre.Size = new System.Drawing.Size(38, 13);
            this.TXT_AnimalPadre.TabIndex = 34;
            this.TXT_AnimalPadre.Text = "Padre:";
            // 
            // TXT_AnimalMadre
            // 
            this.TXT_AnimalMadre.AutoSize = true;
            this.TXT_AnimalMadre.Location = new System.Drawing.Point(12, 300);
            this.TXT_AnimalMadre.Name = "TXT_AnimalMadre";
            this.TXT_AnimalMadre.Size = new System.Drawing.Size(40, 13);
            this.TXT_AnimalMadre.TabIndex = 32;
            this.TXT_AnimalMadre.Text = "Madre:";
            // 
            // TXT_AnimalNacimiento
            // 
            this.TXT_AnimalNacimiento.AutoSize = true;
            this.TXT_AnimalNacimiento.Location = new System.Drawing.Point(12, 203);
            this.TXT_AnimalNacimiento.Name = "TXT_AnimalNacimiento";
            this.TXT_AnimalNacimiento.Size = new System.Drawing.Size(96, 13);
            this.TXT_AnimalNacimiento.TabIndex = 30;
            this.TXT_AnimalNacimiento.Text = "Fecha Nacimiento:";
            // 
            // COMBO_AnimalRaza
            // 
            this.COMBO_AnimalRaza.FormattingEnabled = true;
            this.COMBO_AnimalRaza.Location = new System.Drawing.Point(12, 177);
            this.COMBO_AnimalRaza.Name = "COMBO_AnimalRaza";
            this.COMBO_AnimalRaza.Size = new System.Drawing.Size(198, 21);
            this.COMBO_AnimalRaza.TabIndex = 29;
            // 
            // TXT_AnimalRaza
            // 
            this.TXT_AnimalRaza.AutoSize = true;
            this.TXT_AnimalRaza.Location = new System.Drawing.Point(12, 161);
            this.TXT_AnimalRaza.Name = "TXT_AnimalRaza";
            this.TXT_AnimalRaza.Size = new System.Drawing.Size(35, 13);
            this.TXT_AnimalRaza.TabIndex = 28;
            this.TXT_AnimalRaza.Text = "Raza:";
            // 
            // COMBO_AnimalFinca
            // 
            this.COMBO_AnimalFinca.FormattingEnabled = true;
            this.COMBO_AnimalFinca.Location = new System.Drawing.Point(12, 135);
            this.COMBO_AnimalFinca.Name = "COMBO_AnimalFinca";
            this.COMBO_AnimalFinca.Size = new System.Drawing.Size(198, 21);
            this.COMBO_AnimalFinca.TabIndex = 27;
            // 
            // TXT_AnimalFinca
            // 
            this.TXT_AnimalFinca.AutoSize = true;
            this.TXT_AnimalFinca.Location = new System.Drawing.Point(12, 118);
            this.TXT_AnimalFinca.Name = "TXT_AnimalFinca";
            this.TXT_AnimalFinca.Size = new System.Drawing.Size(36, 13);
            this.TXT_AnimalFinca.TabIndex = 26;
            this.TXT_AnimalFinca.Text = "Finca:";
            // 
            // MSK_AnimalNombre
            // 
            this.MSK_AnimalNombre.Location = new System.Drawing.Point(12, 92);
            this.MSK_AnimalNombre.Name = "MSK_AnimalNombre";
            this.MSK_AnimalNombre.Size = new System.Drawing.Size(198, 20);
            this.MSK_AnimalNombre.TabIndex = 25;
            // 
            // TXT_AnimalNombre
            // 
            this.TXT_AnimalNombre.AutoSize = true;
            this.TXT_AnimalNombre.Location = new System.Drawing.Point(12, 76);
            this.TXT_AnimalNombre.Name = "TXT_AnimalNombre";
            this.TXT_AnimalNombre.Size = new System.Drawing.Size(47, 13);
            this.TXT_AnimalNombre.TabIndex = 24;
            this.TXT_AnimalNombre.Text = "Nombre:";
            // 
            // MSK_AnimalIdentificacion
            // 
            this.MSK_AnimalIdentificacion.Location = new System.Drawing.Point(12, 50);
            this.MSK_AnimalIdentificacion.Name = "MSK_AnimalIdentificacion";
            this.MSK_AnimalIdentificacion.Size = new System.Drawing.Size(198, 20);
            this.MSK_AnimalIdentificacion.TabIndex = 23;
            // 
            // TXT_AnimalIdentificacion
            // 
            this.TXT_AnimalIdentificacion.AutoSize = true;
            this.TXT_AnimalIdentificacion.Location = new System.Drawing.Point(9, 34);
            this.TXT_AnimalIdentificacion.Name = "TXT_AnimalIdentificacion";
            this.TXT_AnimalIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.TXT_AnimalIdentificacion.TabIndex = 22;
            this.TXT_AnimalIdentificacion.Text = "Identificacion:";
            // 
            // TXT_Info
            // 
            this.TXT_Info.AutoSize = true;
            this.TXT_Info.Location = new System.Drawing.Point(12, 7);
            this.TXT_Info.Name = "TXT_Info";
            this.TXT_Info.Size = new System.Drawing.Size(203, 13);
            this.TXT_Info.TabIndex = 21;
            this.TXT_Info.Text = "Por favor ingrese la siguiente informacion.";
            // 
            // COMBO_AnimalMadre
            // 
            this.COMBO_AnimalMadre.FormattingEnabled = true;
            this.COMBO_AnimalMadre.Location = new System.Drawing.Point(12, 316);
            this.COMBO_AnimalMadre.Name = "COMBO_AnimalMadre";
            this.COMBO_AnimalMadre.Size = new System.Drawing.Size(197, 21);
            this.COMBO_AnimalMadre.TabIndex = 39;
            // 
            // COMBO_AnimalPadre
            // 
            this.COMBO_AnimalPadre.FormattingEnabled = true;
            this.COMBO_AnimalPadre.Location = new System.Drawing.Point(12, 359);
            this.COMBO_AnimalPadre.Name = "COMBO_AnimalPadre";
            this.COMBO_AnimalPadre.Size = new System.Drawing.Size(197, 21);
            this.COMBO_AnimalPadre.TabIndex = 40;
            // 
            // DATEPICK_AnimalNacimiento
            // 
            this.DATEPICK_AnimalNacimiento.Location = new System.Drawing.Point(12, 219);
            this.DATEPICK_AnimalNacimiento.Name = "DATEPICK_AnimalNacimiento";
            this.DATEPICK_AnimalNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DATEPICK_AnimalNacimiento.TabIndex = 41;
            // 
            // Servidor_RegistrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 429);
            this.Controls.Add(this.DATEPICK_AnimalNacimiento);
            this.Controls.Add(this.COMBO_AnimalPadre);
            this.Controls.Add(this.COMBO_AnimalMadre);
            this.Controls.Add(this.RADIOGROUP_AnimalSexo);
            this.Controls.Add(this.BTN_Registrar);
            this.Controls.Add(this.TXT_AnimalPadre);
            this.Controls.Add(this.TXT_AnimalMadre);
            this.Controls.Add(this.TXT_AnimalNacimiento);
            this.Controls.Add(this.COMBO_AnimalRaza);
            this.Controls.Add(this.TXT_AnimalRaza);
            this.Controls.Add(this.COMBO_AnimalFinca);
            this.Controls.Add(this.TXT_AnimalFinca);
            this.Controls.Add(this.MSK_AnimalNombre);
            this.Controls.Add(this.TXT_AnimalNombre);
            this.Controls.Add(this.MSK_AnimalIdentificacion);
            this.Controls.Add(this.TXT_AnimalIdentificacion);
            this.Controls.Add(this.TXT_Info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor_RegistrarAnimal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Animal";
            this.Load += new System.EventHandler(this.Servidor_RegistrarAnimal_Load);
            this.RADIOGROUP_AnimalSexo.ResumeLayout(false);
            this.RADIOGROUP_AnimalSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RADIOGROUP_AnimalSexo;
        private System.Windows.Forms.RadioButton RADIOBTN_AnimalSexoMacho;
        private System.Windows.Forms.RadioButton RADIOBTN_AnimalSexoHembra;
        private System.Windows.Forms.Label TXT_AnimalSexo;
        private System.Windows.Forms.Button BTN_Registrar;
        private System.Windows.Forms.Label TXT_AnimalPadre;
        private System.Windows.Forms.Label TXT_AnimalMadre;
        private System.Windows.Forms.Label TXT_AnimalNacimiento;
        private System.Windows.Forms.ComboBox COMBO_AnimalRaza;
        private System.Windows.Forms.Label TXT_AnimalRaza;
        private System.Windows.Forms.ComboBox COMBO_AnimalFinca;
        private System.Windows.Forms.Label TXT_AnimalFinca;
        private System.Windows.Forms.MaskedTextBox MSK_AnimalNombre;
        private System.Windows.Forms.Label TXT_AnimalNombre;
        private System.Windows.Forms.MaskedTextBox MSK_AnimalIdentificacion;
        private System.Windows.Forms.Label TXT_AnimalIdentificacion;
        private System.Windows.Forms.Label TXT_Info;
        private System.Windows.Forms.ComboBox COMBO_AnimalMadre;
        private System.Windows.Forms.ComboBox COMBO_AnimalPadre;
        private System.Windows.Forms.DateTimePicker DATEPICK_AnimalNacimiento;
    }
}
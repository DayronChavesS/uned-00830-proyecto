/* UNIVERSIDAD ESTATAL A DISTANCIA DE COSTA RICA
 * VICERRECTORIA ACADEMICA
 * ESCUELA DE CIENCIAS EXACTAS Y NATURALES
 * CARRERA DE INGENIERIA INFORMATICA
 * 
 * PROYECTO
 * SISTEMA DE INFORMACION DE EMPRESA AGROGANADERA MI FINCA v3.0
 * 
 * GRUPO 03
 * PROFESOR GORGE CALVO SOLANO
 * 
 * DAYRON ANTONY CHAVES SANDOVAL
 * 305240018
 * 
 * CENTRO UNIVERSITARIO DE TURRIALBA
 * 
 * FECHA DE ENTREGA
 * 18 DE ABRIL DEL 2021
 *
 * PRIMER CUATRIMESTRE, 2021.
 */

using Servidor.CLASES;
using System;
using System.Windows.Forms;

namespace Servidor.GUI.Registro
{
    //este formulario permite que el usuario registre animales
    public partial class Servidor_RegistrarAnimal : Form
    {
        public Servidor_RegistrarAnimal()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Servidor_RegistrarAnimal_Load(object sender, EventArgs e)
        {
            //se obtiene informacion para los comboboxes
            ActualizarCombo();

            //se modifica el formato del DataPicker para coincidir con el de la base de datos
            DATEPICK_AnimalNacimiento.Format = DateTimePickerFormat.Custom;
            DATEPICK_AnimalNacimiento.CustomFormat = "yyyy-MM-dd";

            //se bloquea el comportamiento del combobox a solo seleccion
            COMBO_AnimalFinca.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBO_AnimalMadre.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBO_AnimalPadre.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBO_AnimalRaza.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ActualizarCombo()
        {
            //se obtiene informacion para el combobox finca
            Servidor.LOGICA.Metodo.CargarComboBox_Finca(COMBO_AnimalFinca);
            //se obtiene informacion para el combobox raza
            Servidor.LOGICA.Metodo.CargarComboBox_Raza(COMBO_AnimalRaza);
            //se obtiene informacion para el combobox madre
            Servidor.LOGICA.Metodo.CargarComboBox_Madre(COMBO_AnimalMadre);
            //se obtiene informacion para el combobox padre
            Servidor.LOGICA.Metodo.CargarComboBox_Padre(COMBO_AnimalPadre);
        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            //si la informacion digitada por el usuario es valida...
            if (Servidor.LOGICA.Metodo.ValidarRegistro_Animal(MSK_AnimalIdentificacion, MSK_AnimalNombre, COMBO_AnimalFinca, COMBO_AnimalRaza, DATEPICK_AnimalNacimiento, RADIOBTN_AnimalSexoHembra, RADIOBTN_AnimalSexoMacho, COMBO_AnimalMadre, COMBO_AnimalPadre) == true)
            {
                //se crea un objeto de tipo animal con la informacion obtenida
                Animal ObjAnimal = Servidor.LOGICA.Metodo.CrearObjeto_Animal(MSK_AnimalIdentificacion, MSK_AnimalNombre, COMBO_AnimalFinca, COMBO_AnimalRaza, DATEPICK_AnimalNacimiento, RADIOBTN_AnimalSexoHembra, RADIOBTN_AnimalSexoMacho, COMBO_AnimalMadre, COMBO_AnimalPadre);

                //si la informacion se inserta en la base de datos...
                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal) == true)
                {
                    //se muestra un mensaje de exito al usuario
                    DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otro animal?", "EXITO", MessageBoxButtons.YesNo);
                    //si el usuario escoge la opcion "No" en el mensaje
                    if (EXITO == DialogResult.No)
                    {
                        //se cierra el formulario
                        Close();
                    }
                    //si el usuario escoge la opcion "Si" en el mensaje
                    if (EXITO == DialogResult.Yes)
                    {
                        //se limpia el formulario
                        LimpiarFormulario();
                    }
                }
                else //si se falla en insertar la informacion en la base de datos
                {
                    //se limpia el formulario
                    LimpiarFormulario();
                }
            }
        }

        //este metodo limpia el formulario de la informacion que ingreso el usuario
        private void LimpiarFormulario()
        {
            MSK_AnimalIdentificacion.Clear();
            MSK_AnimalNombre.Clear();
            DATEPICK_AnimalNacimiento.Value = System.DateTime.Now;
            COMBO_AnimalMadre.SelectedIndex = 0;
            COMBO_AnimalPadre.SelectedIndex = 0;
            COMBO_AnimalFinca.SelectedIndex = 0;
            COMBO_AnimalRaza.SelectedIndex = 0;
            RADIOBTN_AnimalSexoHembra.Checked = false;
            RADIOBTN_AnimalSexoMacho.Checked = false;
        }
    }
}

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
    //este formulario permite que el usuario registre dueños
    public partial class Servidor_RegistrarDueño : Form
    {
        public Servidor_RegistrarDueño()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Servidor_RegistrarDueño_Load(object sender, EventArgs e)
        {
            //se obtiene informacion para los comboboxes
            ActualizarCombo();
        }

        private void ActualizarCombo()
        {
            //se obtiene informacion para el combobox finca
            Servidor.LOGICA.Metodo.CargarComboBox_Finca(COMBO_DueñoFinca);

            //se bloquea el comportamiento del combobox a solo seleccion
            COMBO_DueñoFinca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //al hacer click en el boton registrar
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            //si la informacion digitada por el usuario es valida...
            if (Servidor.LOGICA.Metodo.ValidarRegistro_Dueño(MSK_DueñoIdentificacion, MSK_DueñoNombre, MSK_DueñoPrimerApellido, MSK_DueñoSegundoApellido, MSK_DueñoCorreo, MSK_DueñoCelular, COMBO_DueñoFinca) == true)
            {
                //se crea un objeto de tipo animal con la informacion obtenida
                Dueño ObjDueño = Servidor.LOGICA.Metodo.CrearObjeto_Dueño(MSK_DueñoIdentificacion, MSK_DueñoNombre, MSK_DueñoPrimerApellido, MSK_DueñoSegundoApellido, MSK_DueñoCorreo, MSK_DueñoCelular, COMBO_DueñoFinca);
                //si la informacion se inserta en la base de datos...
                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarDueño(ObjDueño) == true)
                {
                    //se muestra un mensaje de exito al usuario
                    DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otro dueño?", "EXITO", MessageBoxButtons.YesNo);
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
                else//si se falla en insertar la informacion en la base de datos
                {
                    //se limpia el formulario
                    LimpiarFormulario();
                }
            }
        }

        //este metodo limpia el formulario de la informacion que ingreso el usuario
        private void LimpiarFormulario()
        {
            MSK_DueñoIdentificacion.Clear();
            MSK_DueñoNombre.Clear();
            MSK_DueñoPrimerApellido.Clear();
            MSK_DueñoSegundoApellido.Clear();
            MSK_DueñoCorreo.Clear();
            MSK_DueñoCelular.Clear();
            COMBO_DueñoFinca.SelectedIndex = 0;
        }
    }
}

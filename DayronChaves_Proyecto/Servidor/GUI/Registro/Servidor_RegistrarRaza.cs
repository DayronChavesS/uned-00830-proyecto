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
    //este formulario permite que el usuario registre razas
    public partial class Servidor_RegistrarRaza : Form
    {
        public Servidor_RegistrarRaza()
        {
            InitializeComponent();
        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            //si la informacion digitada por el usuario es valida...
            if (Servidor.LOGICA.Metodo.ValidarRegistro_Raza(MSK_CodigoRaza, MSK_DescripcionRaza) == true)
            {
                //se crea un objeto de tipo raza con la informacion obtenida
                Raza ObjRaza = Servidor.LOGICA.Metodo.CrearObjeto_Raza(MSK_CodigoRaza, MSK_DescripcionRaza);
                //si la informacion se inserta en la base de datos...
                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarRaza(ObjRaza) == true)
                {
                    //se muestra un mensaje de exito al usuario
                    DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otra raza?", "EXITO", MessageBoxButtons.YesNo);
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
                else
                {
                    //se limpia el formulario
                    LimpiarFormulario();
                }
            }
        }

        //este metodo limpia el formulario de la informacion que ingreso el usuario
        private void LimpiarFormulario()
        {
            MSK_CodigoRaza.Clear();
            MSK_DescripcionRaza.Clear();
        }
    }
}

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
    //este formulario permite que el usuario registre fincas
    public partial class Servidor_RegistrarFinca : Form
    {
        public Servidor_RegistrarFinca()
        {
            InitializeComponent();
        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            //si la informacion digitada por el usuario es valida...
            if (Servidor.LOGICA.Metodo.ValidarRegistro_Finca(MSK_FincaNumero, MSK_FincaNombre, MSK_FincaTamaño, MSK_FincaDireccion, MSK_FincaTelefono) == true)
            {
                //se crea un objeto de tipo finca con la informacion obtenida
                Finca ObjFinca = Servidor.LOGICA.Metodo.CrearObjeto_Finca(MSK_FincaNumero, MSK_FincaNombre, MSK_FincaTamaño, MSK_FincaDireccion, MSK_FincaTelefono);
                //si la informacion se inserta en la base de datos...
                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarFinca(ObjFinca) == true)
                {
                    //se muestra un mensaje de exito al usuario
                    DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otra finca?", "EXITO", MessageBoxButtons.YesNo);
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
            MSK_FincaNumero.Clear();
            MSK_FincaNombre.Clear();
            MSK_FincaTamaño.Clear();
            MSK_FincaDireccion.Clear();
            MSK_FincaTelefono.Clear();
        }
    }
}

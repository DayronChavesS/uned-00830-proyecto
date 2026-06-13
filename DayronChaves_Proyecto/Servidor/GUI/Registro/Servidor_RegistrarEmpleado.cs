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
    //este formulario permite que el usuario registre empleados
    public partial class Servidor_RegistrarEmpleado : Form
    {
        public Servidor_RegistrarEmpleado()
        {
            InitializeComponent();
        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            //si la informacion digitada por el usuario es valida...
            if (Servidor.LOGICA.Metodo.ValidarRegistro_Empleado(MSK_EmpleadoIdentificacion, MSK_EmpleadoNombre, MSK_EmpleadoPrimerApellido, MSK_EmpleadoSegundoApellido, MSK_EmpleadoSalario, MSK_EmpleadoUsuario, MSK_EmpleadoContraseña) == true)
            {
                //se crea un objeto de tipo empleado con la informacion obtenida
                Empleado ObjEmpleado = Servidor.LOGICA.Metodo.CrearObjeto_Empleado(MSK_EmpleadoIdentificacion, MSK_EmpleadoNombre, MSK_EmpleadoPrimerApellido, MSK_EmpleadoSegundoApellido, MSK_EmpleadoSalario, MSK_EmpleadoUsuario, MSK_EmpleadoContraseña);

                //si la informacion se inserta en la base de datos...
                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado(ObjEmpleado) == true)
                {
                    //se muestra un mensaje de exito al usuario
                    DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otro empleado?", "EXITO", MessageBoxButtons.YesNo);
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
                else  //si se falla en insertar la informacion en la base de datos
                {
                    //se limpia el formulario
                    LimpiarFormulario();
                }
            }
        }

        //este metodo limpia el formulario de la informacion que ingreso el usuario
        private void LimpiarFormulario()
        {
            MSK_EmpleadoIdentificacion.Clear();
            MSK_EmpleadoNombre.Clear();
            MSK_EmpleadoPrimerApellido.Clear();
            MSK_EmpleadoSegundoApellido.Clear();
            MSK_EmpleadoSalario.Clear();
            MSK_EmpleadoUsuario.Clear();
            MSK_EmpleadoContraseña.Clear();
        }
    }
}

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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cliente.GUI.Sesión
{
    public partial class Cliente_RegistrarEmpleado : Form
    {
        //este formulario permite que el usuario registre un nuevo empleado (desde el cliente)
        public Cliente_RegistrarEmpleado()
        {
            InitializeComponent();
        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si la informacion digitada por el usuario es valida...
                if (Cliente.LOGICA.Metodo.ValidarRegistro_Empleado(MSK_EmpleadoIdentificacion, MSK_EmpleadoNombre, MSK_EmpleadoPrimerApellido, MSK_EmpleadoSegundoApellido, MSK_EmpleadoSalario, MSK_EmpleadoUsuario, MSK_EmpleadoContraseña) == true)
                {
                    //se crea una coleccion generica que contiene todos los atributos del empleado
                    //(se omite el paso de crear el objeto ya que el cliente carece de la clase necesaria)
                    List<string> ListaAtributosEmpleado;
                    ListaAtributosEmpleado = Cliente.LOGICA.Metodo.CrearListaAtributosEmpleado(MSK_EmpleadoIdentificacion, MSK_EmpleadoNombre, MSK_EmpleadoPrimerApellido, MSK_EmpleadoSegundoApellido, MSK_EmpleadoSalario, MSK_EmpleadoUsuario, MSK_EmpleadoContraseña);

                    //si la informacion enviada al servidor se guarda exitosamente...
                    if (Cliente.CONEXION.ConexionClienteServidor.EnviarEmpleado(ListaAtributosEmpleado) == true)
                    {
                        //se muestra un mensaje de exito al usuario
                        DialogResult EXITO = MessageBox.Show("Se ha registrado exitosamente. El administrador debera validar su usuario para poder iniciar sesion.", "EXITO", MessageBoxButtons.OK);
                        //se cierra el formulario
                        Close();
                    }
                    else
                    {
                        LimpiarFormulario();
                    }
                }
            }
            else
            {
                this.Dispose();
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

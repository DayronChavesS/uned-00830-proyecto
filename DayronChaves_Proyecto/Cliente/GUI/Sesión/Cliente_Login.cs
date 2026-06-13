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
    //este formulario permite que el usuario inicie sesion
    public partial class Cliente_Login : Form
    {
        public Cliente_Login()
        {
            InitializeComponent();
        }

        //al hacer click en el boton iniciar sesion...
        private void BTN_IniciarSesion_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si la informacion digitada por el usuario es valida...
                if (Cliente.LOGICA.Metodo.Validar_Login(MSK_Usuario, MSK_Contraseña) == true)
                {
                    //se crea una lista con la informacion para enviar al servidor
                    List<string> InformacionUsuario = new List<string>();
                    InformacionUsuario.Add(MSK_Usuario.Text);
                    InformacionUsuario.Add(MSK_Contraseña.Text);

                    //si la informacion digitada por el usuario existe en la base de datos
                    if (Cliente.CONEXION.ConexionClienteServidor.IntentarLogin(InformacionUsuario) == true)
                    {
                        //se crea un nuevo formulario 
                        Cliente.GUI.Cliente_MenuPrincipal MenuPrincipal;
                        MenuPrincipal = new Cliente.GUI.Cliente_MenuPrincipal();
                        //se pasa el nombre de usuario al formulario
                        MenuPrincipal.CargarNombreDeUsuario(MSK_Usuario.Text);
                        //se muestra el formulario en pantalla
                        MenuPrincipal.Show();
                        //se cierra el formulario de inicio de sesion
                        Dispose();
                    }
                    else //si la informacion no existe...
                    {
                        //se envia un mensaje de error al usuario
                        DialogResult ERROR = MessageBox.Show("No se ha podido iniciar sesion.", "ERROR.", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                this.Dispose();
            }
        }

        //al hacer click en el boton registrarse...
        private void BTN_Registrarse_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //se crea un nuevo formulario 
                Cliente.GUI.Sesión.Cliente_RegistrarEmpleado RegistrarEmpleado;
                RegistrarEmpleado = new Cliente.GUI.Sesión.Cliente_RegistrarEmpleado();
                //se muestra el formulario en pantalla
                RegistrarEmpleado.Show();
                //se cierra el formulario de inicio de sesion
                Dispose();
            }
            else
            {
                this.Dispose();
            }
        }
    }
}

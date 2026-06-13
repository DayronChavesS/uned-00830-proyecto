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

using Servidor;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Principal
{
    //este formulario permite al usuario abrir el proyecto Cliente y proyecto Servidor
    public partial class Principal_MenuPrincipal : Form
    {
        public Principal_MenuPrincipal()
        {
            InitializeComponent();
        }

        //al hacer click en el boton salir...
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            //se muestra un mensaje informativo al usuario
            DialogResult confirmar = MessageBox.Show("¿Realmente desea salir?", "Confirmacion", MessageBoxButtons.YesNo);
            //si el usuario escoge la opcion "Si" en el mensaje
            if (confirmar == DialogResult.Yes)
            {
                //se cierra toda la solucion
                Process.GetCurrentProcess().Kill();
            }
        }

        //al hacer click en el boton crear servidor...
        private void BTN_CrearServidor_Click(object sender, EventArgs e)
        {
            //si el servidor no esta iniciado...
            if (Servidor.CONEXION.ConexionServidorCliente.ServidorIniciado == false)
            {
                //se crea un nuevo formulario 
                Servidor_MenuPrincipal NuevoServidor;
                NuevoServidor = new Servidor_MenuPrincipal();
                //se muestra el formulario en pantalla
                NuevoServidor.Show();
            }
            else //si el servidor ya estaba iniciado
            {
                //se envia un mensaje de error al usuario
                MessageBox.Show("El servidor ya esta iniciado.", "ERROR.", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton crear cliente...
        private void BTN_CrearCliente_Click(object sender, EventArgs e)
        {
            //se crea un nuevo formulario 
            Cliente.GUI.Sesión.Cliente_Login NuevoCliente;
            NuevoCliente = new Cliente.GUI.Sesión.Cliente_Login();
            //se muestra el formulario en pantalla

            if (Cliente.CONEXION.ConexionClienteServidor.ConectarAServidor() == true)
            {
                NuevoCliente.Show();
            }
        }
    }
}

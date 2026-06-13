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
using System.Timers;
using System.Windows.Forms;

namespace Servidor
{
    //este formulario permite al usuario abrir otros formularios en el proyecto servidor
    public partial class Servidor_MenuPrincipal : Form
    {
        System.Timers.Timer myTimer;

        public Servidor_MenuPrincipal()
        {
            InitializeComponent();
        }

        //Al cargar el formulario
        private void Servidor_MenuPrincipal_Load(object sender, EventArgs e)
        {
            //si no se puede conectar a la base de datos se cierra el formulario
            if (CONEXION.ConexionBaseDeDatos.ConectarBaseDeDatos() == false)
            {
                this.Dispose();
            }
            else
            {
                //se inicia el servidor para permitir la conexion de los clientes
                CONEXION.ConexionServidorCliente.IniciarServidor();
                //se crea la conexion con la base de datos
                //se crea un contador para actualizar de forma automatica la cantidad de clientes conectados
                myTimer = new System.Timers.Timer();
                myTimer.Elapsed += new ElapsedEventHandler(ActualizarClientesConectados);
                myTimer.Interval = 1000;
                myTimer.Start();
            }
        }

        //al hacer click en el boton apagar servidor...
        private void BTN_ApagarServidor_Click(object sender, EventArgs e)
        {
            //se detiene el servidor para no permitir la conexion de los clientes
            CONEXION.ConexionServidorCliente.DetenerServidor();
            //se cierra el formulario
            Dispose();
        }

        //al hacer click en el boton registrar finca...
        private void BTN_RegistrarFinca_Click(object sender, EventArgs e)
        {
            //se crea un nuevo formulario 
            Servidor.GUI.Registro.Servidor_RegistrarFinca NuevoRegistroFinca = new Servidor.GUI.Registro.Servidor_RegistrarFinca();
            //se muestra el formulario en pantalla
            NuevoRegistroFinca.Show();
        }

        //al hacer click en el boton registrar dueño...
        private void BTN_RegistrarDueño_Click(object sender, EventArgs e)
        {
            //si la tabla finca no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaFincaVacia() == false)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Registro.Servidor_RegistrarDueño NuevoRegistroDueño = new Servidor.GUI.Registro.Servidor_RegistrarDueño();
                //se muestra el formulario en pantalla
                NuevoRegistroDueño.Show();
            }
            else //si la tabla estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar fincas primero.", "ERROR", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton registrar empleado...
        private void BTN_RegistrarEmpleado_Click(object sender, EventArgs e)
        {
            //se crea un nuevo formulario 
            Servidor.GUI.Registro.Servidor_RegistrarEmpleado NuevoRegistroEmpleado = new Servidor.GUI.Registro.Servidor_RegistrarEmpleado();
            //se muestra el formulario en pantalla
            NuevoRegistroEmpleado.Show();
        }

        //al hacer click en el boton registrar raza...
        private void BTN_RegistrarRaza_Click(object sender, EventArgs e)
        {
            //se crea un nuevo formulario 
            Servidor.GUI.Registro.Servidor_RegistrarRaza NuevoRegistroRaza = new Servidor.GUI.Registro.Servidor_RegistrarRaza();
            //se muestra el formulario en pantalla
            NuevoRegistroRaza.Show();
        }

        //al hacer click en el boton registrar animal...
        private void BTN_RegistrarAnimal_Click(object sender, EventArgs e)
        {
            //si la tabla finca no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaFincaVacia() == false)
            {
                //si la tabla raza no esta vacia...
                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaRazaVacia() == false)
                {
                    //se crea un nuevo formulario 
                    Servidor.GUI.Registro.Servidor_RegistrarAnimal NuevoRegistroAnimal = new Servidor.GUI.Registro.Servidor_RegistrarAnimal();
                    //se muestra el formulario en pantalla
                    NuevoRegistroAnimal.Show();
                }
                else //si la tabla raza estaba vacia...
                {
                    //se envia un mensaje de error al usuario
                    DialogResult MensajeInformativo = MessageBox.Show("Debe registrar razas primero.", "ERROR", MessageBoxButtons.OK);
                }
            }
            else //si la tabla finca estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar fincas primero.", "ERROR", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton consultar fincas...
        private void BTN_ConsultarFincas_Click(object sender, EventArgs e)
        {
            //si la tabla finca no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaFincaVacia() == false)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Consulta.Servidor_ConsultarFinca NuevaConsultaFinca = new Servidor.GUI.Consulta.Servidor_ConsultarFinca();
                //se muestra el formulario en pantalla
                NuevaConsultaFinca.Show();
            }
            else //si la tabla estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar fincas primero.", "VACIO", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton consultar dueños...
        private void BTN_ConsultarDueños_Click(object sender, EventArgs e)
        {
            //si la tabla dueño no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaDueñoVacia() == false)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Consulta.Servidor_ConsultarDueño NuevaConsultaDueño = new Servidor.GUI.Consulta.Servidor_ConsultarDueño();
                //se muestra el formulario en pantalla
                NuevaConsultaDueño.Show();
            }
            else //si la tabla estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar dueños primero.", "VACIO", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton consultar empleados...
        private void BTN_ConsultarEmpleados_Click(object sender, EventArgs e)
        {
            //si la tabla empleado no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaEmpleadoVacia() == false)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Consulta.Servidor_ConsultarEmpleado NuevaConsultaEmpleado = new Servidor.GUI.Consulta.Servidor_ConsultarEmpleado();
                //se muestra el formulario en pantalla
                NuevaConsultaEmpleado.Show();
            }
            else //si la tabla estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar empleados primero.", "VACIO", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton consultar razas...
        private void BTN_ConsultarRazas_Click(object sender, EventArgs e)
        {
            //si la tabla raza no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaRazaVacia() == false)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Consulta.Servidor_ConsultarRaza NuevaConsultaRaza = new Servidor.GUI.Consulta.Servidor_ConsultarRaza();
                //se muestra el formulario en pantalla
                NuevaConsultaRaza.Show();
            }
            else //si la tabla estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar razas primero.", "VACIO", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton consultar animales...
        private void BTN_ConsultarAnimales_Click(object sender, EventArgs e)
        {
            //si la tabla animal no esta vacia...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaAnimalVacia() == false)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Consulta.Servidor_ConsultarAnimal NuevaConsultaAnimal = new Servidor.GUI.Consulta.Servidor_ConsultarAnimal();
                //se muestra el formulario en pantalla
                NuevaConsultaAnimal.Show();
            }
            else //si la tabla estaba vacia...
            {
                //se envia un mensaje de error al usuario
                DialogResult MensajeInformativo = MessageBox.Show("Debe registrar animales primero.", "VACIO", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton empleados pendientes...
        private void BTN_EmpleadosPendientes_Click(object sender, EventArgs e)
        {
            //se crea un nuevo formulario 
            Servidor.GUI.Otros.Servidor_EmpleadosPendientes NuevoEmpleadosPendientes = new Servidor.GUI.Otros.Servidor_EmpleadosPendientes();
            //se muestra el formulario en pantalla
            NuevoEmpleadosPendientes.Show();
        }

        //al hacer click en el boton eventos recientes...
        private void BTN_EventosRecientes_Click(object sender, EventArgs e)
        {
            if (Servidor.CONEXION.ConexionServidorCliente.ListaEventos.Count != 0)
            {
                //se crea un nuevo formulario 
                Servidor.GUI.Otros.Servidor_EventosRecientes NuevoEventosRecientes = new Servidor.GUI.Otros.Servidor_EventosRecientes();
                //se muestra el formulario en pantalla
                NuevoEventosRecientes.Show();
            }
            else
            {
                MessageBox.Show("No se ha registrado ningun evento.", "VACIO", MessageBoxButtons.OK);
            }
        }

        private void ActualizarClientesConectados(object source, ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            TXT_NumeroClientesConectados.Text = Servidor.CONEXION.ConexionServidorCliente.ClientesConectados.ToString();
            CheckForIllegalCrossThreadCalls = true;
        }
    }
}

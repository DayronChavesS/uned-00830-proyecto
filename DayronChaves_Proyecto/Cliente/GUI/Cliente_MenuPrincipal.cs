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
using System.Windows.Forms;

namespace Cliente.GUI
{
    //este formulario permite al usuario abrir otros formularios en el proyecto cliente
    public partial class Cliente_MenuPrincipal : Form
    {
        public Cliente_MenuPrincipal()
        {
            InitializeComponent();
        }

        //Al cargar el formulario
        private void Cliente_MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //se guarda el evento en la auditoria del servidor
                string NuevoEvento = TXT_NombreUsuario.Text + ", se conecto.";
                Cliente.CONEXION.ConexionClienteServidor.EnviarEvento(NuevoEvento);
            }
            else
            {
                this.Dispose();
            }
        }

        //al hacer click en el boton cerrar sesion...
        private void BTN_CerrarSesion_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //se guarda el evento en la auditoria del servidor
                string NuevoEvento = TXT_NombreUsuario.Text + ", se desconecto.";
                Cliente.CONEXION.ConexionClienteServidor.EnviarEvento(NuevoEvento);
                //se cierra el formulario
                Dispose();
            }
            else
            {
                this.Dispose();
            }
        }

        //al hacer click en el boton registrar vacuna...
        private void BTN_RegistrarVacuna_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si las tablas finca, animal y vacuna no estan vacias...
                if (Cliente.CONEXION.ConexionClienteServidor.TablaFincaEstaVacia() == false && Cliente.CONEXION.ConexionClienteServidor.TablaAnimalEstaVacia() == false && Cliente.CONEXION.ConexionClienteServidor.TablaVacunaEstaVacia() == false)
                {
                    //se crea un nuevo formulario 
                    Cliente.GUI.Registro.Cliente_RegistrarVacuna RegistrarVacuna;
                    RegistrarVacuna = new Cliente.GUI.Registro.Cliente_RegistrarVacuna();
                    //se pasa el nombre de usuario al formulario
                    RegistrarVacuna.CargarNombreDeUsuario(TXT_NombreUsuario.Text);
                    //se muestra el formulario en pantalla
                    RegistrarVacuna.Show();
                }
                else //si cualquiera de las tablas anteriores estaba vacia...
                {
                    //se envia un mensaje de error al usuario
                    DialogResult MensajeInformativo = MessageBox.Show("No hay suficiente informacion para realizar este proceso. Contacte al administrador.", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.Dispose();
            }
        }

        //al hacer click en el boton consultar vacuna...
        private void BTN_ConsultarVacuna_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si la tabla de vacunamientos no esta vacia...
                if (Cliente.CONEXION.ConexionClienteServidor.TablaVacunamientoEstaVacia() == false)
                {
                    //se guarda el evento en la auditoria del servidor
                    string NuevoEvento = TXT_NombreUsuario.Text + ", consulto vacunamientos.";
                    Cliente.CONEXION.ConexionClienteServidor.EnviarEvento(NuevoEvento);

                    //se crea un nuevo formulario 
                    Cliente.GUI.Consulta.Cliente_ConsultarVacunamiento ConsultarVacunamiento;
                    ConsultarVacunamiento = new Cliente.GUI.Consulta.Cliente_ConsultarVacunamiento();
                    //se muestra el formulario en pantalla
                    ConsultarVacunamiento.Show();
                }
                else //si la tabla estaba vacia...
                {
                    //se envia un mensaje de error al usuario
                    DialogResult MensajeInformativo = MessageBox.Show("Debe registrar vacunamientos primero.", "VACIO", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.Dispose();
            }
        }

        //al hacer click en el boton registrar tratamiento...
        private void BTN_RegistrarTratamiento_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si las tablas finca y animal no estan vacias...
                if (Cliente.CONEXION.ConexionClienteServidor.TablaFincaEstaVacia() == false && Cliente.CONEXION.ConexionClienteServidor.TablaAnimalEstaVacia() == false)
                {
                    //se crea un nuevo formulario 
                    Cliente.GUI.Registro.Cliente_RegistrarTratamiento RegistrarTratamiento;
                    RegistrarTratamiento = new Cliente.GUI.Registro.Cliente_RegistrarTratamiento();
                    //se pasa el nombre de usuario al formulario
                    RegistrarTratamiento.CargarNombreDeUsuario(TXT_NombreUsuario.Text);
                    //se muestra el formulario en pantalla
                    RegistrarTratamiento.Show();
                }
                else //si cualquiera de las tablas anteriores estaba vacia...
                {
                    //se envia un mensaje de error al usuario
                    DialogResult MensajeInformativo = MessageBox.Show("No hay suficiente informacion para realizar este proceso. Contacte al administrador.", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.Dispose();
            }
        }

        //al hacer click en el boton consultar tratamiento...
        private void BTN_ConsultarTratamiento_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si la tabla de tratamientos no esta vacia...
                if (Cliente.CONEXION.ConexionClienteServidor.TablaTratamientoEstaVacia() == false)
                {
                    //se guarda el evento en la auditoria del servidor
                    string NuevoEvento = TXT_NombreUsuario.Text + ", consulto tratamientos.";
                    Cliente.CONEXION.ConexionClienteServidor.EnviarEvento(NuevoEvento);

                    //se crea un nuevo formulario 
                    Cliente.GUI.Consulta.Cliente_ConsultarTratamiento ConsultarTratamiento;
                    ConsultarTratamiento = new Cliente.GUI.Consulta.Cliente_ConsultarTratamiento();

                    //se muestra el formulario en pantalla
                    ConsultarTratamiento.Show();
                }
                else //si la tabla estaba vacia...
                {
                    //se envia un mensaje de error al usuario
                    DialogResult MensajeInformativo = MessageBox.Show("Debe registrar tratamientos primero.", "VACIO", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.Dispose();
            }
        }

        //se obtiene el nombre de usuario para auditoria
        public void CargarNombreDeUsuario(string usuario)
        {
            TXT_NombreUsuario.Text = usuario;
        }
    }
}

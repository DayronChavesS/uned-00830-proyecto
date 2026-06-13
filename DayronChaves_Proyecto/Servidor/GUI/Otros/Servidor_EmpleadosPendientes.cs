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

namespace Servidor.GUI.Otros
{
    //este formulario permite que el usuario consulte los empleados
    //registrados a traves del cliente y pendientes de activacion
    public partial class Servidor_EmpleadosPendientes : Form
    {
        public Servidor_EmpleadosPendientes()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Servidor_EmpleadosPendientes_Load(object sender, EventArgs e)
        {
            //se bloquea el comportamiento del combobox a solo seleccion
            COMBO_EmpleadosPendientes.DropDownStyle = ComboBoxStyle.DropDownList;
            //se obtiene informacion para el combobox empleados pendientes
            ActualizarCombo();
            //si no hay empleados pendientes...
            if (COMBO_EmpleadosPendientes.Items.Count == 0)
            {
                MessageBox.Show("No hay empleados pendientes", "VACIO.", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        //al hacer click en el boton activar...
        private void BTN_Activar_Click(object sender, EventArgs e)
        {
            //se envia a actualizar el empleado seleccionado
            Servidor.CONEXION.ConexionBaseDeDatos.SQLActualizarEstadoEmpleado(COMBO_EmpleadosPendientes.SelectedItem.ToString());
            //se actualiza el combobox una vez mas
            ActualizarCombo();
        }

        private void ActualizarCombo()
        {
            //se carga el ComboBox Empleados Pendientes con informacion
            Servidor.LOGICA.Metodo.CargarComboBox_EmpleadosPendientes(COMBO_EmpleadosPendientes);
            if (COMBO_EmpleadosPendientes.Items.Count == 0)
            {
                COMBO_EmpleadosPendientes.Enabled = false;
                BTN_Activar.Enabled = false;
                TXT_Info.Text = "Ya no hay empleados pendientes.";
            }
        }
    }
}

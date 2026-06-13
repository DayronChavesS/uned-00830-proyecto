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

namespace Cliente.GUI.Registro
{
    //este formulario permite que el usuario registre vacunamientos
    public partial class Cliente_RegistrarVacuna : Form
    {
        private string NombreDeUsuario; //variable global para guardar el nombre de usuario
        public Cliente_RegistrarVacuna()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Cliente_RegistrarVacuna_Load(object sender, EventArgs e)
        {
            //se obtiene informacion para el combobox finca
            Cliente.LOGICA.Metodo.CargarComboBox_NumeroFinca(COMBO_Finca);

            //se bloquea el comportamiento de los combobox a solo seleccion
            COMBO_Finca.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBO_Animal.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBO_Vacuna.DropDownStyle = ComboBoxStyle.DropDownList;

            //se modifica el formato del DataPicker para coincidir con el de la base de datos
            DATEPICK_FechaAplicacion.Format = DateTimePickerFormat.Custom;
            DATEPICK_FechaAplicacion.CustomFormat = "yyyy-MM-dd";
        }

        //si el item seleccionado del ComboBox Finca cambia...
        private void COMBO_Finca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si este item no es nulo....
            if (COMBO_Finca.SelectedItem != null)
            {
                //se carga el ComboBox Animal, aplicando un filtro con base en la finca
                Cliente.LOGICA.Metodo.CargarComboBox_Animal(COMBO_Animal, COMBO_Finca.SelectedItem.ToString());
            }
        }

        //si el item seleccionado del ComboBox Animal cambia...
        private void COMBO_Animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si este item no es nulo....
            if (COMBO_Animal.SelectedItem != null)
            {
                //se carga el ComboBox Vacuna con informacion
                Cliente.LOGICA.Metodo.CargarComboBox_IdentificadorVacuna(COMBO_Vacuna);
            }

            //si el item seleccionado fue "Todos"
            if (COMBO_Animal.SelectedItem.ToString().Equals("Todos"))
            {
                //se envia una advertencia al usuario
                MessageBox.Show("Solo seleccione esta opcion si no ha registrado ninguna vacunacion para esa finca.", "ADVERTENCIA.", MessageBoxButtons.OK);
            }
        }

        //si el item seleccionado del ComboBox Vacuna cambia...
        private void COMBO_Vacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si este item no es nulo....
            if (COMBO_Vacuna.SelectedItem != null)
            {
                //se habilitan los demas controles del formulario
                DATEPICK_FechaAplicacion.Enabled = true;
                MSK_Enfermedad.Enabled = true;
                MSK_Observaciones.Enabled = true;
            }

        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si la informacion digitada por el usuario es valida...
                if (Cliente.LOGICA.Metodo.ValidarRegistro_Vacunamiento(COMBO_Finca, COMBO_Animal, COMBO_Vacuna, DATEPICK_FechaAplicacion, MSK_Enfermedad, MSK_Observaciones) == true)
                {
                    //se crea un objeto de tipo vacunamiento con la informacion obtenida
                    Cliente.CLASES.Vacunamiento ObjVacunamiento;
                    ObjVacunamiento = Cliente.LOGICA.Metodo.CrearObjeto_Vacunamiento(COMBO_Finca, COMBO_Animal, COMBO_Vacuna, DATEPICK_FechaAplicacion, MSK_Enfermedad, MSK_Observaciones);

                    //con la informacion del objeto se crea una coleccion generica que contiene todos los atributos
                    List<string> ListaAtributosVacunamiento;
                    ListaAtributosVacunamiento = Cliente.LOGICA.Metodo.CrearListaAtributosVacunamiento(ObjVacunamiento);

                    //si la informacion enviada al servidor se guarda exitosamente...
                    if (Cliente.CONEXION.ConexionClienteServidor.EnviarVacunamiento(ListaAtributosVacunamiento) == true)
                    {
                        //se guarda el evento en la auditoria del servidor
                        string NuevoEvento = NombreDeUsuario + ", registro vacunamiento.";
                        Cliente.CONEXION.ConexionClienteServidor.EnviarEvento(NuevoEvento);

                        //se muestra un mensaje de exito al usuario
                        DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otra vacuna?", "EXITO", MessageBoxButtons.YesNo);
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
                    else //si se falla en insertar la informacion en la base de datos
                    {
                        //se limpia el formulario
                        LimpiarFormulario();
                    }
                }
            }
            else
            {
                this.Dispose();
            }
        }

        //se obtiene el nombre de usuario para auditoria
        public void CargarNombreDeUsuario(string NombreParametro)
        {
            NombreDeUsuario = NombreParametro;
        }

        //este metodo limpia el formulario de la informacion que ingreso el usuario
        public void LimpiarFormulario()
        {
            COMBO_Finca.SelectedIndex = 0;
            COMBO_Animal.SelectedIndex = 0;
            COMBO_Vacuna.SelectedIndex = 0;
            DATEPICK_FechaAplicacion.Value = System.DateTime.Now;
            MSK_Enfermedad.Text = null;
            MSK_Observaciones.Text = null;
        }
    }
}

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
    //este formulario permite que el usuario registre tratamientos
    public partial class Cliente_RegistrarTratamiento : Form
    {
        private string NombreDeUsuario; //variable global para guardar el nombre de usuario

        public Cliente_RegistrarTratamiento()
        {
            InitializeComponent();
        }

        //Al cargar el formulario
        private void Cliente_RegistrarTratamiento_Load(object sender, EventArgs e)
        {
            //se bloquea el comportamiento de los combobox a solo seleccion
            COMBO_Finca.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBO_Animal.DropDownStyle = ComboBoxStyle.DropDownList;

            //se actualiza la informacion del ComboBox.
            Cliente.LOGICA.Metodo.CargarComboBox_NumeroFinca(COMBO_Finca);

            //se modifica el formato del DataPicker para coincidir con el de la base de datos
            DATEPICK_FechaTratamiento.Format = DateTimePickerFormat.Custom;
            DATEPICK_FechaTratamiento.CustomFormat = "yyyy-MM-dd";
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
                //se habilitan los demas controles del formulario
                DATEPICK_FechaTratamiento.Enabled = true;
                MSK_Diagnostico.Enabled = true;
                MSK_MedicamentoAplicado.Enabled = true;
                MSK_DiaTratamiento.Enabled = true;
                MSK_Observaciones.Enabled = true;
            }

            //si el item seleccionado fue "Todos"
            if (COMBO_Animal.SelectedItem.ToString().Equals("Todos"))
            {
                //se envia una advertencia al usuario
                MessageBox.Show("Solo seleccione esta opcion si no ha registrado ningun tratamiento para esa finca.", "ADVERTENCIA.", MessageBoxButtons.OK);
            }
        }

        //al hacer click en el boton registrar...
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (Cliente.CONEXION.ConexionClienteServidor.ServidorEstado() == true)
            {
                //si la informacion digitada por el usuario es valida...
                if (Cliente.LOGICA.Metodo.ValidarRegistro_Tratamiento(COMBO_Finca, COMBO_Animal, DATEPICK_FechaTratamiento, MSK_Diagnostico, MSK_MedicamentoAplicado, MSK_DiaTratamiento, MSK_Observaciones) == true)
                {
                    //se crea un objeto de tipo tratamiento con la informacion obtenida
                    Cliente.CLASES.Tratamiento ObjTratamiento;
                    ObjTratamiento = Cliente.LOGICA.Metodo.CrearObjeto_Tratamiento(COMBO_Finca, COMBO_Animal, DATEPICK_FechaTratamiento, MSK_Diagnostico, MSK_MedicamentoAplicado, MSK_DiaTratamiento, MSK_Observaciones);

                    //con la informacion del objeto se crea una coleccion generica que contiene todos los atributos
                    List<string> ListaAtributosTratamiento;
                    ListaAtributosTratamiento = Cliente.LOGICA.Metodo.CrearListaAtributosTratamiento(ObjTratamiento);

                    //si la informacion enviada al servidor se guarda exitosamente...
                    if (Cliente.CONEXION.ConexionClienteServidor.EnviarTratamiento(ListaAtributosTratamiento) == true)
                    {
                        //se guarda el evento en la auditoria del servidor
                        string NuevoEvento = NombreDeUsuario + ", registro tratamiento.";
                        Cliente.CONEXION.ConexionClienteServidor.EnviarEvento(NuevoEvento);

                        //se muestra un mensaje de exito al usuario
                        DialogResult EXITO = MessageBox.Show("La informacion ha sido registrada. ¿Desea ingresar otro tratamiento?", "EXITO", MessageBoxButtons.YesNo);
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
        private void LimpiarFormulario()
        {
            COMBO_Finca.SelectedIndex = 0;
            COMBO_Animal.SelectedIndex = 0;
            DATEPICK_FechaTratamiento.Value = System.DateTime.Now;
            MSK_Diagnostico.Text = null;
            MSK_MedicamentoAplicado.Text = null;
            MSK_DiaTratamiento.Text = null;
            MSK_Observaciones.Text = null;
        }
    }
}


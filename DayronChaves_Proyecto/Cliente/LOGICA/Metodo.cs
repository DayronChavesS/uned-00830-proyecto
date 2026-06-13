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

using Cliente.CLASES;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cliente.LOGICA
{
    //la siguiente clase contiene una biblioteca de metodos necesarios para que el programa funcione correctamente
    //la clase es publica  y todos los metodos son estaticos para que pueda ser usada desde cualquier lugar sin necesidad de instancias
    public class Metodo
    {

        /* Metodos Validar Registro:
         * Los siguientes metodos se encargan de validar los datos introducidos por el usuario
         * de confirmadad con los requerimientos de la base de datos.
         */

        //validar el registro de empleado
        public static bool ValidarRegistro_Empleado(MaskedTextBox MSK_EmpleadoIdentificacion, MaskedTextBox MSK_EmpleadoNombre, MaskedTextBox MSK_EmpleadoPrimerApellido, MaskedTextBox MSK_EmpleadoSegundoApellido, MaskedTextBox MSK_EmpleadoSalario, MaskedTextBox MSK_EmpleadoUsuario, MaskedTextBox MSK_EmpleadoContraseña)
        {
            bool valido = true;

            //si los MaskedTextBox no estan vacios...
            if (!MSK_EmpleadoIdentificacion.Text.Equals("") && !MSK_EmpleadoNombre.Text.Equals("") && !MSK_EmpleadoPrimerApellido.Text.Equals("") && !MSK_EmpleadoSegundoApellido.Text.Equals("") && !MSK_EmpleadoSalario.Text.Equals("") && !MSK_EmpleadoUsuario.Text.Equals("") && !MSK_EmpleadoContraseña.Text.Equals(""))
            {
                //si los tipos de datos son validos...
                if (MSK_EmpleadoIdentificacion.Text.All(char.IsDigit) && MSK_EmpleadoSalario.Text.All(char.IsDigit))
                {
                    valido = true; //la informacion es valida
                }
                //si no se cumple alguna de las condiciones anteriores la informacion es invalida y se informa al usuario
                else
                {
                    DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un tipo de dato invalido.", "ERROR.", MessageBoxButtons.OK);
                    valido = false;
                }
            }
            else
            {
                DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un MaskedTextBox vacio.", "ERROR.", MessageBoxButtons.OK);
                valido = false;
            }

            return valido;
        }

        //validar el registro de tratamiento
        public static bool ValidarRegistro_Tratamiento(ComboBox COMBO_Finca, ComboBox COMBO_Animal, DateTimePicker DATEPICK_FechaTratamiento, MaskedTextBox MSK_Diagnostico, MaskedTextBox MSK_MedicamentoAplicado, MaskedTextBox MSK_DiaTratamiento, MaskedTextBox MSK_Observaciones)
        {
            bool valido = true;

            //si no hay ComboBox nulos...
            if (COMBO_Animal.SelectedItem != null || COMBO_Finca.SelectedItem != null)
            {
                //si los MaskedTextBox no estan vacios...
                if (!MSK_Diagnostico.Text.Equals("") || !MSK_MedicamentoAplicado.Text.Equals("") || !MSK_DiaTratamiento.Text.Equals("") || !MSK_Observaciones.Text.Equals(""))
                {
                    //si los tipos de datos son validos...
                    if (MSK_DiaTratamiento.Text.All(char.IsDigit))
                    {
                        //se crea una lista para enviar al servidor
                        List<string> FincaYAnimal = new List<string>();
                        FincaYAnimal.Add(COMBO_Finca.Text);
                        FincaYAnimal.Add(COMBO_Animal.Text);

                        //si el animal es de esa finca...
                        if (Cliente.CONEXION.ConexionClienteServidor.AnimalEsDeFinca(FincaYAnimal) == true)
                        {
                            valido = true;  //la informacion es valida
                        }
                        else
                        {
                            DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado una inconsistencia entre la finca y el animal.", "ERROR.", MessageBoxButtons.OK);
                            valido = false;
                        }
                    }
                    //si no se cumple alguna de las condiciones anteriores la informacion es invalida y se informa al usuario
                    else
                    {
                        DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un tipo de dato invalido.", "ERROR.", MessageBoxButtons.OK);
                        valido = false;
                    }
                }
                else
                {
                    DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un MaskedTextBox vacio.", "ERROR.", MessageBoxButtons.OK);
                    valido = false;
                }
            }
            else
            {
                DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un ComboBox vacio.", "ERROR.", MessageBoxButtons.OK);
                valido = false;
            }
            return valido;
        }

        //validar el registro de vacunamiento
        public static bool ValidarRegistro_Vacunamiento(ComboBox COMBO_Finca, ComboBox COMBO_Animal, ComboBox COMBO_Vacuna, DateTimePicker DATEPICK_FechaAplicacion, MaskedTextBox MSK_Enfermedad, MaskedTextBox MSK_Observaciones)
        {
            bool valido = true;

            //si no hay ComboBox nulos...
            if (COMBO_Animal.SelectedItem != null || COMBO_Finca.SelectedItem != null)
            {
                //si los MaskedTextBox no estan vacios...
                if (!MSK_Enfermedad.Text.Equals("") || !MSK_Observaciones.Text.Equals(""))
                {
                    //se crea una lista para enviar al servidor
                    List<string> FincaYAnimal = new List<string>();
                    FincaYAnimal.Add(COMBO_Finca.Text);
                    FincaYAnimal.Add(COMBO_Animal.Text);

                    //si el animal es de esa finca...
                    if (Cliente.CONEXION.ConexionClienteServidor.AnimalEsDeFinca(FincaYAnimal) == true)
                    {
                        valido = true;  //la informacion es valida
                    }
                    else
                    {
                        DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado una inconsistencia entre la finca y el animal.", "ERROR.", MessageBoxButtons.OK);
                        valido = false;
                    }
                }
                //si no se cumple alguna de las condiciones anteriores la informacion es invalida y se informa al usuario
                else
                {
                    DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un MaskedTextBox vacio.", "ERROR.", MessageBoxButtons.OK);
                    valido = false;
                }
            }
            else
            {
                DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado un ComboBox vacio.", "ERROR.", MessageBoxButtons.OK);
                valido = false;
            }
            return valido;
        }

        //validar el login
        public static bool Validar_Login(MaskedTextBox MSK_Usuario, MaskedTextBox MSK_Contraseña)
        {
            bool valido = false;

            //si los MaskedTextBox no estan vacios...
            if (!MSK_Usuario.Text.Equals("") || !MSK_Contraseña.Text.Equals(""))
            {
                valido = true;  //la informacion es valida
            }
            //si no se cumple la condicion anterior la informacion es invalida y se informa al usuario
            else
            {
                DialogResult MensajeInformativo = MessageBox.Show("Se ha detectado MaskedTextBox vacios", "ERROR", MessageBoxButtons.OK);
                valido = false;
            }

            return valido;
        }

        /* Metodos CrearListaAtributosX
         * Estos metodos crean colecciones genericas que contienen los atributos de un objeto especifco.
         * Esto es necesario ya que la aplicacion del servidor no contiene las clases necesarias
         * para entender los objetos de tipo Vacuna, Vacunamiento y Tratamiento.
         * Lo mismo aplicaria en sentido contrario.
         */

        //crear coleccion generica con los atributos de empleado
        public static List<string> CrearListaAtributosEmpleado(MaskedTextBox MSK_EmpleadoIdentificacion, MaskedTextBox MSK_EmpleadoNombre, MaskedTextBox MSK_EmpleadoPrimerApellido, MaskedTextBox MSK_EmpleadoSegundoApellido, MaskedTextBox MSK_EmpleadoSalario, MaskedTextBox MSK_EmpleadoUsuario, MaskedTextBox MSK_EmpleadoContraseña)
        {
            //se declara la coleccion generica
            List<string> AtributosEmpleado = new List<string>();

            //el estado del empleado siempre es 0 si se crea desde el cliente
            int estado = 0;

            //se añade a la coleccion generica toda la informacion recibida por parametro
            AtributosEmpleado.Add(MSK_EmpleadoIdentificacion.Text);
            AtributosEmpleado.Add(MSK_EmpleadoNombre.Text);
            AtributosEmpleado.Add(MSK_EmpleadoPrimerApellido.Text);
            AtributosEmpleado.Add(MSK_EmpleadoSegundoApellido.Text);
            AtributosEmpleado.Add(MSK_EmpleadoSalario.Text);
            AtributosEmpleado.Add(MSK_EmpleadoUsuario.Text);
            AtributosEmpleado.Add(MSK_EmpleadoContraseña.Text);
            AtributosEmpleado.Add(estado.ToString());

            //se retorna la coleccion generica
            return AtributosEmpleado;
        }

        //crear coleccion generica con los atributos de vacuna
        public static List<string> CrearListaAtributosVacuna(Vacuna ObjVacuna)
        {
            //se declara la coleccion generica
            List<string> AtributosVacuna = new List<string>
            {

                //se añade a la coleccion generica toda la informacion recibida por parametro
                ObjVacuna.VacunaIdentificador.ToString(),
                ObjVacuna.VacunaDescripcion
            };

            //se retorna la coleccion generica
            return AtributosVacuna;
        }

        //crear coleccion generica con los atributos de vacunamiento
        public static List<string> CrearListaAtributosVacunamiento(Vacunamiento ObjVacunamiento)
        {
            //se declara la coleccion generica
            List<string> AtributosVacunamiento = new List<string>
            {

                //se añade a la coleccion generica toda la informacion recibida por parametro
                ObjVacunamiento.VacunamientoAnimal.ToString(),
                ObjVacunamiento.VacunamientoVacuna.ToString(),
                ObjVacunamiento.VacunamientoFecha,
                ObjVacunamiento.VacunamientoEnfermedad,
                ObjVacunamiento.VacunamientoObservaciones,
                ObjVacunamiento.VacunamientoFinca.ToString()
            };

            //se retorna la coleccion generica
            return AtributosVacunamiento;
        }

        //crear coleccion generica con los atributos de tratamiento
        public static List<string> CrearListaAtributosTratamiento(Tratamiento ObjTratamiento)
        {
            //se declara la coleccion generica
            List<string> AtributosTratamiento = new List<string>
            {

                //se añade a la coleccion generica toda la informacion recibida por parametro
                ObjTratamiento.TratamientoAnimal.ToString(),
                ObjTratamiento.TratamientoFecha,
                ObjTratamiento.TratamientoDiagnostico,
                ObjTratamiento.TratamientoMedicamento,
                ObjTratamiento.TratamientoDias.ToString(),
                ObjTratamiento.TratamientoObservaciones,
                ObjTratamiento.TratamientoFinca.ToString()
            };

            //se retorna la coleccion generica
            return AtributosTratamiento;
        }

        /* Metodos Crear Objeto:
         * Los siguientes metodos se encargan de crear los objetos mediante constructores
         * Con la informacion obtenida de los formularios.
         * Los metodos existen para no llenar los formularios de demasiado codigo.
         */

        //crear un objeto tratamiento
        public static Tratamiento CrearObjeto_Tratamiento(ComboBox COMBO_Finca, ComboBox COMBO_Animal, DateTimePicker DATEPICK_FechaTratamiento, MaskedTextBox MSK_Diagnostico, MaskedTextBox MSK_MedicamentoAplicado, MaskedTextBox MSK_DiaTratamiento, MaskedTextBox MSK_Observaciones)
        {
            //se declara el objeto
            Tratamiento ObjTratamiento;

            //se construye el objeto con la informacion obtenida por parametro
            ObjTratamiento = new Tratamiento
            {
                TratamientoFecha = DATEPICK_FechaTratamiento.Text.ToString(),
                TratamientoDiagnostico = MSK_Diagnostico.Text.ToString(),
                TratamientoMedicamento = MSK_MedicamentoAplicado.Text.ToString(),
                TratamientoDias = int.Parse(MSK_DiaTratamiento.Text.ToString()),
                TratamientoObservaciones = MSK_Observaciones.Text.ToString(),
                TratamientoFinca = int.Parse(COMBO_Finca.SelectedItem.ToString())
            };

            //si el item seleccionado en el combo box animal no es "Todos"...
            if (!COMBO_Animal.SelectedItem.ToString().Equals("Todos"))
            {
                //se obtiene el valor seleccionado del combo box
                ObjTratamiento.TratamientoAnimal = int.Parse(COMBO_Animal.SelectedItem.ToString());
            }
            else //si es "Todos"....
            {
                //se setea en el atributo un valor clave
                ObjTratamiento.TratamientoAnimal = -999999999;
            }

            //se retorna el objeto
            return ObjTratamiento;
        }

        //crear un objeto vacuna
        public static Vacuna CrearObjeto_Vacuna(int Identificador, string Descripcion)
        {
            //se declara el objeto
            Vacuna ObjVacuna;

            //se construye el objeto con la informacion obtenida por parametro
            ObjVacuna = new Vacuna
            {
                VacunaIdentificador = Identificador,
                VacunaDescripcion = Descripcion
            };

            //se retorna el objeto
            return ObjVacuna;
        }

        //crear un objeto vacunamiento
        public static Vacunamiento CrearObjeto_Vacunamiento(ComboBox COMBO_Finca, ComboBox COMBO_Animal, ComboBox COMBO_Vacuna, DateTimePicker DATEPICK_FechaAplicacion, MaskedTextBox MSK_Enfermedad, MaskedTextBox MSK_Observaciones)
        {
            //se declara el objeto
            Vacunamiento ObjVacunamiento;

            //se construye el objeto con la informacion obtenida por parametro
            ObjVacunamiento = new Vacunamiento
            {

                VacunamientoVacuna = int.Parse(COMBO_Vacuna.SelectedItem.ToString()),
                VacunamientoFecha = DATEPICK_FechaAplicacion.Text.ToString(),
                VacunamientoEnfermedad = MSK_Enfermedad.Text.ToString(),
                VacunamientoObservaciones = MSK_Observaciones.Text.ToString(),
                VacunamientoFinca = int.Parse(COMBO_Finca.SelectedItem.ToString())
            };

            //si el item seleccionado en el combo box animal no es "Todos"...
            if (!COMBO_Animal.SelectedItem.ToString().Equals("Todos"))
            {
                //se obtiene el valor seleccionado del combo box
                ObjVacunamiento.VacunamientoAnimal = int.Parse(COMBO_Animal.SelectedItem.ToString());
            }
            else //si es "Todos"....
            {
                //se setea en el atributo un valor clave
                ObjVacunamiento.VacunamientoAnimal = -999999999;
            }

            //se retorna el objeto
            return ObjVacunamiento;
        }

        ///DEL CLIENTE///

        //cargar combobox finca con identificadores
        public static ComboBox CargarComboBox_NumeroFinca(ComboBox COMBO_Finca)
        {
            //se solicita todos los numeros de finca guardados en la base de datos 
            //se setea la fuente de datos del combo box con la coleccion retornada
            COMBO_Finca.DataSource = Cliente.CONEXION.ConexionClienteServidor.RecibirFincas();
            return COMBO_Finca;
        }

        //cargar combobox animal con identificadores de animal
        public static ComboBox CargarComboBox_Animal(ComboBox COMBO_Animal, string Finca)
        {
            //se solicita por medio del servidor todos los identificadores de animales
            //se guardan en una coleccion generica
            List<string> ListaAnimal = Cliente.CONEXION.ConexionClienteServidor.RecibirAnimales();
            //se añade la opcion "Todos"
            ListaAnimal.Add("Todos");
            //se setea la fuente de datos del combo box con la coleccion generica
            COMBO_Animal.DataSource = ListaAnimal;
            return COMBO_Animal;
        }

        //cargar combobox vacuna con identificadores
        public static ComboBox CargarComboBox_IdentificadorVacuna(ComboBox COMBO_Vacuna)
        {
            //se solicita todos los identificadores de vacuna guardados en la base de datos
            //se guardan en una coleccion generica
            List<int> ListaVacunas = Cliente.CONEXION.ConexionClienteServidor.RecibirVacunas();
            //se setea la fuente de datos del combo box con la coleccion generica
            COMBO_Vacuna.DataSource = ListaVacunas;
            return COMBO_Vacuna;
        }
    }
}

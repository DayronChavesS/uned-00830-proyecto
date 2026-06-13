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
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Servidor.LOGICA
{

    //la siguiente clase contiene una biblioteca de metodos necesarios para que el programa funcione correctamente
    //la clase es publica y todos los metodos son estaticos para que pueda ser usada desde cualquier lugar sin necesidad de instancias
    public class Metodo
    {

        /*Metodos Validar Registro:
         * Los siguientes metodos se encargan de validar los datos introducidos por el usuario
         * de confirmadad con los requerimientos de la base de datos.
         */

        //validar el registro de finca
        public static bool ValidarRegistro_Finca(MaskedTextBox MSK_FincaNumero, MaskedTextBox MSK_FincaNombre, MaskedTextBox MSK_FincaTamaño, MaskedTextBox MSK_FincaDireccion, MaskedTextBox MSK_FincaTelefono)
        {
            bool valido = true;

            //si los MaskedTextBox no estan vacios...
            if (!MSK_FincaNumero.Text.Equals("") && !MSK_FincaNombre.Text.Equals("") && !MSK_FincaTamaño.Text.Equals("") && !MSK_FincaDireccion.Text.Equals("") && !MSK_FincaTelefono.Text.Equals(""))
            {
                //si los tipos de datos son validos...
                if (MSK_FincaNumero.Text.All(char.IsDigit) && MSK_FincaTamaño.Text.All(char.IsDigit) && MSK_FincaTelefono.Text.All(char.IsDigit))
                {
                    valido = true;//la informacion es valida
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

        //validar el registro de dueño
        public static bool ValidarRegistro_Dueño(MaskedTextBox MSK_DueñoIdentificacion, MaskedTextBox MSK_DueñoNombre, MaskedTextBox MSK_DueñoPrimerApellido, MaskedTextBox MSK_DueñoSegundoApellido, MaskedTextBox MSK_DueñoCorreo, MaskedTextBox MSK_DueñoCelular, ComboBox COMBO_DueñoFinca)
        {
            bool valido = true;

            //si no hay ComboBox nulos...
            if (COMBO_DueñoFinca.SelectedItem != null)
            {
                //si los MaskedTextBox no estan vacios...
                if (!MSK_DueñoIdentificacion.Text.Equals("") && !MSK_DueñoNombre.Text.Equals("") && !MSK_DueñoPrimerApellido.Text.Equals("") && !MSK_DueñoSegundoApellido.Text.Equals("") && !MSK_DueñoCorreo.Text.Equals("") && !MSK_DueñoCelular.Text.Equals(""))
                {
                    //si los tipos de datos son validos...
                    if (MSK_DueñoIdentificacion.Text.All(char.IsDigit) && MSK_DueñoCelular.Text.All(char.IsDigit))
                    {
                        valido = true;//la informacion es valida
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
                    valido = true;//la informacion es valida
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

        //validar el registro de raza
        public static bool ValidarRegistro_Raza(MaskedTextBox MSK_CodigoRaza, MaskedTextBox MSK_DescripcionRaza)
        {
            bool valido = true;

            //si los MaskedTextBox no estan vacios...
            if (!MSK_CodigoRaza.Text.Equals("") && !MSK_DescripcionRaza.Text.Equals(""))
            {
                //si los tipos de datos son validos...
                if (MSK_CodigoRaza.Text.All(char.IsDigit))
                {
                    valido = true;//la informacion es valida
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

        //validar el registro de animal
        public static bool ValidarRegistro_Animal(MaskedTextBox MSK_AnimalIdentificacion, MaskedTextBox MSK_AnimalNombre, ComboBox COMBO_AnimalFinca, ComboBox COMBO_AnimalRaza, DateTimePicker DATEPICK_AnimalNacimiento, RadioButton RADIOBTN_AnimalSexoHembra, RadioButton RADIOBTN_AnimalSexoMacho, ComboBox COMBO_AnimalMadre, ComboBox COMBO_AnimalPadre)
        {
            bool valido = true;

            //si no hay ComboBox nulos...
            if (COMBO_AnimalFinca.SelectedItem != null && COMBO_AnimalRaza.SelectedItem != null)
            {
                //si los MaskedTextBox no estan vacios...
                if (!MSK_AnimalIdentificacion.Text.Equals("") && !MSK_AnimalNombre.Text.Equals(""))
                {
                    //si no hay RadioButtons sin seleccionar...
                    if (RADIOBTN_AnimalSexoHembra.Checked == true || RADIOBTN_AnimalSexoMacho.Checked == true)
                    {
                        //si los tipos de datos son validos...
                        if (MSK_AnimalIdentificacion.Text.All(char.IsDigit))
                        {
                            //si el padre es un macho...
                            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLEsteAnimalEsMacho(COMBO_AnimalPadre.SelectedItem.ToString()) == true)
                            {
                                //si la madre es una hembra...
                                if (Servidor.CONEXION.ConexionBaseDeDatos.SQLEsteAnimalEsHembra(COMBO_AnimalMadre.SelectedItem.ToString()) == true)
                                {
                                    valido = true;//la informacion es valida
                                }
                                else //si no se cumple alguna de las condiciones anteriores la informacion es invalida y se informa al usuario
                                {
                                    DialogResult MensajeInfomativo = MessageBox.Show("La madre que selecciono no es una hembra.", "ERROR.", MessageBoxButtons.OK);
                                    valido = false;
                                }
                            }
                            else
                            {
                                DialogResult MensajeInfomativo = MessageBox.Show("El padre que selecciono no es un macho.", "ERROR.", MessageBoxButtons.OK);
                                valido = false;
                            }
                        }
                        else
                        {
                            DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado tipo de datos invalidos.", "ERROR.", MessageBoxButtons.OK);
                            valido = false;
                        }
                    }
                    else
                    {
                        DialogResult MensajeInfomativo = MessageBox.Show("Se ha detectado RadioButtons sin seleccionar.", "ERROR.", MessageBoxButtons.OK);
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

        /*Metodos Crear Objeto:
         * Los siguientes metodos se encargan de crear los objetos mediante los constructores.
         * Con la informacion obtenida de los formularios.
         * Estos metodos se crean para no llenar de codigo extra no relacionado a los formularios.
         */

        //crear un objeto finca
        public static Finca CrearObjeto_Finca(MaskedTextBox MSK_FincaNumero, MaskedTextBox MSK_FincaNombre, MaskedTextBox MSK_FincaTamaño, MaskedTextBox MSK_FincaDireccion, MaskedTextBox MSK_FincaTelefono)
        {
            //se declara el objeto
            Finca ObjFinca;

            //se construye el objeto con la informacion obtenida por parametro
            ObjFinca = new Finca
            {
                FincaNumero = int.Parse(MSK_FincaNumero.Text.ToString()),
                FincaNombre = MSK_FincaNombre.Text.ToString(),
                FincaTamaño = int.Parse(MSK_FincaTamaño.Text.ToString()),
                FincaDireccion = MSK_FincaDireccion.Text.ToString(),
                FincaTelefono = int.Parse(MSK_FincaTelefono.Text.ToString())
            };

            //se retorna el objeto
            return ObjFinca;
        }

        //crear un objeto dueño
        public static Dueño CrearObjeto_Dueño(MaskedTextBox MSK_DueñoIdentificacion, MaskedTextBox MSK_DueñoNombre, MaskedTextBox MSK_DueñoPrimerApellido, MaskedTextBox MSK_DueñoSegundoApellido, MaskedTextBox MSK_DueñoCorreo, MaskedTextBox MSK_DueñoCelular, ComboBox COMBO_DueñoFinca)
        {
            //se declara el objeto
            Dueño ObjDueño;

            //se construye el objeto con la informacion obtenida por parametro
            ObjDueño = new Dueño
            {
                PersonaIdentificacion = int.Parse(MSK_DueñoIdentificacion.Text.ToString()),
                PersonaNombre = MSK_DueñoNombre.Text.ToString(),
                PersonaPrimerApellido = MSK_DueñoPrimerApellido.Text.ToString(),
                PersonaSegundoApellido = MSK_DueñoSegundoApellido.Text.ToString(),
                DueñoCorreo = MSK_DueñoCorreo.Text.ToString(),
                DueñoCelular = int.Parse(MSK_DueñoCelular.Text.ToString()),
                DueñoFinca = Convertir_NombreFincaANumeroFinca(COMBO_DueñoFinca)
            };

            //se retorna el objeto
            return ObjDueño;
        }

        //crear un objeto empleado
        public static Empleado CrearObjeto_Empleado(MaskedTextBox MSK_EmpleadoIdentificacion, MaskedTextBox MSK_EmpleadoNombre, MaskedTextBox MSK_EmpleadoPrimerApellido, MaskedTextBox MSK_EmpleadoSegundoApellido, MaskedTextBox MSK_EmpleadoSalario, MaskedTextBox MSK_EmpleadoUsuario, MaskedTextBox MSK_EmpleadoContraseña)
        {
            //se declara el objeto
            Empleado ObjEmpleado;
            //se construye el objeto con la informacion obtenida por parametro
            ObjEmpleado = new Empleado
            {
                PersonaIdentificacion = int.Parse(MSK_EmpleadoIdentificacion.Text.ToString()),
                PersonaNombre = MSK_EmpleadoNombre.Text.ToString(),
                PersonaPrimerApellido = MSK_EmpleadoPrimerApellido.Text.ToString(),
                PersonaSegundoApellido = MSK_EmpleadoSegundoApellido.Text.ToString(),
                EmpleadoSalario = int.Parse(MSK_EmpleadoSalario.Text.ToString()),
                EmpleadoUsuario = MSK_EmpleadoUsuario.Text.ToString(),
                EmpleadoContraseña = MSK_EmpleadoContraseña.Text.ToString(),
                EmpleadoEstado = 1
            };

            //se retorna el objeto
            return ObjEmpleado;
        }

        //crear un objeto raza
        public static Raza CrearObjeto_Raza(MaskedTextBox MSK_CodigoRaza, MaskedTextBox MSK_DescripcionRaza)
        {
            //se declara el objeto
            Raza ObjRaza;

            //se construye el objeto con la informacion obtenida por parametro
            ObjRaza = new Raza
            {
                CodigoRaza = int.Parse(MSK_CodigoRaza.Text.ToString()),
                DescripcionRaza = MSK_DescripcionRaza.Text.ToString()
            };

            //se retorna el objeto
            return ObjRaza;
        }

        //crear un objeto animal
        public static Animal CrearObjeto_Animal(MaskedTextBox MSK_AnimalIdentificacion, MaskedTextBox MSK_AnimalNombre, ComboBox COMBO_AnimalFinca, ComboBox COMBO_AnimalRaza, DateTimePicker DATEPICK_AnimalNacimiento, RadioButton RADIOBTN_AnimalSexoHembra, RadioButton RADIOBTN_AnimalSexoMacho, ComboBox COMBO_AnimalMadre, ComboBox COMBO_AnimalPadre)
        {
            //se declara el objeto
            Animal ObjAnimal;

            //se construye el objeto con la informacion obtenida por parametro
            ObjAnimal = new Animal
            {
                AnimalIdentificacion = int.Parse(MSK_AnimalIdentificacion.Text.ToString()),
                AnimalNombre = MSK_AnimalNombre.Text.ToString(),
                AnimalFinca = Convertir_NombreFincaANumeroFinca(COMBO_AnimalFinca),
                AnimalRaza = Convertir_DescripcionRazaAIdRaza(COMBO_AnimalRaza),
                AnimalFechaNacimiento = DATEPICK_AnimalNacimiento.Text.ToString(),
                AnimalSexo = DeterminarSexoAnimal(RADIOBTN_AnimalSexoHembra, RADIOBTN_AnimalSexoMacho),
            };

            //si madre es "Ninguno" y padre es "Ninguno"
            if (COMBO_AnimalMadre.SelectedItem.ToString().Equals("Ninguno") && COMBO_AnimalPadre.SelectedItem.ToString().Equals("Ninguno"))
            {
                ObjAnimal.AnimalMadre = -999999999;
                ObjAnimal.AnimalPadre = -999999999;
            }

            //si madre no es "Ninguno" y padre  no es "Ninguno"...
            if (!COMBO_AnimalMadre.SelectedItem.ToString().Equals("Ninguno") && !COMBO_AnimalPadre.SelectedItem.ToString().Equals("Ninguno"))
            {
                //se obtiene la informacion de los combobox
                ObjAnimal.AnimalMadre = Convertir_NombreAnimalAIdentificacionAnimal(COMBO_AnimalMadre);
                ObjAnimal.AnimalPadre = Convertir_NombreAnimalAIdentificacionAnimal(COMBO_AnimalPadre);
            }

            //si madre es "Ninguno" y padre no es "Ninguno"...
            if (COMBO_AnimalMadre.SelectedItem.ToString().Equals("Ninguno") && !COMBO_AnimalPadre.SelectedItem.ToString().Equals("Ninguno"))
            {
                //se obtiene la informacion del combobox de el padre
                //se setea la madre con valor reservado
                ObjAnimal.AnimalMadre = -999999999;
                ObjAnimal.AnimalPadre = Convertir_NombreAnimalAIdentificacionAnimal(COMBO_AnimalPadre);
            }

            //si madre no es "Ninguno" y padre es "Ninguno"...
            if (!COMBO_AnimalMadre.SelectedItem.ToString().Equals("Ninguno") && COMBO_AnimalPadre.SelectedItem.ToString().Equals("Ninguno"))
            {
                //se obtiene la informacion del combobox de la madre
                //se setea el padre con valor reservado
                ObjAnimal.AnimalMadre = Convertir_NombreAnimalAIdentificacionAnimal(COMBO_AnimalMadre);
                ObjAnimal.AnimalPadre = -999999999;
            }

            //se retorna el objeto
            return ObjAnimal;
        }

        /* Metodos Cargar ComboBox:
         * Los siguientes metodos se encargan de llenar de informacion los combobox.
         * haciendo las respectivas solicitudes a la base de datos.
         */

        ///DEL SERVIDOR///

        //cargar combobox finca
        public static ComboBox CargarComboBox_Finca(ComboBox COMBO_Finca)
        {
            //se solicita todos los nombres de fincas guardados en la base de datos
            //se setea la fuente de datos del combo box con la coleccion retornada
            COMBO_Finca.DataSource = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerNombresFincas();
            return COMBO_Finca;
        }

        //cargar combobox raza
        public static ComboBox CargarComboBox_Raza(ComboBox COMBO_AnimalRaza)
        {
            //se solicita todas descripciones de razas guardados en la base de datos
            //se setea la fuente de datos del combo box con la coleccion retornada
            COMBO_AnimalRaza.DataSource = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerDescripcionesRazas();
            return COMBO_AnimalRaza;
        }

        //cargar combobox animal madre
        public static ComboBox CargarComboBox_Madre(ComboBox COMBO_AnimalMadre)
        {
            //se solicita todos los nombres de animales guardados en la base de datos
            //se guardan en una coleccion generica
            List<string> ListaAnimalMadre = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerNombresAnimales();
            //se añade la opcion "Ninguno"
            ListaAnimalMadre.Add("Ninguno");
            //se setea la fuente de datos del combo box con la coleccion generica
            COMBO_AnimalMadre.DataSource = ListaAnimalMadre;
            return COMBO_AnimalMadre;
        }

        //cargar combobox animal padre
        public static ComboBox CargarComboBox_Padre(ComboBox COMBO_AnimalPadre)
        {
            //se solicita todos los identificadores de animales guardados en la base de datos
            //se guardan en una coleccion generica
            List<string> ListaAnimalPadre = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerNombresAnimales();
            //se añade la opcion "Ninguno"
            ListaAnimalPadre.Add("Ninguno");
            //se setea la fuente de datos del combo box con la coleccion generica
            COMBO_AnimalPadre.DataSource = ListaAnimalPadre;
            return COMBO_AnimalPadre;
        }

        //cargar combobox empleados pendientes
        public static ComboBox CargarComboBox_EmpleadosPendientes(ComboBox COMBO_EmpleadosPendientes)
        {
            //se solicita todos los nombres de empleados guardados en la base de datos (filtrado por estado)
            //se setea la fuente de datos del combo box con la coleccion retornada
            COMBO_EmpleadosPendientes.DataSource = Servidor.CONEXION.ConexionBaseDeDatos.SQLConsultarEmpleadosPendientes();
            return COMBO_EmpleadosPendientes;
        }

        /* Metodos ConvertirX_a_X:
         * Los valores de algunos ComboBox no son identificadores para ser mas comprensibles
         * Los siguientes metodos obtienen el valor comprensible y lo convierten en un identificador de nuevo
         * de modo que puedan ser insertados en la creacion de objetos y la base de datos.
         */

        //obtiene un nombre de finca y lo convierte a un numero de finca
        public static int Convertir_NombreFincaANumeroFinca(ComboBox COMBO_Finca)
        {
            //se declara la variable de almacenamiento
            int NumeroFinca = 0;

            //se solicita todos los numeros de finca guardados en la base de datos
            //se guardan en una coleccion generica
            List<int> ListaNumeroFinca = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerNumeroFinca();

            //el numero de finca es igual a...
            //la posicion en la coleccion generica igual al indice seleccionado en el combobox
            NumeroFinca = ListaNumeroFinca[COMBO_Finca.SelectedIndex];

            //se retorna la variable
            return NumeroFinca;
        }

        //obtiene una descripcion de raza y lo convierte en un identificador de raza
        public static int Convertir_DescripcionRazaAIdRaza(ComboBox COMBO_Raza)
        {
            //se declara la variable de almacenamiento
            int IdRaza = 0;

            //se solicita todos los identificaciones de razas guardadas en la base de datos
            //se guardan en una coleccion generica
            List<int> ListaIdRaza = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerIdRaza();

            //el identificador de raza es igual a...
            //la posicion en la coleccion generica igual al indice seleccionado en el combobox
            IdRaza = ListaIdRaza[COMBO_Raza.SelectedIndex];

            //se retorna la variable
            return IdRaza;
        }

        //obtiene un nombre de animal y lo convierte a una identificacion de animal
        public static int Convertir_NombreAnimalAIdentificacionAnimal(ComboBox COMBO_Animal)
        {
            //se declara la variable de almacenamiento
            int IdentificacionAnimal = 0;

            //se solicita todas las identificaciones de animales guardadas en la base de datos
            //se guardan en una coleccion generica
            List<string> ListaIdentificacionAnimal = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerIdentificacionAnimal();

            try
            {
                //la identificacion del animal es igual a...
                //la posicion en la coleccion generica igual al indice seleccionado en el combobox
                IdentificacionAnimal = Int32.Parse(ListaIdentificacionAnimal[COMBO_Animal.SelectedIndex]);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("El índice estaba fuera del intervalo"))
                {
                    IdentificacionAnimal = 0;
                }
            }

            //se retorna la variable
            return IdentificacionAnimal;
        }

        //Este metodo determina el sexo del animal mediante la seleccion de los radio buttons.
        public static int DeterminarSexoAnimal(RadioButton RADIOBTN_AnimalSexoHembra, RadioButton RADIOBTN_AnimalSexoMacho)
        {
            //se declara la variable de almacenamiento
            int sexo = 0;

            //Si el radiobutton hembra esta seleccionado...
            if (RADIOBTN_AnimalSexoHembra.Checked == true)
            {
                sexo = 1; //se setea el sexo a 1 (hembra)
            }
            //Si el radiobutton macho esta seleccionado...
            else if (RADIOBTN_AnimalSexoMacho.Checked == true)
            {
                sexo = 2; //se setea el sexo a 2 (macho)
            }

            //se retorna la variable
            return sexo;
        }

    }
}

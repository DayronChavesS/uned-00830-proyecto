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
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Servidor.CONEXION
{
    //La siguiente clase contiene todo el codigo relacionado con la conexion Servidor >> Base de Datos
    public class ConexionBaseDeDatos
    {
        private static SqlConnection SQLConexion;
        private static SqlConnectionStringBuilder SQLConstructorConexion;
        private static SqlCommand SQLComando;
        private static SqlDataReader SQLLector;
        private static string SQLScript;

        //crear la conexion entre el servidor y la base de datos
        public static bool ConectarBaseDeDatos()
        {
            bool conectado = false;

            SQLConstructorConexion = new SqlConnectionStringBuilder
            {
                DataSource = ".\\SQLEXPRESS",
                InitialCatalog = "MIFINCA",
                IntegratedSecurity = true
            };
            SQLConexion = new SqlConnection(SQLConstructorConexion.ConnectionString);

            //se hace un test
            try
            {
                SQLComando = ConstruirComando("SELECT* FROM dbo.Finca");
                SQLComando.ExecuteNonQuery();
                conectado = true;
            }
            catch (Exception)
            {
                conectado = false;
                SQLConexion.Close();
                SQLConexion.Dispose();
                DialogResult EXCEPCION = MessageBox.Show("No se puede conectar a la base de datos.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
            }
            SQLConexion.Close();

            return conectado;

        }

        //construir un comando sql
        public static SqlCommand ConstruirComando(string SQLScript)
        {
            try
            {
                //se abre la conexion con la base de datos
                SQLConexion.Open();
                //se construye el comando con el script del parametro y la informacion de la conexion
                SQLComando = new SqlCommand(SQLScript, SQLConexion);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Valor de tiempo de espera caducado"))
                {
                    SQLConexion.Close();
                    DialogResult EXCEPCION = MessageBox.Show("La base de datos esta ocupada, intentelo de nuevo.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }
            }

            return SQLComando;
        }

        //ejecutar un comando
        public static bool EjecutarComandoNonQuery(SqlCommand Comando)
        {
            bool exito = true;

            try
            {
                //se trata de limitar la ejecucion del comando a solo un proceso a la vez
                lock (SQLComando)
                {
                    //ejecuta un comando en modo nonquery (solo retorna el numero de filas alteradas pero no se captura)
                    SQLComando.ExecuteNonQuery();
                }
            }
            catch (Exception e) //existe una excepcion para cada una de las llaves en la base de datos
            {
                exito = false; //si ocurre una excepcion signfica que la ejecucion del comando no tuvo exito

                if (e.Message.Contains("PK_Finca"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, esa finca ya existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("PK_Duenno"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, esa dueño ya existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("FK_Duenno_Finca"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, esa finca ya le pertenece a ese dueño.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("PK_Empleado"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, ese empleado ya existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("PK_Raza"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, esa raza ya existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("PK_Animales"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, ese animal ya existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("FK_Animales_Finca"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, la finca que intenta seleccionar no existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("FK_Animales_Raza"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, la raza que intenta seleccionar no existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("FK_Animales_Animales"))
                {
                    exito = true; //En caso de que sea el primer ingreso o "Ninguno" sea seleccionado es necesario ignorar esto
                }

                else if (e.Message.Contains("FK_Animales_Animales1"))
                {
                    exito = true; //En caso de que sea el primer ingreso o "Ninguno" sea seleccionado es necesario ignorar esto
                }

                else if (e.Message.Contains("PK_Vacunas"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, esa vacuna ya existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("PK_Vacuna_Animal"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, ese animal ya fue vacunado.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("FK_Vacuna_Animal_Animales"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, el animal que desea vacunar no existe.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("FK_Vacuna_Animal_Vacunas"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, el animal que desea vacunar no existe", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("PK_Tramientos"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, ese animal ya recibio tratamiento", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else if (e.Message.Contains("'FK_Tramientos_Animales"))
                {
                    DialogResult EXCEPCION = MessageBox.Show("Lo sentimos, ese animal ya recibio tratamiento", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }

                else
                {
                    DialogResult EXCEPCION = MessageBox.Show("A ocurrido un error desconocido al intentar insertar ese objeto.", "EXCEPCION CAPTURADA", MessageBoxButtons.OK);
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return exito;
        }

        /* Metodo SQLInsertarX:
         * Los siguientes metodos reciben un objeto por parametro y lo tratan de insertar en la tabla correspondiente
         * Contienen los scripts SQL de inserccion correspondientes para cada caso
         * retornan falso o verdadero segun el exito de la ejecucion del comando
         */

        ///DEL SERVIDOR///

        //insertar una nueva finca
        public static bool SQLInsertarFinca(Finca ObjFinca)
        {
            bool exito = true;

            //se crea el script
            SQLScript = "INSERT into dbo.Finca(Id_Finca, Nombre, Tamanno, Direccion, Telefono)";
            SQLScript += "VALUES('" + ObjFinca.FincaNumero.ToString() + "', '" + ObjFinca.FincaNombre.ToString() + "', '" + ObjFinca.FincaTamaño.ToString() + "', '" + ObjFinca.FincaDireccion.ToString() + "', '" + ObjFinca.FincaTelefono.ToString() + "')";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar un nuevo dueño
        public static bool SQLInsertarDueño(Dueño ObjDueño)
        {
            bool exito = true;

            //se crea el script
            SQLScript = "INSERT into dbo.Duenno(Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Correo_Electronico, Telefono_Celular, Id_Finca)";
            SQLScript += "VALUES('" + ObjDueño.PersonaIdentificacion.ToString() + "', '" + ObjDueño.PersonaNombre.ToString() + "', '" + ObjDueño.PersonaPrimerApellido.ToString() + "', '" + ObjDueño.PersonaSegundoApellido.ToString() + "', '" + ObjDueño.DueñoCorreo.ToString() + "', '" + ObjDueño.DueñoCelular.ToString() + "', '" + ObjDueño.DueñoFinca.ToString() + "')";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar un nuevo empleado
        public static bool SQLInsertarEmpleado(Empleado ObjEmpleado)
        {
            bool exito = true;

            //se crea el script
            SQLScript = "INSERT into dbo.Empleado(Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Salario, Usuario, Contrasena, Estado)";
            SQLScript += "VALUES('" + ObjEmpleado.PersonaIdentificacion.ToString() + "', '" + ObjEmpleado.PersonaNombre.ToString() + "', '" + ObjEmpleado.PersonaPrimerApellido.ToString() + "', '" + ObjEmpleado.PersonaSegundoApellido.ToString() + "', '" + ObjEmpleado.EmpleadoSalario.ToString() + "', '" + ObjEmpleado.EmpleadoUsuario.ToString() + "', '" + ObjEmpleado.EmpleadoContraseña.ToString() + "', '" + ObjEmpleado.EmpleadoEstado.ToString() + "')";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar una nueva raza
        public static bool SQLInsertarRaza(Raza ObjRaza)
        {
            bool exito = true;

            //se crea el script
            SQLScript = "INSERT into dbo.Raza(ID_Raza, Descripcion)";
            SQLScript += "VALUES('" + ObjRaza.CodigoRaza.ToString() + "', '" + ObjRaza.DescripcionRaza.ToString() + "')";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar una nuevo animal
        public static bool SQLInsertarAnimal(Animal ObjAnimal)
        {
            bool exito = true;

            if (ObjAnimal.AnimalMadre != -999999999 && ObjAnimal.AnimalPadre != -999999999)
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Animales(Id_Animal, Nombre, Id_Finca, Id_Raza, Fecha_Nacimiento, Sexo, Id_Madre, Id_Padre)";
                SQLScript += "VALUES('" + ObjAnimal.AnimalIdentificacion.ToString() + "', '" + ObjAnimal.AnimalNombre.ToString() + "', '" + ObjAnimal.AnimalFinca.ToString() + "', '" + ObjAnimal.AnimalRaza.ToString() + "', '" + ObjAnimal.AnimalFechaNacimiento.ToString() + "', '" + ObjAnimal.AnimalSexo.ToString() + "', '" + ObjAnimal.AnimalMadre.ToString() + "', '" + ObjAnimal.AnimalPadre.ToString() + "')";
            }

            if (ObjAnimal.AnimalMadre == -999999999 && ObjAnimal.AnimalPadre == -999999999)
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Animales(Id_Animal, Nombre, Id_Finca, Id_Raza, Fecha_Nacimiento, Sexo, Id_Madre, Id_Padre)";
                SQLScript += "VALUES('" + ObjAnimal.AnimalIdentificacion.ToString() + "', '" + ObjAnimal.AnimalNombre.ToString() + "', '" + ObjAnimal.AnimalFinca.ToString() + "', '" + ObjAnimal.AnimalRaza.ToString() + "', '" + ObjAnimal.AnimalFechaNacimiento.ToString() + "', '" + ObjAnimal.AnimalSexo.ToString() + "'" + ", null, null)";
            }

            if (ObjAnimal.AnimalMadre != -999999999 && ObjAnimal.AnimalPadre == -999999999)
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Animales(Id_Animal, Nombre, Id_Finca, Id_Raza, Fecha_Nacimiento, Sexo, Id_Madre, Id_Padre)";
                SQLScript += "VALUES('" + ObjAnimal.AnimalIdentificacion.ToString() + "', '" + ObjAnimal.AnimalNombre.ToString() + "', '" + ObjAnimal.AnimalFinca.ToString() + "', '" + ObjAnimal.AnimalRaza.ToString() + "', '" + ObjAnimal.AnimalFechaNacimiento.ToString() + "', '" + ObjAnimal.AnimalSexo.ToString() + "', '" + ObjAnimal.AnimalMadre.ToString() + "', null)";
            }

            if (ObjAnimal.AnimalMadre == -999999999 && ObjAnimal.AnimalPadre != -999999999)
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Animales(Id_Animal, Nombre, Id_Finca, Id_Raza, Fecha_Nacimiento, Sexo, Id_Madre, Id_Padre)";
                SQLScript += "VALUES('" + ObjAnimal.AnimalIdentificacion.ToString() + "', '" + ObjAnimal.AnimalNombre.ToString() + "', '" + ObjAnimal.AnimalFinca.ToString() + "', '" + ObjAnimal.AnimalRaza.ToString() + "', '" + ObjAnimal.AnimalFechaNacimiento.ToString() + "', '" + ObjAnimal.AnimalSexo.ToString() + "', null, '" + ObjAnimal.AnimalPadre.ToString() + "')";
            }

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        public static void SQLActualizarEstadoEmpleado(string Empleado)
        {
            //se crea el script
            SQLScript = "UPDATE dbo.Empleado SET Estado = 1 WHERE CONCAT(Nombre, ' ', Primer_Apellido, ' ', Segundo_Apellido) = '" + Empleado + "'";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando
            EjecutarComandoNonQuery(SQLComando);

        }

        ///DEL CLIENTE///
        ///estos metodos reciben colecciones genericas por parametro
        ///ya que el servidor carece de las clases para entender los objetos

        //insertar un nuevo empleado
        public static bool SQLInsertarEmpleado_Cliente(List<string> InformacionEmpleado)
        {
            bool exito = true;

            //se crea el script
            SQLScript = "INSERT into dbo.Empleado(Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Salario, Usuario, Contrasena, Estado)";
            SQLScript += "VALUES('" + InformacionEmpleado[0].ToString() + "', '" + InformacionEmpleado[1].ToString() + "', '" + InformacionEmpleado[2].ToString() + "', '" + InformacionEmpleado[3].ToString() + "', '" + InformacionEmpleado[4].ToString() + "', '" + InformacionEmpleado[5].ToString() + "', '" + InformacionEmpleado[6].ToString() + "', '" + InformacionEmpleado[7].ToString() + "')";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar una nueva vacuna
        public static bool SQLInsertarVacuna(List<string> InformacionVacuna)
        {
            bool exito = true;

            //se crea el script
            SQLScript = "INSERT into dbo.Vacunas( Id_Vacuna, Descripcion)";
            SQLScript += "VALUES('" + InformacionVacuna[0].ToString() + "', '" + InformacionVacuna[1].ToString() + "')";

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar un nuevo vacunamiento
        public static bool SQLInsertarVacunamiento(List<string> InformacionVacunamiento)
        {
            bool exito = true;

            //si el nombre del animal no es "-999999999"
            if (!InformacionVacunamiento[0].Contains("-999999999"))
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Vacuna_Animal (Id_animal, Id_vacuna, Fec_vacuna, Enfermedad, Observaciones)";
                SQLScript += "VALUES('" + InformacionVacunamiento[0].ToString() + "', '" + InformacionVacunamiento[1].ToString() + "', '" + InformacionVacunamiento[2].ToString() + "', '" + InformacionVacunamiento[3].ToString() + "', '" + InformacionVacunamiento[4].ToString() + "')";
            }
            else //se construye un script distinto que añade la vacunacion a todos los animales de una finca especifica
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Vacuna_Animal (Id_animal, Id_vacuna, Fec_vacuna, Enfermedad, Observaciones)";
                SQLScript += " SELECT dbo.Animales.Id_animal, '" + InformacionVacunamiento[1].ToString() + "', '" + InformacionVacunamiento[2].ToString() + "', '" + InformacionVacunamiento[3].ToString() + "', '" + InformacionVacunamiento[4].ToString() + "'";
                SQLScript += " FROM dbo.Animales";
                SQLScript += " WHERE dbo.Animales.Id_Finca = " + InformacionVacunamiento[5].ToString() + "";
            }

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }

        //insertar un nuevo tratamiento
        public static bool SQLInsertarTratamiento(List<string> InformacionTratamiento)
        {
            bool exito = true;

            //si el nombre del animal no es "-999999999"
            if (!InformacionTratamiento[0].Contains("-999999999"))
            {
                //se crea el script
                SQLScript = "INSERT into dbo.Tramientos(Id_animal, Fec_tratamiento, Diagnostico, Medicamento, Dias_tratamiento, Observaciones)";
                SQLScript += "VALUES('" + InformacionTratamiento[0].ToString() + "', '" + InformacionTratamiento[1].ToString() + "', '" + InformacionTratamiento[2].ToString() + "', '" + InformacionTratamiento[3].ToString() + "', '" + InformacionTratamiento[4].ToString() + "', '" + InformacionTratamiento[5].ToString() + "')";
            }
            else //si el nombre es "-999999999" se construye un script distinto que añade el tratamiento a todos los animales de una finca especifica
            {
                //se crea el script
                SQLScript = "INSERT INTO dbo.Tramientos(Id_animal, Fec_tratamiento, Diagnostico, Medicamento, Dias_tratamiento, Observaciones)";
                SQLScript += " SELECT dbo.Animales.Id_animal, '" + InformacionTratamiento[1].ToString() + "', '" + InformacionTratamiento[2].ToString() + "', '" + InformacionTratamiento[3].ToString() + "', " + InformacionTratamiento[4].ToString() + ", '" + InformacionTratamiento[5].ToString() + "'";
                SQLScript += " FROM dbo.Animales";
                SQLScript += " WHERE dbo.Animales.Id_Finca = " + InformacionTratamiento[6].ToString() + "";
            }

            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);

            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            exito = EjecutarComandoNonQuery(SQLComando);

            return exito;
        }


        /* Metodo SQLConsultarX:
         * Los siguientes metodos retornan listas genericas con todos los datos de una tabla
         * Estos metodos son necesarios para los formularios de consulta del servidor y cliente
         */

        ///DEL SERVIDOR///

        //obtener toda la tabla finca
        public static List<Finca> SQLConsultarFincas()
        {
            List<Finca> ListaFinca = new List<Finca>();

            //se crea el script
            SQLScript = "Select* From dbo.Finca";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaFinca.Add(new Finca
                    {
                        FincaNumero = SQLLector.GetInt32(0),
                        FincaNombre = SQLLector.GetString(1),
                        FincaTamaño = SQLLector.GetInt32(2),
                        FincaDireccion = SQLLector.GetString(3),
                        FincaTelefono = SQLLector.GetInt32(4)
                    });
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaFinca;
        }

        //obtener toda la tabla dueño
        public static List<Dueño> SQLConsultarDueño()
        {
            List<Dueño> ListaDueño = new List<Dueño>();

            //se crea el script
            SQLScript = "Select* From dbo.Duenno";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaDueño.Add(new Dueño
                    {
                        PersonaIdentificacion = SQLLector.GetInt32(0),
                        PersonaNombre = SQLLector.GetString(1),
                        PersonaPrimerApellido = SQLLector.GetString(2),
                        PersonaSegundoApellido = SQLLector.GetString(3),
                        DueñoCorreo = SQLLector.GetString(4),
                        DueñoCelular = SQLLector.GetInt32(5),
                        DueñoFinca = SQLLector.GetInt32(6)
                    });
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaDueño;
        }

        //obtener toda la tabla empleado
        public static List<Empleado> SQLConsultarEmpleado()
        {
            List<Empleado> ListaEmpleado = new List<Empleado>();

            //se crea el script
            SQLScript = "Select* From dbo.Empleado";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaEmpleado.Add(new Empleado
                    {
                        PersonaIdentificacion = SQLLector.GetInt32(0),
                        PersonaNombre = SQLLector.GetString(1),
                        PersonaPrimerApellido = SQLLector.GetString(2),
                        PersonaSegundoApellido = SQLLector.GetString(3),
                        EmpleadoSalario = SQLLector.GetDecimal(4),
                        EmpleadoUsuario = SQLLector.GetString(5),
                        EmpleadoContraseña = SQLLector.GetString(6),
                        EmpleadoEstado = SQLLector.GetInt32(7),
                    });
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaEmpleado;
        }

        //obtener toda la tabla raza
        public static List<Raza> SQLConsultarRaza()
        {
            List<Raza> ListaRaza = new List<Raza>();

            //se crea el script
            SQLScript = "Select* From dbo.Raza";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaRaza.Add(new Raza
                    {
                        CodigoRaza = SQLLector.GetInt32(0),
                        DescripcionRaza = SQLLector.GetString(1)
                    });
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaRaza;
        }

        //obtener toda la tabla animal
        public static List<Animal> SQLConsultarAnimal()
        {
            List<Animal> ListaAnimal = new List<Animal>();

            //se crea el script
            SQLScript = "Select* From dbo.Animales";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaAnimal.Add(new Animal
                    {
                        AnimalIdentificacion = SQLLector.GetInt32(0),
                        AnimalNombre = SQLLector.GetString(1),
                        AnimalFinca = SQLLector.GetInt32(2),
                        AnimalRaza = SQLLector.GetInt32(3),
                        AnimalFechaNacimiento = SQLLector.GetDateTime(4).ToString(),
                        AnimalSexo = SQLLector.GetInt32(5),
                        AnimalMadre = SQLLector.IsDBNull(6) ? 0 : SQLLector.GetInt32(6),
                        AnimalPadre = SQLLector.IsDBNull(7) ? 0 : SQLLector.GetInt32(7)
                    });
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaAnimal;
        }

        //obtener toda la tabla empleado
        public static List<string> SQLConsultarEmpleadosPendientes()
        {
            List<string> ListaEmpleadosPendientes = new List<string>();

            //se crea el script
            SQLScript = "Select* From dbo.Empleado Where Estado=0";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaEmpleadosPendientes.Add(SQLLector.GetString(1) + " " + SQLLector.GetString(2) + " " + SQLLector.GetString(3));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaEmpleadosPendientes;
        }

        ///DEL CLIENTE///

        //obtener toda la tabla vacunamientos
        public static List<string> SQLConsultarVacunamientos()
        {
            List<string> ListaVacunamientos = new List<string>();

            //se crea el script
            SQLScript = " SELECT A.Nombre, V.Descripcion, VA.Fec_vacuna, VA.Enfermedad, VA.Observaciones";
            SQLScript += " FROM Vacuna_Animal AS VA";
            SQLScript += " JOIN Vacunas AS V ON V.Id_vacuna = VA.Id_vacuna";
            SQLScript += " JOIN Animales AS A ON A.Id_animal = VA.Id_animal";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaVacunamientos.Add
                    (
                        "Animal: " + SQLLector.GetString(0) + " || " +
                        "Vacuna: " + SQLLector.GetString(1) + " || " +
                        "Fecha: " + SQLLector.GetDateTime(2).ToString() + " || " +
                        "Enfermedad: " + SQLLector.GetString(3) + " || " +
                        "Observaciones: " + SQLLector.GetString(4)
                    );
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaVacunamientos;
        }

        //obtener toda la tabla tratamiento
        public static List<string> SQLConsultarTratamientos()
        {
            List<string> ListaTratamientos = new List<string>();

            //se crea el script
            SQLScript = "SELECT A.Nombre, T.Fec_tratamiento, T.Diagnostico, T.Medicamento, T.Dias_tratamiento, T.Observaciones";
            SQLScript += " FROM Tramientos AS T";
            SQLScript += " JOIN Animales AS A ON A.Id_animal = T.Id_animal";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaTratamientos.Add
                    (
                       "Animal: " + SQLLector.GetString(0) + " || " +
                       "Fecha: " + SQLLector.GetDateTime(1).ToString() + " || " +
                       "Diagnostico: " + SQLLector.GetString(2) + " || " +
                       "Medicamento: " + SQLLector.GetString(3) + " || " +
                       "Dias de Tratamiento: " + SQLLector.GetInt32(4).ToString() + " || " +
                       "Observaciones: " + SQLLector.GetString(5)
                    );
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaTratamientos;
        }

        /* Metodo SQLObtenerX:
         * Los siguientes metodos retornan colecciones genericas con datos especificos 
         * de la base de datos para poder trabajar con ellos en metodos.
         */

        //obtener nombres de fincas
        public static List<string> SQLObtenerNombresFincas()
        {
            //
            List<string> ListaNombresFincas = new List<string>();

            //se crea el script
            SQLScript = "Select Nombre From dbo.Finca";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaNombresFincas.Add(SQLLector.GetString(0));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaNombresFincas;
        }

        //obtener identificadores de razas
        public static List<int> SQLObtenerIdRaza()
        {
            List<int> ListaIdRaza = new List<int>();

            //se crea el script
            SQLScript = "SELECT Id_Raza FROM dbo.Raza";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaIdRaza.Add(SQLLector.GetInt32(0));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaIdRaza;
        }

        //obtener identificadores de animales
        public static List<string> SQLObtenerIdentificacionAnimal()
        {
            List<string> ListaIdentificacionAnimal = new List<string>();

            //se crea el script
            SQLScript = "SELECT Id_animal FROM dbo.Animales";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaIdentificacionAnimal.Add(SQLLector.GetInt32(0).ToString());
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaIdentificacionAnimal;
        }

        //obtener nombres de animales
        public static List<string> SQLObtenerNombresAnimales()
        {
            List<string> ListaNombresAnimales = new List<string>();

            //se crea el script
            SQLScript = "Select Nombre From dbo.Animales";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaNombresAnimales.Add(SQLLector.GetString(0));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaNombresAnimales;
        }

        //obtener descripciones de razas
        public static List<string> SQLObtenerDescripcionesRazas()
        {
            List<string> ListaDescripcionesRazas = new List<string>();

            //se crea el script
            SQLScript = "Select Descripcion From dbo.Raza";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaDescripcionesRazas.Add(SQLLector.GetString(0));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaDescripcionesRazas;
        }


        ///DEL CLIENTE///

        //obtener numeros de fincas
        public static List<int> SQLObtenerNumeroFinca()
        {
            List<int> ListaNumeroFincas = new List<int>();

            //se crea el script
            SQLScript = "SELECT Id_Finca FROM dbo.Finca";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaNumeroFincas.Add(SQLLector.GetInt32(0));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaNumeroFincas;
        }


        //obtener identificadores de animales filtrados por numero de finca
        public static List<string> SQLObtenerIdentificacionAnimal_FiltroFinca(string Id_Finca)
        {
            List<string> ListaIdentificadorAnimalesFiltrado = new List<string>();

            //se crea el script
            SQLScript = "SELECT Id_Animal FROM dbo.Animales WHERE Id_Finca = " + Id_Finca;
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaIdentificadorAnimalesFiltrado.Add(SQLLector.GetInt32(0).ToString());
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaIdentificadorAnimalesFiltrado;
        }

        //obtener identificadores de vacunas
        public static List<int> SQLObtenerIdentificadorVacuna()
        {
            List<int> ListaIdentificadorVacunas = new List<int>();

            //se crea el script
            SQLScript = "Select Id_vacuna From dbo.Vacunas";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                //mientras el lector este leyendo...
                while (SQLLector.Read())
                {
                    //se añade a la coleccion generica la informacion obtenida
                    ListaIdentificadorVacunas.Add(SQLLector.GetInt32(0));
                }
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return ListaIdentificadorVacunas;
        }

        /* Metodo SQLTablaXVacia:
         * Los siguientes metodos retornan falso o verdadero
         * dependiendo de si un conteo de las filas de las tablas da 0 o no.
         */

        public static bool DeterminarVacio(SqlCommand Comando)
        {
            bool vacia = true;

            //se ejecuta el comando y se guarda la cantidad de filas con un casteo
            int CantidadFilas = (int)Comando.ExecuteScalar();

            //si la cantidad de filas es diferente de 0
            if (CantidadFilas != 0)
            {
                vacia = false; //la tabla no esta vacia
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return vacia;
        }

        //¿la tabla finca esta vacia?
        public static bool SQLTablaFincaVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Finca";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla dueño esta vacia?
        public static bool SQLTablaDueñoVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Duenno";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla empleado esta vacia?
        public static bool SQLTablaEmpleadoVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Empleado";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla raza esta vacia?
        public static bool SQLTablaRazaVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Raza";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla animal esta vacia?
        public static bool SQLTablaAnimalVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Animales";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla vacuna esta vacia?
        public static bool SQLTablaVacunaVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Vacunas";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla vacunamiento esta vacia?
        public static bool SQLTablaVacunamientoVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Vacuna_Animal";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        //¿la tabla tratamiento esta vacia?
        public static bool SQLTablaTratamientoVacia()
        {
            bool vacia = true;

            //se crea el script
            SQLScript = "SELECT COUNT(*) FROM dbo.Tramientos";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando y se almacena el resultado (falso o verdadero)
            vacia = DeterminarVacio(SQLComando);

            return vacia;
        }

        ///DEL SERVIDOR///

        //¿este animal es una hembra?
        public static bool SQLEsteAnimalEsHembra(string nombreanimal)
        {
            bool EsHembra = false;

            //si el nombre de animal no es "ninguno"...
            if (!nombreanimal.Equals("Ninguno"))
            {
                //se crea el script
                SQLScript = "Select* From dbo.Animales WHERE Sexo = 1 AND Nombre = '" + nombreanimal + "'";
                //se construye el comando
                SQLComando = ConstruirComando(SQLScript);
                //se ejecuta el comando en modo de lectura
                SQLLector = SQLComando.ExecuteReader();

                //si el lector de la tabla tiene filas...
                if (SQLLector.HasRows)
                {
                    EsHembra = true; //entonces el animal solictado con este sexo existe
                }

                //se restablece el script
                SQLScript = null;
                //se cierra la conexion con la base de datos
                SQLConexion.Close();
            }
            else //si el nombre es "ninguno" se omite la verificacion
            {
                EsHembra = true;
            }

            return EsHembra;
        }

        //¿este animal es un macho?
        public static bool SQLEsteAnimalEsMacho(string nombreanimal)
        {
            bool EsMacho = false;

            //si el nombre de animal no es "ninguno"...
            if (!nombreanimal.Equals("Ninguno"))
            {
                //se crea el script
                SQLScript = "Select* From dbo.Animales WHERE Sexo = 2 AND Nombre = '" + nombreanimal + "'";
                //se construye el comando
                SQLComando = ConstruirComando(SQLScript);
                //se ejecuta el comando en modo de lectura
                SQLLector = SQLComando.ExecuteReader();

                //si el lector de la tabla tiene filas...
                if (SQLLector.HasRows)
                {
                    EsMacho = true; //entonces el animal solictado con este sexo existe 
                }

                //se restablece el script
                SQLScript = null;
                //se cierra la conexion con la base de datos
                SQLConexion.Close();
            }
            else //si el nombre es "ninguno" se omite la verificacion
            {
                EsMacho = true;
            }

            return EsMacho;
        }

        ///DEL CLIENTE///
        
        //¿Este animal es de esta finca?
        public static bool SQLEsteAnimalEsDeEstaFinca(List<string> FincaYAnimal)
        {
            bool EsDeFinca = false;

            //si el nombre de animal no es "Todos"...
            if (!FincaYAnimal[1].Equals("Todos"))
            {
                //se crea el script
                SQLScript = "SELECT* From dbo.Animales WHERE Id_Finca = '" + FincaYAnimal[0] + "' AND Id_Animal = '" + FincaYAnimal[1] + "'";
                //se construye el comando
                SQLComando = ConstruirComando(SQLScript);
                //se ejecuta el comando en modo de lectura
                SQLLector = SQLComando.ExecuteReader();

                //si el lector de la tabla tiene filas...
                if (SQLLector.HasRows)
                {
                    EsDeFinca = true; //entonces el animal solictado si existe en esta finca
                }

                //se restablece el script
                SQLScript = null;
                //se cierra la conexion con la base de datos
                SQLConexion.Close();
            }
            else //si el nombre es "Todos" se omite la verificacion
            {
                EsDeFinca = true;
            }

            return EsDeFinca;
        }

        //¿la cuenta que intenta usar el usuario existe?
        public static bool SQLValidarLogin(List<string> InformacionUsuario)
        {
            bool exito = false;

            List<string> ListaDeFilas = new List<string>();

            //se crea el script
            SQLScript = "SELECT Usuario, Contrasena, Estado FROM dbo.Empleado";
            SQLScript += " WHERE(Usuario = '" + InformacionUsuario[0] + "' AND Contrasena = '" + InformacionUsuario[1] + "' AND Estado = 1)";
            //se construye el comando
            SQLComando = ConstruirComando(SQLScript);
            //se ejecuta el comando en modo de lectura
            SQLLector = SQLComando.ExecuteReader();

            //si el lector de la tabla tiene filas...
            if (SQLLector.HasRows)
            {
                exito = true; //entonces el usuario existe y esta activado
            }

            //se restablece el script
            SQLScript = null;
            //se cierra la conexion con la base de datos
            SQLConexion.Close();

            return exito;
        }

    }
}

/* UNIVERSIDAD ESTATAL A DISTANCIA DE COSTA RICA
 * VICERRECTORIA ACADEMICA
 * ESCUELA DE CIENCIAS EXACTAS Y NATURALES
 * CARRERA DE INGENIERIA INFORMATICA
 * 
 * PROYECTO
 * SISTEMA DE INFORMACION DE EMPRESA AGROGANADERA MI FINCA v3.0
 * 
 * GRUPO 03
 * PROFESOR JORGE CALVO SOLANO
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

namespace Principal
{
    //la siguiente clase permite que toda la solucion (y este proyecto en particular) inicie
    internal static class Run
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ///!\ IGNORAR /!\///
            //LLENARTODO();
            ///!\ IGNORAR /!\///

            InsertarVacunas();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_MenuPrincipal());
        }

        //El proyecto no indica que se deba desarrollar pantalla para insertar vacunas
        //Y estas son esenciales para el correcto funcionamiento del cliente
        //Por lo tanto se insertan automaticamente.
        public static void InsertarVacunas()
        {
            if (Servidor.CONEXION.ConexionBaseDeDatos.ConectarBaseDeDatos() == true && Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaVacunaVacia() == true)
            {
                Cliente.CLASES.Vacuna ObjVacuna1 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 1,
                    VacunaDescripcion = "SoyVacuna1"
                };



                Cliente.CLASES.Vacuna ObjVacuna2 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 2,
                    VacunaDescripcion = "SoyVacuna2"
                };



                Cliente.CLASES.Vacuna ObjVacuna3 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 3,
                    VacunaDescripcion = "SoyVacuna3"
                };

                List<string> ListaAtributosVacuna1 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna1);
                List<string> ListaAtributosVacuna2 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna2);
                List<string> ListaAtributosVacuna3 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna3);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna3);
            }
        }



        /*
         * /!\ IGNORAR ESTE CODIGO /!\
         *Solo fue usado para hacer pruebas.
         *Esta desactivado por defecto.
         *Llena toda la base de datos con informacion automaticamente
         */
        public static void LLENARTODO()
        {
            if (Servidor.CONEXION.ConexionBaseDeDatos.ConectarBaseDeDatos() == true)
            {
                //////////TABLA FINCA//////////

                Servidor.CLASES.Finca ObjFinca1 = new Servidor.CLASES.Finca
                {
                    FincaNumero = 1,
                    FincaNombre = "a",
                    FincaTamaño = 1,
                    FincaDireccion = "a",
                    FincaTelefono = 1
                };


                Servidor.CLASES.Finca ObjFinca2 = new Servidor.CLASES.Finca
                {
                    FincaNumero = 2,
                    FincaNombre = "b",
                    FincaTamaño = 2,
                    FincaDireccion = "b",
                    FincaTelefono = 2
                };



                Servidor.CLASES.Finca ObjFinca3 = new Servidor.CLASES.Finca
                {
                    FincaNumero = 3,
                    FincaNombre = "c",
                    FincaTamaño = 3,
                    FincaDireccion = "c",
                    FincaTelefono = 3
                };



                Servidor.CLASES.Finca ObjFinca4 = new Servidor.CLASES.Finca
                {
                    FincaNumero = 4,
                    FincaNombre = "d",
                    FincaTamaño = 4,
                    FincaDireccion = "d",
                    FincaTelefono = 4
                };



                Servidor.CLASES.Finca ObjFinca5 = new Servidor.CLASES.Finca
                {
                    FincaNumero = 5,
                    FincaNombre = "e",
                    FincaTamaño = 5,
                    FincaDireccion = "e",
                    FincaTelefono = 5
                };



                ////////////TABLA EMPLEADO/////////////

                Servidor.CLASES.Empleado ObjEmpleado1 = new Servidor.CLASES.Empleado
                {
                    PersonaIdentificacion = 1,
                    PersonaNombre = "a",
                    PersonaPrimerApellido = "a",
                    PersonaSegundoApellido = "a",
                    EmpleadoSalario = 1,
                    EmpleadoUsuario = "a",
                    EmpleadoContraseña = "a",
                    EmpleadoEstado = 1
                };



                Servidor.CLASES.Empleado ObjEmpleado2 = new Servidor.CLASES.Empleado
                {
                    PersonaIdentificacion = 2,
                    PersonaNombre = "b",
                    PersonaPrimerApellido = "b",
                    PersonaSegundoApellido = "b",
                    EmpleadoSalario = 2,
                    EmpleadoUsuario = "b",
                    EmpleadoContraseña = "b",
                    EmpleadoEstado = 1
                };



                Servidor.CLASES.Empleado ObjEmpleado3 = new Servidor.CLASES.Empleado
                {
                    PersonaIdentificacion = 3,
                    PersonaNombre = "c",
                    PersonaPrimerApellido = "c",
                    PersonaSegundoApellido = "c",
                    EmpleadoSalario = 3,
                    EmpleadoUsuario = "c",
                    EmpleadoContraseña = "c",
                    EmpleadoEstado = 1
                };



                Servidor.CLASES.Empleado ObjEmpleado4 = new Servidor.CLASES.Empleado
                {
                    PersonaIdentificacion = 4,
                    PersonaNombre = "d",
                    PersonaPrimerApellido = "d",
                    PersonaSegundoApellido = "d",
                    EmpleadoSalario = 4,
                    EmpleadoUsuario = "d",
                    EmpleadoContraseña = "d",
                    EmpleadoEstado = 1
                };



                Servidor.CLASES.Empleado ObjEmpleado5 = new Servidor.CLASES.Empleado
                {
                    PersonaIdentificacion = 5,
                    PersonaNombre = "e",
                    PersonaPrimerApellido = "e",
                    PersonaSegundoApellido = "e",
                    EmpleadoSalario = 5,
                    EmpleadoUsuario = "e",
                    EmpleadoContraseña = "e",
                    EmpleadoEstado = 1
                };



                //////////TABLA RAZA//////////

                Servidor.CLASES.Raza ObjRaza1 = new Servidor.CLASES.Raza
                {
                    CodigoRaza = 1,
                    DescripcionRaza = "a"
                };



                Servidor.CLASES.Raza ObjRaza2 = new Servidor.CLASES.Raza
                {
                    CodigoRaza = 2,
                    DescripcionRaza = "b"
                };


                Servidor.CLASES.Raza ObjRaza3 = new Servidor.CLASES.Raza
                {
                    CodigoRaza = 3,
                    DescripcionRaza = "c"
                };



                Servidor.CLASES.Raza ObjRaza4 = new Servidor.CLASES.Raza
                {
                    CodigoRaza = 4,
                    DescripcionRaza = "d"
                };



                Servidor.CLASES.Raza ObjRaza5 = new Servidor.CLASES.Raza
                {
                    CodigoRaza = 5,
                    DescripcionRaza = "e"
                };



                //////////TABLA VACUNA//////////
                Cliente.CLASES.Vacuna ObjVacuna1 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 1,
                    VacunaDescripcion = "a"
                };



                Cliente.CLASES.Vacuna ObjVacuna2 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 2,
                    VacunaDescripcion = "b"
                };



                Cliente.CLASES.Vacuna ObjVacuna3 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 3,
                    VacunaDescripcion = "c"
                };



                Cliente.CLASES.Vacuna ObjVacuna4 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 4,
                    VacunaDescripcion = "d"
                };



                Cliente.CLASES.Vacuna ObjVacuna5 = new Cliente.CLASES.Vacuna
                {
                    VacunaIdentificador = 5,
                    VacunaDescripcion = "e"
                };

                //////////TABLA DUEÑO (DEPENDE DE FINCA)//////////

                Servidor.CLASES.Dueño ObjDueño1 = new Servidor.CLASES.Dueño
                {
                    PersonaIdentificacion = 1,
                    PersonaNombre = "a",
                    PersonaPrimerApellido = "a",
                    PersonaSegundoApellido = "a",
                    DueñoCorreo = "a",
                    DueñoCelular = 1,
                    DueñoFinca = 1
                };



                Servidor.CLASES.Dueño ObjDueño2 = new Servidor.CLASES.Dueño
                {
                    PersonaIdentificacion = 2,
                    PersonaNombre = "b",
                    PersonaPrimerApellido = "b",
                    PersonaSegundoApellido = "b",
                    DueñoCorreo = "b",
                    DueñoCelular = 2,
                    DueñoFinca = 2
                };



                Servidor.CLASES.Dueño ObjDueño3 = new Servidor.CLASES.Dueño
                {
                    PersonaIdentificacion = 3,
                    PersonaNombre = "c",
                    PersonaPrimerApellido = "c",
                    PersonaSegundoApellido = "c",
                    DueñoCorreo = "c",
                    DueñoCelular = 3,
                    DueñoFinca = 3
                };



                Servidor.CLASES.Dueño ObjDueño4 = new Servidor.CLASES.Dueño
                {
                    PersonaIdentificacion = 4,
                    PersonaNombre = "d",
                    PersonaPrimerApellido = "d",
                    PersonaSegundoApellido = "d",
                    DueñoCorreo = "d",
                    DueñoCelular = 4,
                    DueñoFinca = 4
                };



                Servidor.CLASES.Dueño ObjDueño5 = new Servidor.CLASES.Dueño
                {
                    PersonaIdentificacion = 5,
                    PersonaNombre = "e",
                    PersonaPrimerApellido = "e",
                    PersonaSegundoApellido = "e",
                    DueñoCorreo = "e",
                    DueñoCelular = 5,
                    DueñoFinca = 5
                };



                //////////TABLA ANIMAL (DEPENDE DE FINCA, RAZA, Y OPCIONALMENTE DE ANIMAL)//////////
                Servidor.CLASES.Animal ObjAnimal1 = new Servidor.CLASES.Animal
                {
                    AnimalIdentificacion = 1,
                    AnimalNombre = "a",
                    AnimalFinca = 1,
                    AnimalRaza = 1,
                    AnimalFechaNacimiento = "2021-12-01",
                    AnimalSexo = 1,
                    AnimalMadre = 1,
                    AnimalPadre = 1
                };



                Servidor.CLASES.Animal ObjAnimal2 = new Servidor.CLASES.Animal
                {
                    AnimalIdentificacion = 2,
                    AnimalNombre = "b",
                    AnimalFinca = 1,
                    AnimalRaza = 2,
                    AnimalFechaNacimiento = "2021-12-02",
                    AnimalSexo = 1,
                    AnimalMadre = 2,
                    AnimalPadre = 2
                };



                Servidor.CLASES.Animal ObjAnimal3 = new Servidor.CLASES.Animal
                {
                    AnimalIdentificacion = 3,
                    AnimalNombre = "c",
                    AnimalFinca = 1,
                    AnimalRaza = 3,
                    AnimalFechaNacimiento = "2021-12-03",
                    AnimalSexo = 1,
                    AnimalMadre = 3,
                    AnimalPadre = 3
                };



                Servidor.CLASES.Animal ObjAnimal4 = new Servidor.CLASES.Animal
                {
                    AnimalIdentificacion = 4,
                    AnimalNombre = "d",
                    AnimalFinca = 1,
                    AnimalRaza = 4,
                    AnimalFechaNacimiento = "2021-12-04",
                    AnimalSexo = 2,
                    AnimalMadre = 4,
                    AnimalPadre = 4
                };



                Servidor.CLASES.Animal ObjAnimal5 = new Servidor.CLASES.Animal
                {
                    AnimalIdentificacion = 5,
                    AnimalNombre = "e",
                    AnimalFinca = 1,
                    AnimalRaza = 5,
                    AnimalFechaNacimiento = "2021-12-05",
                    AnimalSexo = 2,
                    AnimalMadre = 5,
                    AnimalPadre = 5
                };



                Servidor.CLASES.Animal ObjAnimal6 = new Servidor.CLASES.Animal
                {
                    AnimalIdentificacion = 6,
                    AnimalNombre = "f",
                    AnimalFinca = 1,
                    AnimalRaza = 5,
                    AnimalFechaNacimiento = "2021-12-06",
                    AnimalSexo = 2,
                    AnimalMadre = 6,
                    AnimalPadre = 6
                };



                //////////TABLA VACUNA_ANIMAL (DEPENDE DE ANIMAL Y VACUNA)//////////
                Cliente.CLASES.Vacunamiento ObjVacunamiento1 = new Cliente.CLASES.Vacunamiento
                {
                    VacunamientoAnimal = 1,
                    VacunamientoVacuna = 1,
                    VacunamientoFecha = "2021-12-01",
                    VacunamientoEnfermedad = "a",
                    VacunamientoObservaciones = "a"
                };



                Cliente.CLASES.Vacunamiento ObjVacunamiento2 = new Cliente.CLASES.Vacunamiento
                {
                    VacunamientoAnimal = 2,
                    VacunamientoVacuna = 2,
                    VacunamientoFecha = "2021-12-02",
                    VacunamientoEnfermedad = "b",
                    VacunamientoObservaciones = "b"
                };



                Cliente.CLASES.Vacunamiento ObjVacunamiento3 = new Cliente.CLASES.Vacunamiento
                {
                    VacunamientoAnimal = 3,
                    VacunamientoVacuna = 3,
                    VacunamientoFecha = "2021-12-03",
                    VacunamientoEnfermedad = "c",
                    VacunamientoObservaciones = "c"
                };

                Cliente.CLASES.Vacunamiento ObjVacunamiento4 = new Cliente.CLASES.Vacunamiento
                {
                    VacunamientoAnimal = 4,
                    VacunamientoVacuna = 4,
                    VacunamientoFecha = "2021-12-04",
                    VacunamientoEnfermedad = "d",
                    VacunamientoObservaciones = "d"
                };




                Cliente.CLASES.Vacunamiento ObjVacunamiento5 = new Cliente.CLASES.Vacunamiento
                {
                    VacunamientoAnimal = 5,
                    VacunamientoVacuna = 5,
                    VacunamientoFecha = "2021-12-05",
                    VacunamientoEnfermedad = "e",
                    VacunamientoObservaciones = "e"
                };


                //////////TABLA TRATAMIENTO (DEPENDE DE FINCA Y ANIMALES)//////////
                Cliente.CLASES.Tratamiento ObjTratamiento1 = new Cliente.CLASES.Tratamiento
                {
                    TratamientoAnimal = 1,
                    TratamientoFecha = "2021-12-01",
                    TratamientoDiagnostico = "a",
                    TratamientoMedicamento = "a",
                    TratamientoDias = 1,
                    TratamientoObservaciones = "a"
                };



                Cliente.CLASES.Tratamiento ObjTratamiento2 = new Cliente.CLASES.Tratamiento
                {
                    TratamientoAnimal = 2,
                    TratamientoFecha = "2021-12-02",
                    TratamientoDiagnostico = "b",
                    TratamientoMedicamento = "b",
                    TratamientoDias = 2,
                    TratamientoObservaciones = "b"
                };



                Cliente.CLASES.Tratamiento ObjTratamiento3 = new Cliente.CLASES.Tratamiento
                {
                    TratamientoAnimal = 3,
                    TratamientoFecha = "2021-12-03",
                    TratamientoDiagnostico = "c",
                    TratamientoMedicamento = "c",
                    TratamientoDias = 3,
                    TratamientoObservaciones = "c"
                };



                Cliente.CLASES.Tratamiento ObjTratamiento4 = new Cliente.CLASES.Tratamiento
                {
                    TratamientoAnimal = 4,
                    TratamientoFecha = "2021-12-04",
                    TratamientoDiagnostico = "d",
                    TratamientoMedicamento = "d",
                    TratamientoDias = 4,
                    TratamientoObservaciones = "d"
                };


                Cliente.CLASES.Tratamiento ObjTratamiento5 = new Cliente.CLASES.Tratamiento
                {
                    TratamientoAnimal = 5,
                    TratamientoFecha = "2021-12-05",
                    TratamientoDiagnostico = "e",
                    TratamientoMedicamento = "e",
                    TratamientoDias = 5,
                    TratamientoObservaciones = "e"
                };


                List<string> ListaAtributosVacuna1 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna1);
                List<string> ListaAtributosVacuna2 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna2);
                List<string> ListaAtributosVacuna3 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna3);
                List<string> ListaAtributosVacuna4 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna4);
                List<string> ListaAtributosVacuna5 = Cliente.LOGICA.Metodo.CrearListaAtributosVacuna(ObjVacuna5);

                List<string> ListaAtributosVacunamiento1 = Cliente.LOGICA.Metodo.CrearListaAtributosVacunamiento(ObjVacunamiento1);
                List<string> ListaAtributosVacunamiento2 = Cliente.LOGICA.Metodo.CrearListaAtributosVacunamiento(ObjVacunamiento2);
                List<string> ListaAtributosVacunamiento3 = Cliente.LOGICA.Metodo.CrearListaAtributosVacunamiento(ObjVacunamiento3);
                List<string> ListaAtributosVacunamiento4 = Cliente.LOGICA.Metodo.CrearListaAtributosVacunamiento(ObjVacunamiento4);
                List<string> ListaAtributosVacunamiento5 = Cliente.LOGICA.Metodo.CrearListaAtributosVacunamiento(ObjVacunamiento5);

                List<string> ListaAtributosTratamiento1 = Cliente.LOGICA.Metodo.CrearListaAtributosTratamiento(ObjTratamiento1);
                List<string> ListaAtributosTratamiento2 = Cliente.LOGICA.Metodo.CrearListaAtributosTratamiento(ObjTratamiento2);
                List<string> ListaAtributosTratamiento3 = Cliente.LOGICA.Metodo.CrearListaAtributosTratamiento(ObjTratamiento3);
                List<string> ListaAtributosTratamiento4 = Cliente.LOGICA.Metodo.CrearListaAtributosTratamiento(ObjTratamiento4);
                List<string> ListaAtributosTratamiento5 = Cliente.LOGICA.Metodo.CrearListaAtributosTratamiento(ObjTratamiento5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarFinca(ObjFinca1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarFinca(ObjFinca2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarFinca(ObjFinca3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarFinca(ObjFinca4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarFinca(ObjFinca5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado(ObjEmpleado1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado(ObjEmpleado2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado(ObjEmpleado3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado(ObjEmpleado4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado(ObjEmpleado5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarRaza(ObjRaza1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarRaza(ObjRaza2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarRaza(ObjRaza3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarRaza(ObjRaza4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarRaza(ObjRaza5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarDueño(ObjDueño1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarDueño(ObjDueño2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarDueño(ObjDueño3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarDueño(ObjDueño4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarDueño(ObjDueño5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal5);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarAnimal(ObjAnimal6);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacuna(ListaAtributosVacuna5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacunamiento(ListaAtributosVacunamiento1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacunamiento(ListaAtributosVacunamiento2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacunamiento(ListaAtributosVacunamiento3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacunamiento(ListaAtributosVacunamiento4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacunamiento(ListaAtributosVacunamiento5);

                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarTratamiento(ListaAtributosTratamiento1);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarTratamiento(ListaAtributosTratamiento2);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarTratamiento(ListaAtributosTratamiento3);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarTratamiento(ListaAtributosTratamiento4);
                Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarTratamiento(ListaAtributosTratamiento5);
            }
        }
    }
}

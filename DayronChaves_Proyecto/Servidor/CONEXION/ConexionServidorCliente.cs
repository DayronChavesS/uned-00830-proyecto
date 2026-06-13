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
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Servidor.CONEXION
{
    //En esta clase se encuentra todo el codigo que administra la conexion via Cliente <<< Servidor
    public class ConexionServidorCliente
    {
        public static bool ServidorIniciado = false; //bandera que indica el estado del servidor
        private static IPAddress ServidorIP; //ip del servidor (local host)
        private static TcpClient ClienteTCP; //clientetcp para hacer la conexion
        private static TcpListener ServidorListener; //objeto que escucha por mensajes
        private static Thread HiloEscucharClientes; //hilo de subprocesamiento para escuchar multiples clientes
        private static Thread HiloCliente; //hilo de subprocesamiento para escuchar multiples clientes
        private static NetworkStream ClienteStream; //flujo de datos del cliente
        private static ASCIIEncoding Codificador; //traductor de bytes a palabras
        private static int BytesLeidos; //numero de bytes leidos para determinar largo de una cadena
        private static byte[] BufferDeDatos; //arreglo de bytes que contiene informacion traducida a bytes
        //PARA OBJETOS
        private static BinaryFormatter ConvertirABinario; //usado con "Serialize" convierte cualquier objeto a binario
        private static BinaryFormatter TraducirDeBinario; //usado con "Deserialize" convierte cualquier arreglo de bytes a un objeto
        //EVENTOS
        public static List<string> ListaEventos = new List<string>(); //se crea la lista que contiene los eventos que han ocurrido en el lado del cliente
        public static int ClientesConectados; //numero de clientes conectados actualmente en el servidor

        public static void IniciarServidor()
        {
            ServidorIP = IPAddress.Parse("127.0.0.1"); //se especifica una direccion IP de tipo localhost
            ServidorListener = new TcpListener(ServidorIP, 25000); //se indica al escuchador que debe leer mensajes en esta direccion
            HiloEscucharClientes = new Thread(new ThreadStart(EscucharClientes)); //se crea un nuevo hilo de procesamiento
            HiloEscucharClientes.Start(); //se inicia el hilo
            HiloEscucharClientes.IsBackground = true; //se deja en baja prioridad
            ServidorIniciado = true; //se establece que se ha iniciado el servidor
        }

        //metodo para detener servidor
        public static void DetenerServidor()
        {
            //si estaba inciado
            if (ServidorIniciado == true)
            {
                ServidorListener.Stop(); //se detiene el escuchador
                ServidorIniciado = false; //esta bandera cerrara todos los procesos, metodos y instancias activas
            }
        }

        //metodo de subprocesamiento para escuchar los clientes
        public static void EscucharClientes()
        {
            ServidorListener.Start(); //se inicia el servidor

            while (ServidorIniciado == true) //mientras este iniciado
            {
                try
                {
                    ClienteTCP = ServidorListener.AcceptTcpClient(); //se aceptaran clientes
                    HiloCliente = new Thread(new ParameterizedThreadStart(ComunicacionConCliente)); //se crearan nuevos hilos de comunicacion
                    HiloCliente.Start(ClienteTCP); //se empezaran los hilos
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        //este metodo es el que escucha los mensajes provinientes del cliente
        public static void ComunicacionConCliente(object cliente)
        {
            ClienteTCP = (TcpClient)cliente; //se obtiene el canal de comunicacion del cliente para este hilo
            ClienteStream = ClienteTCP.GetStream(); //se obtiene el canal donde fluye la informacion
            Codificador = new ASCIIEncoding(); //se crea un nuevo traductor bytes >> palabras
            BufferDeDatos = new byte[4096]; //se crea una variable de almacenamiento de bytes

            BytesLeidos = 0;

            //se escucha por informacion
            while (ServidorIniciado == true)
            {
                try
                {   //se intenta obtener informacion
                    BytesLeidos = ClienteStream.Read(BufferDeDatos, 0, BufferDeDatos.Length);
                }
                catch (Exception) //si no hay informacion ocurre una expecion
                {
                    break; //se rompe el ciclo
                }

                if (BytesLeidos == 0) //si no hay bytes
                {
                    break; //se rompe el ciclo
                }

                //SE RECIBIO UN MENSAJE!!

                Codificador = new ASCIIEncoding();
                string mensajerecibido = Codificador.GetString(BufferDeDatos, 0, BytesLeidos);

                //segun el mensaje recibido se llamaran distintos metodos
                //usando un switch para controlar el flujo del programa
                switch (mensajerecibido)
                {
                    case "servidor":                EnviarEstado();             break;
                    case "login":                   VerificarLogin();           break;
                    case "registro":                RegistrarEmpleado();        break;
                    case "finca":                   EnviarFincas();             break;
                    case "animal":                  EnviarAnimales();           break;
                    case "vacuna":                  EnviarVacunas();            break;
                    case "tratamiento":             EnviarTratamientos();       break;
                    case "vacunamiento":            EnviarVacunamientos();      break;
                    case "registrovacunamiento":    RegistrarVacunamientos();   break;
                    case "registrotratamiento":     RegistrarTratamiento();     break;
                    case "evento":                  RegistrarEvento();          break;
                    case "fincavacia":              FincaEstaVacia();           break;
                    case "animalvacio":             AnimalEstaVacia();          break;
                    case "vacunavacio":             VacunaEstaVacio();          break;
                    case "vacunamientovacio":       VacunamientoEstaVacio();    break;
                    case "tratamientovacio":        TratamientoEstaVacio();     break;
                    case "animalfinca":             AnimalEsDeFinca();          break;
                }
            }
        }

        //¿el servidor esta iniciado?
        public static void EnviarEstado()
        {
            if (ServidorIniciado == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //el cliente hace una solicitud y necesita saber si esta fue exitosa o no
        //el servidor puede responder mediate un mensaje
        public static void EnviarRespuesta(string datos)
        {
            ClienteStream = ClienteTCP.GetStream();
            Codificador = new ASCIIEncoding();
            byte[] BufferDeDatos = Codificador.GetBytes(datos);
            ClienteStream.Write(BufferDeDatos, 0, BufferDeDatos.Length);
            ClienteStream.Flush();
        }

        //determina si la informacion de cuenta que envio el usuario es valida o no
        public static void VerificarLogin()
        {
            List<string> Usuario = new List<string>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se recibe la informacion que se enviara del cliente
            Usuario = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);

            //si el usuario existe...
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLValidarLogin(Usuario) == true)
            {
                EnviarRespuesta("true");
            }
            else //si el usuario no existia en la base de datos...
            {
                EnviarRespuesta("false");
            }
        }

        //obtiene informacion de un empleado desde el cliente y lo intenta registrar en la base de datos
        public static void RegistrarEmpleado()
        {
            List<string> Empleado = new List<string>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se recibe la informacion que se enviara del cliente
            Empleado = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);

            //se inserta la informacion recibida;
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarEmpleado_Cliente(Empleado) == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //se devuelve una lista con los numeros de fincas que hay en la base de datos
        public static void EnviarFincas()
        {
            List<int> ListaFincas;
            ListaFincas = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerNumeroFinca();
            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, ListaFincas);
        }

        //se devuelve una lista con los identificadores de animales que hay en la base de datos
        public static void EnviarAnimales()
        {
            List<string> ListaAnimales;
            ListaAnimales = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerIdentificacionAnimal();
            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, ListaAnimales);
        }

        //se devuelve una lista con los identificadores de vacunas que hay en la base de datos
        public static void EnviarVacunas()
        {
            List<int> ListaVacunas;
            ListaVacunas = Servidor.CONEXION.ConexionBaseDeDatos.SQLObtenerIdentificadorVacuna();
            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, ListaVacunas);
        }

        //se devuelve una lista con todos los tratamientos que hay en la base de datos
        public static void EnviarTratamientos()
        {
            List<string> ListaTratamientos;
            ListaTratamientos = Servidor.CONEXION.ConexionBaseDeDatos.SQLConsultarTratamientos();
            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, ListaTratamientos);
        }

        //se devuelve una lista con todos los vacunamientos que hay en la base de datos
        public static void EnviarVacunamientos()
        {
            List<string> ListaVacunamientos;
            ListaVacunamientos = Servidor.CONEXION.ConexionBaseDeDatos.SQLConsultarVacunamientos();
            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, ListaVacunamientos);
        }


        //obtiene informacion de un vacunamiento desde el cliente y lo intenta registrar en la base de datos
        public static void RegistrarVacunamientos()
        {
            List<string> Vacunamiento = new List<string>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();


            //se recibe la informacion que se enviara del cliente
            Vacunamiento = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);

            //se inserta la informacion recibida


            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarVacunamiento(Vacunamiento) == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //obtiene informacion de un tratamiento desde el cliente y lo intenta registrar en la base de datos
        public static void RegistrarTratamiento()
        {
            List<string> Tratamiento = new List<string>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se recibe la informacion que se enviara del cliente
            Tratamiento = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);

            //se inserta la informacion recibida
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLInsertarTratamiento(Tratamiento) == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //obtiene informacion de un evento desde el cliente y lo intenta registrar lista
        public static void RegistrarEvento()
        {
            List<string> Evento = new List<string>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se recibe la informacion que se enviara del cliente
            Evento = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);

            //se inserta la informacion recibida
            RegistrarNuevoEvento(Evento[0]);
        }

        //¿la tabla de fincas esta vacia?
        public static void FincaEstaVacia()
        {
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaFincaVacia() == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //¿la tabla de animales esta vacia?
        public static void AnimalEstaVacia()
        {
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaAnimalVacia() == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //¿la tabla de vacunas esta vacia?
        public static void VacunaEstaVacio()
        {
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaVacunaVacia() == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //¿la tabla de vacunamientos esta vacia?
        public static void VacunamientoEstaVacio()
        {
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaVacunamientoVacia() == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //¿la tabla de tratamientos esta vacia?
        public static void TratamientoEstaVacio()
{
            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLTablaTratamientoVacia() == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //¿este animal es de esa finca?
        public static void AnimalEsDeFinca()
        {
            List<string> FincaYAnimal = new List<string>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se recibe la informacion que se enviara del cliente
            FincaYAnimal = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);


            if (Servidor.CONEXION.ConexionBaseDeDatos.SQLEsteAnimalEsDeEstaFinca(FincaYAnimal) == true)
            {
                EnviarRespuesta("true");
            }
            else
            {
                EnviarRespuesta("false");
            }
        }

        //este metodo permite modificar la lista de auditoria
        public static void RegistrarNuevoEvento(string NuevoEvento)
        {
            //se añade el evento obtenido por parametro a la lista de auditoria de servidor
            ListaEventos.Add(NuevoEvento);

            //si se desconecto un cliente....
            if (NuevoEvento.Contains(", se desconecto."))
            {
                ClientesConectados--; //se resta uno a la variable de clientes conectados
            }
            //si se conecto un cliente...
            else if (NuevoEvento.Contains(", se conecto"))
            {
                ClientesConectados++; //se suma uno a la variable de clientes conectados
            }
        }
    }
}

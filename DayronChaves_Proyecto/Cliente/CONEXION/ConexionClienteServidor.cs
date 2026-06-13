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
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Cliente.CONEXION
{
    //En esta clase se encuentra todo el codigo que administra la conexion via Cliente >>> Servidor
    public class ConexionClienteServidor
    {
        private static IPAddress ServidorIP;  //ip del servidor (local host)
        private static TcpClient ClienteTCP; //clientetcp para hacer la conexion
        private static IPEndPoint ServidorEndPoint; //objeto que contiene toda la informacion de la direccion del servidor (ip + puerto)
        private static NetworkStream ClienteStream; //flujo de datos del cliente
        private static ASCIIEncoding Codificador; //traductor de bytes a palabras
        private static int BytesLeidos; //numero de bytes leidos para determinar largo de una cadena
        private static byte[] BufferDeDatos; //arreglo de bytes que contiene informacion traducida a bytes
        //PARA OBJETOS
        private static BinaryFormatter TraducirDeBinario; //usado con "Deserialize" convierte cualquier arreglo de bytes a un objeto
        private static BinaryFormatter ConvertirABinario; //usado con "Serialize" convierte cualquier objeto a binario

        public static bool ConectarAServidor()
        {
            bool conectado = true;

            ServidorIP = IPAddress.Parse("127.0.0.1"); //se especifica una direccion IP de tipo localhost
            ClienteTCP = new TcpClient();
            ServidorEndPoint = new IPEndPoint(ServidorIP, 25000); //se declara protocolo 25000
            try
            {
                ClienteTCP.Connect(ServidorEndPoint);
            }
            catch (Exception)
            {
                conectado = false;
                MessageBox.Show("Primero debe iniciar el servidor.", "NO SE PUDO CONECTAR AL SERVIDOR.", MessageBoxButtons.OK);
            }

            return conectado;
        }
        public static void DesconectarDeServidor()
        {
            ClienteTCP.Close();
            ClienteStream.Close();
        }

        public static string EscucharServidor()
        {
            ClienteStream = ClienteTCP.GetStream(); //se obtiene el canal donde fluye la informacion
            Codificador = new ASCIIEncoding(); //se crea un nuevo traductor bytes >> palabras
            BufferDeDatos = new byte[4096]; //se crea una variable de almacenamiento de bytes

            BytesLeidos = 0;
            string mensajerecibido = "";

            //se escucha por informacion
            while (true)
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
                mensajerecibido = Codificador.GetString(BufferDeDatos, 0, BytesLeidos);
                break;
            }
            return mensajerecibido;
        }


        public static void EnviarUnaSolicitud(string datos)
        {
            ClienteStream = ClienteTCP.GetStream();
            Codificador = new ASCIIEncoding();
            byte[] BufferDeDatos = Codificador.GetBytes(datos);
            ClienteStream.Write(BufferDeDatos, 0, BufferDeDatos.Length);
            ClienteStream.Flush();
        }

        public static bool ServidorEstado()
        {
            bool activo = false;

            //se envia la solicitud
            EnviarUnaSolicitud("servidor");

            if (EscucharServidor() == "true")
            {
                activo = true;
            }
            else
            {
                MessageBox.Show("El servidor se cayo.", "ERROR", MessageBoxButtons.OK);
            }

            return activo;
        }

        public static bool IntentarLogin(List<string> InformacionUsuario)
        {
            bool valido = false;

            //se envia la solicitud
            EnviarUnaSolicitud("login");

            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, InformacionUsuario);

            if (EscucharServidor() == "true")
            {
                valido = true;
            }

            return valido;
        }

        public static bool EnviarEmpleado(List<string> InformacionEmpleado)
        {
            bool exito = false;

            //se envia la solicitud
            EnviarUnaSolicitud("registro");

            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, InformacionEmpleado);

            if (EscucharServidor() == "true")
            {
                exito = true;
            }

            return exito;
        }

        public static List<int> RecibirFincas()
        {
            List<int> Fincas = new List<int>();
            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se envia la solicitud
            EnviarUnaSolicitud("finca");

            //se recibe la informacion que se enviara del servidor
            Fincas = (List<int>)TraducirDeBinario.Deserialize(ClienteStream);

            return Fincas;
        }

        public static List<string> RecibirAnimales()
        {
            List<string> Animales = new List<string>();

            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se envia la solicitud
            EnviarUnaSolicitud("animal");

            //se recibe la informacion que se enviara del servidor
            Animales = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);


            return Animales;
        }

        public static List<int> RecibirVacunas()
        {
            List<int> Vacunas = new List<int>();

            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se envia la solicitud
            EnviarUnaSolicitud("vacuna");

            //se recibe la informacion que se enviara del servidor
            Vacunas = (List<int>)TraducirDeBinario.Deserialize(ClienteStream);


            return Vacunas;
        }

        public static List<string> RecibirVacunamientos()
        {
            List<string> Vacunamientos = new List<string>();

            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se envia la solicitud
            EnviarUnaSolicitud("vacunamiento");

            //se recibe la informacion que se enviara del servidor
            Vacunamientos = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);


            return Vacunamientos;
        }

        public static List<string> RecibirTratamientos()
        {
            List<string> Tratamientos = new List<string>();

            ClienteStream = ClienteTCP.GetStream();
            TraducirDeBinario = new BinaryFormatter();

            //se envia la solicitud
            EnviarUnaSolicitud("tratamiento");

            //se recibe la informacion que se enviara del servidor
            Tratamientos = (List<string>)TraducirDeBinario.Deserialize(ClienteStream);


            return Tratamientos;
        }

        public static bool EnviarTratamiento(List<string> InformacionTratamiento)
        {
            bool exito = false;

            //se envia la solicitud
            EnviarUnaSolicitud("registrotratamiento");

            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, InformacionTratamiento);

            if (EscucharServidor() == "true")
            {
                exito = true;
            }

            return exito;

        }

        public static bool EnviarVacunamiento(List<string> InformacionVacunamiento)
        {
            bool exito = false;

            //se envia la solicitud
            EnviarUnaSolicitud("registrovacunamiento");

            ConvertirABinario = new BinaryFormatter();
            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, InformacionVacunamiento);


            if (EscucharServidor() == "true")
            {
                exito = true;
            }

            return exito;
        }

        public static void EnviarEvento(string eventonuevo)
        {
            //se envia la solicitud
            EnviarUnaSolicitud("evento");

            List<string> Evento = new List<string>();
            Evento.Add(eventonuevo);
            ConvertirABinario = new BinaryFormatter();

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, Evento);
        }

        public static bool TablaFincaEstaVacia()
        {
            bool vacio = false;

            //se envia la solicitud
            EnviarUnaSolicitud("fincavacia");
            if (EscucharServidor() == "true")
            {
                vacio = true;
            }

            return vacio;
        }

        public static bool TablaAnimalEstaVacia()
        {
            bool vacio = false;

            //se envia la solicitud
            EnviarUnaSolicitud("animalvacio");
            if (EscucharServidor() == "true")
            {
                vacio = true;
            }

            return vacio;
        }

        public static bool TablaVacunaEstaVacia()
        {
            bool vacio = false;

            //se envia la solicitud
            EnviarUnaSolicitud("vacunavacio");
            if (EscucharServidor() == "true")
            {
                vacio = true;
            }

            return vacio;
        }

        public static bool TablaVacunamientoEstaVacia()
        {
            bool vacio = false;

            //se envia la solicitud
            EnviarUnaSolicitud("vacunamientovacio");
            if (EscucharServidor() == "true")
            {
                vacio = true;
            }

            return vacio;
        }

        public static bool TablaTratamientoEstaVacia()
        {
            bool vacio = false;

            //se envia la solicitud
            EnviarUnaSolicitud("tratamientovacio");
            if (EscucharServidor() == "true")
            {
                vacio = true;
            }

            return vacio;
        }

        public static bool AnimalEsDeFinca(List<string> FincaYAnimal)
        {
            bool EsDeLaFinca = false;

            //se envia la solicitud
            EnviarUnaSolicitud("animalfinca");

            //se seraliza la lista y se envia a traves del flujo de informacion
            ConvertirABinario.Serialize(ClienteStream, FincaYAnimal);

            if (EscucharServidor() == "true")
            {
                EsDeLaFinca = true;
            }

            return EsDeLaFinca;
        }
    }
}

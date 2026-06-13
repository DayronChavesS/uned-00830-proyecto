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
namespace Servidor.CLASES
{
    //Esta clase contiene todos los atributos y propiedades del objeto Dueño.
    public class Dueño : Persona //Esta clase hereda los atributos de la clase persona.
    {
        //atributos con sus setters y getters
        public string DueñoCorreo { set; get; }
        public int DueñoCelular { set; get; }
        public int DueñoFinca { set; get; }

        //constructor completo
        public Dueño(string dueñoCorreo, int dueñoCelular, int dueñoFinca)
        {
            DueñoCorreo = dueñoCorreo ?? throw new ArgumentNullException(nameof(dueñoCorreo));
            DueñoCelular = dueñoCelular;
            DueñoFinca = dueñoFinca;
        }

        //constructor vacio
        public Dueño()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Identificacion: {0} Nombre: {1} Primer Apellido: {2} Segundo Apellido: {3} Correo: {4} Celular: {5} Numero de Finca: {6}",
                                PersonaIdentificacion, PersonaNombre, PersonaPrimerApellido, PersonaSegundoApellido, DueñoCorreo, DueñoCelular, DueñoFinca);
        }

    }
}

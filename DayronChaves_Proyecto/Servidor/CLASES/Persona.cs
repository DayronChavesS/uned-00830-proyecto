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
    //Esta clase contiene todos los atributos y propiedades del objeto Persona.
    //Para informacion mas especifica dirijase a las clases de Dueño o Empleado.
    public class Persona
    {
        //atributos con sus setters y getters
        public int PersonaIdentificacion { set; get; }
        public string PersonaNombre { set; get; }
        public string PersonaPrimerApellido { set; get; }
        public string PersonaSegundoApellido { set; get; }

        //constructor completo
        public Persona(int personaIdentificacion, string personaNombre, string personaPrimerApellido, string personaSegundoApellido)
        {
            PersonaIdentificacion = personaIdentificacion;
            PersonaNombre = personaNombre ?? throw new ArgumentNullException(nameof(personaNombre));
            PersonaPrimerApellido = personaPrimerApellido ?? throw new ArgumentNullException(nameof(personaPrimerApellido));
            PersonaSegundoApellido = personaSegundoApellido ?? throw new ArgumentNullException(nameof(personaSegundoApellido));
        }

        //constructor vacio
        public Persona()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Identificacion: {0} Nombre: {1} {2} {3} ",
                                  PersonaIdentificacion, PersonaNombre, PersonaPrimerApellido, PersonaSegundoApellido);
        }

    }


}

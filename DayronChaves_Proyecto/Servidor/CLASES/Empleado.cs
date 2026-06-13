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
    //Esta clase contiene todos los atributos y propiedades del objeto Empleado.

    public class Empleado : Persona //Esta clase hereda los atributos de la clase persona.
    {
        //atributos con sus setters y getters
        public decimal EmpleadoSalario { set; get; }
        public string EmpleadoUsuario { set; get; }
        public string EmpleadoContraseña { set; get; }
        public int EmpleadoEstado { set; get; }

        //constructor completo

        public Empleado(decimal empleadoSalario, string empleadoUsuario, string empleadoContraseña, int empleadoEstado)
        {
            EmpleadoSalario = empleadoSalario;
            EmpleadoUsuario = empleadoUsuario ?? throw new ArgumentNullException(nameof(empleadoUsuario));
            EmpleadoContraseña = empleadoContraseña ?? throw new ArgumentNullException(nameof(empleadoContraseña));
            EmpleadoEstado = empleadoEstado;
        }

        //constructor vacio
        public Empleado()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Identificacion: {0} Nombre: {1} {2} {3} Salario: {4} Usuario: {5} Contraseña: {6} Estado: {7}",
                                  PersonaIdentificacion, PersonaNombre, PersonaPrimerApellido, PersonaSegundoApellido, EmpleadoSalario, EmpleadoUsuario, EmpleadoContraseña, EmpleadoEstado);
        }

    }
}

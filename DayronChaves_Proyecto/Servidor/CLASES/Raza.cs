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
    //Esta clase contiene todos los atributos y propiedades del objeto Tratamiento.
    public class Raza
    {
        //atributos con sus setters y getters
        public int CodigoRaza { set; get; }
        public string DescripcionRaza { set; get; }

        //constructor completo
        public Raza(int codigoRaza, string descripcionRaza)
        {
            CodigoRaza = codigoRaza;
            DescripcionRaza = descripcionRaza ?? throw new ArgumentNullException(nameof(descripcionRaza));
        }

        //constructor vacio
        public Raza()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Codigo: {0} " + "Descripcion: {1} ",
                                CodigoRaza, DescripcionRaza);
        }


    }
}

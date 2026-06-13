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
    //Esta clase contiene todos los atributos y propiedades del objeto Finca.
    public class Finca
    {
        //atributos con sus setters y getters
        public int FincaNumero { set; get; }
        public string FincaNombre { set; get; }
        public int FincaTamaño { set; get; }
        public string FincaDireccion { set; get; }
        public int FincaTelefono { set; get; }

        //constructor completo
        public Finca(int fincaNumero, string fincaNombre, int fincaTamaño, string fincaDireccion, int fincaTelefono)
        {
            FincaNumero = fincaNumero;
            FincaNombre = fincaNombre ?? throw new ArgumentNullException(nameof(fincaNombre));
            FincaTamaño = fincaTamaño;
            FincaDireccion = fincaDireccion ?? throw new ArgumentNullException(nameof(fincaDireccion));
            FincaTelefono = fincaTelefono;
        }

        //constructor vacio
        public Finca()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Numero: {0} Nombre: {1} Tamaño: {2} Direccion: {3} Telefono: {4}",
                                  FincaNumero, FincaNombre, FincaTamaño, FincaDireccion, FincaTelefono);
        }


    }
}
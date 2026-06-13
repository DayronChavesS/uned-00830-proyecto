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

namespace Cliente.CLASES
{
    //Esta clase contiene todos los atributos y propiedades del objeto Tratamiento.
    public class Tratamiento
    {
        //atributos con sus setters y getters
        public int TratamientoAnimal { set; get; }
        public string TratamientoFecha { set; get; }
        public string TratamientoDiagnostico { set; get; }
        public string TratamientoMedicamento { set; get; }
        public int TratamientoDias { set; get; }
        public string TratamientoObservaciones { set; get; }
        public int TratamientoFinca { set; get; }

        //constructor completo
        public Tratamiento(int tratamientoFinca, int tratamientoAnimal, string tratamientoFecha, string tratamientoDiagnostico, string tratamientoMedicamento, int tratamientoDias, string tratamientoObservaciones)
        {
            TratamientoAnimal = tratamientoAnimal;
            TratamientoFecha = tratamientoFecha ?? throw new ArgumentNullException(nameof(tratamientoFecha));
            TratamientoDiagnostico = tratamientoDiagnostico ?? throw new ArgumentNullException(nameof(tratamientoDiagnostico));
            TratamientoMedicamento = tratamientoMedicamento ?? throw new ArgumentNullException(nameof(tratamientoMedicamento));
            TratamientoDias = tratamientoDias;
            TratamientoObservaciones = tratamientoObservaciones ?? throw new ArgumentNullException(nameof(tratamientoObservaciones));
        }

        //constructor vacio
        public Tratamiento()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Animal: {0} Fecha de Tratamiento: {1} Diagnostico: {2} Medicamento Aplicado: {3} Dias de Tratamiento: {4} Observaciones: {5}",
                                  TratamientoAnimal, TratamientoFecha, TratamientoDiagnostico, TratamientoMedicamento, TratamientoDias, TratamientoObservaciones);
        }
    }
}

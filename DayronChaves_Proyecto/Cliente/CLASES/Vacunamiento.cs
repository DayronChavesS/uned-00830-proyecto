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
    //Esta clase contiene todos los atributos y propiedades del objeto Vacunamiento.
    public class Vacunamiento
    {
        //atributos con sus setters y getters
        public int VacunamientoAnimal { set; get; }
        public int VacunamientoVacuna { set; get; }
        public string VacunamientoFecha { set; get; }
        public string VacunamientoEnfermedad { set; get; }
        public string VacunamientoObservaciones { set; get; }
        public int VacunamientoFinca { set; get; }

        //constructor completo
        public Vacunamiento(int vacunamientoAnimal, int vacunamientoVacuna, string vacunamientoFecha, string vacunamientoEnfermedad, string vacunamientoObservaciones)
        {
            VacunamientoAnimal = vacunamientoAnimal;
            VacunamientoVacuna = vacunamientoVacuna;
            VacunamientoFecha = vacunamientoFecha ?? throw new ArgumentNullException(nameof(vacunamientoFecha));
            VacunamientoEnfermedad = vacunamientoEnfermedad ?? throw new ArgumentNullException(nameof(vacunamientoEnfermedad));
            VacunamientoObservaciones = vacunamientoObservaciones ?? throw new ArgumentNullException(nameof(vacunamientoObservaciones));
        }

        //constructor vacio
        public Vacunamiento()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Animal: {0} Vacuna: {1} Fecha de Aplicacion: {2} Enfermedad: {3} Observaciones: {4} ",
                                  VacunamientoAnimal, VacunamientoVacuna, VacunamientoFecha, VacunamientoEnfermedad, VacunamientoObservaciones);
        }
    }
}

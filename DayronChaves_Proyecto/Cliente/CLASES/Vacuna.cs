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

namespace Cliente.CLASES
{
    //Esta clase contiene todos los atributos y propiedades del objeto Vacuna.
    public class Vacuna
    {
        //atributos con sus setters y getters

        public int VacunaIdentificador { set; get; }

        public string VacunaDescripcion { set; get; }

        //constructor vacio
        public Vacuna()
        {
        }

        //constructor completo
        public Vacuna(int vacunaIdentificador, string vacunaDescripcion)
        {
            VacunaIdentificador = vacunaIdentificador;
            VacunaDescripcion = vacunaDescripcion;
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Identificador: {0} Descripcion: {1}",
                                  VacunaIdentificador, VacunaDescripcion);
        }

    }
}

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
    //Esta clase contiene todos los atributos y propiedades del objeto Animal.
    public class Animal
    {
        //atributos con sus setters y getters
        public int AnimalIdentificacion { set; get; }
        public string AnimalNombre { set; get; }
        public int AnimalFinca { set; get; }
        public int AnimalRaza { set; get; }
        public string AnimalFechaNacimiento { set; get; }
        public int AnimalSexo { set; get; }
        public int AnimalMadre { set; get; }
        public int AnimalPadre { set; get; }

        //constructor completo
        public Animal(int animalIdentificacion, string animalNombre, int animalFinca, int animalRaza, string animalFechaNacimiento, int animalSexo, int animalMadre, int animalPadre)
        {
            AnimalIdentificacion = animalIdentificacion;
            AnimalNombre = animalNombre ?? throw new ArgumentNullException(nameof(animalNombre));
            AnimalFinca = animalFinca;
            AnimalRaza = animalRaza;
            AnimalFechaNacimiento = animalFechaNacimiento ?? throw new ArgumentNullException(nameof(animalFechaNacimiento));
            AnimalSexo = animalSexo;
            AnimalMadre = animalMadre;
            AnimalPadre = animalPadre;
        }

        //constructor vacio
        public Animal()
        {
        }

        //metodo para convertir la clase a un string
        public override string ToString()
        {
            return string.Format("Identificacion: {0} Nombre: {1} Finca: {2} Raza: {3} Fecha Nacimiento: {4} Sexo: {5} Madre: {6} Padre: {7}",
                                  AnimalIdentificacion, AnimalNombre, AnimalFinca, AnimalRaza, AnimalFechaNacimiento, AnimalSexo, AnimalMadre, AnimalPadre);
        }
    }
}

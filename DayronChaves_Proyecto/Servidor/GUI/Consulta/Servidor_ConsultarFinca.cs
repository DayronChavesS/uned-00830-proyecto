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

using Servidor.CLASES;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Servidor.GUI.Consulta
{
    //este formulario permite que el usuario consulte fincas
    public partial class Servidor_ConsultarFinca : Form
    {
        public Servidor_ConsultarFinca()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Servidor_ConsultarFinca_Load(object sender, EventArgs e)
        {
            //se crea una coleccion generica que contiene objetos finca
            List<Finca> ListaFinca;
            //se llena la lista con una consulta a la base de datos
            ListaFinca = Servidor.CONEXION.ConexionBaseDeDatos.SQLConsultarFincas();

            //se setea la fuente de datos del datagridview a la coleccion generica
            DGV_Finca.DataSource = ListaFinca;

            //se configura el datagridview para que sus columnas aumenten de tamaño segun los valores que contengan las celdas
            DGV_Finca.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

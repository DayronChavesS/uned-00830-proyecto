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
    //este formulario permite que el usuario consulte dueños
    public partial class Servidor_ConsultarDueño : Form
    {
        public Servidor_ConsultarDueño()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Servidor_ConsultarDueño_Load(object sender, EventArgs e)
        {
            //se crea una coleccion generica que contiene dueños
            List<Dueño> ListaDueño;
            //se llena la lista con una consulta a la base de datos
            ListaDueño = Servidor.CONEXION.ConexionBaseDeDatos.SQLConsultarDueño();

            //se setea la fuente de datos del datagridview a la coleccion generica
            DGV_Dueño.DataSource = ListaDueño;

            //se configura el datagridview para que sus columnas aumenten de tamaño segun los valores que contengan las celdas
            DGV_Dueño.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

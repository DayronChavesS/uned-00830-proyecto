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
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cliente.GUI.Consulta
{
    //este formulario permite que el usuario consulte tratamientos
    public partial class Cliente_ConsultarTratamiento : Form
    {
        public Cliente_ConsultarTratamiento()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Cliente_ConsultarTratamiento_Load(object sender, EventArgs e)
        {
            //se crea una coleccion generica que contiene string
            List<string> ListaTratamientos;
            //se llena la lista con una consulta a la base de datos por medio del servidor
            ListaTratamientos = Cliente.CONEXION.ConexionClienteServidor.RecibirTratamientos();

            //se setea la fuente de datos del datagridview a la coleccion generica
            //se indica que se debe seleccionar cada valor dentro de esta lista
            DGV_Tratamientos.DataSource = ListaTratamientos.Select(x => new { Value = x }).ToList();

            //se configura el datagridview para que sus columnas aumenten de tamaño segun los valores que contengan las celdas
            DGV_Tratamientos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

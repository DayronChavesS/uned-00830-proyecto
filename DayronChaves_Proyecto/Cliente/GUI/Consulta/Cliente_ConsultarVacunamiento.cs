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
    public partial class Cliente_ConsultarVacunamiento : Form
    {
        //este formulario permite que el usuario consulte vacunamientos
        public Cliente_ConsultarVacunamiento()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Cliente_ConsultarVacuna_Load(object sender, EventArgs e)
        {
            //se crea una coleccion generica que contiene strings
            List<string> ListaVacunamientos;
            //se llena la lista con una consulta a la base de datos por medio del servidor
            ListaVacunamientos = Cliente.CONEXION.ConexionClienteServidor.RecibirVacunamientos();

            //se setea la fuente de datos del datagridview a la lista de vacunamientos
            //se indica que se debe seleccionar cada valor dentro de esta lista
            DGV_Vacunamientos.DataSource = ListaVacunamientos.Select(x => new { Value = x }).ToList();

            //se configura el datagridview para que sus columnas aumenten de tamaño segun los valores que contengan las celdas
            DGV_Vacunamientos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

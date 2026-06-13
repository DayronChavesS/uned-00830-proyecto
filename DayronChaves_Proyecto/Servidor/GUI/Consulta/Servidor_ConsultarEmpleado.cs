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
    //este formulario permite que el usuario consulte empleados
    public partial class Servidor_ConsultarEmpleado : Form
    {
        public Servidor_ConsultarEmpleado()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void Servidor_ConsultarEmpleado_Load(object sender, EventArgs e)
        {
            //se crea una coleccion generica que contiene objetos empleado
            List<Empleado> ListaEmpleado;
            //se llena la lista con una consulta a la base de datos
            ListaEmpleado = Servidor.CONEXION.ConexionBaseDeDatos.SQLConsultarEmpleado();

            //se setea la fuente de datos del datagridview a la coleccion generica
            DGV_Empleado.DataSource = ListaEmpleado;

            //se configura el datagridview para que sus columnas aumenten de tamaño segun los valores que contengan las celdas
            DGV_Empleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

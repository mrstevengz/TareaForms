using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trabajo_Steven
{
    public partial class Form1 : Form
    {

        public class Estudiante
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int CIF { get; set; }
            public string Carrera { get; set; }
            public decimal Promedio { get; set; }
            public int MateriasA { get; set; }

            public Estudiante(string nombre, string apellido, int cif, string carrera, decimal promedio, int materiasaprobadas)
            {
                Nombre = nombre;
                Apellido = apellido;
                CIF = cif;
                Carrera = carrera;
                Promedio = promedio;
                MateriasA = materiasaprobadas;
            }
        }

        public List<Estudiante> estudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarEstudiante()
        {
            string nombre = tBoxNombre.Text;
            string apellido = tBoxApellido.Text;
            int cif = int.Parse(tBoxCIF.Text);
            string carrera = cBoxCarrera.SelectedItem.ToString();
            decimal promedio = decimal.Parse(tBoxPromedio.Text);
            int materiasaprobadas = int.Parse(tBoxMaterias.Text);

            estudiantes.Add(new Estudiante(nombre, apellido, cif, carrera, promedio, materiasaprobadas));
            Limpiar();
            ActualizarCuenta();
            CargarGrafico();

        }

        private void Limpiar()
        {
            tBoxNombre.Clear();
            tBoxApellido.Clear();
            tBoxPromedio.Clear();
            tBoxCIF.Clear();
            cBoxCarrera.SelectedIndex = -1;
            tBoxPromedio.Clear();
            tBoxMaterias.Clear();
        }

        private void ActualizarDataGrid()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = estudiantes;
            ActualizarCuenta();
            CargarGrafico();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEstudiante();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEstudiante();
            ActualizarDataGrid();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarEstudiante();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripEstado_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarEstudiante();
        }

        private void ActualizarCuenta()
        {
          toolStripEstado.Text = $"Estudiantes registrados en el sistema: {estudiantes.Count}";
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = dgvLista.CurrentCell.RowIndex;
            Estudiante estudiante = estudiantes[c];

            tBoxNombre.Text = estudiante.Nombre;
            tBoxApellido.Text = estudiante.Apellido;
            tBoxCIF.Text = estudiante.CIF.ToString();
            cBoxCarrera.SelectedItem = estudiante.Carrera;
            tBoxPromedio.Text = estudiante.Promedio.ToString();
            tBoxMaterias.Text = estudiante.MateriasA.ToString();

            estudiantes.RemoveAt(c);
            ActualizarDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLista.ContextMenuStrip = contextMenu;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrafico()
        {
            graficoEstudiantes.Series.Clear();
            graficoEstudiantes.Titles.Clear();
            graficoEstudiantes.ChartAreas[0].AxisX.Interval = 1;
            graficoEstudiantes.ChartAreas[0].AxisY.Interval = 1;
            graficoEstudiantes.ChartAreas[0].AxisY.Maximum = 5;

            Series serie = new Series("Estudiantes por Carrera");

            var carreras = estudiantes
                .GroupBy(e => e.Carrera)
                .Select(g => new { Carrera = g.Key, Cantidad = g.Count() });

            foreach (var carrera in carreras)
            {
                serie.Points.AddXY(carrera.Carrera, carrera.Cantidad);
            }

            graficoEstudiantes.Series.Add(serie);
            graficoEstudiantes.ChartAreas[0].AxisX.Title = "Carreras";
            graficoEstudiantes.ChartAreas[0].AxisY.Title = "Número de Estudiantes";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GuardarEstudiante();
        }

        private void tStripEliminar_Click(object sender, EventArgs e)
        {
            EliminarEstudiante();
        }

        private void EliminarEstudiante()
        {
            int x = dgvLista.CurrentCell.RowIndex;
            estudiantes.RemoveAt(x);
            ActualizarDataGrid();
        }

        private void tStripActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }
    }
}

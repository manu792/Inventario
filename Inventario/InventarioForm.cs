using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Commons.Modelos;
using Inventario.Servicios;

namespace Inventario
{
    public partial class InventarioForm : Form
    {
        private ServicioInventario ServicioInventario { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }

        public InventarioForm()
        {
            ServicioInventario = new ServicioInventario();
            ServicioArticulo = new ServicioArticulo();
            ServicioProyecto = new ServicioProyecto();
            InitializeComponent();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarArticulosDataGrid(ServicioArticulo.ObtenerArticulos());
            CargarProyectosComboBox(ServicioProyecto.ObtenerProyectos());
        }
        private void CargarArticulosDataGrid(List<string[]> articulos)
        {
            foreach(string[] articulo in articulos)
                articulosDataGrid.Rows.Add(articulo[1], articulo[2], articulo[3], articulo[4]);
        }
        private void CargarProyectosComboBox(List<Proyecto> proyectos)
        {
            foreach (Proyecto proyecto in proyectos)
                proyectosComboBox.Items.Add(proyecto);
        }
        private void proyectosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(proyectosComboBox.SelectedIndex > -1)
            {
                articulosPorProyectoDataGrid.Rows.Clear();
                Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
                CargarArticulosPorProyectoDataGrid(ServicioInventario.ObtenerArticulosPorProyecto(proyecto.Id));
            }
        }
        private void CargarArticulosPorProyectoDataGrid(List<InventarioProyecto> articulosPorProyecto)
        {
            foreach (InventarioProyecto registro in articulosPorProyecto)
                articulosPorProyectoDataGrid.Rows.Add(registro.Articulo.Nombre, registro.Articulo.Unidad, registro.Articulo.Precio, registro.Articulo.Descripcion, registro.Cantidad, registro.Total);
        }

        private void refrescarBtn_Click(object sender, EventArgs e)
        {
            articulosDataGrid.Rows.Clear();
            CargarArticulosDataGrid(ServicioArticulo.ObtenerArticulos());
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            if(proyectosComboBox.SelectedIndex > -1)
            {
                articulosPorProyectoDataGrid.Rows.Clear();
                Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
                CargarArticulosPorProyectoDataGrid(ServicioInventario.ObtenerArticulosPorProyecto(proyecto.Id));
            }
        }
    }
}

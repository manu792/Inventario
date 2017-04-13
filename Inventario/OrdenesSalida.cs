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
    public partial class OrdenesSalida : Form
    {
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioOrdenSalida ServicioOrdenSalida { get; set; }
        private ServicioInventario ServicioInventario { get; set; }
        private DataView dv;

        public OrdenesSalida()
        {
            ServicioProyecto = new ServicioProyecto();
            ServicioOrdenSalida = new ServicioOrdenSalida();
            ServicioInventario = new ServicioInventario();
            InitializeComponent();
        }

        private void OrdenesSalida_Load(object sender, EventArgs e)
        {
            CargarProyectos(ServicioProyecto.ObtenerProyectos());
        }
        private void CargarProyectos(List<Proyecto> proyectos)
        {
            foreach(Proyecto proyecto in proyectos)
            {
                listaProyectos.Items.Add(proyecto);
                listaProyectosVer.Items.Add(proyecto);
            }
        }

        private void listaProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proyecto proyecto = (Proyecto)listaProyectos.SelectedItem;
            CargarArticulosDataGrid(ServicioInventario.ObtenerArticulosPorProyecto(proyecto.Id));
        }
        private void CargarArticulosDataGrid(List<InventarioProyecto> inventario)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Nombre");
            table.Columns.Add("Unidad");
            table.Columns.Add("Precio");
            table.Columns.Add("Descripcion");
            table.Columns.Add("Cantidad");

            foreach (InventarioProyecto registro in inventario)
                table.Rows.Add(registro.Id, registro.Articulo.Nombre, registro.Articulo.Unidad, registro.Articulo.Precio, registro.Articulo.Precio, registro.Cantidad);

            articulosDataGrid.DataSource = table;
            dv = new DataView(table);
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e)
        {
            if (articulosDataGrid.Rows.Count > 0)
            {
                dv.RowFilter = "[Nombre] LIKE '%" + buscarTxt.Text + "%'";
                if (dv.Count > 0)
                    articulosDataGrid.DataSource = dv;
            }
        }
    }
}

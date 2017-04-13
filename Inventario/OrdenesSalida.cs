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
            ServicioInventario = new ServicioInventario(ServicioOrdenSalida);
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
                table.Rows.Add(registro.Articulo.Id, registro.Articulo.Nombre, registro.Articulo.Unidad, registro.Articulo.Precio, registro.Articulo.Descripcion, registro.Cantidad);

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

        private void agregarCarritoBtn_Click(object sender, EventArgs e)
        {
            if (articulosDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in articulosDataGrid.SelectedRows)
                {
                    if (!ExisteArticulo(fila))
                    {
                        articulosDataGridView.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[5].Value);
                        articulosDataGridView.Rows[articulosDataGridView.Rows.Count - 1].Cells[5].Value = Double.Parse(articulosDataGridView.Rows[articulosDataGridView.Rows.Count - 1].Cells[3].Value.ToString()) * Int32.Parse(articulosDataGridView.Rows[articulosDataGridView.Rows.Count - 1].Cells[4].Value.ToString());
                    }
                }
            }
        }
        private bool ExisteArticulo(DataGridViewRow fila)
        {
            foreach (DataGridViewRow filaCarrito in articulosDataGridView.Rows)
            {
                if (fila.Cells[0].Value == filaCarrito.Cells[1].Value)
                    return true;
            }
            return false;
        }

        private void articulosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            int cantidadMaxima = BuscarCantidadMaximaPermitida(Int32.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()));
            if(Int32.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString()) > cantidadMaxima)
            {
                MessageBox.Show("La cantidad de articulos a eliminar debe ser menor a la cantidad en inventario");
                data.Rows[e.RowIndex].Cells[4].Value = 1;
            }
            data.Rows[e.RowIndex].Cells[5].Value = Double.Parse(data.Rows[e.RowIndex].Cells[3].Value.ToString()) * Int32.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private int BuscarCantidadMaximaPermitida(int idArticulo)
        {
            foreach(DataGridViewRow fila in articulosDataGrid.Rows)
            {
                if (Int32.Parse(fila.Cells[0].Value.ToString()) == idArticulo)
                    return Int32.Parse(fila.Cells[5].Value.ToString());
            }
            return 0;
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if (articulosDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in articulosDataGridView.SelectedRows)
                {
                    articulosDataGridView.Rows.RemoveAt(fila.Index);
                }
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            articulosDataGridView.Rows.Clear();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                List<Detalle> detallesSalida = new List<Detalle>();

                Proyecto proyecto = (Proyecto)listaProyectos.SelectedItem;

                Orden ordenSalida = new Orden(proyecto, fechaOrdenSalida.Value, comentarioTxt.Text);

                foreach (DataGridViewRow fila in articulosDataGridView.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[0].Value.ToString()));
                        detallesSalida.Add(new Detalle(articulo, Int32.Parse(fila.Cells[4].Value.ToString()), Double.Parse(fila.Cells[5].Value.ToString())));
                    }
                }
                ServicioOrdenSalida.Agregar(ordenSalida, detallesSalida);
            }
        }
        private bool EsDataValida()
        {
            if (articulosDataGridView.Rows.Count > 0 && listaProyectos.SelectedIndex > -1)
                return true;

            return false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {

        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

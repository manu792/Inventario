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
    public partial class OrdenesEntrada : Form
    {
        private ServicioOrdenEntrada OrdenEntrada { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }
        private DataView dv;

        public OrdenesEntrada()
        {
            OrdenEntrada = new ServicioOrdenEntrada();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
            InitializeComponent();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            CargarListaProyectos(ServicioProyecto.ObtenerProyectos());
            CargarArticulosDataGrid(ServicioArticulo.ObtenerArticulos());
        }
        private void CargarListaProyectos(List<Proyecto> proyectos)
        {
            foreach (Proyecto proyecto in proyectos)
            {
                listaProyectos.Items.Add(proyecto);
                proyectosComboBox.Items.Add(proyecto);
            }
        }
        private void CargarArticulosDataGrid(List<string[]> articulos)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Nombre");
            table.Columns.Add("Unidad");
            table.Columns.Add("Precio");
            table.Columns.Add("Descripcion");

            foreach (string[] articulo in articulos)
                table.Rows.Add(articulo[0], articulo[1], articulo[2], articulo[3], articulo[4]);

            articulosDataGrid.DataSource = table;
            dv = new DataView(table);
        }
        private void CargarOrdenesEntrada(List<string[]> listaOrdenesEntrada)
        {
            foreach(string[] ordenEntrada in listaOrdenesEntrada)
            {
                ListViewItem item = new ListViewItem(ordenEntrada, 0);
                ordenesEntradaListView.Items.Add(item);
            }
            ordenesEntradaListView.View = View.Details;
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e)
        {
            if (articulosDataGrid.Rows.Count > 0)
            {
                dv.RowFilter = "[Nombre] LIKE '%" + buscarTxt.Text + "%'"; // query example = "id = 10"
                if (dv.Count > 0)
                    articulosDataGrid.DataSource = dv;
            }
        }

        private void agregarCarritoBtn_Click(object sender, EventArgs e)
        {
            if(articulosDataGrid.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow fila in articulosDataGrid.SelectedRows)
                {
                    if(!ExisteFila(fila))
                        carritoDataGridView.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[3].Value, 1, fila.Cells[3].Value);
                }
            }
        }
        private bool ExisteFila(DataGridViewRow fila)
        {
            foreach (DataGridViewRow filaCarrito in carritoDataGridView.Rows)
            {
                if (fila.Cells[0].Value == filaCarrito.Cells[0].Value)
                    return true;
            }
            return false;
        }
        void carritoDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            grid.Rows[e.RowIndex].Cells[4].Value = Double.Parse(grid.Rows[e.RowIndex].Cells[2].Value.ToString()) * Int32.Parse(grid.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if(carritoDataGridView.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow fila in carritoDataGridView.SelectedRows)
                {
                    carritoDataGridView.Rows.RemoveAt(fila.Index);
                }
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            carritoDataGridView.Rows.Clear();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if(EsDataValida())
            {
                List<DetalleEntrada> detallesEntrada = new List<DetalleEntrada>();

                Proyecto proyecto = (Proyecto)listaProyectos.SelectedItem;

                OrdenEntrada ordenEntrada = new OrdenEntrada(proyecto.Id, fecha.Value, comentarioTxt.Text);

                foreach (DataGridViewRow fila in carritoDataGridView.Rows)
                {
                    if (fila.Cells[0].Value != null)
                        detallesEntrada.Add(new DetalleEntrada(Int32.Parse(fila.Cells[0].Value.ToString()), Int32.Parse(fila.Cells[3].Value.ToString()), Double.Parse(fila.Cells[4].Value.ToString())));
                }

                OrdenEntrada.Agregar(ordenEntrada, detallesEntrada);
            }
        }

        private void proyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (proyectosComboBox.SelectedIndex > -1)
            {
                ordenesEntradaListView.Items.Clear();
                Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
                CargarOrdenesEntrada(OrdenEntrada.ObtenerOrdenesEntrada(proyecto.Id));
            }
        }

        private void ordenesEntradaListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (ordenesEntradaListView.SelectedItems.Count > 0)
            //{
            //    ListViewItem i;
            //    i = ordenesEntradaListView.SelectedItems[0];
            //    idTxt.Text = i.SubItems[0].Text;
            //    //proyectoTxt.Text = i.SubItems[1].Text;
            //    //encargadoTxt.Text = i.SubItems[2].Text;
            //    //direccionTxt.Text = i.SubItems[3].Text;
            //    //descripcionTxt.Text = i.SubItems[4].Text;
            //    //fechaInicio.Value = DateTime.Parse(i.SubItems[5].Text);
            //    //fechaFin.Value = DateTime.Parse(i.SubItems[6].Text);
            //}
        }
        private bool EsDataValida()
        {
            if (carritoDataGridView.Rows.Count > 0 && listaProyectos.SelectedIndex > -1)
                return true;

            return false;
        }
    }
}

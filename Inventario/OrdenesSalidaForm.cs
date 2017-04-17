using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Inventario.Commons.Modelos;
using Inventario.Servicios;

namespace Inventario
{
    public partial class OrdenesSalidaForm : Form
    {
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioOrdenSalida ServicioOrdenSalida { get; set; }
        private ServicioInventario ServicioInventario { get; set; }
        private DataView dv;
        private List<Orden> ordenes;

        public OrdenesSalidaForm()
        {
            ServicioProyecto = new ServicioProyecto();
            ServicioOrdenSalida = new ServicioOrdenSalida();
            ServicioInventario = new ServicioInventario(ServicioOrdenSalida);
            ordenes = new List<Orden>();
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
                proyectosVerLista.Items.Add(proyecto);
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
            table.Columns.Add("Cantidad Inventario");
            table.Columns.Add("Total");

            foreach (InventarioProyecto registro in inventario)
                table.Rows.Add(registro.Articulo.Id, registro.Articulo.Nombre, registro.Articulo.Unidad, registro.Articulo.Precio, registro.Articulo.Descripcion, registro.Cantidad, registro.Total);

            articulosDataGrid.DataSource = table;
            dv = new DataView(table);
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[Nombre] LIKE '%" + buscarTxt.Text + "%'";
            if (dv.Count > 0)
                articulosDataGrid.DataSource = dv;
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

        private void ArticulosDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
            }
        }

        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) //se permite utilizar la tecla backspace para borrar
                e.Handled = false;
            else if (!char.IsDigit(e.KeyChar)) //verifico que no se ingrese una letra
                e.Handled = true;
        }

        private void ArticulosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            int cantidadMaxima = BuscarCantidadMaximaPermitida(Int32.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()));

            if (data.Rows[e.RowIndex].Cells[4].Value == null || data.Rows[e.RowIndex].Cells[4].Value.ToString() == string.Empty || Int32.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString()) == 0)
                data.Rows[e.RowIndex].Cells[4].Value = 1;

            if (Int32.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString()) > cantidadMaxima)
            {
                MessageBox.Show("La cantidad de articulos a eliminar debe ser menor a la cantidad en inventario");
                data.Rows[e.RowIndex].Cells[4].Value = 1;
            }
            data.Rows[e.RowIndex].Cells[5].Value = Double.Parse(data.Rows[e.RowIndex].Cells[3].Value.ToString()) * Int32.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void articulosVerLista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
            Orden ordenSeleccionada = ordenes.Where(x => x.Id == Int32.Parse(IdVerTxt.Text)).FirstOrDefault();
            if(ordenSeleccionada != null)
            {
                int cantidadMaxima = ServicioInventario.ObtenerCantidadArticuloPorProyecto(proyecto.Id, Int32.Parse(data.Rows[e.RowIndex].Cells[1].Value.ToString())) + ordenSeleccionada.Detalles[e.RowIndex].Cantidad;

                if (data.Rows[e.RowIndex].Cells[5].Value == null || data.Rows[e.RowIndex].Cells[5].Value.ToString() == string.Empty || Int32.Parse(data.Rows[e.RowIndex].Cells[5].Value.ToString()) == 0)
                    data.Rows[e.RowIndex].Cells[5].Value = 1;

                if (Int32.Parse(data.Rows[e.RowIndex].Cells[5].Value.ToString()) > cantidadMaxima)
                {
                    MessageBox.Show("La cantidad de articulos a eliminar debe ser menor o igual a la cantidad que se ingresaron en la orden de entrada");
                    data.Rows[e.RowIndex].Cells[5].Value = 1;
                }
                data.Rows[e.RowIndex].Cells[6].Value = Double.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString()) * Int32.Parse(data.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
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
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[0].Value.ToString()), Double.Parse(fila.Cells[3].Value.ToString()));
                        detallesSalida.Add(new Detalle(articulo, Int32.Parse(fila.Cells[4].Value.ToString()), Double.Parse(fila.Cells[5].Value.ToString())));
                    }
                }
                ordenSalida.Detalles = detallesSalida;
                int idOrden = ServicioOrdenSalida.Agregar(ordenSalida);

                MessageBox.Show("Orden de salida numero: " + idOrden + " agregada correctamente");
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
            if (proyectosVerLista.SelectedIndex > -1 && ordenesSalidaVerLista.SelectedIndices.Count > 0 && articulosVerLista.Rows.Count > 0)
            {
                List<Detalle> detallesSalida = new List<Detalle>();

                Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;

                Orden ordenSalida = new Orden(Int32.Parse(IdVerTxt.Text), proyecto, fechaVer.Value, comentarioVerTxt.Text);

                foreach (DataGridViewRow fila in articulosVerLista.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[1].Value.ToString()), Double.Parse(fila.Cells[4].Value.ToString()));
                        detallesSalida.Add(new Detalle(Int32.Parse(fila.Cells[0].Value.ToString()), ordenSalida.Id, articulo, Int32.Parse(fila.Cells[5].Value.ToString()), Double.Parse(fila.Cells[6].Value.ToString())));
                    }
                }
                ordenSalida.Detalles = detallesSalida;

                ServicioOrdenSalida.Modificar(ordenSalida);
                ObtenerOrdenesSalida();

                MessageBox.Show("Orden de salida modificada correctamente");
                LimpiarControles();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (proyectosVerLista.SelectedIndex > -1 && ordenesSalidaVerLista.SelectedIndices.Count > 0)
            {
                Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
                ServicioOrdenSalida.Eliminar(Int32.Parse(IdVerTxt.Text));
                LimpiarControles();
                ObtenerOrdenesSalida();
            }
        }

        private void proyectosVerLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (proyectosVerLista.SelectedIndex > -1)
            {
                LimpiarControles();
                ObtenerOrdenesSalida();
            }
        }
        private void ObtenerOrdenesSalida()
        {
            Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
            ordenes = ServicioOrdenSalida.ObtenerOrdenesSalida(proyecto.Id);
            CargarOrdenesSalida();
        }
        private void LimpiarControles()
        {
            ordenesSalidaVerLista.Items.Clear();
            IdVerTxt.Clear();
            comentarioVerTxt.Clear();
            articulosVerLista.Rows.Clear();
        }
        private void CargarOrdenesSalida()
        {
            ordenesSalidaVerLista.Items.Clear();
            foreach (Orden ServicioOrdenEntrada in ordenes)
            {
                ListViewItem item = new ListViewItem(ServicioOrdenEntrada.ConvertirAArray(), 0);
                ordenesSalidaVerLista.Items.Add(item);
            }
            ordenesSalidaVerLista.View = View.Details;
        }

        private void ordenesEntradaVerLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenesSalidaVerLista.SelectedItems.Count > 0)
            {
                ListViewItem i;
                i = ordenesSalidaVerLista.SelectedItems[0];
                IdVerTxt.Text = i.SubItems[0].Text;
                fechaVer.Value = DateTime.Parse(i.SubItems[2].Text);
                comentarioVerTxt.Text = i.SubItems[3].Text;
                List<Detalle> detallesSalida = ordenes[ordenesSalidaVerLista.SelectedIndices[0]].Detalles;
                foreach (Detalle detalleSalida in detallesSalida)
                {
                    Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
                    int cantidadEnInventario = ServicioInventario.ObtenerCantidadArticuloPorProyecto(proyecto.Id, detalleSalida.Articulo.Id);

                    articulosVerLista.Rows.Add(detalleSalida.IdDetalle, detalleSalida.Articulo.Id, detalleSalida.Articulo.Nombre, detalleSalida.Articulo.Unidad, detalleSalida.Articulo.Precio, detalleSalida.Cantidad, detalleSalida.Total, cantidadEnInventario);
                    if (cantidadEnInventario == 0)
                        articulosVerLista.Rows[articulosVerLista.Rows.Count - 1].Cells[5].ReadOnly = true;
                    else
                        articulosVerLista.Rows[articulosVerLista.Rows.Count - 1].Cells[5].ReadOnly = false;
                }
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            ordenes.Clear();
            detallesSalidaDataGridView.Rows.Clear();
            ordenes.Add(ServicioOrdenSalida.ObtenerOrdenSalidaPorId((int)idOrden.Value));
            if (ordenes[0] != null)
            {
                idOrdenSalidaTxt.Text = ordenes[0].Id.ToString();
                proyectoTxt.Text = ordenes[0].Proyecto.Nombre;
                fechaOrden.Value = ordenes[0].Fecha;
                comentarioOrdenTxt.Text = ordenes[0].Comentario;

                foreach (Detalle detalle in ordenes[0].Detalles)
                {
                    int cantidadInventario = ServicioInventario.ObtenerCantidadArticuloPorProyecto(ordenes[0].Proyecto.Id, detalle.Articulo.Id);

                    detallesSalidaDataGridView.Rows.Add(detalle.IdDetalle, detalle.Articulo.Id, detalle.Articulo.Nombre, detalle.Articulo.Unidad, detalle.Articulo.Precio, detalle.Cantidad, detalle.Total, cantidadInventario);

                    if (cantidadInventario > 0)
                        detallesSalidaDataGridView.Rows[detallesSalidaDataGridView.Rows.Count - 1].Cells[5].ReadOnly = false;
                    else
                        detallesSalidaDataGridView.Rows[detallesSalidaDataGridView.Rows.Count - 1].Cells[5].ReadOnly = true;
                }
            }
            else
                MessageBox.Show("La orden de entrada no existe o fue removida del sistema");
        }

        private void modificarOrdenBtn_Click(object sender, EventArgs e)
        {
            if (comentarioOrdenTxt.Text != string.Empty && detallesSalidaDataGridView.Rows.Count > 0)
            {
                List<Detalle> detallesEntrada = new List<Detalle>();

                Orden ordenEntrada = new Orden(Int32.Parse(idOrdenSalidaTxt.Text), new Proyecto(ordenes[0].Proyecto.Id), fechaOrden.Value, comentarioOrdenTxt.Text);

                foreach (DataGridViewRow fila in detallesSalidaDataGridView.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[1].Value.ToString()), Double.Parse(fila.Cells[4].Value.ToString()));
                        detallesEntrada.Add(new Detalle(Int32.Parse(fila.Cells[0].Value.ToString()), ordenEntrada.Id, articulo, Int32.Parse(fila.Cells[5].Value.ToString()), Double.Parse(fila.Cells[6].Value.ToString())));
                    }
                }
                ordenEntrada.Detalles = detallesEntrada;
                ServicioOrdenSalida.Modificar(ordenEntrada);
                MessageBox.Show("Orden de salida modificada correctamente");
                Limpiar();
            }
        }

        private void eliminarOrdenBtn_Click(object sender, EventArgs e)
        {
            if (comentarioOrdenTxt.Text != string.Empty && detallesSalidaDataGridView.Rows.Count > 0)
            {
                ServicioOrdenSalida.Eliminar(Int32.Parse(idOrdenSalidaTxt.Text));
                Limpiar();
            }
        }
        private void Limpiar()
        {
            idOrdenSalidaTxt.Clear();
            proyectoTxt.Clear();
            comentarioOrdenTxt.Clear();
            detallesSalidaDataGridView.Rows.Clear();
        }

        private void detallesSalidaDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            Orden ordenSeleccionada = ordenes.Where(x => x.Id == Int32.Parse(idOrdenSalidaTxt.Text)).FirstOrDefault();
            if (ordenSeleccionada != null)
            {
                int cantidadMaxima = ServicioInventario.ObtenerCantidadArticuloPorProyecto(ordenes[0].Id, Int32.Parse(data.Rows[e.RowIndex].Cells[1].Value.ToString())) + ordenSeleccionada.Detalles[e.RowIndex].Cantidad;

                if (data.Rows[e.RowIndex].Cells[5].Value == null || data.Rows[e.RowIndex].Cells[5].Value.ToString() == string.Empty || Int32.Parse(data.Rows[e.RowIndex].Cells[5].Value.ToString()) == 0)
                    data.Rows[e.RowIndex].Cells[5].Value = 1;

                if (Int32.Parse(data.Rows[e.RowIndex].Cells[5].Value.ToString()) > cantidadMaxima)
                {
                    MessageBox.Show("La cantidad de articulos a eliminar debe ser menor o igual a la cantidad que se ingresaron en la orden de entrada");
                    data.Rows[e.RowIndex].Cells[5].Value = 1;
                }
                data.Rows[e.RowIndex].Cells[6].Value = Double.Parse(data.Rows[e.RowIndex].Cells[4].Value.ToString()) * Int32.Parse(data.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Inventario.Commons.Modelos;
using Inventario.Servicios;
using System.Linq;

namespace Inventario
{
    public partial class OrdenesEntradaForm : Form
    {
        private ServicioOrdenEntrada ServicioOrdenEntrada { get; set; }
        private ServicioInventario ServicioInventario { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }
        private DataView dv;
        private List<Orden> Ordenes;

        public OrdenesEntradaForm()
        {
            ServicioOrdenEntrada = new ServicioOrdenEntrada();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
            ServicioInventario = new ServicioInventario(ServicioOrdenEntrada);
            Ordenes = new List<Orden>();
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
                proyectosVerLista.Items.Add(proyecto);
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
        private void CargarOrdenesEntrada()
        {
            ordenesEntradaVerLista.Items.Clear();
            foreach (Orden ordenEntrada in Ordenes)
            {
                ListViewItem item = new ListViewItem(ordenEntrada.ConvertirAArray(), 0);
                ordenesEntradaVerLista.Items.Add(item);
            }
            ordenesEntradaVerLista.View = View.Details;
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "[Nombre] LIKE '%" + buscarTxt.Text + "%'";
            if (dv.Count > 0)
                articulosDataGrid.DataSource = dv;
        }

        private void agregarCarritoBtn_Click(object sender, EventArgs e)
        {
            if(articulosDataGrid.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow fila in articulosDataGrid.SelectedRows)
                {
                    if(!ExisteArticulo(fila))
                        articulosDataGridView.Rows.Add(0, fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, 1, fila.Cells[3].Value);
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
        private void carritoDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;

            if (grid.Rows[e.RowIndex].Cells[5].Value == null || grid.Rows[e.RowIndex].Cells[5].Value.ToString() == string.Empty || Int32.Parse(grid.Rows[e.RowIndex].Cells[5].Value.ToString()) == 0)
                grid.Rows[e.RowIndex].Cells[5].Value = 1;

            grid.Rows[e.RowIndex].Cells[6].Value = Double.Parse(grid.Rows[e.RowIndex].Cells[4].Value.ToString()) * Int32.Parse(grid.Rows[e.RowIndex].Cells[5].Value.ToString());
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

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if(articulosDataGridView.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow fila in articulosDataGridView.SelectedRows)
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
                List<Detalle> detallesEntrada = new List<Detalle>();

                Proyecto proyecto = (Proyecto)listaProyectos.SelectedItem;

                Orden ordenEntrada = new Orden(proyecto, fechaOrdenEntrada.Value, comentarioOrdenEntradaTxt.Text);

                foreach (DataGridViewRow fila in articulosDataGridView.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[1].Value.ToString()), Double.Parse(fila.Cells[4].Value.ToString()));
                        detallesEntrada.Add(new Detalle(articulo, Int32.Parse(fila.Cells[5].Value.ToString()), Double.Parse(fila.Cells[6].Value.ToString())));
                    }
                }
                ordenEntrada.Detalles = detallesEntrada;
                int idOrden = ServicioOrdenEntrada.Agregar(ordenEntrada);
                MessageBox.Show("Orden de entrada numero: " + idOrden + " agregada correctamente");
                
            }
        }
        private bool EsDataValida()
        {
            if (articulosDataGridView.Rows.Count > 0 && listaProyectos.SelectedIndex > -1)
                return true;

            return false;
        }

        private void ordenesEntradaVerLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenesEntradaVerLista.SelectedItems.Count > 0)
            {
                articulosVerLista.Rows.Clear();
                ListViewItem i;
                i = ordenesEntradaVerLista.SelectedItems[0];
                IdVerTxt.Text = i.SubItems[0].Text;
                fechaVer.Value = DateTime.Parse(i.SubItems[2].Text);
                comentarioVerTxt.Text = i.SubItems[3].Text;
                List<Detalle> detallesEntrada = Ordenes[ordenesEntradaVerLista.SelectedIndices[0]].Detalles;
                foreach (Detalle detalleEntrada in detallesEntrada)
                {
                    Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
                    int cantidadInventario = ServicioInventario.ObtenerCantidadArticuloPorProyecto(proyecto.Id, detalleEntrada.Articulo.Id);

                    articulosVerLista.Rows.Add(detalleEntrada.IdDetalle, detalleEntrada.Articulo.Id, detalleEntrada.Articulo.Nombre, detalleEntrada.Articulo.Unidad, detalleEntrada.Articulo.Precio, detalleEntrada.Cantidad, detalleEntrada.Total);

                    if (cantidadInventario > 0)
                        articulosVerLista.Rows[articulosVerLista.Rows.Count - 1].Cells[5].ReadOnly = false;
                    else
                        articulosVerLista.Rows[articulosVerLista.Rows.Count - 1].Cells[5].ReadOnly = true;
                }
            }
        }

        private void proyectosVerLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (proyectosVerLista.SelectedIndex > -1)
            {
                LimpiarControles();
                ObtenerOrdenesEntrada();
            }
        }
        private void ObtenerOrdenesEntrada()
        {
            Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
            Ordenes = ServicioOrdenEntrada.ObtenerOrdenesEntrada(proyecto.Id);
            CargarOrdenesEntrada();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (proyectosVerLista.SelectedIndex > -1 && ordenesEntradaVerLista.SelectedIndices.Count > 0 && articulosVerLista.Rows.Count > 0)
            {
                List<Detalle> detallesEntrada = new List<Detalle>();

                Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;

                Orden ordenEntrada = new Orden(Int32.Parse(IdVerTxt.Text), proyecto, fechaVer.Value, comentarioVerTxt.Text);

                foreach (DataGridViewRow fila in articulosVerLista.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[1].Value.ToString()), Double.Parse(fila.Cells[4].Value.ToString()));
                        detallesEntrada.Add(new Detalle(Int32.Parse(fila.Cells[0].Value.ToString()), ordenEntrada.Id, articulo, Int32.Parse(fila.Cells[5].Value.ToString()), Double.Parse(fila.Cells[6].Value.ToString())));
                    }
                }
                ordenEntrada.Detalles = detallesEntrada;

                ServicioOrdenEntrada.Modificar(ordenEntrada);
                ObtenerOrdenesEntrada();

                MessageBox.Show("Orden de entrada modificada correctamente");
                LimpiarControles();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (proyectosVerLista.SelectedIndex > -1 && ordenesEntradaVerLista.SelectedIndices.Count > 0)
            {
                Proyecto proyecto = (Proyecto)proyectosVerLista.SelectedItem;
                ServicioOrdenEntrada.Eliminar(Int32.Parse(IdVerTxt.Text));
                LimpiarControles();
                ObtenerOrdenesEntrada();
            }
        }
        private void LimpiarControles()
        {
            ordenesEntradaVerLista.Items.Clear();
            IdVerTxt.Clear();
            comentarioVerTxt.Clear();
            articulosVerLista.Rows.Clear();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            Ordenes.Clear();
            detallesEntradaDataGridView.Rows.Clear();
            Ordenes.Add(ServicioOrdenEntrada.ObtenerOrdenEntradaPorId((int)idOrden.Value));
            if (Ordenes[0] != null)
            {
                idOrdenEntradaTxt.Text = Ordenes[0].Id.ToString();
                proyectoTxt.Text = Ordenes[0].Proyecto.Nombre;
                fechaOrden.Value = Ordenes[0].Fecha;
                comentarioOrdenTxt.Text = Ordenes[0].Comentario;
                
                foreach(Detalle detalle in Ordenes[0].Detalles)
                {
                    int cantidadInventario = ServicioInventario.ObtenerCantidadArticuloPorProyecto(Ordenes[0].Proyecto.Id, detalle.Articulo.Id);

                    detallesEntradaDataGridView.Rows.Add(detalle.IdDetalle, detalle.Articulo.Id, detalle.Articulo.Nombre, detalle.Articulo.Unidad, detalle.Articulo.Precio, detalle.Cantidad, detalle.Total);

                    if (cantidadInventario > 0)
                        detallesEntradaDataGridView.Rows[detallesEntradaDataGridView.Rows.Count - 1].Cells[5].ReadOnly = false;
                    else
                        detallesEntradaDataGridView.Rows[detallesEntradaDataGridView.Rows.Count - 1].Cells[5].ReadOnly = true;
                }
            }
            else
                MessageBox.Show("La orden de entrada no existe o fue removida del sistema");
        }
        private void modificarOrdenBtn_Click(object sender, EventArgs e)
        {
            if (comentarioOrdenTxt.Text != string.Empty && detallesEntradaDataGridView.Rows.Count > 0)
            {
                List<Detalle> detallesEntrada = new List<Detalle>();

                Orden ordenEntrada = new Orden(Int32.Parse(idOrdenEntradaTxt.Text), new Proyecto(Ordenes[0].Proyecto.Id), fechaOrden.Value, comentarioOrdenTxt.Text);

                foreach (DataGridViewRow fila in detallesEntradaDataGridView.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        Articulo articulo = new Articulo(Int32.Parse(fila.Cells[1].Value.ToString()), Double.Parse(fila.Cells[4].Value.ToString()));
                        detallesEntrada.Add(new Detalle(Int32.Parse(fila.Cells[0].Value.ToString()), ordenEntrada.Id, articulo, Int32.Parse(fila.Cells[5].Value.ToString()), Double.Parse(fila.Cells[6].Value.ToString())));
                    }
                }
                ordenEntrada.Detalles = detallesEntrada;
                ServicioOrdenEntrada.Modificar(ordenEntrada);
                MessageBox.Show("Orden de entrada modificada correctamente");
                Limpiar();
            }
        }
        private void eliminarOrdenBtn_Click(object sender, EventArgs e)
        {
            if (comentarioOrdenTxt.Text != string.Empty && detallesEntradaDataGridView.Rows.Count > 0)
            {
                ServicioOrdenEntrada.Eliminar(Int32.Parse(idOrdenEntradaTxt.Text));
                Limpiar();
            }
        }
        private void Limpiar()
        {
            idOrdenEntradaTxt.Clear();
            proyectoTxt.Clear();
            comentarioOrdenTxt.Clear();
            detallesEntradaDataGridView.Rows.Clear();
        }
    }
}

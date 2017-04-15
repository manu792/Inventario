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
    public partial class ReporteForm : Form
    {
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioInventario ServicioInventario { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }
        private ServicioOrdenEntrada ServicioOrdenEntrada { get; set; }
        private ServicioOrdenSalida ServicioOrdenSalida { get; set; }
        private ServicioReporte ServicioReporte { get; set; }

        public ReporteForm()
        {
            ServicioProyecto = new ServicioProyecto();
            ServicioInventario = new ServicioInventario();
            ServicioArticulo = new ServicioArticulo();
            ServicioOrdenEntrada = new ServicioOrdenEntrada();
            ServicioOrdenSalida = new ServicioOrdenSalida();
            ServicioReporte = new ServicioReporte();
            InitializeComponent();
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {
            CargarProyectosComboBox(ServicioProyecto.ObtenerProyectos());
        }
        private void CargarProyectosComboBox(List<Proyecto> proyectos)
        {
            foreach(Proyecto proyecto in proyectos)
                proyectosComboBox.Items.Add(proyecto);
        }

        private void proyectosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(proyectosComboBox.SelectedIndex > -1)
            {
                Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;

                CargarArticulos(proyecto.Id);
                CargarOrdenesEntrada(proyecto.Id);
                CargarOrdenesSalida(proyecto.Id);
            }
        }
        private void CargarArticulos(int idProyecto)
        {
            articulosDataGridView.Rows.Clear();
            CargarArticulosDataGrid(ServicioInventario.ObtenerArticulosPorProyecto(idProyecto));
        }
        private void CargarArticulosDataGrid(List<InventarioProyecto> inventario)
        {
            foreach (InventarioProyecto registro in inventario)
                articulosDataGridView.Rows.Add(registro.Articulo.Nombre, registro.Articulo.Unidad, registro.Articulo.Precio, registro.Articulo.Descripcion, registro.Cantidad, registro.Total);
        }
        private void CargarOrdenesEntrada(int idProyecto)
        {
            ordenesEntradaListView.Items.Clear();
            articulosVerLista.Rows.Clear();
            CargarOrdenesEntradaListView(ServicioOrdenEntrada.ObtenerOrdenesEntrada(idProyecto));
        }
        private void CargarOrdenesEntradaListView(List<Orden> ordenesEntrada)
        {
            foreach (Orden orden in ordenesEntrada)
            {
                ListViewItem item = new ListViewItem(orden.ConvertirAArray(), 0);
                ordenesEntradaListView.Items.Add(item);
            }
            ordenesEntradaListView.View = View.Details;
        }
        private void CargarOrdenesSalida(int idProyecto)
        {
            ordenesSalidaListView.Items.Clear();
            articulosOrdenSalida.Rows.Clear();
            CargarOrdenesSalidaListView(ServicioOrdenSalida.ObtenerOrdenesSalida(idProyecto));
        }
        private void CargarOrdenesSalidaListView(List<Orden> ordenesSalida)
        {
            foreach (Orden orden in ordenesSalida)
            {
                ListViewItem item = new ListViewItem(orden.ConvertirAArray(), 0);
                ordenesSalidaListView.Items.Add(item);
            }
            ordenesSalidaListView.View = View.Details;
        }

        private void ordenesEntradaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenesEntradaListView.SelectedItems.Count > 0)
            {
                articulosVerLista.Rows.Clear();

                ListViewItem i;
                i = ordenesEntradaListView.SelectedItems[0];
                IdVerTxt.Text = i.SubItems[0].Text;
                fechaVer.Value = DateTime.Parse(i.SubItems[2].Text);
                comentarioVerTxt.Text = i.SubItems[3].Text;
                List<Detalle> detallesEntrada = ServicioOrdenEntrada.ObtenerDetallesEntrada(Int32.Parse(i.SubItems[0].Text));
                foreach (Detalle detalleEntrada in detallesEntrada)
                {
                    Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
                    articulosVerLista.Rows.Add(detalleEntrada.IdDetalle, detalleEntrada.Articulo.Id, detalleEntrada.Articulo.Nombre, detalleEntrada.Articulo.Unidad, detalleEntrada.Articulo.Precio, detalleEntrada.Cantidad, detalleEntrada.Total);
                }
            }
        }

        private void ordenesSalidaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordenesSalidaListView.SelectedItems.Count > 0)
            {
                articulosOrdenSalida.Rows.Clear();

                ListViewItem i;
                i = ordenesSalidaListView.SelectedItems[0];
                idSalidaTxt.Text = i.SubItems[0].Text;
                fechaSalida.Value = DateTime.Parse(i.SubItems[2].Text);
                comentarioSalidaTxt.Text = i.SubItems[3].Text;
                List<Detalle> detallesSalida = ServicioOrdenSalida.ObtenerDetallesSalida(Int32.Parse(i.SubItems[0].Text));
                foreach (Detalle detalleSalida in detallesSalida)
                {
                    Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
                    articulosOrdenSalida.Rows.Add(detalleSalida.IdDetalle, detalleSalida.Articulo.Id, detalleSalida.Articulo.Nombre, detalleSalida.Articulo.Unidad, detalleSalida.Articulo.Precio, detalleSalida.Cantidad, detalleSalida.Total);
                }
            }
        }

        private void exportarBtn_Click(object sender, EventArgs e)
        {

        }

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            Dictionary<int, List<Detalle>> detallesEntrada;
            Dictionary<int, List<Detalle>> detallesSalida;

            List<Reporte> reportes = new List<Reporte>();

            List<Proyecto> proyectos = ServicioProyecto.ObtenerProyectos();
            foreach(Proyecto proyecto in proyectos)
            {
                detallesEntrada = new Dictionary<int, List<Detalle>>();
                detallesSalida = new Dictionary<int, List<Detalle>>();

                List<InventarioProyecto> inventario = ServicioInventario.ObtenerArticulosPorProyecto(proyecto.Id);
                List<Orden> ordenesEntrada = ServicioOrdenEntrada.ObtenerOrdenesEntrada(proyecto.Id);
                foreach(Orden ordenEntrada in ordenesEntrada)
                {
                    List<Detalle> detalles = ServicioOrdenEntrada.ObtenerDetallesEntrada(ordenEntrada.Id);
                    detallesEntrada.Add(ordenEntrada.Id, detalles);
                }

                List<Orden> ordenesSalida = ServicioOrdenSalida.ObtenerOrdenesSalida(proyecto.Id);
                foreach (Orden ordenSalida in ordenesSalida)
                {
                    List<Detalle> detalles = ServicioOrdenSalida.ObtenerDetallesSalida(ordenSalida.Id);
                    detallesSalida.Add(ordenSalida.Id, detalles);
                }
                reportes.Add(new Reporte(proyecto, inventario, new OrdenEntrada(ordenesEntrada, detallesEntrada), new OrdenSalida(ordenesSalida, detallesSalida)));
            }
            ServicioReporte.GenerarReporte(reportes);
        }
    }
}

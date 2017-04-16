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
        private ServicioOrdenEntrada ServicioOrdenEntrada { get; set; }
        private ServicioOrdenSalida ServicioOrdenSalida { get; set; }
        private ServicioReporte ServicioReporte { get; set; }
        private List<Orden> OrdenesEntrada;
        private List<Orden> OrdenesSalida;

        public ReporteForm()
        {
            ServicioProyecto = new ServicioProyecto();
            ServicioInventario = new ServicioInventario();
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
            OrdenesEntrada = ServicioOrdenEntrada.ObtenerOrdenesEntrada(idProyecto);
            CargarOrdenesEntradaListView();
        }
        private void CargarOrdenesEntradaListView()
        {
            foreach (Orden orden in OrdenesEntrada)
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
            OrdenesSalida = ServicioOrdenSalida.ObtenerOrdenesSalida(idProyecto);
            CargarOrdenesSalidaListView();
        }
        private void CargarOrdenesSalidaListView()
        {
            foreach (Orden orden in OrdenesSalida)
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
                List<Detalle> detallesEntrada = OrdenesEntrada[ordenesEntradaListView.SelectedIndices[0]].Detalles;
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
                List<Detalle> detallesSalida = OrdenesSalida[ordenesSalidaListView.SelectedIndices[0]].Detalles;
                foreach (Detalle detalleSalida in detallesSalida)
                {
                    Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
                    articulosOrdenSalida.Rows.Add(detalleSalida.IdDetalle, detalleSalida.Articulo.Id, detalleSalida.Articulo.Nombre, detalleSalida.Articulo.Unidad, detalleSalida.Articulo.Precio, detalleSalida.Cantidad, detalleSalida.Total);
                }
            }
        }

        private void exportarBtn_Click(object sender, EventArgs e)
        {
            List<Reporte> reportes = new List<Reporte>();

            Proyecto proyecto = (Proyecto)proyectosComboBox.SelectedItem;
            List<InventarioProyecto> inventario = ServicioInventario.ObtenerArticulosPorProyecto(proyecto.Id);
            List<Orden> ordenesEntrada = ServicioOrdenEntrada.ObtenerOrdenesEntrada(proyecto.Id);
            List<Orden> ordenesSalida = ServicioOrdenSalida.ObtenerOrdenesSalida(proyecto.Id);
            reportes.Add(new Reporte(proyecto, inventario, ordenesEntrada, ordenesSalida));
            ServicioReporte.GenerarReporte(reportes);
        }

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            List<Reporte> reportes = new List<Reporte>();

            List<Proyecto> proyectos = ServicioProyecto.ObtenerProyectos();
            foreach(Proyecto proyecto in proyectos)
            {
                List<InventarioProyecto> inventario = ServicioInventario.ObtenerArticulosPorProyecto(proyecto.Id);
                List<Orden> ordenesEntrada = ServicioOrdenEntrada.ObtenerOrdenesEntrada(proyecto.Id);
                List<Orden> ordenesSalida = ServicioOrdenSalida.ObtenerOrdenesSalida(proyecto.Id);
                reportes.Add(new Reporte(proyecto, inventario, ordenesEntrada, ordenesSalida));
            }
            ServicioReporte.GenerarReporte(reportes);
        }
    }
}

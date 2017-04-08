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
        private ServicioOrdenSalida OrdenSalida { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }

        public OrdenesEntrada()
        {
            OrdenEntrada = new ServicioOrdenEntrada();
            OrdenSalida = new ServicioOrdenSalida();
            ServicioProyecto = new ServicioProyecto();
            InitializeComponent();
        }

        private void listaProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listaProyectos.SelectedIndex > -1)
            {
                ordenesEntradaListView.Items.Clear();
                Proyecto proyecto = (Proyecto)listaProyectos.SelectedItem;
                CargarOrdenesEntrada(OrdenEntrada.ObtenerOrdenesEntrada(proyecto.Id));
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            CargarListaProyectos(ServicioProyecto.ObtenerProyectos());
        }

        private void ordenesEntradaListView_SelectedIndexChanged(object sender, EventArgs e)
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
        private void CargarListaProyectos(List<Proyecto> proyectos)
        {
            foreach (Proyecto proyecto in proyectos)
                listaProyectos.Items.Add(proyecto);
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
    }
}

using Inventario.Commons.Modelos;
using Inventario.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ProyectosForm : Form
    {
        private ServicioProyecto ServicioProyecto { get; set; }

        public ProyectosForm()
        {
            ServicioProyecto = new ServicioProyecto();
            InitializeComponent();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            List<string[]> listaProyectos = ConvertirAArray(ServicioProyecto.ObtenerProyectos());
            CargarProyectos(listaProyectos);
        }

        private List<string[]> ConvertirAArray(List<Proyecto> proyectos)
        {
            List<string[]> listaProyectos = new List<string[]>();

            foreach (Proyecto proyecto in proyectos)
                listaProyectos.Add(proyecto.ConvertirAArray());

            return listaProyectos;
        }

        private void CargarProyectos(List<string[]> proyectos)
        {
            foreach (string[] proyecto in proyectos)
            {
                ListViewItem item = new ListViewItem(proyecto, 0);
                proyectosListView.Items.Add(item);
            }
            proyectosListView.View = View.Tile;
        }
        private bool EsDataValida()
        {
            if (proyectoTxt.Text != string.Empty && encargadoTxt.Text != string.Empty && direccionTxt.Text != string.Empty && descripcionTxt.Text != string.Empty)
                return true;

            return false;
        }

        private void agregarBtn_Click_1(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                Proyecto proyecto = new Proyecto(proyectoTxt.Text, encargadoTxt.Text, direccionTxt.Text, descripcionTxt.Text, fechaInicio.Value, fechaFin.Value);
                string[] campos = ServicioProyecto.Agregar(proyecto);
                
                ListViewItem item = new ListViewItem(campos, 0);
                proyectosListView.Items.Add(item);
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                ServicioProyecto.Eliminar(Int32.Parse(idTxt.Text));

                proyectosListView.SelectedItems[0].Remove();
                Limpiar();
            }
        }
        private void Limpiar()
        {
            idTxt.Clear();
            proyectoTxt.Clear();
            encargadoTxt.Clear();
            direccionTxt.Clear();
            descripcionTxt.Clear();
            fechaInicio.Value = DateTime.Now;
            fechaFin.Value = DateTime.Now;
        }

        private void modificatBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                Proyecto proyecto = new Proyecto(Int32.Parse(idTxt.Text), proyectoTxt.Text, encargadoTxt.Text, direccionTxt.Text, descripcionTxt.Text, fechaInicio.Value, fechaFin.Value);
                ServicioProyecto.Modificar(Int32.Parse(idTxt.Text), proyecto);

                ListViewItem i = proyectosListView.SelectedItems[0];
                i.SubItems[0].Text = idTxt.Text;
                i.SubItems[1].Text = proyectoTxt.Text;
                i.SubItems[2].Text = encargadoTxt.Text;
                i.SubItems[3].Text = direccionTxt.Text;
                i.SubItems[4].Text = descripcionTxt.Text;
                i.SubItems[5].Text = fechaInicio.Value.ToString();
                i.SubItems[6].Text = fechaFin.Value.ToString();
            }
        }

        private void proyectosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (proyectosListView.SelectedItems.Count > 0)
            {
                ListViewItem i;
                i = proyectosListView.SelectedItems[0];
                idTxt.Text = i.SubItems[0].Text;
                proyectoTxt.Text = i.SubItems[1].Text;
                encargadoTxt.Text = i.SubItems[2].Text;
                direccionTxt.Text = i.SubItems[3].Text;
                descripcionTxt.Text = i.SubItems[4].Text;
                fechaInicio.Value = DateTime.Parse(i.SubItems[5].Text);
                fechaFin.Value = DateTime.Parse(i.SubItems[6].Text);
            }
        }
    }
}

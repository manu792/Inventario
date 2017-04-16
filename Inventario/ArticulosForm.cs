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
    public partial class ArticulosForm : Form
    {
        private ServicioArticulo ServicioArticulo { get; set; }
         
        public ArticulosForm()
        {
            ServicioArticulo = new ServicioArticulo();
            InitializeComponent();
        }

        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            CargarArticulos(ServicioArticulo.ObtenerArticulos());
        }
        private void CargarArticulos(List<string[]> articulos)
        {
            foreach (string[] articulo in articulos)
            {
                ListViewItem item = new ListViewItem(articulo, 0);
                articulosListView.Items.Add(item);
            }
            articulosListView.View = View.Tile;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                Articulo articulo = new Articulo(articuloTxt.Text, Int32.Parse(unidadTxt.Text), Double.Parse(precioTxt.Text), descripcionTxt.Text);
                string[] campos = ServicioArticulo.Agregar(articulo);

                ListViewItem item = new ListViewItem(campos, 0);
                articulosListView.Items.Add(item);

                Limpiar();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                ServicioArticulo.Eliminar(Int32.Parse(idTxt.Text));

                articulosListView.SelectedItems[0].Remove();
                Limpiar();
            }
        }

        private void modificatBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
            {
                Articulo articulo = new Articulo(Int32.Parse(idTxt.Text), articuloTxt.Text, Int32.Parse(unidadTxt.Text), Double.Parse(precioTxt.Text), descripcionTxt.Text);
                ServicioArticulo.Modificar(Int32.Parse(idTxt.Text), articulo);

                ListViewItem i = articulosListView.SelectedItems[0];
                i.SubItems[0].Text = idTxt.Text;
                i.SubItems[1].Text = articuloTxt.Text;
                i.SubItems[2].Text = unidadTxt.Text;
                i.SubItems[3].Text = precioTxt.Text;
                i.SubItems[4].Text = descripcionTxt.Text;

                Limpiar();
            }
        }
        private bool EsDataValida()
        {
            if (articuloTxt.Text != string.Empty && unidadTxt.Text != string.Empty && precioTxt.Text != string.Empty && descripcionTxt.Text != string.Empty)
                return true;

            return false;
        }
        private void Limpiar()
        {
            idTxt.Clear();
            articuloTxt.Clear();
            unidadTxt.Clear();
            precioTxt.Clear();
            descripcionTxt.Clear();
        }

        private void articulosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articulosListView.SelectedItems.Count > 0)
            {
                ListViewItem i;
                i = articulosListView.SelectedItems[0];
                idTxt.Text = i.SubItems[0].Text;
                articuloTxt.Text = i.SubItems[1].Text;
                unidadTxt.Text = i.SubItems[2].Text;
                precioTxt.Text = i.SubItems[3].Text;
                descripcionTxt.Text = i.SubItems[4].Text;
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            idTxt.Clear();
            articuloTxt.Clear();
            unidadTxt.Clear();
            precioTxt.Clear();
            descripcionTxt.Clear();
        }
    }
}

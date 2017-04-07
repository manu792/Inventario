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
    public partial class InventarioForm : Form
    {
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        public InventarioForm()
        {
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
            InitializeComponent();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarComboBoxProyectos(ServicioProyecto.ObtenerProyectos());
        }

        private void CargarComboBoxProyectos(List<Proyecto> proyectos)
        {
            foreach (Proyecto proyecto in proyectos)
                listaProyectos.Items.Add(proyecto.Nombre);
        }
        
        private void listaProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (EsDataValida())
                ServicioProyecto.AgregarProyecto(Int32.Parse(idTxt.Text), proyectoTxt.Text, encargadoTxt.Text, direccionTxt.Text, descripcionTxt.Text, fechaInicio.Value, fechaFin.Value);
        }
        private bool EsDataValida()
        {
            if (proyectoTxt.Text != string.Empty && encargadoTxt.Text != string.Empty && direccionTxt.Text != string.Empty && descripcionTxt.Text != string.Empty)
                return true;

            return false;
        }
    }
}

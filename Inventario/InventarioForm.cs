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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioProyecto.AgregarProyecto(1, "Proyecto Los Lagos", "Manuel Roman", "Alajuelita", "Un proyecto nuevo", DateTime.Now, DateTime.Now.AddDays(10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ServicioArticulo.AgregarArticulo(1, "Manuel", 200, 2500, "Articulo de prueba");
            ServicioArticulo.EliminarArticulo(3);
        }
    }
}

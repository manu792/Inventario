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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void ArticulosForm(object sender, EventArgs e)
        {
            ArticulosForm articulosForm = new ArticulosForm();
            articulosForm.MdiParent = this;
            articulosForm.Show();
        }

        private void ProyectosForm(object sender, EventArgs e)
        {
            ProyectosForm proyectosForm = new ProyectosForm();
            proyectosForm.MdiParent = this;
            proyectosForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesEntrada ordenesEntradaForm = new OrdenesEntrada();
            ordenesEntradaForm.MdiParent = this;
            ordenesEntradaForm.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesSalida ordenesSalidaForm = new OrdenesSalida();
            ordenesSalidaForm.MdiParent = this;
            ordenesSalidaForm.Show();
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioForm inventarioForm = new InventarioForm();
            inventarioForm.MdiParent = this;
            inventarioForm.Show();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteForm reporteForm = new ReporteForm();
            reporteForm.MdiParent = this;
            reporteForm.Show();
        }
    }
}

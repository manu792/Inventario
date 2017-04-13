using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios.OrdenEntradaEventArgs
{
    public class NuevaOrdenDetalles : EventArgs
    {
        public int IdProyecto { get; set; }
        public List<Detalle> Detalles { get; set; }

        public NuevaOrdenDetalles(int idProyecto, List<Detalle> detalles)
        {
            IdProyecto = idProyecto;
            Detalles = detalles;
        }
    }
}

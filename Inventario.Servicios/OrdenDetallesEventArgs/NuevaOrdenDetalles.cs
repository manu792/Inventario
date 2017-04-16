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
        public Orden Orden { get; set; }

        public NuevaOrdenDetalles(Orden orden)
        {
            Orden = orden;
        }
    }
}

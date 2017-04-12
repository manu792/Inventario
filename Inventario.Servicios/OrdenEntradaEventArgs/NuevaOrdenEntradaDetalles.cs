using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios.OrdenEntradaEventArgs
{
    public class NuevaOrdenEntradaDetalles : EventArgs
    {
        public int IdProyecto { get; set; }
        public List<Detalle> DetallesEntrada { get; set; }

        public NuevaOrdenEntradaDetalles(int idProyecto, List<Detalle> detallesEntrada)
        {
            IdProyecto = idProyecto;
            DetallesEntrada = detallesEntrada;
        }
    }
}

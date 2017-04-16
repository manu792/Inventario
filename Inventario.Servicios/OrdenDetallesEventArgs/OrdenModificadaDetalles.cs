using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios.OrdenEntradaEventArgs
{
    public class OrdenModificadaDetalles : EventArgs
    {
        public Orden Orden { get; set; }
        public List<string[]> RegistrosModificados { get; set; }

        public OrdenModificadaDetalles(Orden orden, List<string[]> registrosModificados)
        {
            Orden = orden;
            RegistrosModificados = registrosModificados;
        }
    }
}

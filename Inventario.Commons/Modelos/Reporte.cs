using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class Reporte
    {
        public Proyecto Proyecto { get; set; }
        public List<InventarioProyecto> Inventario { get; set; }
        public List<Orden> OrdenesEntrada { get; set; }
        public List<Orden> OrdenesSalida { get; set; }

        public Reporte(Proyecto proyecto, List<InventarioProyecto> inventario, List<Orden> ordenesEntrada, List<Orden> ordenesSalida)
        {
            Proyecto = proyecto;
            Inventario = inventario;
            OrdenesEntrada = ordenesEntrada;
            OrdenesSalida = ordenesSalida;
        }
    }
}

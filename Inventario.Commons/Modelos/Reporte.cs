using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class OrdenEntrada
    {
        public List<Orden> OrdenesEntrada { get; set; }
        public Dictionary<int, List<Detalle>> DetallesEntrada { get; set; }
        //public List<Detalle> DetallesEntrada { get; set; }

        public OrdenEntrada(List<Orden> ordenesEntrada, Dictionary<int, List<Detalle>> detallesEntrada)
        {
            OrdenesEntrada = ordenesEntrada;
            DetallesEntrada = detallesEntrada;
        }
    }
    public class OrdenSalida
    {
        public List<Orden> OrdenesSalida { get; set; }
        public Dictionary<int, List<Detalle>> DetallesSalida { get; set; }
        //public List<Detalle> DetallesSalida { get; set; }

        public OrdenSalida(List<Orden> ordenesSalida, Dictionary<int, List<Detalle>> detallesSalida)
        {
            OrdenesSalida = ordenesSalida;
            DetallesSalida = detallesSalida;
        }
    }

    public class Reporte
    {
        public Proyecto Proyecto { get; set; }
        public List<InventarioProyecto> Inventario { get; set; }
        public OrdenEntrada RepositorioOrdenEntrada { get; set; }
        public OrdenSalida RepositorioOrdenSalida { get; set; }

        public Reporte(Proyecto proyecto, List<InventarioProyecto> inventario, OrdenEntrada repositorioOrdenEntrada, OrdenSalida repositorioOrdenSalida)
        {
            Proyecto = proyecto;
            Inventario = inventario;
            RepositorioOrdenEntrada = repositorioOrdenEntrada;
            RepositorioOrdenSalida = repositorioOrdenSalida;
        }
    }
}

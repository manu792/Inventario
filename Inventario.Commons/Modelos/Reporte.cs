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
    }
    public class OrdenSalida
    {
        public List<Orden> OrdenesSalida { get; set; }
    }

    public class Reporte
    {
        public Proyecto Proyecto { get; set; }
        public OrdenEntrada RepositorioOrdenEntrada { get; set; }
        public OrdenSalida RepositorioOrdenSalida { get; set; }
    }
}

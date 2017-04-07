using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class DetalleSalida
    {
        public int IdDetalleSalida { get; set; }
        public int IdSalida { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public DetalleSalida(int idDetalleSalida, int idSalida, int idArticulo, int cantidad, double total)
        {
            IdDetalleSalida = idDetalleSalida;
            IdSalida = idSalida;
            IdArticulo = idArticulo;
            Cantidad = cantidad;
            Total = total;
        }

        public override string ToString()
        {
            return IdDetalleSalida + "#" + IdSalida + "#" + IdArticulo + "#" + Cantidad + "#" + Total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class DetalleEntrada
    {
        public int IdDetalleEntrada { get; set; }
        public int IdEntrada { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public DetalleEntrada(int idArticulo, int cantidad, double total)
        {
            IdArticulo = idArticulo;
            Cantidad = cantidad;
            Total = total;
        }
        public DetalleEntrada(int idDetalleEntrada, int idEntrada, int idArticulo, int cantidad, double total)
        {
            IdDetalleEntrada = idDetalleEntrada;
            IdEntrada = idEntrada;
            IdArticulo = idArticulo;
            Cantidad = cantidad;
            Total = total;
        }

        public override string ToString()
        {
            return IdDetalleEntrada + "#" + IdEntrada + "#" + IdArticulo + "#" + Cantidad + "#" + Total;
        }
    }
}

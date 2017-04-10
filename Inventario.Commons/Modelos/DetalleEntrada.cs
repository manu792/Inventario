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
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public DetalleEntrada(Articulo articulo, int cantidad, double total)
        {
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }
        public DetalleEntrada(int idEntrada, Articulo articulo, int cantidad, double total)
        {
            IdEntrada = idEntrada;
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }
        public DetalleEntrada(int idDetalleEntrada, int idEntrada, Articulo articulo, int cantidad, double total)
        {
            IdDetalleEntrada = idDetalleEntrada;
            IdEntrada = idEntrada;
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }

        public override string ToString()
        {
            return IdDetalleEntrada + "#" + IdEntrada + "#" + Articulo.Id + "#" + Cantidad + "#" + Total;
        }

        public string[] ConvertirAArray()
        {
            string[] campos = new string[4];
            campos[0] = Articulo.Nombre;
            campos[1] = Articulo.Precio.ToString();
            campos[2] = Cantidad.ToString();
            campos[3] = Total.ToString();
            return campos;
        }
    }
}

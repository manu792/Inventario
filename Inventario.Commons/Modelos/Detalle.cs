using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class Detalle
    {
        public int IdDetalle { get; set; }
        public int IdOrden { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public Detalle(Articulo articulo, int cantidad, double total)
        {
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }
        public Detalle(int idEntrada, Articulo articulo, int cantidad, double total)
        {
            IdOrden = idEntrada;
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }
        public Detalle(int idDetalleEntrada, int idEntrada, Articulo articulo, int cantidad, double total)
        {
            IdDetalle = idDetalleEntrada;
            IdOrden = idEntrada;
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }

        public override string ToString()
        {
            return IdDetalle + "#" + IdOrden + "#" + Articulo.Id + "#" + Cantidad + "#" + Total;
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

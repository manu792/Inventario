using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Servicios.Modelos
{
    public class DetalleEntradaVista
    {
        public int IdDetalleEntrada { get; set; }
        public int IdEntrada { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public DetalleEntradaVista(Articulo articulo, int cantidad, double total)
        {
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
        }
        public DetalleEntradaVista(int idDetallaEntrada, int idEntrada, Articulo articulo, int cantidad, double total)
        {
            IdDetalleEntrada = idDetallaEntrada;
            IdEntrada = idEntrada;
            Articulo = articulo;
            Cantidad = cantidad;
            Total = total;
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

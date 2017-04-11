using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Inventario.Data.Archivos;

namespace Inventario.Servicios
{
    public class ServicioInventario
    {
        private InventarioArchivo InventarioArchivo { get; set; }

        public ServicioInventario()
        {
            InventarioArchivo = new InventarioArchivo();
        }

        public void ActualizarInventario(int idProyecto, List<DetalleEntrada> detallesEntrada)
        {
            foreach(DetalleEntrada detalleEntrada in detallesEntrada)
            {
                Inventario.Commons.Modelos.Inventario registro = InventarioArchivo.ArticuloEnProyecto(idProyecto, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad += detalleEntrada.Cantidad;
                    InventarioArchivo.ActualizarCantidad(idProyecto, detalleEntrada.Articulo.Id, registro);
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new Commons.Modelos.Inventario(idProyecto, detalleEntrada.Articulo.Id, detalleEntrada.Cantidad));
            }
        }
    }
}

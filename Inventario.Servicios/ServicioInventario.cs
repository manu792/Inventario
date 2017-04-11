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
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(idProyecto, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad += detalleEntrada.Cantidad;
                    InventarioArchivo.ActualizarCantidad(idProyecto, detalleEntrada.Articulo.Id, registro);
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new InventarioProyecto(idProyecto, detalleEntrada.Articulo.Id, detalleEntrada.Cantidad));
            }
        }

        public void ActualizarInventario(int idProyecto, List<DetalleSalida> detallesSalida)
        {
            foreach (DetalleSalida detalleSalida in detallesSalida)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(idProyecto, detalleSalida.IdArticulo);
                if (registro != null)
                {
                    registro.Cantidad -= detalleSalida.Cantidad;
                    InventarioArchivo.ActualizarCantidad(idProyecto, detalleSalida.IdArticulo, registro);
                }
                else
                    throw new Exception("El articulo no existe para el proyecto con id: " + idProyecto);
            }
        }
    }
}

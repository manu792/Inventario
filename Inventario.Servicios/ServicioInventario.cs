using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Inventario.Data.Archivos;
using Inventario.Servicios.OrdenEntradaEventArgs;

namespace Inventario.Servicios
{
    public class ServicioInventario
    {
        private InventarioArchivo InventarioArchivo { get; set; }
        private ServicioOrdenEntrada ServicioOrdenEntrada { get; set; }

        public ServicioInventario(ServicioOrdenEntrada servicioOrdenEntrada)
        {
            InventarioArchivo = new InventarioArchivo();
            ServicioOrdenEntrada = servicioOrdenEntrada;
            ServicioOrdenEntrada.NuevaOrdeEntrada += ActualizarInventario;
            ServicioOrdenEntrada.OrdenEntradaModificada += Modificar;
        }

        public void ActualizarInventario(object sender, NuevaOrdenEntradaDetalles e)
        {
            foreach(Detalle detalleEntrada in e.DetallesEntrada)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.IdProyecto, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad += detalleEntrada.Cantidad;
                    InventarioArchivo.ActualizarCantidad(e.IdProyecto, detalleEntrada.Articulo.Id, registro);
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new InventarioProyecto(e.IdProyecto, detalleEntrada.Articulo.Id, detalleEntrada.Cantidad));
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

        public void Modificar(object sender, OrdenEntradaModificadaDetalles e)
        {
            foreach (Detalle detalleEntrada in e.DetallesEntrada)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.IdProyecto, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    string[] campos = e.RegistrosModificados.Where(x => Int32.Parse(x[2]) == registro.IdArticulo).FirstOrDefault();
                    if (campos != null)
                    {
                        registro.Cantidad -= Int32.Parse(campos[3]);
                        registro.Cantidad += detalleEntrada.Cantidad;

                        InventarioArchivo.ActualizarCantidad(e.IdProyecto, detalleEntrada.Articulo.Id, registro);
                    }
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new InventarioProyecto(e.IdProyecto, detalleEntrada.Articulo.Id, detalleEntrada.Cantidad));
            }
        }
    }
}

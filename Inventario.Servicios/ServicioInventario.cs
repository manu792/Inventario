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
        private ServicioOrdenSalida ServicioOrdenSalida { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        private ServicioInventario()
        {
            InventarioArchivo = new InventarioArchivo();
            ServicioArticulo = new ServicioArticulo();
        }

        public ServicioInventario(ServicioOrdenEntrada servicioOrdenEntrada) : this()
        {
            ServicioOrdenEntrada = servicioOrdenEntrada;
            ServicioOrdenEntrada.NuevaOrdeEntrada += AgregarAlInventario;
            ServicioOrdenEntrada.OrdenEntradaModificada += Modificar;
        }
        public ServicioInventario(ServicioOrdenSalida servicioOrdenSalida) : this()
        {
            ServicioOrdenSalida = servicioOrdenSalida;
            ServicioOrdenSalida.NuevaOrdenSalida += RemoverDelInventario;
            servicioOrdenSalida.OrdenSalidaModificada += Modificar;
        }

        public void AgregarAlInventario(object sender, NuevaOrdenDetalles e)
        {
            foreach(Detalle detalleEntrada in e.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.IdProyecto, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad += detalleEntrada.Cantidad;
                    InventarioArchivo.ActualizarCantidad(e.IdProyecto, detalleEntrada.Articulo.Id, registro);
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new InventarioProyecto(new Proyecto(e.IdProyecto), new Articulo(detalleEntrada.Articulo.Id), detalleEntrada.Cantidad));
            }
        }

        public void RemoverDelInventario(object sender, NuevaOrdenDetalles e)
        {
            foreach (Detalle detalleSalida in e.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.IdProyecto, detalleSalida.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad -= detalleSalida.Cantidad;
                    InventarioArchivo.ActualizarCantidad(e.IdProyecto, detalleSalida.Articulo.Id, registro);
                }
                else
                    throw new Exception("El articulo no existe para el proyecto con id: " + e.IdProyecto);
            }
        }

        public void Modificar(object sender, OrdenModificadaDetalles e)
        {
            foreach (Detalle detalleEntrada in e.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.IdProyecto, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    string[] campos = e.RegistrosModificados.Where(x => Int32.Parse(x[2]) == registro.Articulo.Id).FirstOrDefault();
                    if (campos != null)
                    {
                        registro.Cantidad -= Int32.Parse(campos[3]);
                        registro.Cantidad += detalleEntrada.Cantidad;

                        InventarioArchivo.ActualizarCantidad(e.IdProyecto, detalleEntrada.Articulo.Id, registro);
                    }
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new InventarioProyecto(new Proyecto(e.IdProyecto), new Articulo(detalleEntrada.Articulo.Id), detalleEntrada.Cantidad));
            }
        }
        public List<InventarioProyecto> ObtenerArticulosPorProyecto(int idProyecto)
        {
            List<InventarioProyecto> inventario = InventarioArchivo.ArticulosEnProyecto(idProyecto);
            foreach(InventarioProyecto registro in inventario)
            {
                registro.Articulo = ServicioArticulo.ObtenerArticulo(registro.Articulo.Id);
            }
            return inventario;
        }
    }
}

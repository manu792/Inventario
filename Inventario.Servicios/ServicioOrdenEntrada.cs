using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Inventario.Data;
using Inventario.Servicios.OrdenEntradaEventArgs;

namespace Inventario.Servicios
{
    public class ServicioOrdenEntrada
    {
        private OrdenEntradaArchivo OrdenEntradaArchivo { get; set; }
        private DetalleEntradaArchivo DetalleEntradaArchivo { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        public event EventHandler<NuevaOrdenDetalles> NuevaOrdeEntrada;
        public event EventHandler<OrdenModificadaDetalles> OrdenEntradaModificada;

        public ServicioOrdenEntrada()
        {
            OrdenEntradaArchivo = new OrdenEntradaArchivo();
            DetalleEntradaArchivo = new DetalleEntradaArchivo();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
        }

        public List<Orden> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<Orden> ordenesEntrada = OrdenEntradaArchivo.ObtenerOrdenesEntrada(idProyecto);
            foreach (Orden ordenEntrada in ordenesEntrada)
            {
                Proyecto proyecto = ServicioProyecto.ObtenerProyecto(ordenEntrada.Proyecto.Id);
                ordenEntrada.Proyecto = proyecto;
                ordenEntrada.Detalles = DetalleEntradaArchivo.ObtenerDetalleEntradas(ordenEntrada.Id);
                ObtenerArticulosPorDetalle(ordenEntrada);
            }

            return ordenesEntrada;
        }
        private void ObtenerArticulosPorDetalle(Orden ordenEntrada)
        {
            foreach (Detalle detalle in ordenEntrada.Detalles)
            {
                detalle.Articulo = ServicioArticulo.ObtenerArticulo(detalle.Articulo.Id);
            }
        }

        public void Agregar(Orden ordenEntrada)
        {
            int idEntrada = OrdenEntradaArchivo.Guardar(ordenEntrada);

            foreach(Detalle detalleEntrada in ordenEntrada.Detalles)
            {
                detalleEntrada.IdOrden = idEntrada;
                DetalleEntradaArchivo.Guardar(detalleEntrada);
            }
            
            OnNuevaOrdenEntrada(new NuevaOrdenDetalles(ordenEntrada));
        }

        public void Modificar(Orden ordenEntrada)
        {
            List<string[]> registrosModificados = new List<string[]>();

            OrdenEntradaArchivo.Modificar(ordenEntrada);
            foreach (Detalle detalleEntrada in ordenEntrada.Detalles)
            {
                registrosModificados.Add(DetalleEntradaArchivo.Modificar(detalleEntrada));
            }

            OnOrdenEntradaModificada(new OrdenModificadaDetalles(ordenEntrada, registrosModificados));
        }

        public void Eliminar(int idOrdenEntrada)
        {
            DetalleEntradaArchivo.Eliminar(idOrdenEntrada);
            OrdenEntradaArchivo.Eliminar(idOrdenEntrada);
        }

        protected void OnNuevaOrdenEntrada(NuevaOrdenDetalles e)
        {
            if (NuevaOrdeEntrada != null)
                NuevaOrdeEntrada(this, e);
        }

        protected void OnOrdenEntradaModificada(OrdenModificadaDetalles e)
        {
            if (OrdenEntradaModificada != null)
                OrdenEntradaModificada(this, e);
        }
    }
}

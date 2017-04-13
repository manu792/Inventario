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
        
        public List<Detalle> ObtenerDetallesEntrada(int idOrdenEntrada)
        {
            List<Detalle> detallesEntrada = DetalleEntradaArchivo.ObtenerDetalleEntradas(idOrdenEntrada);
            foreach(Detalle detalleEntrada in detallesEntrada)
            {
                Articulo articulo = ServicioArticulo.ObtenerArticulo(detalleEntrada.Articulo.Id);
                detalleEntrada.Articulo = articulo;
            }
            return detallesEntrada;
        }

        public List<string[]> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<string[]> listaOrdenesEntrada = new List<string[]>();
            
            List<Orden> ordenesEntrada = OrdenEntradaArchivo.ObtenerOrdenesEntrada(idProyecto);
            foreach (Orden ordenEntrada in ordenesEntrada)
            {
                Proyecto proyecto = ServicioProyecto.ObtenerProyecto(ordenEntrada.Proyecto.Id);
                ordenEntrada.Proyecto = proyecto;
                listaOrdenesEntrada.Add(ordenEntrada.ConvertirAArray());
            }

            return listaOrdenesEntrada;
        }

        public void Agregar(Orden ordenEntrada, List<Detalle> detallesEntrada)
        {
            int idEntrada = OrdenEntradaArchivo.Guardar(ordenEntrada);

            foreach(Detalle detalleEntrada in detallesEntrada)
            {
                detalleEntrada.IdOrden = idEntrada;
                DetalleEntradaArchivo.Guardar(detalleEntrada);
            }
            
            OnNuevaOrdenEntrada(new NuevaOrdenDetalles(ordenEntrada.Proyecto.Id, detallesEntrada));
        }

        public void Modificar(Orden ordenEntrada, List<Detalle> detallesEntrada)
        {
            List<string[]> registrosModificados = new List<string[]>();

            OrdenEntradaArchivo.Modificar(ordenEntrada);
            foreach (Detalle detalleEntrada in detallesEntrada)
            {
                registrosModificados.Add(DetalleEntradaArchivo.Modificar(detalleEntrada));
            }

            OnOrdenEntradaModificada(new OrdenModificadaDetalles(ordenEntrada.Proyecto.Id, detallesEntrada, registrosModificados));
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

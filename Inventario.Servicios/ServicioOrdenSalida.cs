using Inventario.Commons.Modelos;
using Inventario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Servicios.OrdenEntradaEventArgs;

namespace Inventario.Servicios
{
    public class ServicioOrdenSalida
    {
        private OrdenSalidaArchivo OrdenSalidaArchivo { get; set; }
        private DetalleSalidaArchivo DetalleSalidaArchivo { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        public event EventHandler<NuevaOrdenDetalles> NuevaOrdenSalida;
        public event EventHandler<OrdenModificadaDetalles> OrdenSalidaModificada;

        public ServicioOrdenSalida()
        {
            OrdenSalidaArchivo = new OrdenSalidaArchivo();
            DetalleSalidaArchivo = new DetalleSalidaArchivo();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
        }

        public List<Detalle> ObtenerDetallesSalida(int idOrdenSalida)
        {
            List<Detalle> detallesSalida = DetalleSalidaArchivo.ObtenerDetalleSalidas(idOrdenSalida);
            foreach (Detalle detalleSalida in detallesSalida)
            {
                Articulo articulo = ServicioArticulo.ObtenerArticulo(detalleSalida.Articulo.Id);
                detalleSalida.Articulo = articulo;
            }
            return detallesSalida;
        }

        public List<Orden> ObtenerOrdenesSalida(int idProyecto)
        {
            //List<string[]> listaOrdenesSalida = new List<string[]>();

            List<Orden> ordenesSalida = OrdenSalidaArchivo.ObtenerOrdenesSalidas(idProyecto);
            foreach (Orden ordenSalida in ordenesSalida)
            {
                Proyecto proyecto = ServicioProyecto.ObtenerProyecto(ordenSalida.Proyecto.Id);
                ordenSalida.Proyecto = proyecto;
                //listaOrdenesSalida.Add(ordenSalida.ConvertirAArray());
            }

            return ordenesSalida;
        }

        public void Agregar(Orden ordenSalida, List<Detalle> detallesSalida)
        {
            int idSalida = OrdenSalidaArchivo.Guardar(ordenSalida);

            foreach (Detalle detalleSalida in detallesSalida)
            {
                detalleSalida.IdOrden = idSalida;
                DetalleSalidaArchivo.Guardar(detalleSalida);
            }

            OnNuevaOrdenSalida(new NuevaOrdenDetalles(ordenSalida.Proyecto.Id, detallesSalida));
        }

        public void Modificar(Orden ordenSalida, List<Detalle> detallesSalida)
        {
            List<string[]> registrosModificados = new List<string[]>();

            OrdenSalidaArchivo.Modificar(ordenSalida);
            foreach (Detalle detalleSalida in detallesSalida)
            {
                registrosModificados.Add(DetalleSalidaArchivo.Modificar(detalleSalida));
            }
            OnOrdenSalidaModificada(new OrdenModificadaDetalles(ordenSalida.Proyecto.Id, detallesSalida, registrosModificados));
        }

        public void Eliminar(int idOrdenSalida)
        {
            DetalleSalidaArchivo.Eliminar(idOrdenSalida);
            OrdenSalidaArchivo.Eliminar(idOrdenSalida);
        }

        protected void OnNuevaOrdenSalida(NuevaOrdenDetalles e)
        {
            if (NuevaOrdenSalida != null)
                NuevaOrdenSalida(this, e);
        }

        protected void OnOrdenSalidaModificada(OrdenModificadaDetalles e)
        {
            if (OrdenSalidaModificada != null)
                OrdenSalidaModificada(this, e);
        }
    }
}

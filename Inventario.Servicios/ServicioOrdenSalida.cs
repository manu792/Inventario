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

        public List<Orden> ObtenerOrdenesSalida(int idProyecto)
        {
            List<Orden> ordenesSalida = OrdenSalidaArchivo.ObtenerOrdenesSalidas(idProyecto);
            foreach (Orden ordenSalida in ordenesSalida)
            {
                Proyecto proyecto = ServicioProyecto.ObtenerProyecto(ordenSalida.Proyecto.Id);
                ordenSalida.Proyecto = proyecto;
                ordenSalida.Detalles = DetalleSalidaArchivo.ObtenerDetalleSalidas(ordenSalida.Id);
                ObtenerArticulosPorDetalle(ordenSalida);
            }

            return ordenesSalida;
        }
        private void ObtenerArticulosPorDetalle(Orden ordenSalida)
        {
            foreach(Detalle detalle in ordenSalida.Detalles)
            {
                detalle.Articulo = ServicioArticulo.ObtenerArticulo(detalle.Articulo.Id);
            }
        }

        public void Agregar(Orden ordenSalida)
        {
            int idSalida = OrdenSalidaArchivo.Guardar(ordenSalida);

            foreach (Detalle detalleSalida in ordenSalida.Detalles)
            {
                detalleSalida.IdOrden = idSalida;
                DetalleSalidaArchivo.Guardar(detalleSalida);
            }

            OnNuevaOrdenSalida(new NuevaOrdenDetalles(ordenSalida));
        }

        public void Modificar(Orden ordenSalida)
        {
            List<string[]> registrosModificados = new List<string[]>();

            OrdenSalidaArchivo.Modificar(ordenSalida);
            foreach (Detalle detalleSalida in ordenSalida.Detalles)
            {
                registrosModificados.Add(DetalleSalidaArchivo.Modificar(detalleSalida));
            }
            OnOrdenSalidaModificada(new OrdenModificadaDetalles(ordenSalida, registrosModificados));
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

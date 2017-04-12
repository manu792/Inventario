using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Inventario.Data;

namespace Inventario.Servicios
{
    public class NuevaOrdenEntradaDetalles : EventArgs
    {
        public int IdProyecto { get; set; }
        public List<DetalleEntrada> DetallesEntrada { get; set; }

        public NuevaOrdenEntradaDetalles(int idProyecto, List<DetalleEntrada> detallesEntrada)
        {
            IdProyecto = idProyecto;
            DetallesEntrada = detallesEntrada;
        }
    }

    public class OrdenEntradaModificadaDetalles : EventArgs
    {
        public int IdProyecto { get; set; }
        public List<DetalleEntrada> DetallesEntrada { get; set; }
        public List<string[]> RegistrosModificados { get; set; }

        public OrdenEntradaModificadaDetalles(int idProyecto, List<DetalleEntrada> detallesEntrada, List<string[]> registrosModificados)
        {
            IdProyecto = idProyecto;
            DetallesEntrada = detallesEntrada;
            RegistrosModificados = registrosModificados;
        }
    }




    public class ServicioOrdenEntrada
    {
        private OrdenEntradaArchivo OrdenEntradaArchivo { get; set; }
        private DetalleEntradaArchivo DetalleEntradaArchivo { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        public event EventHandler<NuevaOrdenEntradaDetalles> NuevaOrdeEntrada;
        public event EventHandler<OrdenEntradaModificadaDetalles> OrdenEntradaModificada;

        public ServicioOrdenEntrada()
        {
            OrdenEntradaArchivo = new OrdenEntradaArchivo();
            DetalleEntradaArchivo = new DetalleEntradaArchivo();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
        }
        
        public List<DetalleEntrada> ObtenerDetallesEntrada(int idOrdenEntrada)
        {
            List<DetalleEntrada> detallesEntrada = DetalleEntradaArchivo.ObtenerDetalleEntradas(idOrdenEntrada);
            foreach(DetalleEntrada detalleEntrada in detallesEntrada)
            {
                Articulo articulo = ServicioArticulo.ObtenerArticulo(detalleEntrada.Articulo.Id);
                detalleEntrada.Articulo = articulo;
            }
            return detallesEntrada;
        }

        public List<string[]> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<string[]> listaOrdenesEntrada = new List<string[]>();
            
            List<OrdenEntrada> ordenesEntrada = OrdenEntradaArchivo.ObtenerOrdenesEntrada(idProyecto);
            foreach (OrdenEntrada ordenEntrada in ordenesEntrada)
            {
                Proyecto proyecto = ServicioProyecto.ObtenerProyecto(ordenEntrada.Proyecto.Id);
                ordenEntrada.Proyecto = proyecto;
                listaOrdenesEntrada.Add(ordenEntrada.ConvertirAArray());
            }

            return listaOrdenesEntrada;
        }

        public void Agregar(OrdenEntrada ordenEntrada, List<DetalleEntrada> detallesEntrada)
        {
            int idEntrada = OrdenEntradaArchivo.Guardar(ordenEntrada);

            foreach(DetalleEntrada detalleEntrada in detallesEntrada)
            {
                detalleEntrada.IdEntrada = idEntrada;
                DetalleEntradaArchivo.Guardar(detalleEntrada);
            }
            
            OnNuevaOrdenEntrada(new NuevaOrdenEntradaDetalles(ordenEntrada.Proyecto.Id, detallesEntrada));
        }

        public void Modificar(OrdenEntrada ordenEntrada, List<DetalleEntrada> detallesEntrada)
        {
            List<string[]> registrosModificados = new List<string[]>();

            OrdenEntradaArchivo.Modificar(ordenEntrada);
            foreach (DetalleEntrada detalleEntrada in detallesEntrada)
            {
                registrosModificados.Add(DetalleEntradaArchivo.Modificar(detalleEntrada));
            }

            OnOrdenEntradaModificada(new OrdenEntradaModificadaDetalles(ordenEntrada.Proyecto.Id, detallesEntrada, registrosModificados));
        }

        public void Eliminar(int idOrdenEntrada)
        {
            DetalleEntradaArchivo.Eliminar(idOrdenEntrada);
            OrdenEntradaArchivo.Eliminar(idOrdenEntrada);
        }

        protected void OnNuevaOrdenEntrada(NuevaOrdenEntradaDetalles e)
        {
            if (NuevaOrdeEntrada != null)
                NuevaOrdeEntrada(this, e);
        }

        protected void OnOrdenEntradaModificada(OrdenEntradaModificadaDetalles e)
        {
            if (OrdenEntradaModificada != null)
                OrdenEntradaModificada(this, e);
        }
    }
}

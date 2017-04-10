using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Inventario.Data;
using Inventario.Data.Modelos;
using Inventario.Servicios.Modelos;

namespace Inventario.Servicios
{
    public class ServicioOrdenEntrada
    {
        private OrdenEntradaArchivo OrdenEntradaArchivo { get; set; }
        private DetalleEntradaArchivo DetalleEntradaArchivo { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        public ServicioOrdenEntrada()
        {
            OrdenEntradaArchivo = new OrdenEntradaArchivo();
            DetalleEntradaArchivo = new DetalleEntradaArchivo();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
        }
        
        public List<DetalleEntradaVista> ObtenerDetallesEntrada(int idOrdenEntrada)
        {
            List<DetalleEntradaVista> detallesEntradaVista = new List<DetalleEntradaVista>();

            List<DetalleEntrada> detallesEntrada = DetalleEntradaArchivo.ObtenerDetalleEntradas(idOrdenEntrada);
            foreach(DetalleEntrada detalleEntrada in detallesEntrada)
            {
                Articulo articulo = ServicioArticulo.ObtenerArticulo(detalleEntrada.IdArticulo);
                DetalleEntradaVista detalleEntradaVista = new DetalleEntradaVista(detalleEntrada.IdDetalleEntrada, detalleEntrada.IdEntrada, articulo, detalleEntrada.Cantidad, detalleEntrada.Total);
                detallesEntradaVista.Add(detalleEntradaVista);
            }
            return detallesEntradaVista;
        }

        public List<string[]> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<string[]> listaOrdenesEntrada = new List<string[]>();

            Proyecto proyecto = ServicioProyecto.ObtenerProyecto(idProyecto);
            List<OrdenEntrada> ordenesEntrada = OrdenEntradaArchivo.ObtenerOrdenesEntrada(idProyecto, proyecto.Nombre);
            foreach (OrdenEntrada ordenEntrada in ordenesEntrada)
            {
                OrdenEntradaVista ordenEntradaVista = new OrdenEntradaVista(ordenEntrada.Id, proyecto, ordenEntrada.Fecha, ordenEntrada.Comentario);
                listaOrdenesEntrada.Add(ordenEntradaVista.ConvertirAArray());
            }

            return listaOrdenesEntrada;
        }

        public void Agregar(OrdenEntradaVista ordenEntrada, List<DetalleEntradaVista> detallesEntrada)
        {
            //List<DetalleEntrada> detallesEntradaArchivo = new List<DetalleEntrada>();
            OrdenEntrada ordenEntradaArchivo = new OrdenEntrada(ordenEntrada.Proyecto.Id, ordenEntrada.Fecha, ordenEntrada.Comentario);
            int idEntrada = OrdenEntradaArchivo.Guardar(ordenEntradaArchivo);
            foreach(DetalleEntradaVista detalleEntrada in detallesEntrada)
            {
                DetalleEntrada detalleEntradaArchivo = new DetalleEntrada(idEntrada, detalleEntrada.Articulo.Id, detalleEntrada.Cantidad, detalleEntrada.Total);
                //detallesEntradaArchivo.Add(detalleEntradaArchivo);
                DetalleEntradaArchivo.Guardar(detalleEntradaArchivo);
            }
        }
    }
}

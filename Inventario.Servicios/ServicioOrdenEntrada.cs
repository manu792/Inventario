using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Inventario.Data;

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
                //DetalleEntrada detalleEntradaArchivo = new DetalleEntrada(idEntrada, detalleEntrada.Articulo.Id, detalleEntrada.Cantidad, detalleEntrada.Total);
                //detallesEntradaArchivo.Add(detalleEntradaArchivo);
                detalleEntrada.IdEntrada = idEntrada;
                DetalleEntradaArchivo.Guardar(detalleEntrada);
            }
        }
    }
}

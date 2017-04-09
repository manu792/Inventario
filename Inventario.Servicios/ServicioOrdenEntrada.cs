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

        public ServicioOrdenEntrada()
        {
            OrdenEntradaArchivo = new OrdenEntradaArchivo();
            DetalleEntradaArchivo = new DetalleEntradaArchivo();
        }

        public List<string[]> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<string[]> listaOrdenesEntrada = new List<string[]>();

            List<OrdenEntrada> ordenesEntrada = OrdenEntradaArchivo.ObtenerOrdenesEntrada(idProyecto);
            foreach (OrdenEntrada ordenEntrada in ordenesEntrada)
                listaOrdenesEntrada.Add(ordenEntrada.ConvertirAArray());

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
        }
    }
}

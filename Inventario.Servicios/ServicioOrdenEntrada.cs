﻿using System;
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
        private ServicioInventario ServicioInventario { get; set; } 

        public ServicioOrdenEntrada()
        {
            OrdenEntradaArchivo = new OrdenEntradaArchivo();
            DetalleEntradaArchivo = new DetalleEntradaArchivo();
            ServicioProyecto = new ServicioProyecto();
            ServicioArticulo = new ServicioArticulo();
            ServicioInventario = new ServicioInventario();
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

            ServicioInventario.ActualizarInventario(ordenEntrada.Proyecto.Id, detallesEntrada);
        }

        public void Modificar(OrdenEntrada ordenEntrada, List<DetalleEntrada> detallesEntrada)
        {
            OrdenEntradaArchivo.Modificar(ordenEntrada);
            foreach (DetalleEntrada detalleEntrada in detallesEntrada)
            {
                DetalleEntradaArchivo.Modificar(detalleEntrada);
            }
        }

        public void Eliminar(int idOrdenEntrada)
        {
            DetalleEntradaArchivo.Eliminar(idOrdenEntrada);
            OrdenEntradaArchivo.Eliminar(idOrdenEntrada);
        }
    }
}

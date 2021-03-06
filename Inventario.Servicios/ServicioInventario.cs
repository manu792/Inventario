﻿using System;
using System.Collections.Generic;
using System.Linq;
using Inventario.Commons.Modelos;
using Inventario.Data;
using Inventario.Data.Archivos;
using Inventario.Servicios.OrdenEntradaEventArgs;

namespace Inventario.Servicios
{
    public class ServicioInventario
    {
        private InventarioArchivo InventarioArchivo { get; set; }
        private ArticuloArchivo ArticuloArchivo { get; set; }

        private ServicioOrdenEntrada ServicioOrdenEntrada { get; set; }
        private ServicioOrdenSalida ServicioOrdenSalida { get; set; }

        public ServicioInventario()
        {
            InventarioArchivo = new InventarioArchivo();
            ArticuloArchivo = new ArticuloArchivo();
        }

        public ServicioInventario(ServicioOrdenEntrada servicioOrdenEntrada) : this()
        {
            ServicioOrdenEntrada = servicioOrdenEntrada;
            ServicioOrdenEntrada.NuevaOrdenEntrada += AumentarInventario;
            ServicioOrdenEntrada.OrdenEntradaModificada += ServicioOrdenEntrada_OrdenEntradaModificada;
        }

        public ServicioInventario(ServicioOrdenSalida servicioOrdenSalida) : this()
        {
            ServicioOrdenSalida = servicioOrdenSalida;
            ServicioOrdenSalida.NuevaOrdenSalida += ReducirInventario;
            servicioOrdenSalida.OrdenSalidaModificada += ServicioOrdenSalida_OrdenSalidaModificada;
        }

        private void AumentarInventario(object sender, NuevaOrdenDetalles e)
        {
            foreach(Detalle detalleEntrada in e.Orden.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.Orden.Proyecto.Id, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad += detalleEntrada.Cantidad;
                    registro.Total = registro.Cantidad * detalleEntrada.Articulo.Precio;
                    InventarioArchivo.ActualizarCantidad(e.Orden.Proyecto.Id, detalleEntrada.Articulo.Id, registro);
                }
                else
                    InventarioArchivo.AgregarArticuloInventario(new InventarioProyecto(new Proyecto(e.Orden.Proyecto.Id), new Articulo(detalleEntrada.Articulo.Id), detalleEntrada.Cantidad, detalleEntrada.Total));
            }
        }
        private void ReducirInventario(object sender, NuevaOrdenDetalles e)
        {
            foreach (Detalle detalleSalida in e.Orden.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.Orden.Proyecto.Id, detalleSalida.Articulo.Id);
                if (registro != null)
                {
                    registro.Cantidad -= detalleSalida.Cantidad;
                    registro.Total = registro.Cantidad * detalleSalida.Articulo.Precio;
                    if (registro.Cantidad > 0)
                        InventarioArchivo.ActualizarCantidad(e.Orden.Proyecto.Id, detalleSalida.Articulo.Id, registro);
                    else
                        InventarioArchivo.EliminarArticuloInventario(registro.Id);
                }
                else
                    throw new Exception("El articulo no existe para el proyecto con id: " + e.Orden.Proyecto.Id);
            }
        }
        private void ServicioOrdenEntrada_OrdenEntradaModificada(object sender, OrdenModificadaDetalles e)
        {
            foreach (Detalle detalleEntrada in e.Orden.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.Orden.Proyecto.Id, detalleEntrada.Articulo.Id);
                if (registro != null)
                {
                    string[] campos = e.RegistrosModificados.Where(x => Int32.Parse(x[2]) == registro.Articulo.Id).FirstOrDefault();
                    if (campos != null)
                    {
                        registro.Cantidad -= Int32.Parse(campos[3]);
                        registro.Cantidad += detalleEntrada.Cantidad;

                        registro.Total = registro.Cantidad * detalleEntrada.Articulo.Precio;

                        if (registro.Cantidad > 0)
                            InventarioArchivo.ActualizarCantidad(e.Orden.Proyecto.Id, detalleEntrada.Articulo.Id, registro);
                        else
                            InventarioArchivo.EliminarArticuloInventario(registro.Id);
                    }
                }
            }
        }
        private void ServicioOrdenSalida_OrdenSalidaModificada(object sender, OrdenModificadaDetalles e)
        {
            foreach (Detalle detalleSalida in e.Orden.Detalles)
            {
                InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(e.Orden.Proyecto.Id, detalleSalida.Articulo.Id);
                if (registro != null)
                {
                    string[] campos = e.RegistrosModificados.Where(x => Int32.Parse(x[2]) == registro.Articulo.Id).FirstOrDefault();
                    if (campos != null)
                    {
                        registro.Cantidad += Int32.Parse(campos[3]);
                        registro.Cantidad -= detalleSalida.Cantidad;

                        registro.Total = registro.Cantidad * detalleSalida.Articulo.Precio;

                        if (registro.Cantidad > 0)
                            InventarioArchivo.ActualizarCantidad(e.Orden.Proyecto.Id, detalleSalida.Articulo.Id, registro);
                        else
                            InventarioArchivo.EliminarArticuloInventario(registro.Id);
                    }
                }
            }
        }
        public List<InventarioProyecto> ObtenerArticulosPorProyecto(int idProyecto)
        {
            List<InventarioProyecto> inventario = InventarioArchivo.ArticulosEnProyecto(idProyecto);
            foreach(InventarioProyecto registro in inventario)
            {
                registro.Articulo = ArticuloArchivo.ObtenerArticulo(registro.Articulo.Id);
            }
            return inventario;
        }
        public int ObtenerCantidadArticuloPorProyecto(int idProyecto, int idArticulo)
        {
            InventarioProyecto registro = InventarioArchivo.ArticuloEnProyecto(idProyecto, idArticulo);
            if (registro != null)
                return registro.Cantidad;
            else
                return 0;
        }
    }
}

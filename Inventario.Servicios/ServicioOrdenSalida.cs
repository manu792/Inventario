﻿using Inventario.Commons.Modelos;
using Inventario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios
{
    public class ServicioOrdenSalida
    {
        private OrdenSalidaArchivo OrdenSalidaArchivo { get; set; }
        private DetalleSalidaArchivo DetalleSalidaArchivo { get; set; }
        private ServicioProyecto ServicioProyecto { get; set; }
        private ServicioArticulo ServicioArticulo { get; set; }

        //public event EventHandler<NuevaOrdenEntradaDetalles> NuevaOrdeEntrada;
        //public event EventHandler<OrdenEntradaModificadaDetalles> OrdenEntradaModificada;

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

        public List<string[]> ObtenerOrdenesSalida(int idProyecto)
        {
            List<string[]> listaOrdenesSalida = new List<string[]>();

            List<Orden> ordenesSalida = OrdenSalidaArchivo.ObtenerOrdenesSalidas(idProyecto);
            foreach (Orden ordenSalida in ordenesSalida)
            {
                Proyecto proyecto = ServicioProyecto.ObtenerProyecto(ordenSalida.Proyecto.Id);
                ordenSalida.Proyecto = proyecto;
                listaOrdenesSalida.Add(ordenSalida.ConvertirAArray());
            }

            return listaOrdenesSalida;
        }

        public void Agregar(Orden ordenSalida, List<Detalle> detallesSalida)
        {
            int idSalida = OrdenSalidaArchivo.Guardar(ordenSalida);

            foreach (Detalle detalleSalida in detallesSalida)
            {
                detalleSalida.IdOrden = idSalida;
                DetalleSalidaArchivo.Guardar(detalleSalida);
            }

            //OnNuevaOrdenEntrada(new NuevaOrdenEntradaDetalles(ordenEntrada.Proyecto.Id, detallesEntrada));
        }

        public void Modificar(Orden ordenSalida, List<Detalle> detallesSalida)
        {
            List<string[]> registrosModificados = new List<string[]>();

            OrdenSalidaArchivo.Modificar(ordenSalida);
            foreach (Detalle detalleSalida in detallesSalida)
            {
                registrosModificados.Add(DetalleSalidaArchivo.Modificar(detalleSalida));
            }

            //OnOrdenEntradaModificada(new OrdenEntradaModificadaDetalles(ordenEntrada.Proyecto.Id, detallesEntrada, registrosModificados));
        }

        public void Eliminar(int idOrdenSalida)
        {
            DetalleSalidaArchivo.Eliminar(idOrdenSalida);
            OrdenSalidaArchivo.Eliminar(idOrdenSalida);
        }

        //protected void OnNuevaOrdenEntrada(NuevaOrdenEntradaDetalles e)
        //{
        //    if (NuevaOrdeEntrada != null)
        //        NuevaOrdeEntrada(this, e);
        //}

        //protected void OnOrdenEntradaModificada(OrdenEntradaModificadaDetalles e)
        //{
        //    if (OrdenEntradaModificada != null)
        //        OrdenEntradaModificada(this, e);
        //}
    }
}

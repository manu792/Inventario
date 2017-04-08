using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data
{
    public class Repositorio
    {
        private ProyectoArchivo Proyectos { get; set; }
        private ArticuloArchivo Articulos { get; set; }
        private OrdenEntradaArchivo OrdenEntrada { get; set; }
        private OrdenSalidaArchivo OrdenSalida { get; set; }
        private DetalleEntradaArchivo DetalleEntrada { get; set; }
        private DetalleSalidaArchivo DetalleSalida { get; set; }

        private static Repositorio instancia;
        public static Repositorio Instancia 
        {
            get
            {
                if (instancia == null)
                    instancia = new Repositorio();

                return instancia;
            }
        }

        private Repositorio()
        {
            Proyectos = new ProyectoArchivo();
            Articulos = new ArticuloArchivo();
            OrdenEntrada = new OrdenEntradaArchivo();
            OrdenSalida = new OrdenSalidaArchivo();
            DetalleEntrada = new DetalleEntradaArchivo();
            DetalleSalida = new DetalleSalidaArchivo();
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return Proyectos.ObtenerProyectos();
        }
        public Proyecto ObtenerProyecto(int id)
        {
            return Proyectos.ObtenerProyecto(id);
        }
        public string[] AgregarProyecto(Proyecto proyecto)
        {
            return Proyectos.Guardar(proyecto);
        }

        public void ModificarProyecto(int id, Proyecto proyecto)
        {
            Proyectos.ModificarProyecto(id, proyecto);
        }

        public void EliminarProyecto(int id)
        {
            Proyectos.EliminarProyecto(id);
        }

        public List<string[]> ObtenerArticulos()
        {
            return Articulos.ObtenerArticulos();
        }

        public string[] AgregarArticulo(Articulo articulo)
        {
            return Articulos.Guardar(articulo);
        }

        public void ModificarArticulo(int id, Articulo articulo)
        {
            Articulos.ModificarArticulo(id, articulo);
        }

        public void EliminarArticulo(int id)
        {
            Articulos.EliminarArticulo(id);
        }
    }
}

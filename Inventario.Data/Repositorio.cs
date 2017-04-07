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

        public Repositorio()
        {
            Proyectos = new ProyectoArchivo();
            Articulos = new ArticuloArchivo();
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            Proyectos.Guardar(proyecto);    
        }

        public void AgregarArticulo(Articulo articulo)
        {
            Articulos.Guardar(articulo);
        }

        public void EliminarArticulo(int id)
        {
            Articulos.EliminarArticulo(id);
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return Proyectos.ObtenerProyectos();
        }
    }
}

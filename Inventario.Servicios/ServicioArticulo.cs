using Inventario.Commons.Modelos;
using Inventario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios
{
    public class ServicioArticulo
    {
        private ArticuloArchivo ArticuloArchivo { get; set; }
        
        public ServicioArticulo()
        {
            ArticuloArchivo = new ArticuloArchivo();
        }

        public string[] Agregar(Articulo articulo)
        {
            return ArticuloArchivo.Guardar(articulo);
        }
        public void Modificar(int id, Articulo articulo)
        {
            ArticuloArchivo.Modificar(id, articulo);
        }
        public List<string[]> ObtenerArticulos()
        {
            return ArticuloArchivo.ObtenerArticulos();
        }
        public Articulo BuscarArticulo(int id)
        {
            return ArticuloArchivo.ObtenerArticulo(id);
        }
        public void Eliminar(int id)
        {
            ArticuloArchivo.Eliminar(id);
        }
    }
}

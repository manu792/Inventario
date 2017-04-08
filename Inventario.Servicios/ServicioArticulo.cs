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
        private Repositorio Repositorio { get; set; }
        
        public ServicioArticulo()
        {
            Repositorio = Repositorio.Instancia;
        }

        public string[] Agregar(string nombre, int unidad, double precio, string descripcion)
        {
            return Repositorio.AgregarArticulo(new Articulo(nombre, unidad, precio, descripcion));
        }
        public void Modificar(int id, Articulo articulo)
        {
            Repositorio.ModificarArticulo(id, articulo);
        }
        public List<string[]> ObtenerArticulos()
        {
            return Repositorio.ObtenerArticulos();
        }
        public void BuscarArticulo(int id)
        {

        }
        public void Eliminar(int id)
        {
            Repositorio.EliminarArticulo(id);
        }
    }
}

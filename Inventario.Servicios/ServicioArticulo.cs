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
            Repositorio = new Repositorio();
        }

        public void AgregarArticulo(int id, string nombre, int unidad, double precio, string descripcion)
        {
            Repositorio.AgregarArticulo(new Articulo(id, nombre, unidad, precio, descripcion));
        }
        public void ModificarArticulo(int id)
        {

        }
        public void ObtenerArticulos()
        {

        }
        public void BuscarArticulo(int id)
        {

        }
        public void EliminarArticulo(int id)
        {

        }
    }
}

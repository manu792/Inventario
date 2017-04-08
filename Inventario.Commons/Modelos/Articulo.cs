using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Unidad { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }

        public Articulo(string nombre, int unidad, double precio, string descripcion)
        {
            Nombre = nombre;
            Unidad = unidad;
            Precio = precio;
            Descripcion = descripcion;
        }

        public Articulo(int id, string nombre, int unidad, double precio, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Unidad = unidad;
            Precio = precio;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Id + "#" + Nombre + "#" + Unidad + "#" + Precio + "#" + Descripcion;
        }
    }
}

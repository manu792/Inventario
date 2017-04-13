using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class InventarioProyecto
    {
        public int Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

        public InventarioProyecto(Proyecto proyecto, Articulo articulo, int cantidad)
        {
            Proyecto = proyecto;
            Articulo = articulo;
            Cantidad = cantidad;
        }

        public InventarioProyecto(int id, Proyecto proyecto, Articulo articulo, int cantidad)
        {
            Id = id;
            Proyecto = proyecto;
            Articulo = articulo;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return Id + "#" + Proyecto.Id + "#" + Articulo.Id + "#" + Cantidad;
        }
    }
}

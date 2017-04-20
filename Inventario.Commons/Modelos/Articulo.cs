namespace Inventario.Commons.Modelos
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        
        public Articulo(int id)
        {
            Id = id;
        }
        
        public Articulo(int id, double precio)
        {
            Id = id;
            Precio = precio;
        }

        public Articulo(string nombre, string unidad, double precio, string descripcion)
        {
            Nombre = nombre;
            Unidad = unidad;
            Precio = precio;
            Descripcion = descripcion;
        }

        public Articulo(int id, string nombre, string unidad, double precio, string descripcion)
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

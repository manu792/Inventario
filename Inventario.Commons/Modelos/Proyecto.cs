using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Encargado { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Proyecto(int id, string nombre, string encargado, string direccion, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            Id = id;
            Nombre = nombre;
            Encargado = encargado;
            Direccion = direccion;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public override string ToString()
        {
            return Id + "#" + Nombre + "#" + Encargado + "#" + Direccion + "#" + Descripcion + "#" + FechaInicio + "#" + FechaFin;
        }
    }
}

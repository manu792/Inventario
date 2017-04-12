using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class Orden
    {
        public int Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        public Orden(Proyecto proyecto, DateTime fecha, string comentario)
        {
            Proyecto = proyecto;
            Fecha = fecha;
            Comentario = comentario;
        }
        public Orden(int id, Proyecto proyecto, DateTime fecha, string comentario)
        {
            Id = id;
            Proyecto = proyecto;
            Fecha = fecha;
            Comentario = comentario;
        }

        public override string ToString()
        {
            return Id + "#" + Proyecto.Id + "#" + Fecha + "#" + Comentario;
        }

        public string[] ConvertirAArray()
        {
            string[] campos = new string[4];
            campos[0] = Id.ToString();
            campos[1] = Proyecto.Nombre;
            campos[2] = Fecha.ToString();
            campos[3] = Comentario;
            return campos;
        }
    }
}

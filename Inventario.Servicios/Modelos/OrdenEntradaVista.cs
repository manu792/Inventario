using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Servicios.Modelos
{
    public class OrdenEntradaVista
    {
        public int Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        public OrdenEntradaVista(Proyecto proyecto, DateTime fecha, string comentario)
        {
            Proyecto = proyecto;
            Fecha = fecha;
            Comentario = comentario;
        }
        public OrdenEntradaVista(int id, Proyecto proyecto, DateTime fecha, string comentario)
        {
            Id = id;
            Proyecto = proyecto;
            Fecha = fecha;
            Comentario = comentario;
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

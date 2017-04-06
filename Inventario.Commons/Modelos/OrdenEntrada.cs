using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class OrdenEntrada
    {
        public int Id { get; set; }
        public int IdProyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        public OrdenEntrada(int id, int idProyecto, DateTime fecha, string comentario)
        {
            Id = id;
            IdProyecto = idProyecto;
            Fecha = fecha;
            Comentario = comentario;
        }
    }
}

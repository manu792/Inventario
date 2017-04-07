using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class OrdenSalida
    {
        public int IdSalida { get; set; }
        public int IdProyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        public OrdenSalida(int idSalida, int idProyecto, DateTime fecha, string comentario)
        {
            IdSalida = idSalida;
            IdProyecto = idProyecto;
            Fecha = fecha;
            Comentario = comentario;
        }

        public override string ToString()
        {
            return IdSalida + "#" + IdProyecto + "#" + Fecha + "#" + Comentario;
        }
    }
}

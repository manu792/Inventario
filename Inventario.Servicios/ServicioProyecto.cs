using Inventario.Commons.Modelos;
using Inventario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios
{
    public class ServicioProyecto
    {
        private ProyectoArchivo ProyectoArchivo { get; set; }

        public ServicioProyecto()
        {
            ProyectoArchivo = new ProyectoArchivo();
        }
        
        public string[] Agregar(Proyecto proyecto)
        {
            return ProyectoArchivo.Guardar(proyecto);
        }

        public void Modificar(int id, Proyecto proyecto)
        {
            ProyectoArchivo.Modificar(id, proyecto);
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return ProyectoArchivo.ObtenerProyectos();
        }

        public Proyecto ObtenerProyecto(int id)
        {
            return ProyectoArchivo.ObtenerProyecto(id);
        }

        public void Eliminar(int id)
        {
            ProyectoArchivo.Eliminar(id);
        }
    }
}

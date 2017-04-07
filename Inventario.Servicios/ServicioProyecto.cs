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
        private Repositorio Repositorio { get; set; }

        public ServicioProyecto()
        {
            Repositorio = new Repositorio();
        }
        
        public void AgregarProyecto(int id, string nombre, string encargado, string direccion, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            Repositorio.AgregarProyecto(new Proyecto(id, nombre, encargado, direccion, descripcion, fechaInicio, fechaFin));
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return Repositorio.ObtenerProyectos();
        }
        public void EliminarProyecto(int id)
        {

        }
    }
}

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
        private List<Proyecto> Proyectos;
        private Repositorio Repositorio { get; set; }

        public ServicioProyecto()
        {
            Proyectos = new List<Proyecto>();
            Repositorio = Repositorio.Instancia;
        }
        
        public string[] AgregarProyecto(string nombre, string encargado, string direccion, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            return Repositorio.AgregarProyecto(new Proyecto(nombre, encargado, direccion, descripcion, fechaInicio, fechaFin));
        }

        public void Modificar(int id, Proyecto proyecto)
        {
            Repositorio.ModificarProyecto(id, proyecto);
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return Repositorio.ObtenerProyectos();
        }

        public Proyecto ObtenerProyecto(int indice)
        {
            if (Proyectos.Count > 0)
                return Proyectos[indice];

            return null;
        }

        public void EliminarProyecto(int id)
        {
            //falta eliminar de la lista
            Repositorio.EliminarProyecto(id);
        }
    }
}

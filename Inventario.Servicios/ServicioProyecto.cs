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
        
        public void AgregarProyecto(int id, string nombre, string encargado, string direccion, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            Repositorio.AgregarProyecto(new Proyecto(id, nombre, encargado, direccion, descripcion, fechaInicio, fechaFin));
        }

        public void Modificar(int indice, Proyecto proyecto)
        {
            int id = Proyectos[indice].Id;
            Proyectos[indice] = proyecto;
            Repositorio.ModificarProyecto(id, proyecto);
        }

        public List<Proyecto> ObtenerProyectos()
        {
            Proyectos = Repositorio.ObtenerProyectos();
            return Proyectos;
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

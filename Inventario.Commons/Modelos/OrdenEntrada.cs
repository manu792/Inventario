﻿using System;
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
        public string NombreProyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

        public OrdenEntrada(int idProyecto, DateTime fecha, string comentario)
        {
            IdProyecto = idProyecto;
            Fecha = fecha;
            Comentario = comentario;
        }
        public OrdenEntrada(int id, int idProyecto, DateTime fecha, string comentario)
        {
            Id = id;
            IdProyecto = idProyecto;
            Fecha = fecha;
            Comentario = comentario;
        }
        public OrdenEntrada(int id, string nombreProyecto, DateTime fecha, string comentario)
        {
            Id = id;
            NombreProyecto = nombreProyecto;
            Fecha = fecha;
            Comentario = comentario;
        }

        public override string ToString()
        {
            return Id + "#" + IdProyecto + "#" + Fecha + "#" + Comentario;
        }

        public string[] ConvertirAArray()
        {
            string[] campos = new string[4];
            campos[0] = Id.ToString();
            campos[1] = NombreProyecto;
            campos[2] = Fecha.ToString();
            campos[3] = Comentario;
            return campos;
        }
    }
}

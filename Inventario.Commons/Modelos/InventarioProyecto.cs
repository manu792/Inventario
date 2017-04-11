﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Commons.Modelos
{
    public class InventarioProyecto
    {
        public int Id { get; set; }
        public int IdProyecto { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }

        public InventarioProyecto(int idProyecto, int idArticulo, int cantidad)
        {
            IdProyecto = idProyecto;
            IdArticulo = idArticulo;
            Cantidad = cantidad;
        }

        public InventarioProyecto(int id, int idProyecto, int idArticulo, int cantidad)
        {
            Id = id;
            IdProyecto = idProyecto;
            IdArticulo = idArticulo;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return Id + "#" + IdProyecto + "#" + IdArticulo + "#" + Cantidad;
        }
    }
}
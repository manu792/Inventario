using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios.OrdenEntradaEventArgs
{
    public class OrdenModificadaDetalles : EventArgs
    {
        public int IdProyecto { get; set; }
        public List<Detalle> Detalles { get; set; }
        public List<string[]> RegistrosModificados { get; set; }

        public OrdenModificadaDetalles(int idProyecto, List<Detalle> detalles, List<string[]> registrosModificados)
        {
            IdProyecto = idProyecto;
            Detalles = detalles;
            RegistrosModificados = registrosModificados;
        }
    }
}

using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios.OrdenEntradaEventArgs
{
    public class OrdenEntradaModificadaDetalles : EventArgs
    {
        public int IdProyecto { get; set; }
        public List<Detalle> DetallesEntrada { get; set; }
        public List<string[]> RegistrosModificados { get; set; }

        public OrdenEntradaModificadaDetalles(int idProyecto, List<Detalle> detallesEntrada, List<string[]> registrosModificados)
        {
            IdProyecto = idProyecto;
            DetallesEntrada = detallesEntrada;
            RegistrosModificados = registrosModificados;
        }
    }
}

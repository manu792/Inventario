using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Data
{
    public class DetalleEntradaArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/DetalleEntrada.txt";
        private const string direccionTemp = "Archivos/DetalleEntradaTemp.txt";
        private const string direccionBackup = "Archivos/Backups/DetalleEntrada.bk";
        private int id;

        public DetalleEntradaArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion).Close();
                id = 0;
            }
            else
                ObtenerUltimoId();
        }
        public List<Detalle> ObtenerDetalleEntradas(int idOrdenEntrada)
        {
            List<Detalle> detallesEntrada = new List<Detalle>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if(Int32.Parse(campos[1]) == idOrdenEntrada)
                        detallesEntrada.Add(new Detalle(Int32.Parse(campos[0]), Int32.Parse(campos[1]), new Articulo(Int32.Parse(campos[2])), Int32.Parse(campos[3]), Double.Parse(campos[4])));
                }
            }

            return detallesEntrada;
        }
        public void Guardar(Detalle detalleEntrada)
        {
            id += 1;
            detalleEntrada.IdDetalle = id;
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(detalleEntrada.ToString());
            }
        }
        public string[] Modificar(Detalle detalleEntrada)
        {
            string[] registroModificado = null;

            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[1]) == detalleEntrada.IdOrden && Int32.Parse(campos[2]) == detalleEntrada.Articulo.Id)
                        {
                            writer.WriteLine(detalleEntrada.ToString());
                            registroModificado = campos;
                        }
                        else
                            writer.WriteLine(registro);
                    }
                }
            }
            File.Replace(direccionTemp, direccion, direccionBackup);
            
            return registroModificado;
        }
        public void Eliminar(int idOrdenEntrada)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[1]) != idOrdenEntrada)
                            writer.WriteLine(registro);
                    }
                }
            }
            File.Replace(direccionTemp, direccion, direccionBackup);
        }
        private void ObtenerUltimoId()
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    id = Int32.Parse(campos[0]);
                }
            }
        }
    }
}

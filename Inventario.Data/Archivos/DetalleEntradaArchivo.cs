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
        public List<DetalleEntrada> ObtenerDetalleEntradas(int idOrdenEntrada)
        {
            List<DetalleEntrada> detallesEntrada = new List<DetalleEntrada>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if(Int32.Parse(campos[1]) == idOrdenEntrada)
                        detallesEntrada.Add(new DetalleEntrada(Int32.Parse(campos[0]), Int32.Parse(campos[1]), new Articulo(Int32.Parse(campos[2])), Int32.Parse(campos[3]), Double.Parse(campos[4])));
                }
            }

            return detallesEntrada;
        }
        public DetalleEntrada ObtenerDetalleEntrada(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new DetalleEntrada(Int32.Parse(campos[0]), Int32.Parse(campos[1]), new Articulo(Int32.Parse(campos[2])), Int32.Parse(campos[3]), Double.Parse(campos[4]));
                    }
                }
            }

            return null;
        }
        public void Guardar(DetalleEntrada detalleEntrada)
        {
            id += 1;
            detalleEntrada.IdDetalleEntrada = id;
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(detalleEntrada.ToString());
            }
        }
        public string[] Modificar(DetalleEntrada detalleEntrada)
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

                        if (Int32.Parse(campos[1]) == detalleEntrada.IdEntrada && Int32.Parse(campos[2]) == detalleEntrada.Articulo.Id)
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

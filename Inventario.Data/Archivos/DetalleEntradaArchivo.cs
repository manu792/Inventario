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

        public DetalleEntradaArchivo()
        {
            if (!File.Exists(direccion))
                File.Create(direccion).Close();
        }
        public List<DetalleEntrada> ObtenerDetalleEntradas()
        {
            List<DetalleEntrada> detalleEntrada = new List<DetalleEntrada>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    detalleEntrada.Add(new DetalleEntrada(Int32.Parse(campos[0]), Int32.Parse(campos[1]), Int32.Parse(campos[2]), Int32.Parse(campos[3]), Double.Parse(campos[4])));
                }
            }

            return detalleEntrada;
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
                        return new DetalleEntrada(Int32.Parse(campos[0]), Int32.Parse(campos[1]), Int32.Parse(campos[2]), Int32.Parse(campos[3]), Double.Parse(campos[4]));
                    }
                }
            }

            return null;
        }
        public void Guardar(DetalleEntrada detalleEntrada)
        {
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(detalleEntrada.ToString());
            }
        }
        public void EliminarDetalleEntrada(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[0]) != id)
                            writer.WriteLine(registro);
                    }
                }
            }
            File.Replace(direccionTemp, direccion, "DetalleEntradaTemp.bk");
        }
    }
}

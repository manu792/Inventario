using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Data
{
    public class OrdenEntradaArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/OrdenEntrada.txt";

        public OrdenEntradaArchivo()
        {
            if (!File.Exists(direccion))
                File.Create(direccion).Close();
        }
        public List<OrdenEntrada> ObtenerOrdenEntradas()
        {
            List<OrdenEntrada> ordenEntrada = new List<OrdenEntrada>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    ordenEntrada.Add(new OrdenEntrada(Int32.Parse(campos[0]), Int32.Parse(campos[1]), DateTime.Parse(campos[2]), campos[3]));
                }
            }

            return ordenEntrada;
        }
        public OrdenEntrada ObtenerOrdenEntrada(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new OrdenEntrada(Int32.Parse(campos[0]), Int32.Parse(campos[1]), DateTime.Parse(campos[2]), campos[3]);
                    }
                }
            }

            return null;
        }
        public void Guardar(OrdenEntrada ordenEntrada)
        {
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(ordenEntrada.ToString());
            }
        }
        public void EliminarOrdenEntrada(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText("OrdenEntradaTemp.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[0]) != id)
                            writer.WriteLine(registro);
                    }
                    File.Replace("temp.txt", direccion, "temp.bk");
                }
            }
        }
    }
}

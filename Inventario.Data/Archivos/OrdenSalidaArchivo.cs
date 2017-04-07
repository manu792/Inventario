using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Data
{
    public class OrdenSalidaArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/OrdenSalida.txt";
        private const string direccionTemp = "Archivos/OrdenSalidaTemp.txt";

        public OrdenSalidaArchivo()
        {
            if (!File.Exists(direccion))
                File.Create(direccion).Close();
        }

        public List<OrdenSalida> ObtenerOrdenSalidas()
        {
            List<OrdenSalida> ordenSalida = new List<OrdenSalida>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    ordenSalida.Add(new OrdenSalida(Int32.Parse(campos[0]), Int32.Parse(campos[1]), DateTime.Parse(campos[2]), campos[3]));
                }
            }

            return ordenSalida;
        }
        public OrdenSalida ObtenerOrdenSalida(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new OrdenSalida(Int32.Parse(campos[0]), Int32.Parse(campos[1]), DateTime.Parse(campos[2]), campos[3]);
                    }
                }
            }

            return null;
        }
        public void Guardar(OrdenSalida ordenSalida)
        {
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(ordenSalida.ToString());
            }
        }
        public void EliminarOrdenSalida(int id)
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
            File.Replace(direccionTemp, direccion, "OrdenSalidaTemp.bk");
        }
    }
}

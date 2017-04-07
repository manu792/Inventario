using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Data
{
    public class DetalleSalidaArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/DetalleSalida.txt";
        private const string direccionTemp = "Archivos/DetalleSalidaTemp.txt";

        public DetalleSalidaArchivo()
        {
            if (!File.Exists(direccion))
                File.Create(direccion).Close();
        }

        public List<DetalleSalida> ObtenerDetalleSalidas()
        {
            List<DetalleSalida> detalleSalida = new List<DetalleSalida>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    detalleSalida.Add(new DetalleSalida(Int32.Parse(campos[0]), Int32.Parse(campos[1]), Int32.Parse(campos[2]), Int32.Parse(campos[3]), Double.Parse(campos[4])));
                }
            }

            return detalleSalida;
        }
        public DetalleSalida ObtenerDetalleSalida(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new DetalleSalida(Int32.Parse(campos[0]), Int32.Parse(campos[1]), Int32.Parse(campos[2]), Int32.Parse(campos[3]), Double.Parse(campos[4]));
                    }
                }
            }

            return null;
        }
        public void Guardar(DetalleSalida detalleSalida)
        {
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(detalleSalida.ToString());
            }
        }
        public void EliminarDetalleSalida(int id)
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
            File.Replace(direccionTemp, direccion, "DetalleSalidaTemp.bk");
        }
    }
}

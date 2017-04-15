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
        private const string direccionBackup = "Archivos/Backups/DetalleSalida.bk";
        private int id;

        public DetalleSalidaArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion).Close();
                id = 0;
            }
            else
                ObtenerUltimoId();
        }

        public List<Detalle> ObtenerDetalleSalidas(int idOrdenSalida)
        {
            List<Detalle> detalleSalida = new List<Detalle>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[1]) == idOrdenSalida)
                        detalleSalida.Add((new Detalle(Int32.Parse(campos[0]), Int32.Parse(campos[1]), new Articulo(Int32.Parse(campos[2])), Int32.Parse(campos[3]), Double.Parse(campos[4]))));
                }
            }

            return detalleSalida;
        }
        public Detalle ObtenerDetalleSalida(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new Detalle(Int32.Parse(campos[0]), Int32.Parse(campos[1]), new Articulo(Int32.Parse(campos[2])), Int32.Parse(campos[3]), Double.Parse(campos[4]));
                    }
                }
            }

            return null;
        }
        public void Guardar(Detalle detalleSalida)
        {
            id += 1;
            detalleSalida.IdDetalle = id;
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(detalleSalida.ToString());
            }
        }
        public string[] Modificar(Detalle detalleSalida)
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

                        if (Int32.Parse(campos[1]) == detalleSalida.IdOrden && Int32.Parse(campos[2]) == detalleSalida.Articulo.Id)
                        {
                            writer.WriteLine(detalleSalida.ToString());
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
        public void Eliminar(int idOrdenSalida)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[1]) != idOrdenSalida)
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

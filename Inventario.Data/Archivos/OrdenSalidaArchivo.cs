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
        private const string direccionBackup = "Archivos/Backups/OrdenSalida.bk";
        private int id;

        public OrdenSalidaArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion).Close();
                id = 0;
            }
            else
                ObtenerUltimoId();
        }

        public List<Orden> ObtenerOrdenesSalidas(int idProyecto)
        {
            List<Orden> ordenSalida = new List<Orden>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[1]) == idProyecto)
                        ordenSalida.Add(new Orden(Int32.Parse(campos[0]), new Proyecto(idProyecto), DateTime.Parse(campos[2]), campos[3]));
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
        public int Guardar(Orden ordenSalida)
        {
            id += 1;
            ordenSalida.Id = id;
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(ordenSalida.ToString());
            }
            return id;
        }
        public void Modificar(Orden ordenSalida)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[0]) != ordenSalida.Id)
                            writer.WriteLine(registro);
                        else
                            writer.WriteLine(ordenSalida.ToString());
                    }
                }
            }
            File.Replace(direccionTemp, direccion, direccionBackup);
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

                        if (Int32.Parse(campos[0]) != idOrdenSalida)
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

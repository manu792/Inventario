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
        private const string direccionTemp = "Archivos/OrdenEntradaTemp.txt";
        private const string direccionBackup = "Archivos/Backups/OrdenEntrada.bk";
        private int id;

        public OrdenEntradaArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion).Close();
                id = 0;
            }
            else
                ObtenerUltimoId();
        }
        public List<Orden> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<Orden> ordenesEntrada = new List<Orden>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[1]) == idProyecto)
                    {
                        ordenesEntrada.Add(new Orden(Int32.Parse(campos[0]), new Proyecto(idProyecto), DateTime.Parse(campos[2]), campos[3]));
                    }
                }
            }

            return ordenesEntrada;
        }
        public int Guardar(Orden ordenEntrada)
        {
            id += 1;
            ordenEntrada.Id = id;
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(ordenEntrada.ToString());
            }
            return id;
        }
        public void Modificar(Orden ordenEntrada)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[0]) != ordenEntrada.Id)
                            writer.WriteLine(registro);
                        else
                            writer.WriteLine(ordenEntrada.ToString());
                    }
                }
            }
            File.Replace(direccionTemp, direccion, direccionBackup);
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

                        if (Int32.Parse(campos[0]) != idOrdenEntrada)
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

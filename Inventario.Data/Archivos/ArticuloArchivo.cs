using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data
{
    public class ArticuloArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/Articulo.txt";
        private const string direccionTemp = "Archivos/ArticuloTemp.txt";
        private const string direccionBackup = "Archivos/Backups/Articulo.bk";
        private int id;

        public ArticuloArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion).Close();
                id = 0;
            }
            else
                ObtenerUltimoId();
        }

        public List<string[]> ObtenerArticulos()
        {
            List<string[]> articulos = new List<string[]>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    articulos.Add(campos);
                }
            }

            return articulos;
        }
        public Articulo ObtenerArticulo(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new Articulo(Int32.Parse(campos[0]), campos[1], campos[2], Double.Parse(campos[3]), campos[4]);
                    }
                }
            }

            return null;
        }
        public void Modificar(int id, Articulo articulo)
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
                        else
                            writer.WriteLine(articulo.ToString());
                    }
                }
            }
            File.Replace(direccionTemp, direccion, direccionBackup);
        }
        public string[] Guardar(Articulo articulo)
        {
            string[] campos = new string[5];

            id += 1;
            articulo.Id = id;

            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(articulo.ToString());
            }

            campos[0] = articulo.Id.ToString();
            campos[1] = articulo.Nombre;
            campos[2] = articulo.Unidad.ToString();
            campos[3] = articulo.Precio.ToString();
            campos[4] = articulo.Descripcion;
            return campos;
        }
        public void Eliminar(int id)
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

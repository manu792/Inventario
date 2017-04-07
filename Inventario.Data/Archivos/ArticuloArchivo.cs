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

        public ArticuloArchivo()
        {
            if (!File.Exists(direccion))
                File.Create(direccion).Close();
        }

        public List<Articulo> ObtenerArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    articulos.Add(new Articulo(Int32.Parse(campos[0]), campos[1], Int32.Parse(campos[2]), Double.Parse(campos[3]), campos[4]));
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
                        return new Articulo(Int32.Parse(campos[0]), campos[1], Int32.Parse(campos[2]), Double.Parse(campos[3]), campos[4]);
                    }
                }
            }

            return null;
        }
        public void Guardar(Articulo articulo)
        {
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(articulo.ToString());
            }
        }
        public void EliminarArticulo(int id)
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
            File.Replace(direccionTemp, direccion, "Archivos/ArticuloTemp.bk");
        }
    }
}

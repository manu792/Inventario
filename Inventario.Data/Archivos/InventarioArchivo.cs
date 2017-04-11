using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;

namespace Inventario.Data.Archivos
{
    public class InventarioArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/Inventario.txt";
        private const string direccionTemp = "Archivos/InventarioTemp.txt";
        private const string direccionBackup = "Archivos/Backups/Inventario.bk";
        private int id;

        public InventarioArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion);
                id = 0;
            }
            else
                ObtenerUltimoId();
        }

        public Inventario.Commons.Modelos.InventarioProyecto ArticuloEnProyecto(int idProyecto, int idArticulo)
        {
            using (reader = File.OpenText(direccion))
            {
                while(!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[1]) == idProyecto && Int32.Parse(campos[2]) == idArticulo)
                        return new InventarioProyecto(Int32.Parse(campos[0]), Int32.Parse(campos[1]), Int32.Parse(campos[2]), Int32.Parse(campos[3]));
                }
            }
            return null;
        }

        public void ActualizarCantidad(int idProyecto, int idArticulo, InventarioProyecto inventario)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[1]) == idProyecto && Int32.Parse(campos[2]) == idArticulo)
                            writer.WriteLine(inventario.ToString());
                        else
                            writer.WriteLine(registro);
                    }
                }
            }
            File.Replace(direccionTemp, direccion, direccionBackup);
        }

        public void AgregarArticuloInventario(InventarioProyecto inventario)
        {
            id += 1;
            inventario.Id = id;
            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(inventario.ToString());
            }
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

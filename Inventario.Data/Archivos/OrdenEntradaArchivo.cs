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
        public List<OrdenEntrada> ObtenerOrdenesEntrada(int idProyecto)
        {
            List<OrdenEntrada> ordenesEntrada = new List<OrdenEntrada>();

            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[1]) == idProyecto)
                    {
                        ordenesEntrada.Add(new OrdenEntrada(Int32.Parse(campos[0]), ObtenerNombreProyecto(idProyecto), DateTime.Parse(campos[2]), campos[3]));
                    }
                }
            }

            return ordenesEntrada;
        }
        public string[] Guardar(OrdenEntrada ordenEntrada)
        {
            string[] campos = new string[7];

            id += 1;
            ordenEntrada.Id = id;

            using (writer = File.AppendText(direccion))
            {
                writer.WriteLine(ordenEntrada.ToString());
            }

            campos[0] = ordenEntrada.Id.ToString();
            campos[1] = ordenEntrada.IdProyecto.ToString();
            campos[2] = ordenEntrada.Fecha.ToString();
            campos[3] = ordenEntrada.Comentario;
            return campos;
            
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
                }
            }
            File.Replace(direccionTemp, direccion, "OrdenEntradaTemp.bk");
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
        private string ObtenerNombreProyecto(int idProyecto)
        {
            using (StreamReader reader = File.OpenText("Archivos/Proyecto.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == idProyecto)
                        return campos[1];
                }
            }
            return null;
        }
    }
}

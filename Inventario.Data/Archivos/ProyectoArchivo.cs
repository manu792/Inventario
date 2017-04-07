using Inventario.Commons.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data
{
    public class ProyectoArchivo
    {
        private StreamWriter writer;
        private StreamReader reader;
        private const string direccion = "Archivos/Proyecto.txt";
        private const string direccionTemp = "Archivos/ProyectoTemp.txt";

        public ProyectoArchivo()
        {
            if (!File.Exists(direccion))
                File.Create(direccion).Close();
        }


        public List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> proyectos = new List<Proyecto>();

            using(reader = File.OpenText(direccion))
            {
                while(!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    proyectos.Add(new Proyecto(Int32.Parse(campos[0]), campos[1], campos[2], campos[3], campos[4], DateTime.Parse(campos[5]), DateTime.Parse(campos[6])));
                }
            }

            return proyectos;
        }
        public Proyecto ObtenerProyecto(int id)
        {
            using (reader = File.OpenText(direccion))
            {
                while (!reader.EndOfStream)
                {
                    string registro = reader.ReadLine();
                    string[] campos = registro.Split('#');
                    if (Int32.Parse(campos[0]) == id)
                    {
                        return new Proyecto(Int32.Parse(campos[0]), campos[1], campos[2], campos[3], campos[4], DateTime.Parse(campos[5]), DateTime.Parse(campos[6]));
                    }
                }
            }

            return null;
        }
        public void Guardar(Proyecto proyecto)
        {
            using(writer = File.AppendText(direccion))
            {
                writer.WriteLine(proyecto.ToString());
            }
        }
        public void EliminarProyecto(int id)
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
            File.Replace(direccionTemp, direccion, "Archivos/ProyectoTemp.bk");
        }
    }
}

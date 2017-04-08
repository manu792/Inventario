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
        private int id;

        public ProyectoArchivo()
        {
            if (!File.Exists(direccion))
            {
                File.Create(direccion).Close();
                id = 0;
            }
            else
                ObtenerUltimoId();
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
        public void ModificarProyecto(int id, Proyecto proyecto)
        {
            using (reader = File.OpenText(direccion))
            {
                using (writer = File.AppendText(direccionTemp))
                {
                    while (!reader.EndOfStream)
                    {
                        string registro = reader.ReadLine();
                        string[] campos = registro.Split('#');

                        if (Int32.Parse(campos[0]) != proyecto.Id)
                            writer.WriteLine(registro);
                        else
                            writer.WriteLine(proyecto.ConvertirAString());
                    }
                }
            }
            File.Replace(direccionTemp, direccion, "Archivos/ProyectoTemp.bk");
        }
        public string[] Guardar(Proyecto proyecto)
        {
            string[] campos = new string[7];

            id += 1;
            proyecto.Id = id;
            using(writer = File.AppendText(direccion))
            {
                writer.WriteLine(proyecto.ConvertirAString());
            }

            campos[0] = proyecto.Id.ToString();
            campos[1] = proyecto.Nombre;
            campos[2] = proyecto.Encargado;
            campos[3] = proyecto.Direccion;
            campos[4] = proyecto.Descripcion;
            campos[5] = proyecto.FechaInicio.ToString();
            campos[6] = proyecto.FechaFin.ToString();
            return campos;
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

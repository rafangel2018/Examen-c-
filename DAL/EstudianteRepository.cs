using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class EstudianteRepository
    {
        string ruta = @"Examenes.txt";
        List<Estudiante> estudiantes;

        public void Guardar(Estudiante estudiante)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{estudiante.Identificacion};{estudiante.Nombre};{estudiante.Grupo}");
            escritor.Close();
            file.Close();

        }

        public Estudiante Mapear(string linea)
        {
            Estudiante estudiante;
            char delimiter = ';';
            string[] Datos = linea.Split(delimiter);
            estudiante = new Estudiante();
            estudiante.Identificacion= Datos[0];
            estudiante.Nombre = Datos[1];
            estudiante .Grupo= Datos[2];

            return estudiante;
        }
        public List<Estudiante> Consultar()
        {
            estudiantes = new List<Estudiante>();

            string Linea = string.Empty;
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader escritor = new StreamReader(file);
            while ((Linea = escritor.ReadLine()) != null)
            {
                Estudiante estudiante = Mapear(Linea);
                estudiantes.Add(estudiante);
            }
            escritor.Close();
            file.Close();

            return estudiantes;
        }

        public Estudiante BuscarIdentificacion(string identificacion)
        {

            estudiantes = Consultar();
            foreach (var item in estudiantes)
            {
                if (item.Identificacion == identificacion)
                {
                    return item;
                }
            }
            return null;
        }
    }
}

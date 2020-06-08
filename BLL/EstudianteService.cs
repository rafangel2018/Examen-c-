using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstudianteService
    {
        EstudianteRepository estudianteRepository = new EstudianteRepository();
        public string Guardar(Estudiante estudiante)
        {
            try
            {
                if (estudianteRepository.BuscarIdentificacion(estudiante.Identificacion) == null)
                {
                    estudianteRepository.Guardar(estudiante);
                    return $"Se Guardo satisfactoriamente a {estudiante.Nombre}";
                }
                else
                {
                    return "No se pudo guardar la información, se encontraron datos duplicados.";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }

        }

        public List<Estudiante> Consultar()
        {
            return estudianteRepository.Consultar();
        }

    }
}

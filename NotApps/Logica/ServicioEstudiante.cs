using NotApps.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.Logica
{
    public class ServicioEstudiante
    {
        List<Estudiante> ListaEstudiantes;

        public ServicioEstudiante()
        {
            ListaEstudiantes = new List<Estudiante>();
        }

        public string AgregarEstudiante(Estudiante estudiante)
        {
            if (ExisteEstudiante(estudiante))
            {
                return "El estudiante ya esta registrado";
            }
            ListaEstudiantes.Add(estudiante);
            return "Datos agregados correctamente ...";
        }

        public bool ExisteEstudiante(Estudiante estudiante)
        {
            foreach(var item in ListaEstudiantes)
            {
                if (item.ID == estudiante.ID)
                {
                    return true;
                }
            }
            return false;
        }

       public bool ConsultaEstudiante(Estudiante estudiante)
        {
            foreach(var item in ListaEstudiantes)
            {
                if (ListaEstudiantes.Count == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

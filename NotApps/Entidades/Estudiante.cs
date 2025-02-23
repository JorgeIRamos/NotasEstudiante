using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.Entidades
{
    public class Estudiante : Persona //DOS PUNTOS SIRVEN PARA HEREDAR
    {
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }

        public float CalcularDefinitiva()
        {
            return Nota1 * 0.3f + Nota2 * 0.3f + Nota3 * 0.4f;
        }

        public String EstadoEstudiante()
        {
            if (CalcularDefinitiva() >= 3)
            {
                return "EL ESTUDIANTE GANO LA MATERIA";
            }
            return "EL ESTUDIANTE PERDIO LA MATERIA";
        }

       
    }
}

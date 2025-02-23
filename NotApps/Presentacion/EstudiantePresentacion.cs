using NotApps.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.Presentacion
{
    class EstudiantePresentacion
    {
        Logica.ServicioEstudiante ServicioEstudiante = new Logica.ServicioEstudiante();
        Estudiante estudiante;

        public void CapturarNotas()
        {
            estudiante = new Estudiante();
            Console.Clear();
            Console.WriteLine("--CAPTURA DE NOTAS--");
            Console.Write("ID : "); estudiante.ID = int.Parse(Console.ReadLine());
            Console.Write("NOMBRE : "); estudiante.Nombre = Console.ReadLine();
            Console.Write("SEXO : "); estudiante.Sexo = Console.ReadLine();
            Console.Write("NOTA 1 : "); estudiante.Nota1 = float.Parse(Console.ReadLine());
            Console.Write("NOTA 2 : "); estudiante.Nota2 = float.Parse(Console.ReadLine());
            Console.Write("NOTA 3 : "); estudiante.Nota3 = float.Parse(Console.ReadLine());

            ServicioEstudiante.AgregarEstudiante(estudiante);

            Console.Clear();
            Console.WriteLine("DATOS CAPTURADOS CON EXITO");
            Console.ReadKey();
        }

        public void ImprimirResultados()
        {
            Console.Clear();
            Console.WriteLine("--RESULTADOS--");
            Console.WriteLine($"ID : {estudiante.ID}");
            Console.WriteLine($"NOMBRE : {estudiante.Nombre}");
            Console.WriteLine($"SEXO : {estudiante.Sexo}");
            Console.WriteLine($"NOTA 1 : {estudiante.Nota1}");
            Console.WriteLine($"NOTA 2 : {estudiante.Nota2}");
            Console.WriteLine($"NOTA 3 : {estudiante.Nota3}");
            Console.WriteLine($"DEFINITIVA : {estudiante.CalcularDefinitiva()}");
            Console.WriteLine(estudiante.EstadoEstudiante());
            Console.ReadKey();
        }
    }
}

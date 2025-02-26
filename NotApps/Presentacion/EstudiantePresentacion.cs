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
            do
            {
            estudiante = new Estudiante();
            Console.Clear();
            
            Console.SetCursorPosition(20,5); Console.WriteLine("--CAPTURA DE NOTAS--");
            Console.SetCursorPosition(10, 7); Console.Write("ID: ");
            Console.SetCursorPosition(30, 7); Console.Write("NOMBRE: ");
            Console.SetCursorPosition(50, 7); Console.Write("SEXO: ");
            Console.SetCursorPosition(10, 9); Console.Write("NOTA 1: ");
            Console.SetCursorPosition(30, 9); Console.Write("NOTA 2: ");
            Console.SetCursorPosition(50, 9); Console.Write("NOTA 3: ");
            Console.SetCursorPosition(20, 11); Console.Write("==DATOS GUARDADOS==");
            Console.SetCursorPosition(10, 13); Console.Write("ID");
            Console.SetCursorPosition(20, 13); Console.Write("NOMBRE");
            Console.SetCursorPosition(33, 13); Console.Write("SEXO");
            Console.SetCursorPosition(50, 13); Console.Write("NOTA 1");
            Console.SetCursorPosition(65, 13); Console.Write("NOTA 2");
            Console.SetCursorPosition(76, 13); Console.Write("NOTA 3");
            Console.SetCursorPosition(90, 13); Console.Write("DEFINITIVA");
            
                limpiar();
                Console.SetCursorPosition(14, 7); estudiante.ID = int.Parse(Console.ReadLine());

                if (estudiante.ID == 0)
                {
                    return;

                } else

                Console.SetCursorPosition(39, 7); estudiante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(57, 7); estudiante.Sexo = Console.ReadLine();
                Console.SetCursorPosition(18, 9); estudiante.Nota1 = float.Parse(Console.ReadLine());
                Console.SetCursorPosition(38, 9); estudiante.Nota2 = float.Parse(Console.ReadLine());
                Console.SetCursorPosition(58, 9); estudiante.Nota3 = float.Parse(Console.ReadLine());

                ServicioEstudiante.AgregarEstudiante(estudiante);
                ServicioEstudiante.ConsultaGeneral(estudiante);

                Console.ReadKey();

            }
            while (true);

        }

        public void ConsultaListaEstudiantes()
        {
            Console.SetCursorPosition(20, 5); Console.Write("CONSULTA GENERAL DE ESTUDIANTES");
            Console.SetCursorPosition(10, 7); Console.Write("ID   |    NOMBRE    |    SEXO    |    NOTA 1   |    NOTA 2  |   NOTA 3   |   DEFINITIVA");
            ServicioEstudiante.ConsultaGeneral(estudiante);
            Console.ReadKey();
        }

        public void Eliminar()
        {
            Console.WriteLine("DIGITE LA ID A ELIMINAR");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine(ServicioEstudiante.EliminarEstudiante(id));
            Console.ReadKey();
        }

        public void Buscar()
        {
            Console.WriteLine("DIGITE LA ID A BUSCAR");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(ServicioEstudiante.ConsultarEstudiante(id));
            Console.ReadKey();
        }

        public void Modificar()
        {
            Console.WriteLine("DIGITE LA ID A MODIFICAR");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(ServicioEstudiante.ConsultarEstudiante(id));
            if (estudiante == null)
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("DIGITE EL NUEVO NOMBRE");
                estudiante.Nombre = Console.ReadLine();
                Console.WriteLine("DIGITE EL NUEVO SEXO");
                estudiante.Sexo = Console.ReadLine();
                Console.WriteLine("DIGITE LA NUEVA NOTA 1");
                estudiante.Nota1 = float.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE LA NUEVA NOTA 2");
                estudiante.Nota2 = float.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE LA NUEVA NOTA 3");
                estudiante.Nota3 = float.Parse(Console.ReadLine());
                Console.WriteLine(ServicioEstudiante.ModificarEstudiante(estudiante));
            }
                
        }

        private void limpiar()
        {
            Console.SetCursorPosition(14, 7); Console.Write("  ");
            Console.SetCursorPosition(39, 7); Console.Write("      ");
            Console.SetCursorPosition(57, 7); Console.Write("      ");
            Console.SetCursorPosition(18, 9); Console.Write(" ");
            Console.SetCursorPosition(38, 9); Console.Write(" ");
            Console.SetCursorPosition(58, 9); Console.Write(" ");
        }
    }
}

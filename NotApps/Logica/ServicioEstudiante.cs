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
            if (BuscarEstudiante(estudiante) != null)
            {
                return "El estudiante ya esta registrado";
            }
            ListaEstudiantes.Add(estudiante);
            return "Datos agregados correctamente ...";
        }

       public void ConsultaGeneral(Estudiante estudiante)
        {
            int fila = 15;

            foreach (var item in ListaEstudiantes)
            {
                Console.SetCursorPosition(10, fila); Console.Write(item.ID);
                Console.SetCursorPosition(20, fila); Console.Write(item.Nombre);
                Console.SetCursorPosition(33, fila); Console.Write(item.Sexo);
                Console.SetCursorPosition(50, fila); Console.Write(item.Nota1);
                Console.SetCursorPosition(65, fila); Console.Write(item.Nota2);
                Console.SetCursorPosition(76, fila); Console.Write(item.Nota3);
                Console.SetCursorPosition(90, fila); Console.Write(item.CalcularDefinitiva());
                fila++;
            }
        }

        public string EliminarEstudiante(int id)
        {
            var EstudianteEncontrado = BuscarEstudiante(id);
            if (EstudianteEncontrado != null)
            {
                ListaEstudiantes.Remove(EstudianteEncontrado);
                return "ESTUDIANTE ELIMINADO";
            }
            return "NO SE PUDO ELIMINAR EL ESTUDIANTE";
        }

        public string ConsultarEstudiante(int id)
        {
            foreach (var item in ListaEstudiantes)
            {
                if (item.ID == id)
                {
                    Console.WriteLine("ID= " + item.ID); 
                    Console.WriteLine("NOMBRE= " + item.Nombre);
                    Console.WriteLine("SEXO= " + item.Sexo);
                    Console.WriteLine("NOTA 1= " + item.Nota1);
                    Console.WriteLine("NOTA 2= " + item.Nota2);
                    Console.WriteLine("NOTA 3= " + item.Nota3);
                    Console.WriteLine("DEFINITIVA= " + item.CalcularDefinitiva());
                    Console.WriteLine("ESTADO= " + item.EstadoEstudiante());
                    return "ESTUDIANTE ENCONTRADO";
                }
            }
            return "NO SE PUDO ENCONTRAR";
        }

        public string ModificarEstudiante(Estudiante estudiante)
        {
            var EstudianteEncontrado = BuscarEstudiante(estudiante);
            if (EstudianteEncontrado != null)
            {
                EstudianteEncontrado.Nombre = estudiante.Nombre;
                EstudianteEncontrado.Sexo = estudiante.Sexo;
                EstudianteEncontrado.Nota1 = estudiante.Nota1;
                EstudianteEncontrado.Nota2 = estudiante.Nota2;
                EstudianteEncontrado.Nota3 = estudiante.Nota3;
                return "ESTUDIANTE MODIFICADO";
            }
            return "NO SE PUDO MODIFICAR EL ESTUDIANTE";
        }

        private Estudiante BuscarEstudiante(Estudiante estudiante)
        {
            foreach (var item in ListaEstudiantes)
            {
                if (item.ID == estudiante.ID)
                {
                    return item;
                }
            }
            return null;
        }

        private Estudiante BuscarEstudiante(int id)
        {
            foreach (var item in ListaEstudiantes)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        public string AgregarEstudiante(List<Estudiante> lista)
        {
            int contador = 0;
            foreach (var item in lista)
            {
                if (BuscarEstudiante(item) == null)
                {
                    ListaEstudiantes.Add(item);
                    contador++;
                }
            }
            return $"Se agregaron {contador} estudiantes de {lista.Count}";
        }
    }
}

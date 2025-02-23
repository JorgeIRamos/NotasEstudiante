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

       public void ConsultaGeneral(Estudiante estudiante)
        {
            int fila = 9;

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
            foreach (var item in ListaEstudiantes)
            {
                if (item.ID == id)
                {
                    ListaEstudiantes.Remove(item);
                    return "ESTUDIANTE ELIMINADO CON EXITO";
                }
            }
            return "NO SE PUDO ELIMINAR"; 
                
        }

        public void ConsultarEstudiante(int id)
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
                }
            }
        }
    }
}

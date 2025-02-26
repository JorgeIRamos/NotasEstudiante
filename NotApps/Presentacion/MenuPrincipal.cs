using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.Presentacion
{
    class MenuPrincipal
    {
        public void menu()
        {
            int op;
            EstudiantePresentacion estupresentacion = new EstudiantePresentacion();

            do
            {
                Console.Clear();

                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1- AGREGAR ESTUDIANTE");
                Console.WriteLine("2- LISTA ESTUDIANTE");
                Console.WriteLine("3- BUSQUEDA DE ESTUDIANTE");
                Console.WriteLine("4- ELIMINAR ESTUDIANTE");
                Console.WriteLine("5- MODIFICAR ESTUDIANTE");
                Console.WriteLine("6- SALIR");

                Console.WriteLine("SELECCIONE UNA OPCION (1-4)");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        
                        Console.Clear();
                        estupresentacion.CapturarNotas();
                        break;

                    case 2:
                        Console.Clear();
                        estupresentacion.ConsultaListaEstudiantes();
                        break;

                    case 3:
                        Console.Clear();
                        estupresentacion.Buscar();
                        break;

                    case 4:
                        Console.Clear();
                        estupresentacion.Eliminar();
                        break;

                    case 5:
                        Console.Clear();
                        estupresentacion.Modificar();
                        Console.ReadKey();
                        break;
                    
                    case 6:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA");
                        Console.ReadKey();
                        break;
                }


            } while (op != 6);
        }
    }
}

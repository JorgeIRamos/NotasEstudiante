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

            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1- AGREGAR ESTUDIANTE");
                Console.WriteLine("2- CONSULTAR ESTUDIANTE");
                Console.WriteLine("3- CONSULTA SELECTIVA ESTUDIANTE");
                Console.WriteLine("4- SALIR");

                Console.WriteLine("SELECCIONE UNA OPCION (1-4)");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        EstudiantePresentacion estupresentacion = new EstudiantePresentacion();
                        Console.Clear();
                        estupresentacion.CapturarNotas();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }


            } while (op != 3);
        }
    }
}

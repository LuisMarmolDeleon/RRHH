using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Extras
    {
        //Funcion de limpiar pantalla


        public static void Volver()
        {
            Console.WriteLine("\n\nDesea volver a la pagina principal?");
            Console.WriteLine("1-Si\n2-Salir");
            Console.Write("Su opcion: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Inicio.Bienvenida();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.Write("Ha ingresado una opcion invalida!");
                    Volver();
                    break;
            }
        }
    }
}

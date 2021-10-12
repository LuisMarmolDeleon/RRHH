using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{

    class Desvinculacion
    {
        private static string motivo;

        //Confirmacion de desvinculacion
        public static void SolicitarDesvinculacion(int localizacion)
        {
            Console.Clear();
            Console.WriteLine("Desea desvincular a:" + TablaADM.Lista[localizacion + 1]);
            Console.WriteLine("1-Si\n2-No\n");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Proceso_desvinculacion();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese cedula: ");
                    string cedula = Convert.ToString(Console.ReadLine());
                    Busqueda.Buscador(cedula);
                    break;
            }
        }

        //Se solicita el motivo de desvinculacion
        private static void Proceso_desvinculacion()
        {
            Console.Clear();
            Console.WriteLine("Por que se desvinculara?\n");
            motivo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Lamentamos dejarte partir");
            Asigna();
            Print.Printer();
        }

        //Se asigna a la ClaseDatos
        private static void Asigna()
        {
            ClaseDatos.Estado_laboral = "Desvinculado";

            ClaseDatos.MotivoDesvinculado = motivo;

        }
    }
}

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
            Extras.Clean();
            Console.WriteLine("Desea desvincular a:" + TablaADM.Lista[localizacion + 1]);
            Console.WriteLine("1-Si\n2-No\n");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Extras.Clean();
                    Proceso_desvinculacion();
                    break;

                case 2:
                    Extras.Clean();
                    Console.WriteLine("Ingrese cedula: ");
                    string cedula = Convert.ToString(Console.ReadLine());
                    Busqueda.Buscador(cedula);
                    break;
            }
        }

        //Se solicita el motivo de desvinculacion
        private static void Proceso_desvinculacion()
        {
            Extras.Clean();
            Console.WriteLine("Por que se desvinculara?\n");
            motivo = Console.ReadLine();
            Extras.Clean();
            Console.WriteLine("Lamentamos dejarte partir");
            Asigna();
            Print.Printer();
        }

        //Se asigna a la ClaseDatos
        private static void Asigna()
        {
            ClaseDatos.estado_laboral = "Desvinculado";

            ClaseDatos.motivoDesvinculado = motivo;

        }
    }
}

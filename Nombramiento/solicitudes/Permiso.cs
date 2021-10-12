using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Permiso
    {
        private static string fecha_desde,fecha_hasta;
        public static void Solicitar_Permiso(int localizacion)
        {
            Console.Clear();
            Console.WriteLine("Cuando quiere Solicitar el permiso?\nIngrese formato dia/mes/año con los slash");
            fecha_desde = Console.ReadLine();
            DateTime fechaDesde = DateTime.Parse(fecha_desde);
            Console.Clear();
            Console.WriteLine("Cuando quiere iniciar las vacaciones?\nIngrese formato dia/mes/año con los slash");
            fecha_hasta = Console.ReadLine();

            DateTime fechaHasta = DateTime.Parse(fecha_hasta);
            TimeSpan resta = fechaHasta.Subtract(fechaDesde);
            int dias_vacaciones = resta.Days;
            if (dias_vacaciones < 3)
            {
                Console.WriteLine("No puede solicitar una fecha tan larga de permiso");
            }
            Console.WriteLine(TablaADM.Lista[localizacion + 1] + " Tendra " + dias_vacaciones + " Dias de Permiso\n\n");
            Console.Clear();
            Almacena();
            Sobreescribe(localizacion);
            Print.Printer();
        }

        //Se guarda en las ClaseDatos
        private static void Almacena()
        {
            ClaseDatos.Fecha_inicio = fecha_desde;

            ClaseDatos.Estado_laboral = "Permiso";

            ClaseDatos.Fecha_hasta = fecha_hasta;

        }

        //Se sobreescribe los datos
        private static void Sobreescribe(int localizacion)
        {
            TablaADM.Lista[localizacion + 5] = ClaseDatos.Estado_laboral;

            TablaADM.Lista[localizacion + 6] = fecha_desde;

            TablaADM.Lista[localizacion + 7] = fecha_hasta;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Vacaciones
    {
        public static string fecha_desde,fecha_hasta;
        public static void Solicitar_vacaciones(int localizacion)
        {
            Extras.Clean();
            Console.WriteLine("Desea solicitar vacaciones para " + TablaADM.Lista[localizacion + 1] + "?\n");
            Console.WriteLine("1-Si\n2-No\n\nSu opcion: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: AgregarVacaciones(localizacion);
                    break;
                case 2:
                    Extras.Clean();
                    Console.WriteLine("Ingrese cedula: ");
                    string cedula = Convert.ToString(Console.ReadLine());
                    Busqueda.Buscador(cedula);
                    break;
            }
        }

        private static void AgregarVacaciones(int localizacion)
        {
         
            
            Extras.Clean();
            Console.WriteLine("Cuando quiere iniciar las vacaciones?\nIngrese formato Mes/Dia/Año con los slash");
            fecha_desde = Console.ReadLine();
            
            DateTime fechaDesde = DateTime.Parse(fecha_desde);
            TablaADM.Lista[localizacion + 6] = fecha_desde;
            Extras.Clean();
            Console.WriteLine("Cuando quiere iniciar las vacaciones?\nIngrese formato Mes/Dia/Año con los slash");
            fecha_hasta = Console.ReadLine();
     
            TablaADM.Lista[localizacion + 7] = fecha_hasta;
            DateTime fechaHasta = DateTime.Parse(fecha_hasta);
            TimeSpan resta = fechaHasta.Subtract(fechaDesde);
            int dias_vacaciones = resta.Days;
            Extras.Clean();
            Console.WriteLine(TablaADM.Lista[localizacion + 1] + " Tendra " + dias_vacaciones + " Dias de vacaciones\n\n");
            Almacena();
            Asigna();
            Print.Printer();
        }

        public static void Almacena()
        {
            ClaseDatos.fecha_inicio = fecha_desde;

            ClaseDatos.estado_laboral = "Permiso";

            ClaseDatos.fecha_hasta = fecha_hasta;

        }

        private static void Asigna()
        {
            ClaseDatos.estado_laboral = "Vacaciones";

            ClaseDatos.fecha_inicio = fecha_desde;

            ClaseDatos.fecha_hasta = fecha_hasta;


        }
    }
}

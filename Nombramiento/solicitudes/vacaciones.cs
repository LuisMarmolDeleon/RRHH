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
        public static void Solicitar_vacaciones()
        {
            Console.Clear();
            Console.WriteLine("Desea solicitar vacaciones para " + Busqueda.nombre + "?\n");
            Console.WriteLine("1-Si\n2-No\n\nSu opcion: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: AgregarVacaciones();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese la cedula de la persona correcta: ");
                    string cedula = Convert.ToString(Console.ReadLine());
                    Busqueda.Buscador(cedula);
                    break;
            }
        }

        private static void AgregarVacaciones()
        {
         
            
            Console.Clear();
            Console.WriteLine("Cuando quiere iniciar las vacaciones?\nIngrese formato Año/Mes/Dia con los slash");
            fecha_desde = Console.ReadLine();
            
            DateTime fechaDesde = DateTime.Parse(fecha_desde);
            Busqueda.desde = fecha_desde;
            Console.Clear();
            Console.WriteLine("Cuando quiere iniciar las vacaciones?\nIngrese formato Año/Mes/Dia con los slash");
            fecha_hasta = Console.ReadLine();
     
            Busqueda.hasta = fecha_hasta;
            DateTime fechaHasta = DateTime.Parse(fecha_hasta);
            TimeSpan resta = fechaHasta.Subtract(fechaDesde);
            int dias_vacaciones = resta.Days;
            Console.Clear();
            Console.WriteLine(Busqueda.nombre + " Tendra " + dias_vacaciones + " Dias de vacaciones\n\n");
            Almacena();
            Asigna();
            Print.Printer();
        }

        public static void Almacena()
        {
            ClaseDatos.Fecha_inicio = fecha_desde;

            ClaseDatos.Estado_laboral = "Permiso";

            ClaseDatos.Fecha_hasta = fecha_hasta;

        }

        private static void Asigna()
        {
            ClaseDatos.Estado_laboral = "Vacaciones";

            ClaseDatos.Fecha_inicio = fecha_desde;

            ClaseDatos.Fecha_hasta = fecha_hasta;


        }
    }
}

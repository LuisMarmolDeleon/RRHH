using System;

namespace Nombramiento
{
    class Inicio
    {

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Bienvenida();
        }

        //Funcion de Bienvenida
        public static void Bienvenida()
        {
            string cedula;
            Console.WriteLine("RRHH BY Luis Marmol\n\n\n");
            Console.WriteLine("Seleccione una opcion:\n\n");
            Console.WriteLine("1-Registrar personal\n");
            Console.WriteLine("2-Solicitudes\n");
            Console.Write("3-Salir\n\nSu Opcion: ");
            int opp = Convert.ToInt32(Console.ReadLine());
            switch (opp)
            {
                case 1:
                    Console.Clear();
                    Registro_empleado.RegistroEmpleado();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese numero de cedula para realizar una solicitud");
                    cedula = Console.ReadLine();
                    Busqueda.Buscador(cedula);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

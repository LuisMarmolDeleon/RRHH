using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Registro_empleado
    {
        public static void RegistroEmpleado()
        {
            Console.WriteLine("Ingrese el numero de cedula\n");
            ClaseDatos.cedula = Convert.ToString(Console.ReadLine());
             Extras.Clean();
            Console.WriteLine("\nIngrese el nombre del empleado\n");
            ClaseDatos.NombreCompleto_empleado = Console.ReadLine();
             Extras.Clean();
            Console.WriteLine("Ahora ingrese el sueldo por hora de " + ClaseDatos.NombreCompleto_empleado + "\n");
            ClaseDatos.salarioPorHora = Convert.ToInt32(Console.ReadLine());
            Agregar();
             Extras.Clean();
            Opcion.Metodo_pago();
        }

        private static void Agregar()
        {
            TablaADM.Lista.Add(ClaseDatos.cedula);

            TablaADM.Lista.Add(ClaseDatos.NombreCompleto_empleado);

            TablaADM.Lista.Add(Convert.ToString(ClaseDatos.salarioPorHora));


        }
    }
}

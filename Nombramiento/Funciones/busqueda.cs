using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Busqueda
    {
        //Busqueda de cedula de identidad
        public static void Buscador(String cedula)
        {
            int localizador=9*9*9;
             for(int i = 0; i < TablaADM.Lista.Count; i+=9)
             {
                 if (TablaADM.Lista[i] == cedula)
                 {
                    localizador = i;
                     break;
                 }
                Extras.Clean();
             }
            if (localizador != 9*9*9)
            {
                Printer(localizador);
            }
            else
            {
                Extras.Clean();
                Console.WriteLine("No pudimos encontrar a alguien con el numero de cedula: " + cedula+"\n\n");
                Inicio.Bienvenida();
            }
        }

        //Impresion de dato encontrado
        public static void Printer(int localizacion)
        {
            Extras.Clean();
            Console.WriteLine("Dato encontrado\n\n");
            Console.WriteLine("Cedula: "+TablaADM.Lista[localizacion]);

            Console.WriteLine("Nombre: "+TablaADM.Lista[localizacion+ 1]);

            Console.WriteLine("Sueldo: "+TablaADM.Lista[localizacion + 2]);

            Console.WriteLine("Numero de cuenta: "+TablaADM.Lista[localizacion + 3]);

            Console.WriteLine("Tanda laboral: "+TablaADM.Lista[localizacion + 4]);

            Console.WriteLine("Estado laboral: "+TablaADM.Lista[localizacion + 5]);

            SetAClase(localizacion);
            Solicitud(localizacion);
        }

        //Se asigna a la clase de empleado
        public static void SetAClase(int localizacion)
        {
            ClaseDatos.NombreCompleto_empleado = TablaADM.Lista[localizacion + 1];

            ClaseDatos.salarioPorHora = Convert.ToInt32(TablaADM.Lista[localizacion + 2]);

            ClaseDatos.cuenta = Convert.ToInt32(TablaADM.Lista[localizacion + 3]);

            ClaseDatos.tanda = TablaADM.Lista[localizacion + 4];

            ClaseDatos.estado_laboral = TablaADM.Lista[localizacion + 5];
        }

        //Solicitudes
        public static void Solicitud(int localizacion)
        {
            
            Console.WriteLine("\n\nElija que solicitud hara: \n");
            Console.WriteLine("1-Vacaciones\n2-Permiso");
            Console.Write("3-Desvinculacion\nSu opcion: ");
           int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: Vacaciones.Solicitar_vacaciones(localizacion);
                    break;
                case 2:
                    Permiso.Solicitar_Permiso(localizacion);
                    break;
                case 3:
                    Desvinculacion.SolicitarDesvinculacion(localizacion);
                    break;
            }
        }
         
        }

}


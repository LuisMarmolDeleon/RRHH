using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Busqueda
    {
        public static string cedula, nombre, jornada, estado, salario, cuenta_bancaria,desde,hasta;
        //Busqueda de cedula de identidad
        public static void Buscador(String cedula)
        {
            int? localizador=null;
             for(int i = 0; i < TablaADM.Lista.Count; i+=9)
             {
                 if (TablaADM.Lista[i] == cedula)
                 {
                    localizador = i;
                     break;
                 }
                Console.Clear();
             }
            if (localizador !=null)
            {
                Almacenador_Variable((int)localizador);
                Mostrar_Informacion();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No pudimos encontrar a alguien con el numero de cedula: " + cedula+"\n\n");
                Inicio.Bienvenida();
            }
        }

        //Se almacena los datos en unas variables para uso universal
        private static void Almacenador_Variable(int localizacion)
        {
            cedula = TablaADM.Lista[localizacion];

            nombre = TablaADM.Lista[localizacion + 1];

            salario = TablaADM.Lista[localizacion + 2];

            cuenta_bancaria = TablaADM.Lista[localizacion + 3];

            jornada = TablaADM.Lista[localizacion + 4];

            estado = TablaADM.Lista[localizacion + 5];

            desde = TablaADM.Lista[localizacion+6];

            hasta = TablaADM.Lista[localizacion+7];
        }

        //Impresion de dato encontrado
        private static void Mostrar_Informacion()
        {
            Console.Clear();
            Console.WriteLine("Dato encontrado\n\n");
            Console.WriteLine("Cedula: "+cedula);

            Console.WriteLine("Nombre: "+nombre);

            Console.WriteLine("Salario por hora: "+salario);

            Console.WriteLine("Numero de cuenta: "+cuenta_bancaria);

            Console.WriteLine("Tanda laboral: "+jornada);

            Console.WriteLine("Estado laboral: "+estado);

            SetAClase();
            Solicitud();
        }

        //Se asigna a la clase de empleado
        private static void SetAClase()
        {
            ClaseDatos.NombreCompleto_empleado = nombre;

            ClaseDatos.SalarioPorHora = Convert.ToInt32(salario);

            ClaseDatos.Cuenta = Convert.ToInt32(cuenta_bancaria);

            ClaseDatos.Tanda = jornada;

            ClaseDatos.Estado_laboral = estado;
        }

        //Solicitudes
        private static void Solicitud()
        {
            
            Console.WriteLine("\n\nElija que solicitud hara: \n");
            Console.WriteLine("1-Vacaciones\n2-Permiso");
            Console.Write("3-Desvinculacion\n4-Retroceder\nSu opcion: ");
           int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: Vacaciones.Solicitar_vacaciones();
                    break;

                case 2:
                    Permiso.Solicitar_Permiso();
                    break;

                case 3:
                    Desvinculacion.SolicitarDesvinculacion();
                    break;

                case 4:
                    Console.Clear();
                    Inicio.Bienvenida();
                    break;
            }
        }
         
        }

}


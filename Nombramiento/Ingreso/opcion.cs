using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Opcion
    {
        public static void Metodo_pago()
        {
            int res = 0;
                Console.WriteLine("Especifique el horario de trabajo de " + ClaseDatos.NombreCompleto_empleado + "\n\n");
                Console.Write("1- Tiempo Completo\n2- Medio Tiempo.\n3- Temporal.\n\nSu opcion: ");
                 int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        res = 1;
                        break;

                    case 2:
                        res = 2;
                        break;

                    case 3:
                        res = 3;
                        break;
                }

                InterfazEmpleados emp = Clasificador.Getter(res);
                emp.tandaEmpleo();
                emp.metodopago();
                emp.Salario_PorHora();
                emp.salario_porMes();

                if (res == 1 || res == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero de cuentas:\n");
                    ClaseDatos.Cuenta = Convert.ToInt32(Console.ReadLine());
                    TablaADM.Lista.Add(Convert.ToString(ClaseDatos.Cuenta));
                }
                else if (res == 3)
                {
                    ClaseDatos.Cuenta = 0;
                    TablaADM.Lista.Add("Cheque");
                }
                if (res == 1)
                {
                    TablaADM.Lista.Add("Tiempo Completo (8Hrs)");
                }else if (res == 2)
                {
                    TablaADM.Lista.Add("Medio Tiempo (4Hrs)");
                }else if (res == 3)
                {
                    TablaADM.Lista.Add("Temporal (8Hrs)");
                }
                TablaADM.Lista.Add("Laborando");
                TablaADM.Lista.Add("...");
                TablaADM.Lista.Add("...");
                Console.Clear();
                Console.WriteLine("Se agrego a: " + ClaseDatos.NombreCompleto_empleado);
                Print.Printer();          
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombramiento
{
    class Print
    {
        //se imprimen los datos
        public static void Printer()
        {
            TextWriter txtw;
            
            //El documento se creara con el nombre y el estado laboral
            txtw = new StreamWriter(ClaseDatos.NombreCompleto_empleado+ClaseDatos.Estado_laboral+".txt");

            txtw.Write("Datos de empleado:\n\n");
            txtw.Write("Cedula de identidad: " + ClaseDatos.Cedula + "\n");
            txtw.Write("Nombre completo: " + ClaseDatos.NombreCompleto_empleado+"\n");
            txtw.Write("Tanda laboral: " + ClaseDatos.Tanda+"\n");
            txtw.Write("Metodo de pago: " + ClaseDatos.Tipo_pago + "\n");
            if (ClaseDatos.Cuenta !=0) {
            txtw.Write("Cuenta bancaria: " + ClaseDatos.Cuenta + "\n");
            }
            txtw.Write("Salario por hora: " + ClaseDatos.SalarioPorHora + "\n");
            txtw.Write("Salario por mes: " + ClaseDatos.SalarioPorMes + "\n");
            txtw.Write("Estado laboral: " + ClaseDatos.Estado_laboral + "\n");

            //Determinar el estado laboral del empleado
            if (ClaseDatos.Estado_laboral == "Vacaciones" || ClaseDatos.Estado_laboral== "Permiso") {
                txtw.Write("Desde: " + ClaseDatos.Fecha_inicio + "\n");
                txtw.Write("Hasta: " + ClaseDatos.Fecha_hasta + "\n");
            }else if(ClaseDatos.Estado_laboral== "Desvinculado")
            {
                txtw.Write("Motivo de desvinculacion: " + ClaseDatos.MotivoDesvinculado + "\n");
            }
            //Cierre documento
            txtw.Close();
            Extras.Volver();


         }
        }
    }

